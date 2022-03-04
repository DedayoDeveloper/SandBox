using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Net;

namespace SandBoxApp
{
    public partial class SandBoxForm : Form
    {
        OpenFileDialog openFileDialog;
        string fileName;
        public SandBoxForm()
        {
            InitializeComponent();
        }

        private void SandBoxForm_Load(object sender, EventArgs e)
        {

        }



        private PermissionSet pSet(string args)
        {
            // Create a Permission Set -> (UN)Restricted depending on user choice
            PermissionSet permSet = checkUnrestricted.CheckState == CheckState.Checked || args.Contains("-un")
                ? new PermissionSet(PermissionState.Unrestricted) : new PermissionSet(PermissionState.None);

            // Default Permissions required by assembly
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read, fileName));
            permSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.PathDiscovery, fileName));

            // Chosen Permissions
            permSet.AddPermission(checkIO.CheckState == CheckState.Checked || args.Contains("-io")
                ? new FileIOPermission(PermissionState.Unrestricted) : new FileIOPermission(PermissionState.None));

            permSet.AddPermission(checkUI.CheckState == CheckState.Checked || args.Contains("-ui")
                ? new UIPermission(PermissionState.Unrestricted) : new UIPermission(PermissionState.None));

            permSet.AddPermission(checkFileDialog.CheckState == CheckState.Checked || args.Contains("-fd")
                ? new FileDialogPermission(PermissionState.Unrestricted) : new FileDialogPermission(PermissionState.None));

            permSet.AddPermission(checkSecurity.CheckState == CheckState.Checked || args.Contains("-sec")
                ? new SecurityPermission(PermissionState.Unrestricted) : new SecurityPermission(PermissionState.None));

            permSet.AddPermission(checkIsolatedStorage.CheckState == CheckState.Checked || args.Contains("-is")
                ? new IsolatedStorageFilePermission(PermissionState.Unrestricted) : new IsolatedStorageFilePermission(PermissionState.None));

            permSet.AddPermission(checkEnvironment.CheckState == CheckState.Checked || args.Contains("-env")
                ? new EnvironmentPermission(PermissionState.Unrestricted) : new EnvironmentPermission(PermissionState.None));

            permSet.AddPermission(checkKeyContainer.CheckState == CheckState.Checked || args.Contains("-kc")
                ? new KeyContainerPermission(PermissionState.Unrestricted) : new KeyContainerPermission(PermissionState.None));

            permSet.AddPermission(checkPrincipal.CheckState == CheckState.Checked || args.Contains("-pr")
                ? new PrincipalPermission(PermissionState.Unrestricted) : new PrincipalPermission(PermissionState.None));

            permSet.AddPermission(checkReflection.CheckState == CheckState.Checked || args.Contains("-ref")
                ? new ReflectionPermission(PermissionState.Unrestricted) : new ReflectionPermission(PermissionState.None));

            permSet.AddPermission(checkRegistry.CheckState == CheckState.Checked || args.Contains("-reg")
                ? new RegistryPermission(PermissionState.Unrestricted) : new RegistryPermission(PermissionState.None));

            permSet.AddPermission(checkStore.CheckState == CheckState.Checked || args.Contains("-st")
                ? new StorePermission(PermissionState.Unrestricted) : new StorePermission(PermissionState.None));

            permSet.AddPermission(checkTypeDescriptor.CheckState == CheckState.Checked || args.Contains("-ctd")
            ? new TypeDescriptorPermission(PermissionState.Unrestricted) : new TypeDescriptorPermission(PermissionState.None));


            permSet.AddPermission(checkWeb.CheckState == CheckState.Checked || args.Contains("-web")
                ? new WebPermission(PermissionState.Unrestricted) : new WebPermission(PermissionState.None));

            return permSet;
        }





        private void checkReflection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.ShowDialog();
            fileName = openFileDialog.FileName;
            tbx_filepath.AppendText(fileName);
        }

        private void tbx_filepath_TextChanged(object sender, EventArgs e)
        {

        }

        public void writeToConsole(string val)
        {
            rtbx_console.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + val + "\n");
        }


        private void btn_run_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                writeToConsole("No FILE selecterd! Please select file (.exe)");
            }
            else
            {
                SandBox sandbox = new SandBox();
                writeToConsole("Executing " + Path.GetFileName(fileName));
                try
                {
                    sandbox.InitializeSandBox(fileName, tbx_params.Text, pSet(string.Empty));
                }
                catch (SecurityException ex)
                {
                    writeToConsole("SYSTEM-ERROR : " + ex.Action.ToString());
                    Console.WriteLine("--- {0} ERROR ---\n", Path.GetFileNameWithoutExtension(fileName));
                    if (ex.Action.ToString() == "Demand")
                    {
                        int cutPoint = ex.Message.ToString().IndexOf(",");
                        writeToConsole("--- ERROR --- : " + ex.Message.ToString().Substring(0, cutPoint) + "'");
                    }
                }
                writeToConsole("Terminated " + Path.GetFileName(fileName));

            }


        }

        public void startSandBoxFromTerminal(string[] args)
        {
     
            if (args.Contains("-h") || args.Contains("-H"))
            {
                Console.WriteLine(@"Parameters: ""<application path>"" ""<application parameters>"" ""<permissions>""");
                Console.WriteLine("-un = Unrestricted permissions");
                Console.WriteLine("-io = IO permissions");
                Console.WriteLine("-ui = UI permissions");
                Console.WriteLine("-fd = File Dialog permissions");
                Console.WriteLine("-sec = Security permissions");
                Console.WriteLine("-is = Isolated Storage permissions");
                Console.WriteLine("-env = Environment permissions");
                Console.WriteLine("-kc = Key Container permissions");
                Console.WriteLine("-pr = Principal permissions");
                Console.WriteLine("-ref = Reflection permissions");
                Console.WriteLine("-reg = Registry permissions");
                Console.WriteLine("-st = Store permissions");
                Console.WriteLine("-ctd = Check Type Descriptor permissions");
                Console.WriteLine("-web = Web permissions");
            }
            else
            {
                Console.WriteLine("HINT - Use -h for Help & Permissions List");
            }

            // Execute Sandboxer functionality through command line when appropriate amount of arguments given
            if (args.Count() == 3)
            {
                SandBox sandBox = new SandBox();
                try
                {
                    sandBox.InitializeSandBox(args[0].ToString(), args[1].ToString(), pSet(args[2].ToString()));
                }
                catch (SecurityException ex)
                {
                    Console.WriteLine("ERROR : " + ex.Action.ToString());
                    if (ex.Action.ToString() == "Demand")
                    {
                        int cutPoint = ex.Message.ToString().IndexOf(",");
                        Console.WriteLine("--- ERROR --- : " + ex.Message.ToString().Substring(0, cutPoint) + "'");
                    }
                }
            }

        }

        private void tbl_permissions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

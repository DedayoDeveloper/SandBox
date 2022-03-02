using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace SandBoxWindowsApp
{
    public partial class Form1 : Form
    {
        string fileName;
        OpenFileDialog openFileDialog = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void writeToConsole(string logString)
        {
            // Logging to the Log Text Box
            rtbx_console.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + logString + "\n");
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

            //permSet.AddPermission(checkTypeDescriptor.CheckState == CheckState.Checked || args.Contains("-ctd")
            //    ? new TypeDescriptorPermission(PermissionState.Unrestricted) : new TypeDescriptorPermission(PermissionState.None));

            permSet.AddPermission(checkWeb.CheckState == CheckState.Checked || args.Contains("-web")
                ? new WebPermission(PermissionState.Unrestricted) : new WebPermission(PermissionState.None));

            return permSet;
        }


        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.ShowDialog();
            fileName = openFileDialog.FileName;
            txb_filepath.AppendText(fileName);       
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog == null)
            {
                writeToConsole("No FILE selected!.Please select file to run");
            }
            else
            {
                string directoryPath = System.IO.Path.GetDirectoryName(fileName);
                String safeFileName = openFileDialog.SafeFileName;
                string extension = System.IO.Path.GetExtension(safeFileName);
                //string result = safeFileName.Substring(0, safeFileName.Length - extension.Length);
                Assembly assembly = Assembly.LoadFile(fileName);
                String assemblyName = assembly.FullName;
                String assemblyClass = null;
                Type[] t = assembly.GetTypes();
                foreach (Type a in t)
                {
                    if (a.GetMethod("Main") != null)
                    {
                        assemblyClass = a.AssemblyQualifiedName;
                    }
                    else
                    {
                        
                    }
                   
                }
                SandBox s = new SandBox();
                //s.sandBoxVariables(directoryPath, assemblyName, assemblyClass, "Main");
                try
                {
                    
                    writeToConsole("--- {0} STARTED ---" + " " + safeFileName);
                    s.sandBoxVariables(directoryPath, assemblyName, assemblyClass, "Main");
                    //s.ApplicationInitialiseCmd(fileName, assemblyName, pSet("-un"));
                    writeToConsole("--- {0} FINISHED ---\n" + " " + safeFileName);
                    writeToConsole("Executed Successfully");
                }
                catch (Exception ex)
                {
                    writeToConsole("ERROR : " + ex.Message);
                    Console.WriteLine("--- {0} ERROR ---\n", Path.GetFileNameWithoutExtension(fileName));
                    if (ex.Message.ToString() == "Demand")
                    {
                        int cutPoint = ex.Message.ToString().IndexOf(",");
                        writeToConsole("DEMAND : " + ex.Message.ToString().Substring(0, cutPoint) + "'");
                    }
                }
                //writeToConsole(s);


            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }




        public void cmdManage(string[] args)
        {
            Console.WriteLine(args);
            // Help/Permissions list display after the appripriate -h argument entered
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
                Console.WriteLine("-web = Web permissions");
            }
            else
            {
                Console.WriteLine("HINT - Use -h for Help & Permissions List");
            }

            // Execute Sandboxer functionality through command line when appropriate amount of arguments given
            if (args.Count() == 3)
            {
                SandBox appSandbox = new SandBox();
                try
                {
                    appSandbox.ApplicationInitialiseCmd(args[0].ToString(), args[1].ToString(), pSet(args[2].ToString()));
                }
                catch (SecurityException ex)
                {
                    Console.WriteLine("ERROR : " + ex.Action.ToString());
                    if (ex.Action.ToString() == "Demand")
                    {
                        int cutPoint = ex.Message.ToString().IndexOf(",");
                        Console.WriteLine("DEMAND : " + ex.Message.ToString().Substring(0, cutPoint) + "'");
                    }
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkSecurity_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

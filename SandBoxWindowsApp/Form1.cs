using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                rtbx_console.AppendText("No FILE selected!.Please select file to run");
            }
            else
            {
                string directoryPath = System.IO.Path.GetDirectoryName(fileName);
                String safeFileName = openFileDialog.SafeFileName;
                string extension = System.IO.Path.GetExtension(safeFileName);
                string result = safeFileName.Substring(0, safeFileName.Length - extension.Length);
                Assembly assembly = Assembly.LoadFile(fileName);
                String assemblyName = result;
                string assemblyClass = null;
                Type[] t = assembly.GetTypes();
                foreach (Type a in t)
                {
                    if (a.GetMethod("Main") != null)
                    {
                        assemblyClass = a.Name;
                    }
                    else
                    {
                        
                    }
                   
                }
                SandBox s = new SandBox();
                s.sandBoxVariables(directoryPath, assemblyName, assemblyClass, "Main");


            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

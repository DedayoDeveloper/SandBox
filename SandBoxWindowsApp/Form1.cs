using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandBoxWindowsApp
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            String fileName = openFileDialog.FileName;
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
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

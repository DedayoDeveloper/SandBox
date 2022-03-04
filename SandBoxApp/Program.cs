using System;
using System.Windows.Forms;

namespace SandBoxApp
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            
            if (args.Length > 0 && args[0] != string.Empty)
            {
                var cmdStartSandBox = new SandBoxForm();
                 cmdStartSandBox.startSandBoxFromTerminal(args);
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SandBoxForm());
            }
        }
    }
}

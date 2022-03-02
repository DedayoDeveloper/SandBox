using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace UntrustedProject
{
    public class Program
    {
        public static bool IsFibonacci(int number)
        {
         string path ="G:\\labwork\\file.txt";
           // File.ReadAllText("G:\\labwork\\file.txt");
            Console.WriteLine("hello, thank you for using my Sand Box App");
            FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None);


            return false;
        }
        

        public static void Main()
        {
            IsFibonacci(45);
            Console.WriteLine("hello, thank you for using my Sand Box App");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBoxApp
{
    class SandBox : MarshalByRefObject
    {
        const string pathToUntrusted = @"..\..\..\UntrustedProject\bin\Debug";
        const string untrustedAssembly = "UntrustedProject";
        const string untrustedClass = "SandBoxApp.UntrustedProject.Program";
        const string entryPoint = "IsFibonacci";
        private static Object[] parameters = { 45 };
        static void initializeSandBox()
        {
            AppDomainSetup appDomain = new AppDomainSetup();
            appDomain.ApplicationBase = Path.GetFullPath(pathToUntrusted);
        }
       
    }
}

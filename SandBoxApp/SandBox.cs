

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Policy;
using System.Security.Permissions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Reflection;

[assembly: System.Reflection.AssemblyKeyFile("KeyFile.snk")]

namespace SandBoxApp
{
    class SandBox : MarshalByRefObject
    {

        public void InitializeSandBox(string filePath, string parameters, PermissionSet perm)
        {
            string getFileDirectory = Path.GetDirectoryName(filePath);
            string[] appFileParam = parameters.Split(' ');
            string getAssemblyName = Path.GetFileNameWithoutExtension(filePath);
            AppDomainSetup adSetup = new AppDomainSetup();
            adSetup.ApplicationBase = getFileDirectory;
            StrongName trustedAssembly = typeof(SandBox).Assembly.Evidence.GetHostEvidence<StrongName>();
            Random rnd = new Random();
            AppDomain newDomain = AppDomain.CreateDomain("Sandbox" + rnd.Next().ToString(), null, adSetup, perm, trustedAssembly);

            ObjectHandle handle = Activator.CreateInstanceFrom(
                newDomain,
                typeof(SandBox).Assembly.ManifestModule.FullyQualifiedName,
                typeof(SandBox).FullName);

            SandBox instance = (SandBox)handle.Unwrap();
                newDomain.ExecuteAssembly(filePath, appFileParam);
          
            
        }
    




}
}



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
        const string pathToUntrusted = @"..\..\..\UntrustedProject\bin\Debug";
        const string untrustedAssembly = "UntrustedProject";
        const string untrustedClass = "UntrustedProject.Program";
        const string entryPoint = "IsFibonacci";
        private static Object[] parameters = { 45 };


        public void initializeSandBox()
        {
            AppDomainSetup appDomain = new AppDomainSetup();
            appDomain.ApplicationBase = Path.GetFullPath(pathToUntrusted);

            PermissionSet permSet = new PermissionSet(PermissionState.None);
            permSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permSet.AddPermission(new FileIOPermission((PermissionState)FileIOPermissionAccess.Read));
            

            StrongName fullTrustAssembly = typeof(SandBox).Assembly.Evidence.GetHostEvidence<StrongName>();


            AppDomain newDomain = AppDomain.CreateDomain("Sandbox", null, appDomain, permSet, fullTrustAssembly);

            ObjectHandle handle = Activator.CreateInstanceFrom(
           newDomain, typeof(SandBox).Assembly.ManifestModule.FullyQualifiedName,
           typeof(SandBox).FullName
           );
            //Unwrap the new domain instance into a reference in this domain and use it to execute the
            //untrusted code.
            SandBox newDomainInstance = (SandBox)handle.Unwrap();
            newDomainInstance.ExecuteUntrustedCode(untrustedAssembly, untrustedClass, entryPoint, parameters);

        }


        public void ExecuteUntrustedCode(string assemblyName, string typeName, string entryPoint, Object[] parameters)
        {
            //Load the MethodInfo for a method in the new Assembly. This might be a method you know, or
            //you can use Assembly.EntryPoint to get to the main function in an executable.
            MethodInfo target = Assembly.Load(assemblyName).GetType(typeName).GetMethod(entryPoint);
            try
            {
                //Now invoke the method.
                bool retVal = (bool)target.Invoke(null, parameters);
            }
            catch (Exception ex)
            {
                // When we print informations from a SecurityException extra information can be printed if we are
                //calling it with a full-trust stack.
                new PermissionSet(PermissionState.Unrestricted).Assert();
                Console.WriteLine("SecurityException caught:\n{0}", ex.ToString());
                CodeAccessPermission.RevertAssert();
                Console.ReadLine();
            }
        }



    }
}

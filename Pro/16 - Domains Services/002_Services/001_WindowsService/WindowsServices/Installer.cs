using System.Configuration.Install;
using System.ServiceProcess;
using System.ComponentModel;

namespace WindowsServices
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        ServiceProcessInstaller processInstaller;
        ServiceInstaller serviceInstaller;

        public ProjectInstaller()
        {
            processInstaller = new ServiceProcessInstaller();
            processInstaller.Account = ServiceAccount.LocalSystem;

            serviceInstaller = new ServiceInstaller();
            serviceInstaller.ServiceName = "[===== TEST SERVICE =====]";
            serviceInstaller.Description = "My First NT (Windows) Service!";
            serviceInstaller.StartType = ServiceStartMode.Automatic;

            base.Installers.Add(processInstaller);
            base.Installers.Add(serviceInstaller);
        }
    }
}

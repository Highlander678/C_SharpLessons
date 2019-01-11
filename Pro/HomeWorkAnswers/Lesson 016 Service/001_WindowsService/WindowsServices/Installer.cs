using System.Configuration.Install;
using System.ServiceProcess;
using System.ComponentModel;

namespace WindowsServices
{
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            this.Installers.Add( new ServiceProcessInstaller
                          {
                              Account = ServiceAccount.LocalSystem
                          });
            this.Installers.Add(new ServiceInstaller
                          {
                              ServiceName = "===== Deleted Files Logger =====",
                              StartType = ServiceStartMode.Automatic
                          });
        }
    }
}

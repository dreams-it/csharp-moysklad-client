using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService
{
    [RunInstaller(true)]
    public partial class IntegrationServiceInstaller : System.Configuration.Install.Installer
    {
        public IntegrationServiceInstaller()
        {
            var process = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem
            };
            var service = new ServiceInstaller
            {
                DisplayName = "DreamsIT integration service",
                ServiceName = "IntergationService",
                StartType = ServiceStartMode.Manual
            };
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}

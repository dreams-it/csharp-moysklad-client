using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamsIT.MoySklad.IntegrationService
{
    public class IntegrationServiceController
    {
        private static IntegrationServiceController integrationServiceController;

        public static IntegrationServiceController GetInstance(IKernel kernel)
        {
            return integrationServiceController ?? (integrationServiceController = new IntegrationServiceController(kernel));
        }

        public IntegrationServiceController(IKernel kernel)
        {

        }
    }
}

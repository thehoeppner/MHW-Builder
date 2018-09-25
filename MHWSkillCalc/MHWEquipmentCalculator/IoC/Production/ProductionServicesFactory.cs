using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Services;

namespace MHWEquipmentCalculator.IoC.Production
{
    public class ProductionServicesFactory : ViewModels.Services.IServiceFactory
    {
        public IExceptionHandler GetExceptionHandler()
        {
            return new Services.MessageBoxExceptionHandler();
        }

        public ILocalizationService GetLocalizationService()
        {
            return new Services.GermanLocalizationService();
        }
    }
}

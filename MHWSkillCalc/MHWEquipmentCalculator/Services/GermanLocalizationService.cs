using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWEquipmentCalculator.Services
{
    public class GermanLocalizationService : ViewModels.Services.ILocalizationService
    {
        public string ErrorLoadingData => "Fehler beim laden der Daten";
    }
}

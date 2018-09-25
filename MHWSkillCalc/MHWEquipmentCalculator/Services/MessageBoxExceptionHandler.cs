using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWEquipmentCalculator.Services
{
    public class MessageBoxExceptionHandler : ViewModels.Services.IExceptionHandler
    {
        public void HandleException(string message, Exception ex)
        {
            Debug.WriteLine(message);
        }
    }
}

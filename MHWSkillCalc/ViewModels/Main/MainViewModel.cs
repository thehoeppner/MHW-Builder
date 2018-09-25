using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Models;

namespace ViewModels.Main
{
    public class MainViewModel : ViewModelBase
    {
        private IMHWUnitOfWork repository;
        private Services.IServiceFactory service;
        public MainViewModel(IMHWUnitOfWork repository,
            Services.IServiceFactory service = null)
        {
            if (repository == null) { throw new ArgumentNullException(nameof(repository)); }
            this.repository = repository;
            this.service = service;
        }


        private ObservableCollection<Models.Armor.Armor> armors = new ObservableCollection<Models.Armor.Armor>();
        public ObservableCollection<Models.Armor.Armor> Armors
        {
            get { return armors; }
            set
            {
                if (!Equals(armors, value)) {
                    armors = value;
                    OnPropertyChanged();
                }
                                
            }
        }

        #region "Loading"

        public async Task LoadData()
        {
            try
            {
                await repository.LoadData();
                Armors = new ObservableCollection<Models.Armor.Armor>(repository.Armors);
            }
            catch (Exception ex)
            {
                service?.GetExceptionHandler()?.HandleException(
                    service?.GetLocalizationService()?.ErrorLoadingData, ex);
            }
        }

        #endregion


    }
}

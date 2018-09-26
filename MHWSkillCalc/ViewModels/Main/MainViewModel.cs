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


        private IEnumerable<Models.Armor.Armor> allArmors;
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
                allArmors = repository.Armors;
                Armors = new ObservableCollection<Models.Armor.Armor>(allArmors);
            }
            catch (Exception ex)
            {
                service?.GetExceptionHandler()?.HandleException(
                    service?.GetLocalizationService()?.ErrorLoadingData, ex);
            }
        }

        public void Search(string searchValue)
        {
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                var searchResult = (from armor in allArmors
                                    let slugOk = (armor.slug.Contains(searchValue))
                                    let nameOk = (armor.name.Contains(searchValue))
                                    let typeOk = (armor.type.Contains(searchValue))
                                    where slugOk || nameOk || typeOk
                                    select armor).ToList();
                Armors = new ObservableCollection<Models.Armor.Armor>(searchResult);
            }
            else { Armors = new ObservableCollection<Models.Armor.Armor>(allArmors); }
        }

        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Mock
{
    public class SampleMainViewModel 
    {
        public static SampleMainViewModel Instance => new SampleMainViewModel();

        public SampleMainViewModel()
        {
            armors = new System.Collections.ObjectModel.ObservableCollection<Models.Armor.Armor> {
            new Models.Armor.Armor { id = 1, slug = "letherArmor", name = "Lether Armor", type = "chest", rank = "low"},
            new Models.Armor.Armor { id = 2, slug = "ironArmor", name = "Iron Armor", type = "chest", rank = "high"}};
        }

        private ObservableCollection<Models.Armor.Armor> armors = new ObservableCollection<Models.Armor.Armor>();
        public ObservableCollection<Models.Armor.Armor> Armors
        {
            get { return armors; }
            set
            {
                if (!Equals(armors, value))
                {
                    armors = value;
                }

            }
        }
    }
}

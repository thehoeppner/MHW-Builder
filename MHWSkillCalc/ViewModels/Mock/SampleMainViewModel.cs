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
            new Models.Armor.Armor { id = 1, slug = "letherArmor", name = "Lether Armor", type = "chest", rank = "low",
            assets = new Models.Armor.Assets {
                imageMale = "https://assets.mhw-db.com/armor/e7cfa0acf10c8439b78639a0f59c2eb9ee9e2923.c8685d97610f608eae4850d6f53b9226.png" } },
            new Models.Armor.Armor { id = 2, slug = "ironArmor", name = "Iron Armor", type = "chest", rank = "high",
            assets = new Models.Armor.Assets {
                imageMale = "https://assets.mhw-db.com/armor/8c083e8d252d2d86456fda2135a8a16b21679ec6.4856a15b707ce6c14d2fb143c1513696.png" } } };
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

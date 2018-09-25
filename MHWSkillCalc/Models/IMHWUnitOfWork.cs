using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Armor.Results;
using Models.Armor;

namespace Models
{
    public interface IMHWUnitOfWork
    {
        IEnumerable<Armor.Armor> Armors { get;}
        IEnumerable<ArmorSetResult> ArmorSets { get;}
        IEnumerable<Charm.Charm> Charms { get;}
        IEnumerable<Decoration.Decoration> Decorations { get;}
        IEnumerable<Item.Item> Items { get;}
        IEnumerable<Weapon.Weapon> Weapons { get;}

        Task LoadData();
    }
}

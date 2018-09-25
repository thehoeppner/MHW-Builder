using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Armor;
using Models.Armor.Results;
using Models.Charm;
using Models.Decoration;
using Models.Item;
using Models.Weapon;

namespace Repositories
{
    public class MHWUnitOfWork : Models.IMHWUnitOfWork
    {
        public MHWUnitOfWork(string baseUrl)
        {
            if (string.IsNullOrWhiteSpace(baseUrl)) { throw new ArgumentNullException(nameof(baseUrl)); }
            armorRepository = new Armor.ArmorRepository(baseUrl);
            charmsRepository = new Charm.CharmsRepository(baseUrl);
            decorationsRepository = new Decoration.DecorationsRepository(baseUrl);
            itemsRepository = new Item.ItemsRepository(baseUrl);
            weaponsRepository = new Weapon.WeaponsRepository(baseUrl);
        }

        private IEnumerable<Models.Armor.Armor> armors;
        public IEnumerable<Models.Armor.Armor> Armors => armors;
        private IEnumerable<ArmorSetResult> armorSets;
        public IEnumerable<ArmorSetResult> ArmorSets => armorSets;
        private IEnumerable<Models.Charm.Charm> charms;
        public IEnumerable<Models.Charm.Charm> Charms => charms;
        private IEnumerable<Models.Decoration.Decoration> decorations;
        public IEnumerable<Models.Decoration.Decoration> Decorations => decorations;
        private IEnumerable<Models.Item.Item> items;
        public IEnumerable<Models.Item.Item> Items => items;
        private IEnumerable<Models.Weapon.Weapon> weapons;
        public IEnumerable<Models.Weapon.Weapon> Weapons => weapons;

        private Armor.ArmorRepository armorRepository;
        private Charm.CharmsRepository charmsRepository;
        private Decoration.DecorationsRepository decorationsRepository;
        private Item.ItemsRepository itemsRepository;
        private Weapon.WeaponsRepository weaponsRepository;

        public async Task LoadData()
        {
            var armorResult = await armorRepository.GetArmorsResultAsync();
            armors = armorResult.armors;
            armorSets = armorResult.armorSets;
            charms = await charmsRepository.GetCharms();
            decorations = await decorationsRepository.GetDecorations();
            items = await itemsRepository.GetItems();
            weapons = await weaponsRepository.GetWeapons();           
        }
    }
}

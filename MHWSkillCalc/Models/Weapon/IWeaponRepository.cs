using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Weapon
{
    public interface IWeaponRepository
    {
        Task<IEnumerable<Weapon>> GetWeapons();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Armor.Results;
namespace Models.Armor
{
    public interface IArmorRepository
    {
        Task<Results.ArmorsResult> GetArmorsResultAsync();
    }
}

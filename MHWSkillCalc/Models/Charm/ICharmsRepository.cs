using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Charm
{
    public interface ICharmsRepository
    {
        Task<IEnumerable<Charm>> GetCharms();
    }
}

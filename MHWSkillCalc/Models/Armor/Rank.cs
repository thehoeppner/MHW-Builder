using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armor
{
    public enum Rank
    {
        Low = 0,
        High = 1
    }

    public static class RankConverter
    {
        public static Rank GetRank(string rank)
        {
            switch (rank)
            {
                case "low": return Rank.Low;
                case "high": return Rank.High;
                default: return Rank.Low;
            }
        }
    }
}

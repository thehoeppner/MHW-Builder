using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Skill
{
    public enum SkillRankModifier
    {
        Affinity,
        Attack,
        DamageFire,
        DamageWater,
        DamageIce,
        DamageThunder,
        DamageDragon,
        Defense,
        Health,
        SharpnessBonus,
        ResistAll,
        ResistFire,
        ResistWater,
        ResistIce,
        ResistThunder,
        ResistDragon
    }

    public static class SkillRankModifierConverter
    {
        public static SkillRankModifier GetSkillRank(string rank)
        {
            switch (rank)
            {
                case "affinity":return SkillRankModifier.Affinity;
                case "attack":return SkillRankModifier.Attack;
                case "damageFire":return SkillRankModifier.DamageFire;
                case "damageWater":return SkillRankModifier.DamageWater;
                case "damageIce": return SkillRankModifier.DamageIce;
                case "damageThunder":return SkillRankModifier.DamageThunder;
                case "damageDragon":return SkillRankModifier.DamageDragon;
                case "defense":return SkillRankModifier.Defense;
                case "health":return SkillRankModifier.Health;
                case "sharpnessBonus": return SkillRankModifier.SharpnessBonus;
                case "resistAll": return SkillRankModifier.ResistAll;
                case "resistFire": return SkillRankModifier.ResistFire;
                case "resistWater": return SkillRankModifier.ResistWater;
                case "resistIce": return SkillRankModifier.ResistIce;
                case "resistThunder": return SkillRankModifier.ResistThunder;
                case "resistDragon": return SkillRankModifier.ResistDragon;
                default: return SkillRankModifier.Defense;
            }
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace D2DBM
{
    public class HeroModel
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; } // -> Axe
        public HeroRole Roles { set; get; } // -> Nuker | Escaper
        public int BaseStrength { set; get; }
        public int BaseAgility { set; get; }
        public int BaseIntellegence { set; get; }
        public float AdditionalStrength { set; get; }
        public float AdditionalAgility { set; get; }
        public float AdditionalIntellegence { set; get; }
        public HeroAttributeType MainAttribute { set; get; } // -> Agi
        public float BaseArmor { set; get; }
        public float BaseAttack { set; get; }
        public float BaseAttackInterval { set; get; }
        public int BaseAttackRange { set; get; }
        public bool IsMeleeAttack { set; get; }
        public int BaseHealth { set; get; }
        public float BaseHealthRegeneration { set; get; }
        public int BaseMana { set; get; }
        public float BaseManaRegeneration { set; get; }
        public int BaseMoveSpeed { set; get; }
        public float BaseTurnSpeed { set; get; }   // -> 0.6
        public int BaseDayVision { set; get; }
        public int BaseNightVision { set; get; }
        public int BaseMagicResistance { set; get; } // -> 25
        public float SpellAmplification { set; get; }
        public float StatusResistance { set; get; }
    }

    public enum HeroAttributeType
    {
        Str,
        Agi,
        Int
    }

    public enum HeroRole
    {
        Support = 1,
        Nuker = 1 << 1,
        Pusher = 1 << 2,
        Disabler = 1 << 3,
        Jungler = 1 << 4,
        Initiator = 1 << 5,
        Durabler = 1 << 6,
        Escaper = 1 << 7
    }
}

using System;

namespace D2DBM
{
    public class Calc
    {
        public int GetHeroMaxLevelAttribute(HeroModel hero, HeroAttributeType attr)
        {
            if (attr == HeroAttributeType.Str)
                return (int)(hero.BaseStrength + (hero.AdditionalStrength * (GameConstantes.HERO_MAX_LEVEL - 1)));
            else if (attr == HeroAttributeType.Agi)
                return (int)(hero.BaseAgility + (hero.AdditionalAgility * (GameConstantes.HERO_MAX_LEVEL - 1)));
            else if (attr == HeroAttributeType.Int)
                return (int)(hero.BaseIntellegence + (hero.AdditionalIntellegence * (GameConstantes.HERO_MAX_LEVEL - 1)));
            throw new Exception("Unknown hero attribute");
        }
        public int GetHeroAttributeInLevel(HeroModel hero, HeroAttributeType attr, int lvl)
        {
            if (lvl < 1)
                return 0;
            if (attr == HeroAttributeType.Str)
                return (lvl == 1) ? hero.BaseStrength : (int)(hero.BaseStrength + (hero.AdditionalStrength * (lvl - 1)));
            else if (attr == HeroAttributeType.Agi)
                return (lvl == 1) ? hero.BaseAgility : (int)(hero.BaseAgility + (hero.AdditionalAgility * (lvl - 1)));
            else if (attr == HeroAttributeType.Int)
                return (lvl == 1) ? hero.BaseIntellegence : (int)(hero.BaseIntellegence + (hero.AdditionalIntellegence * (lvl - 1)));
            throw new Exception("Unknown hero attribute");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2DBM
{
    class Program
    {
        static void Main()
        {
            using (var db = new HeroContext())
            {
                var axe = new HeroModel()
                {
                    Name = "Axe",
                    AdditionalAgility = 0,
                    AdditionalIntellegence = 0,
                    AdditionalStrength = 0,
                    BaseAgility = 0,
                    BaseArmor = 0,
                    BaseAttack = 0,
                    BaseAttackInterval = 0,
                    BaseAttackRange = 0,
                    BaseDayVision = 0,
                    BaseHealth = 0,
                    BaseHealthRegeneration = 0,
                    BaseIntellegence = 0,
                    BaseMagicResistance = 25,
                    BaseMana = 0,
                    BaseManaRegeneration = 0,
                    BaseMoveSpeed = 0,
                    BaseNightVision = 0,
                    BaseStrength = 0,
                    BaseTurnSpeed = 0,
                    IsMeleeAttack = true,
                    MainAttribute = HeroAttributeType.Str,
                    Roles = HeroRole.Disabler | HeroRole.Initiator | HeroRole.Jungler | HeroRole.Durabler
                };
                db.Heroes.Add(axe);
                db.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}

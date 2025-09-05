using TI_Net2025_HeroesVsMonster.Models.Heroes;
using TI_Net2025_HeroesVsMonster.Models.Monsters;
using TI_Net2025_HeroesVsMonster.Utils;

namespace TI_Net2025_HeroesVsMonster.Factories
{
    public class MonsterFactory
    {

        public static List<Monster> GenerateMonsters(Hero hero, int count = 1)
        {
            List<Monster> monsters = [];
            for (int i = 0; i < count; i++)
            {
                int rng = DiceType.D6.Throw();
                Monster m = null;
                switch (rng)
                {
                    case 1:
                    case 2:
                    case 3:
                        m = new Murloc();
                        break;
                    case 4:
                    case 5:
                        m = new Wolf();
                        break;
                    case 6:
                        m = new Dragon();
                        break;
                }
                m.AddDieEvent(hero.Loot);
                m.AddDieEvent((c) => monsters.Remove(m));
                monsters.Add(m);
            }
            return monsters;
        }
    }
}

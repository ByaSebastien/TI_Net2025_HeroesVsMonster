using TI_Net2025_HeroesVsMonster.Utils;

namespace TI_Net2025_HeroesVsMonster.Models.Heroes
{
    public class Human : Hero
    {
        public Human(string name) : base(name)
        {
            if(Name == "Dante")
            {
                InitStats(DiceType.D100);
                Heal(PvMax);
            }
        }
    }
}

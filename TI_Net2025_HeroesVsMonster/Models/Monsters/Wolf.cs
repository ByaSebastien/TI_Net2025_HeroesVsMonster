using TI_Net2025_HeroesVsMonster.Utils;

namespace TI_Net2025_HeroesVsMonster.Models.Monsters
{
    public class Wolf : Monster, ILeather
    {
        public int Leather => DiceType.D6.Throw();

        protected override void InitStats()
        {
            InitStats(DiceType.D4);
        }
    }
}

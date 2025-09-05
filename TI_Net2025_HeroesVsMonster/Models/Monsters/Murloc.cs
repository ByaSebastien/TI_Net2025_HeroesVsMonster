using TI_Net2025_HeroesVsMonster.Utils;

namespace TI_Net2025_HeroesVsMonster.Models.Monsters
{
    public class Murloc : Monster, IGold
    {
        public int Gold => DiceType.D4.Throw();

        protected override void InitStats()
        {
            InitStats(DiceType.D4);
        }
    }
}

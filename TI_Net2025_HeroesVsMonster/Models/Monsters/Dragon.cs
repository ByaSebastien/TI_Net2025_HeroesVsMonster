using TI_Net2025_HeroesVsMonster.Utils;

namespace TI_Net2025_HeroesVsMonster.Models.Monsters
{
    public class Dragon : Monster, ILeather, IGold
    {
        public int Gold => DiceType.D100.Throw();

        public int Leather => DiceType.D100.Throw();

        protected override void InitStats()
        {
            InitStats(Utils.DiceType.D20);
        }
    }
}

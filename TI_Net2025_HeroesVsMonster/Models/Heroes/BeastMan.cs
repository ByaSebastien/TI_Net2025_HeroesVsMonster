namespace TI_Net2025_HeroesVsMonster.Models.Heroes
{
    public class BeastMan : Hero
    {
        public BeastMan(string name) : base(name)
        {
        }


        protected override void InitStats()
        {
            InitStats(Utils.DiceType.D20);
        }
    }
}

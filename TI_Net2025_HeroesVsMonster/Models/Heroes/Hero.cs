using TI_Net2025_HeroesVsMonster.Utils;
using static TI_Net2025_HeroesVsMonster.Utils.DiceType;

namespace TI_Net2025_HeroesVsMonster.Models.Heroes
{
    public abstract class Hero : Character
    {
        public string Name { get; set; }

        public int Leather {  get; set; }
        public int Gold { get; set; }

        public Hero(string name)
        {
            Name = name;
        }

        public override void Attack(Character target)
        {
            int damage = Atk + D6.Throw() - target.Def;
            target.TakeDamage(damage);
        }

        protected void Heal()
        {
            Heal( 5 + D10.Throw());
        }

        public void Loot(Character target)
        {
            if(target is ILeather l)
            {
                this.Leather += l.Leather;
            }
            if(target is IGold g)
            {
                this.Gold += g.Gold;
            }
            Console.WriteLine("Jackpot");
        }

        protected override void InitStats()
        {
            InitStats(D10);
        }
    }
}

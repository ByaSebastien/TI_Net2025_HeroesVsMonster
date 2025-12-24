using TI_Net2025_HeroesVsMonster.Utils;
using static TI_Net2025_HeroesVsMonster.Utils.DiceType;

namespace TI_Net2025_HeroesVsMonster.Models
{
    public abstract class Character
    {
        private event Action<Character> _dieEvent;
        private int _currentPv;

        public int PvMax { get; protected set; }
        public int CurrentPv {
            get
            {
                return _currentPv;
            } 
            private set
            {
                _currentPv = Math.Clamp(value, 0, PvMax);
                if( _currentPv <= 0)
                {
                    Console.WriteLine(this + " is Dead");
                    _dieEvent?.Invoke(this);
                }
            } 
        }
        public int Atk {  get; protected set; }
        public int AtkSpec { get; protected set; }
        public int Def {  get; protected set; }
        public int DefSpec {  get; protected set; }
        public int Speed { get; protected set; }
        public bool IsAlive => CurrentPv > 0;

        public Character()
        {
            InitStats();
            CurrentPv = PvMax;
        }

        public virtual void Attack(Character target)
        {
            int damage = this.Atk + D4.Throw() - target.Def;
            target.TakeDamage(damage);
        }

        public void TakeDamage(int amount)
        {
            this.CurrentPv -= Math.Max(1, amount);
        }

        protected void Heal(int amount)
        {
            CurrentPv += amount;
        }

        protected abstract void InitStats();

        protected void InitStats(DiceType dice)
        {
            Atk = dice.Throw(5, 3);
            AtkSpec = dice.Throw(5, 3);
            Def = dice.Throw(5, 3);
            DefSpec = dice.Throw(5, 3);
            Speed = dice.Throw(5, 3);
            PvMax = Def + DefSpec;
        }

        public void AddDieEvent(Action<Character> action)
        {
            _dieEvent += action;
        }
    }
}
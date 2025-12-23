namespace TI_Net2025_HeroesVsMonster.Models.Monsters
{
    public abstract class Monster: Character
    {

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}

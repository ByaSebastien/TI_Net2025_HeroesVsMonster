using TI_Net2025_HeroesVsMonster.Models;

namespace TI_Net2025_HeroesVsMonster.Utils
{
    public static class Dice
    {
        public static int Throw(this DiceType dice, int toThrow = 1, int toKeep = -1)
        {
            Random rand = new Random();
            List<int> throws = [];
            for (int i = 0; i < toThrow; i++)
            {
                throws.Add(rand.Next((int)dice) + 1);
            }
            return throws
                .OrderByDescending(it => it)
                .Take(toKeep <= 0 ? toThrow : toKeep)
                .Sum();
        }
    }

    public enum DiceType
    {
        D4 = 4,
        D6 = 6,
        D10 = 10,
        D20 = 20,
        D100 = 100,
    }
}

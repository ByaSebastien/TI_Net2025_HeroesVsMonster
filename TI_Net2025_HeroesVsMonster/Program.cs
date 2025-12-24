using TI_Net2025_HeroesVsMonster.Factories;
using TI_Net2025_HeroesVsMonster.Models.Heroes;
using TI_Net2025_HeroesVsMonster.Models.Monsters;

Human dante = new Human("Dante");
List<Monster> monsters = MonsterFactory.GenerateMonsters(dante,10);

dante.AddDieEvent((c) => Console.WriteLine("Elle est ou ta chaise?"));


List<Monster> copy = [.. monsters];

while(dante.IsAlive && monsters.Count > 0)
{
    foreach (var monster in copy)
    {
        monster.Attack(dante);
        if (dante.IsAlive)
        {
            dante.Attack(monster);
        }
    }
}
Console.WriteLine("Dante " + (dante.IsAlive ? "Gagne" : "Perd"));
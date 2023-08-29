//
//int current = random.Next(1, 11);

//do
//{
//    current = random.Next(1, 11);
//    Console.WriteLine(current);
//} while (current != 7);

//while (current >= 3)
//{
//    Console.WriteLine(current);
//    current = random.Next(1, 11);
//}
//Console.WriteLine($"Last number: {current}");

//do
//{
//    current = random.Next(1, 11);

//    if (current >= 8) continue;

//    Console.WriteLine(current);
//} while (current != 7);

Random random = new Random();
int attack = 0;

int heroHealth = 10;
int monsterHealth = 10;

do
{
    attack = random.Next(1, 11);
    monsterHealth = monsterHealth - attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth}");
    if (monsterHealth <= 0) break;

    attack = random.Next(1, 11);
    heroHealth = heroHealth - attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth}");
    if (heroHealth <= 0) break;
} while (monsterHealth > 0 && heroHealth > 0);


if (heroHealth > monsterHealth)
{
             Console.WriteLine("Hero wins!");
}
else if (monsterHealth > heroHealth)
{
    Console.WriteLine("Monster wins!");
}




using System;
using System.Security.Principal;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    Console.WriteLine("You rolled doubles! +2 bonus to total!");
//    total += 2;
//}

//if ((roll1 == roll2) && (roll2 == roll3))
//{
//    Console.WriteLine("you rolled triples! +6 bocus to total!");
//    total += 6;
//}

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{

    if ((roll1 == roll2) && ( roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("you rolled doubles! +2 bonus to total!");
    }

}

if (total >= 16)
{
    Console.WriteLine("Get New car");
}
else if (total >= 10)
{
    Console.WriteLine("Get New raptap");
}
else if (total == 7)
{
    Console.WriteLine("Get 여행 상품");
}
else
{
    Console.WriteLine("Get cat");
}




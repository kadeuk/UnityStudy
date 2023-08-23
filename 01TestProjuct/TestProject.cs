using System;



Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
Console.WriteLine(dice.Next(1, 7));
dice.Next(1, 7);

//int result = Random.Next();

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"second roll: {roll2}");
Console.WriteLine($"third roll: {roll3}");

int roll4 = dice.Next();

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

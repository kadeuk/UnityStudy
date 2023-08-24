using System;

//string[] names = { "Rowena", "Robin", "Bao" };
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//int sum = 0;
//int bin = 0;


//int[] inventory = { 200, 450, 700, 175, 250 };
//foreach (int items in inventory)
//{
//    sum += items;
//    bin++;
//    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
//}

//Console.WriteLine($"We have {sum} items in inventory");

string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string orderId in orderIds)
{
    if(orderId.StartsWith("B"))
    {
        Console.WriteLine(orderId);
    }
}

/*
 convert the message into a char array
 Reverse the chars
 count the o's
 */

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;
 
foreach (char i in charMessage)
{ 
    if (i == 'o') 
    { 
        x++; 
    } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");





















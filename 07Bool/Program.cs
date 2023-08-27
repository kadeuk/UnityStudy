//Console.WriteLine("a" == "A");
//Console.WriteLine("a" == "a ");
//Console.WriteLine(1 == 2);

//string myValue = "a";
//Console.WriteLine(myValue == "a");

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

//Console.WriteLine(pangram.Contains("fox")  == false);
//Console.WriteLine(!pangram.Contains("fox"));

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(!pangram.Contains("fox"));
//Console.WriteLine(!pangram.Contains("cow"));

//int saleAmount = 1001;
////int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {(saleAmount >1000 ? 100 : 50)}");

//Random coin = new Random();
//int flip = coin.Next(0, 2);
//Console.WriteLine((flip == 0) ? "heads" : "tails");

//Random conin = new Random();
//int flip2 = coin.Next(0, 3);
//Console.WriteLine((flip2 == 0)? "True" : "False");

using System.Net.Security;

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager")) 
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
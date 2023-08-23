Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// 내가 작성한 코드 c# 에서 조건문은 더 구체적인것부터 덜 구체적인 것 순으로 해야한다.
//if (daysUntilExpiration < 10)
//{
//    Console.WriteLine("Your subscription will expires soon. Renew now");
//}    
//else if (daysUntilExpiration < 5)
//{
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
//}
//else if (daysUntilExpiration < 1)
//{
//    Console.WriteLine($"Your subscription expires within a day\nRenew now and save 20%!");
//}
//else if(daysUntilExpiration == 0)
//{
//    Console.WriteLine("Your subscription has expried.");
//}
//else
//{
//    Console.WriteLine(" ");
//}

if(daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired");
}
else if(daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if(daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if(discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");

}






















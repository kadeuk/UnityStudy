string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid.");
    }
} while (validEntry == false);

Console.WriteLine($"Your in put value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
// See https://aka.ms/new-console-template for more information
using Zaliczenie;
using Zaliczenie.Contexts;

Console.WriteLine("-------------------------------------------------");
Console.WriteLine("                    Welcome!");
Console.WriteLine("-------------------------------------------------\n");

while (true)
{
    Console.WriteLine("Are you a customer or owner? (0-customer, 1-owner)");
    int isOwner = UserAction.Get0or1();

    if (isOwner == 0)
    {
        ClientContext clientContext = new();
        clientContext.Run();
    }
    else
    {
        OwnerContext ownerContext = new();
        ownerContext.Run();
    }
    Console.WriteLine("Are we done for today? (0 - no, 1 - yes");

    int answer = UserAction.Get0or1();

    if (answer == 1)
        break;
}
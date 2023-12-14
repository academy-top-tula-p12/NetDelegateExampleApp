using NetDelegateExampleApp;
using System.Threading.Channels;

BankAccount account = new BankAccount(1000);
account.RegisterAccountHandler(PrintConsoleMessage);
account.RegisterAccountHandler(PrintRedConsoleMessage);

account.TakeMoney(300);
account.TakeMoney(500);

account.UnregisterAccountHandler(PrintConsoleMessage);

account.TakeMoney(300);




void PrintConsoleMessage(string message) => Console.WriteLine(message);

void PrintRedConsoleMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}
    
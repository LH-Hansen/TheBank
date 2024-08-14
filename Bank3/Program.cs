using TheBank;

Bank bank = new Bank();

Console.Write("Welcome to {0} - Bank 2\n" +
              "Select account: ", bank.BankName);

if (int.TryParse(Console.ReadLine(), out int accountNumber))

    while (true)
    {
        Console.Clear();

        switch (Menu(bank.BankName))
        {
            case "m":
                Menu(bank.BankName);
                break;

            case "c":
                Console.Write("Navn: ");

                Account account = bank.CreateAccount(Console.ReadLine());

                Console.WriteLine("Account {0} created for {1}, with a balance of {2:c}", account.Number, account.Name, account.Balance);
                break;

            case "d":
                Console.Write("Deposit: ");
                Console.WriteLine("Balance for account: {0:c}", bank.Deposit(Console.ReadLine(), accountNumber));
                break;

            case "w":
                Console.Write("Withdraw: ");
                Console.WriteLine("Balance for account: {0:c}", bank.Withdraw(Console.ReadLine(), accountNumber));
                break;

            case "b":
                Console.WriteLine("Account balance: {0:c}", bank.Balance(accountNumber));
                break;

            case "i":
                Console.WriteLine(bank.BankName);
                break;

            case "e":

                break;

            default:
                Console.Write("An error has occurred");
                break;
        }
    }

static string Menu(string bankName)
{
    GC.Collect();
    Console.Clear();

    Console.WriteLine("m = menu\n" +
                      "c = create account\n" +
                      "d = deposit\n" +
                      "w = withdraw\n" +
                      "b = balance\n" +
                      "i = show bank\n" +
                      "e = exit\n");

    return Console.ReadLine().ToLower();
}
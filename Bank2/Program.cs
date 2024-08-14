using TheBank;

Bank bank = new Bank();

while (true)
{
    switch (Menu(bank.BankName))
    {
        case "m":
            Menu(bank.BankName);
            break;

        case "c":
            Console.Write("Navn: ");

            Account account = bank.CreateAccount(Console.ReadLine());

            Console.WriteLine("Account created for {0}, with a balance of {1:c}", account.Name, account.Balance);
            break;

        case "d":
            Console.Write("Deposit: ");
            Console.WriteLine("Balance for account: {0:c}", bank.Deposit(Console.ReadLine()));
            break;

        case "w":
            Console.Write("Withdraw: ");
            Console.WriteLine("Balance for account: {0:c}", bank.Withdraw(Console.ReadLine()));
            break;

        case "b":
            Console.WriteLine("Account balance: {0:c}", bank.Balance());
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
    Console.WriteLine("Welcome to {0} - Bank 2", bankName);
    Console.WriteLine("m = menu\n" +
                      "c = create account\n" +
                      "d = deposit\n" +
                      "w = withdraw\n" +
                      "b = balance\n" +
                      "i = show bank\n" +
                      "e = exit\n");

    return Console.ReadLine().ToLower();
}
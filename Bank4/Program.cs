using TheBank;

Bank bank = new Bank();

int accountNumber = -1;

string name;

while (true)
{
    switch (Menu(bank.BankName))
    {
        case "s":
            Console.WriteLine("Select account: ");

            if (int.TryParse(Console.ReadLine(), out accountNumber))
                break;
            break;

        case "c":
            Console.Write("Name: ");

            name = Console.ReadLine();

            Console.Write("Account type: ");

            if (int.TryParse(Console.ReadLine(), out int accountType))
            {
                Account newAccount = bank.CreateAccount(name, accountType);
                Console.WriteLine("Account {0} type {1} created for {2}, with a balance of {3:c}", newAccount.Number, newAccount.Type, newAccount.Name, newAccount.Balance);
            }
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

        case "e":
            bank.ChargeInterest();
            break;

        case "i":
            Console.WriteLine(bank.BankName);
            break;

        case "a":
            foreach (var account in bank.ShowAllAccounts())
                Console.WriteLine("{0}, {1}: {2:c}", account.Number, account.Name, account.Balance);
            break;

        default:
            Console.Write("An error has occurred");
            break;
    }
    Console.ReadKey();
    Console.Clear();
}

static string Menu(string bankName)
{
    Console.WriteLine("*** Welcome to {0} - Bank 2 ***\n" +
                      "s = select account\n" +
                      "c = create account\n" +
                      "d = deposit\n" +
                      "w = withdraw\n" +
                      "b = balance\n" +
                      "i = show bank\n" +
                      "e = charge interest\n" +
                      "a = show all accounts\n", bankName);

    return Console.ReadLine().ToLower();
}
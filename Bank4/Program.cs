using TheBank;

Bank bank = new Bank();

Console.Write("Welcome to {0} - Bank 2\n" +
              "Select account: ", bank.BankName);

if (int.TryParse(Console.ReadLine(), out int accountNumber))

    Console.Clear();

while (true)
{
    switch (Menu(bank.BankName))
    {
        case "c":
            Console.Write("Navn: ");

            Account newAccount = bank.CreateAccount(Console.ReadLine());

            Console.WriteLine("Account {0} created for {1}, with a balance of {2:c}", newAccount.Number, newAccount.Name, newAccount.Balance);
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

        case "a":
            List<Account> accountList = bank.ShowAllAccounts();

            foreach (var account in accountList)
                Console.WriteLine("{0}, {1}: {2:c}", account.Number, account.Name, account.Balance);

            accountList = new List<Account>();
            break;

        default:
            Console.Write("An error has occurred");
            break;
    }

    Console.ReadKey();
}

static string Menu(string bankName)
{
    GC.Collect();
    Console.Clear();

    Console.WriteLine("*** Welcome to {0} - Bank 2 ***\n" +
                      "m = menu\n" +
                      "c = create account\n" +
                      "d = deposit\n" +
                      "w = withdraw\n" +
                      "b = balance\n" +
                      "i = show bank\n" +
                      "a = show all accounts\n", bankName);

    return Console.ReadLine().ToLower();
}
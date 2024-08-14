using TheBank;

Bank bank = new Bank();

Console.WriteLine("*** Velkommen til {0} ***", bank.BankName);
Console.Write("Navn: ");

Account account = bank.CreateAccount(Console.ReadLine());

Console.WriteLine("Konto oprettet for {0}, med saldoen {1:c}", account.Name, account.Balance);

Console.ReadLine();
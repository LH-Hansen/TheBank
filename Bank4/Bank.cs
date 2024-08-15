namespace TheBank
{
    internal class Bank
    {
        public string BankName { get; init; }

        public Bank() { BankName = "EUC Syd Banken"; }

        List<Account> accountList = new List<Account>();

        public Account CreateAccount(string name)
        {
            accountList.Add(new Account(name, accountList.Count + 1));

            return accountList[^1];
        }

        public decimal Deposit(string depositAmount, int accountNumber)
        {
            foreach (Account account in accountList)
            {
                if (decimal.TryParse(depositAmount, out decimal result) && account.Number == accountNumber)
                    account.Balance += result;
                return account.Balance;
            }
            return 0;
        }

        public decimal Withdraw(string depositAmount, int accountNumber)
        {
            foreach (Account account in accountList)
            {
                if (decimal.TryParse(depositAmount, out decimal result) && account.Number == accountNumber)
                    account.Balance -= result;

                return account.Balance;
            }
            return 0;
        }

        public decimal Balance(int accountNumber)
        {
            foreach (Account account in accountList)
            {
                if (account.Number == accountNumber)
                    return account.Balance;
            }

            return 0;
        }

        public List<Account> ShowAllAccounts()
        {
            return accountList;
        }
    }
}

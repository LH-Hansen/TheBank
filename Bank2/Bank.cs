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

        public decimal Deposit(string depositAmount)
        {
            if (decimal.TryParse(depositAmount, out decimal result))
                accountList[^1].Balance += result;

            return accountList[^1].Balance;
        }

        public decimal Withdraw(string depositAmount)
        {
            if (decimal.TryParse(depositAmount, out decimal result))
                accountList[^1].Balance -= result;

            return accountList[^1].Balance;
        }

        public decimal Balance()
        {
            return accountList[^1].Balance;
        }
    }
}

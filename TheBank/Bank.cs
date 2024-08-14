namespace TheBank
{
    internal class Bank
    {
        public string BankName { get; private set; }

        public Bank() { BankName = "EUC Syd Banken"; }

        List<Account> accountList = new List<Account>();

        public Account CreateAccount(string name)
        {
            accountList.Add(new Account(name));

            return accountList[^1];
        }

        public decimal Deposit(string depositAmount)
        {
            if (decimal.TryParse(depositAmount, out decimal result))
                accountList[^1].Balance += result;

            return accountList[^1].Balance;
        }
    }
}

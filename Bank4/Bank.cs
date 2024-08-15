using Bank4;

namespace TheBank
{
    internal class Bank
    {
        public string BankName { get; init; }

        public Bank() { BankName = "EUC Syd Banken"; }

        List<Account> accountList = new List<Account>();

        public Account CreateAccount(string name, int accountType)
        {

            switch (accountType)
            {
                case 1:
                    accountList.Add(new CheckingAccount(name, accountList.Count + 1));
                    break;

                case 2:
                    accountList.Add(new SavingsAccount(name, accountList.Count + 1));
                    break;

                case 3:
                    accountList.Add(new ConsumerAccount(name, accountList.Count + 1));
                    break;

                default:
                    Console.WriteLine("Error try again...");
                    break;
            }

            return accountList[^1];
        }

        public decimal Deposit(string depositAmount, int accountNumber)
        {
            foreach (Account account in accountList)
            {
                if (decimal.TryParse(depositAmount, out decimal result) && account.Number == accountNumber)
                {
                    account.Balance += result;
                    return account.Balance;
                }
            }
            return 0;
        }

        public decimal Withdraw(string depositAmount, int accountNumber)
        {
            foreach (Account account in accountList)
            {
                if (decimal.TryParse(depositAmount, out decimal result) && account.Number == accountNumber)
                {
                    account.Balance += result;
                    return account.Balance;
                }
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

        public string ChargeInterest()
        {
            foreach (Account account in accountList)
                account.ChargeInterest();

            return "Intrest has been charged";
        }

        public List<Account> ShowAllAccounts()
        {
            return accountList;
        }
    }
}

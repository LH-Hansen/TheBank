using Bank5.Models;

namespace Repository.Bank5
{
    internal class Bank : IBank
    {
        public string BankName { get; init; }

        public Bank() { BankName = "EUC Syd Banken"; }

        private List<Account> _accountList = new List<Account>();

        public Account CreateAccount(string name, AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.checking:
                    _accountList.Add(new CheckingAccount(name, _accountList.Count + 1));
                    break;
                case AccountType.consumer:
                    _accountList.Add(new ConsumerAccount(name, _accountList.Count + 1));
                    break;
                case AccountType.savings:
                    _accountList.Add(new SavingsAccount(name, _accountList.Count + 1));
                    break;
                default:
                    Console.WriteLine("Error try again...");
                    break;
            }
            return _accountList[^1];
        }

        public decimal Deposit(string depositAmount, int accountNumber)
        {
            foreach (Account account in _accountList)
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
            foreach (Account account in _accountList)
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
            foreach (Account account in _accountList)
            {
                if (account.Number == accountNumber)
                    return account.Balance;
            }

            return 0;
        }

        public string ChargeInterest()
        {
            foreach (Account account in _accountList)
                account.ChargeInterest();

            return "Intrest has been charged";
        }

        public List<AccountListItem> GetAccountList()
        {
            List<AccountListItem> accountList = new List<AccountListItem>();

            foreach (Account account in this._accountList)
            {
                accountList.Add(new(account));
            }

            return accountList;
        }

    }
}
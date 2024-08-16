using Bank5.Models;

namespace Repository.Bank5
{
    internal interface IBank
    {
        string BankName { get; init; }

        decimal Balance(int accountNumber);
        string ChargeInterest();
        Account CreateAccount(string name, int accountType);
        decimal Deposit(string depositAmount, int accountNumber);
        List<Account> ShowAllAccounts();
        decimal Withdraw(string depositAmount, int accountNumber);
        List<AccountListItem> GetAccountList();
    }
}
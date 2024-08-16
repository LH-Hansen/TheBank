using Bank5.Models;

namespace Repository.Bank5
{
    internal interface IBank
    {
        string BankName { get; init; }

        decimal Balance(int accountNumber);
        string ChargeInterest();
        Account CreateAccount(string name, AccountType accountType);
        decimal Deposit(string depositAmount, int accountNumber);
        decimal Withdraw(string depositAmount, int accountNumber);
        List<AccountListItem> GetAccountList();
    }
}
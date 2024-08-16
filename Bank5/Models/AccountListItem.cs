namespace Bank5.Models
{
    internal class AccountListItem
    {
        public string Name { get; init; }
        public decimal Balance { get; set; }
        public int Number { get; init; }
        public Type Type { get; set; }

        public AccountListItem(Account account)
        {
            Name = account.Name;
            Balance = account.Balance;
            Number = account.Number;
            Type = account.GetType();
        }
    }
}

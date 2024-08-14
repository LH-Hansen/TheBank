namespace TheBank
{
    internal class Account
    {
        public string Name { get; init; }
        public decimal Balance { get; set; }

        public Account(string name, int number)
        {
            Name = name;
            Balance = 0;
            Number = number;
        }
    }
}
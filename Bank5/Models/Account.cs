namespace Bank5.Models
{
    internal abstract class Account
    {
        public string Name { get; init; }
        public decimal Balance { get; set; }
        public int Number { get; init; }

        public Account(string name, int number)
        {
            Name = name;
            Balance = 0;
            Number = number;
        }

        public string Type { get; set; }

        public abstract void ChargeInterest();
    }
}
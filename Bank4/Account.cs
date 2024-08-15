namespace TheBank
{
    internal class Account
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

        public static decimal IntrestRate { get; set; }

        public void ChargeInterest()
        {
            Balance *= (1 + IntrestRate);
        }
    }
}
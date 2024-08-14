namespace TheBank
{
    internal class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account(string name)
        {
            Name = name;
            Balance = 0;
        }
    }
}
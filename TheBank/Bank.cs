namespace TheBank
{
    internal class Bank
    {
        public string BankName { get; private set; }

        public Bank()
        { BankName = "EUC Syd Banken"; }

        public Account CreateAccount(string name)
        {
            return new Account(name);
        }
    }
}

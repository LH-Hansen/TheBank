namespace TheBank
{
    internal class Bank
    {
        public string BankName { get; private set; }

        public Bank()
        { BankName = "EUC Syd Banken"; }


        /// <summary>
        /// Creates an account with given name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns new account</returns>
        public Account CreateAccount(string name)
        {
            return new Account(name);
        }
    }
}

using TheBank;

namespace Bank4
{
    internal class CheckingAccount : Account
    {
        public CheckingAccount(string name, int number) : base(name, number)
        {
            IntrestRate = 0.005m;
        }
    }
}

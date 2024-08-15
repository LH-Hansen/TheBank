using TheBank;

namespace Bank4
{
    internal class SavingsAccount : Account
    {
        public SavingsAccount(string name, int number) : base(name, number)
        {
            if (Balance <= 50000)
                IntrestRate = 0.01m;
            else if (Balance <= 100000)
                IntrestRate = 0.02m;
            else if (Balance >= 100000)
                IntrestRate = 0.03m;
        }
    }
}

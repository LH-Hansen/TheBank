using TheBank;

namespace Bank4
{
    internal class ConsumerAccount : Account
    {
        public ConsumerAccount(string name, int number) : base(name, number)
        {
            if (Balance >= 0)
                IntrestRate = 0.01m;
            else if (Balance < 0)
                IntrestRate = 0.2m;
        }
    }
}

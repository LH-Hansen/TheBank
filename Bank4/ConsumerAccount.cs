using TheBank;

namespace Bank4
{
    internal class ConsumerAccount : Account
    {
        private decimal _interestRate;

        public ConsumerAccount(string name, int number) : base(name, number)
        {
            Type = "Consumer account";
        }

        public override void ChargeInterest()
        {
            if (Balance >= 0)
                _interestRate = 0.01m;
            else if (Balance < 0)
                _interestRate = 0.2m;

            Balance *= 1 + _interestRate;
        }
    }
}

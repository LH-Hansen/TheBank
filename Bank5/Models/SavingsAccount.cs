namespace Bank5.Models
{
    internal class SavingsAccount : Account
    {
        private decimal _interestRate;

        public SavingsAccount(string name, int number) : base(name, number)
        {
            Type = "Savings account";
        }

        public override void ChargeInterest()
        {
            if (Balance <= 50000)
                _interestRate = 0.01m;
            else if (Balance < 100000 && Balance > 50000)
                _interestRate = 0.02m;
            else if (Balance >= 100000)
                _interestRate = 0.03m;

            Balance *= 1 + _interestRate;
        }
    }
}

using TheBank;

namespace Bank4
{
    internal class CheckingAccount : Account
    {
        private static decimal _interestRate = 0.005m;

        public CheckingAccount(string name, int number) : base(name, number)
        {
            Type = "Checking account";
        }

        public override void ChargeInterest()
        {
            Balance *= 1 + _interestRate;
        }
    }
}
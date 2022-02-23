namespace Patterns.HeadFirst.Strategy
{
    public class DecreaseByFiveStrategy : ICalcStrategy
    {
        private const int DecreaseAmount = 5;
        public int Calc(int income)
        {
            if (income < 0) return income;

            return income - DecreaseAmount;
        }
    }
}
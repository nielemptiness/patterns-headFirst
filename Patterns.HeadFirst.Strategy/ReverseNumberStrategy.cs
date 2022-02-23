namespace Patterns.HeadFirst.Strategy
{
    public class ReverseNumberStrategy : ICalcStrategy
    {
        public int Calc(int income)
        {
            return Math.Abs(income) * (-1);
        }
    }
}
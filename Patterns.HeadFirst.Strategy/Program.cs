// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.Strategy;

int PerformMath(ICalcStrategy strategy, int number)
{
    return strategy.Calc(number);
}

var res1 = PerformMath(new DecreaseByFiveStrategy(), 5);
var res2 = PerformMath(new ReverseNumberStrategy(), 5);

Console.WriteLine(res1 == 0);
Console.WriteLine(res2 == -5);
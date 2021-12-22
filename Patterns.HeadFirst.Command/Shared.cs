namespace Patterns.HeadFirst;

public static class Shared
{
    public static void PrintNumber() => Console.WriteLine(new Random().Next(1, 10));
    public static void PrintString() => Console.WriteLine("Hello");
}
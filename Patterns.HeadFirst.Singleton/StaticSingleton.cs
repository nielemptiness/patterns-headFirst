namespace Patterns.HeadFirst.Singleton;

public class StaticSingleton
{
    private static readonly StaticSingleton _staticSingleton = new ();
    private readonly int _creationCount = 0;
    
    private StaticSingleton()
    {
        _creationCount++;
        Console.WriteLine("Created instance of " + GetType().Name + " with count of creations: " + _creationCount);
    }

    public static StaticSingleton GetInstance()
    {
        Console.WriteLine("Asking for " + nameof(StaticSingleton) + " instance");
        return _staticSingleton;
    }
}
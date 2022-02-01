namespace Patterns.HeadFirst.Singleton;

public class LockedSingleton
{
    private static LockedSingleton? _lockedSingleton;
    private static readonly object SyncRoot = new object();
    private readonly int _creationCount = 0;
    
    private LockedSingleton()
    {
        _creationCount++;
        Console.WriteLine("Created instance of " + GetType().Name + "with count of creations: " + _creationCount);
    }

    public static LockedSingleton GetInstance()
    {
        Console.WriteLine("Asking for " + nameof(LockedSingleton) + " instance");
        
        if (_lockedSingleton == null)
        {
            lock (SyncRoot)
            {
                if (_lockedSingleton == null)
                {
                    _lockedSingleton = new LockedSingleton();
                }
            }
        }

        return _lockedSingleton;
    }

}
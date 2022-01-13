namespace Patterns.HeadFirst.Composite;

public class Leaf : SimpleComposite
{
    private readonly string _surname;
    public Leaf(string surname)
    {
        _surname = surname;
    }
    public override string GetElementName()
    {
        return GetType().Name + ' ' + _surname;
    }

    public override void Log()
    {
        Console.Write("  I am " + GetElementName());
    }
}
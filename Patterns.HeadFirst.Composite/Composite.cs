namespace Patterns.HeadFirst.Composite;

public class Composite : SimpleComposite
{
    private readonly List<SimpleComposite> _composites;
    private readonly string _name;

    public Composite(List<SimpleComposite> composites, string name)
    {
        _composites = composites;
        _name = name;
    }

    public Composite(string name)
    {
        _name = name;
        _composites = new List<SimpleComposite>();
    }

    public override void Add(SimpleComposite element)
    {
        _composites.Add(element);
    }

    public override void Remove(SimpleComposite element)
    {
        _composites.Remove(element);
    }

    public override string GetElementName()
    {
        return GetType().Name + ' ' + _name;
    }

    public override void Log()
    {
        Console.Write("Hi, i am " + GetElementName());
        foreach (var simpleComposite in _composites)
        {
            Console.Write("\n");
            simpleComposite.Log();
        }
    }
}
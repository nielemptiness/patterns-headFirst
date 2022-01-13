namespace Patterns.HeadFirst.Composite;

public abstract class SimpleComposite
{
    public virtual void Add(SimpleComposite element) { }

    public virtual void Remove(SimpleComposite element) { }

    public abstract string GetElementName();
    public abstract void Log();
}
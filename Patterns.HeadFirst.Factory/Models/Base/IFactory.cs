namespace Patterns.HeadFirst.Factories.Models.Base
{
    public interface IFactory<out TCreature, in TCreatureType> 
        where TCreature : class
        where TCreatureType : Enum
    {
        TCreature Create(TCreatureType creatureType);
    }
}
using Patterns.HeadFirst.Factories.Models.Base;

namespace Patterns.HeadFirst.Factories.Models.Birds
{
    public class BirdFactory : IFactory<Bird, BirdType>
    {
        public Bird Create(BirdType creatureType)
        {
            return creatureType switch
            {
                BirdType.Eagle => new Eagle("John", 11),
                _ => throw new ArgumentOutOfRangeException(nameof(creatureType), creatureType, null)
            };
        }
    }
}
using Patterns.HeadFirst.Factories.Models.Base;

#pragma warning disable CS8524
namespace Patterns.HeadFirst.Factories.Models.Animals
{
    public class AnimalFactory : IFactory<HomeAnimal, AnimalType>
    {
        public HomeAnimal Create(AnimalType type)
        {
            return type switch
            {
                AnimalType.Cat => new Cat("Tom", 1),
                AnimalType.Dog => new Dog("Bill", 3),
                AnimalType.Undefined => throw new ArgumentOutOfRangeException(nameof(type), type, null),
            };
        }
    }
}
using Patterns.HeadFirst.Factories.Models.Base;

namespace Patterns.HeadFirst.Factories.Models.Animals
{
    public class HomeAnimal : Creature
    {
        protected HomeAnimal(AnimalType type)
        {
            CreatureType = type.ToString();
        }
    }
}
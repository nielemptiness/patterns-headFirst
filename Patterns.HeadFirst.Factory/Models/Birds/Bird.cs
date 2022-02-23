using Patterns.HeadFirst.Factories.Models.Base;

namespace Patterns.HeadFirst.Factories.Models.Birds
{
    public class Bird : Creature
    {
        protected Bird(BirdType type, string name, int age)
        {
            Name = name;
            Age = age;
            Action = "Kyaa!";
            CreatureType = type.ToString();
        }
    }
}
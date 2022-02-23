using Patterns.HeadFirst.Factories.Models.Base;

namespace Patterns.HeadFirst.Factories.Models.Animals
{
    public class Cat : HomeAnimal
    {
        public Cat(string name, int age) : base(AnimalType.Cat)
        {
            Name = name;
            Age = age;
            Action = "Meow!";
        }
    }
}
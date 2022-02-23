using Patterns.HeadFirst.Factories.Models.Base;

namespace Patterns.HeadFirst.Factories.Models.Animals
{
    public class Dog : HomeAnimal
    {
        public Dog(string name, int age) : base(AnimalType.Dog)
        {
            Name = name;
            Age = age;
            Action = "Woof!";
        }
    }
}
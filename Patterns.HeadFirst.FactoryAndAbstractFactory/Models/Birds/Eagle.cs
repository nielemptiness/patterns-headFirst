using Patterns.HeadFirst.Factories.Models.Base;

namespace Patterns.HeadFirst.Factories.Models.Birds
{
    public class Eagle : Bird
    {
        public Eagle(string name, int age) : base(BirdType.Eagle, name, age)
        {
        }
    }
}
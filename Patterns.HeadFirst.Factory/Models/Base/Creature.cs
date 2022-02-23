#pragma warning disable CS8618
namespace Patterns.HeadFirst.Factories.Models.Base
{
    public class Creature
    {
        protected string Name { get; set;  }
        protected int Age { get; set; }
        protected string Action { get; set; }
        protected string CreatureType { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"{Action} I am {Name}, {Age} years old! And yes, i am a {CreatureType}");
        }
    }
}


namespace Patterns.HeadFirst.Adapter
{
    internal class BigPitbull : IBigDog
    {
        public void Bark()
        {
            Console.WriteLine("BARK! BARK!");
        }

        public void GetHeight()
        {
            Console.WriteLine("I am 30cm tall!");
        }
    }
}

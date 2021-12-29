
namespace Patterns.HeadFirst.Adapter
{
    internal class SmallHusky : ISmallDoggy
    {
        public void GetHeight()
        {
            Console.WriteLine("I am 13cm tall... Still a puppy tho.");
        }

        public void Woof()
        {
            Console.WriteLine("W-Woof...");
        }
    }
}

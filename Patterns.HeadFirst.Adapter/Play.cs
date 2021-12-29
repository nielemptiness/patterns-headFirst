
namespace Patterns.HeadFirst.Adapter
{
    public class Play
    {
        public static void PlayWithBigDog(IBigDog dog) 
        {
            dog.GetHeight();
            Console.WriteLine("Carefully, he seems big...");
            dog.Bark();
            Console.WriteLine("Oof scary!");
        }
    }
}

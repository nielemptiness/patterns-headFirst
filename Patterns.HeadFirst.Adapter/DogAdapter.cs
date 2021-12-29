
namespace Patterns.HeadFirst.Adapter
{
    public class DogAdapter : IBigDog
    {
        private readonly ISmallDoggy _smallDoggo;
        public DogAdapter(ISmallDoggy doggo)
        { 
            _smallDoggo = doggo;
        }

        public void Bark()
        {
            _smallDoggo.Woof();
        }

        public void GetHeight()
        {
            _smallDoggo.GetHeight();
        }
    }
}

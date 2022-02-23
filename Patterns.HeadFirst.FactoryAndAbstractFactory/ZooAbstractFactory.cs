using Patterns.HeadFirst.Factories.Models.Animals;
using Patterns.HeadFirst.Factories.Models.Base;
using Patterns.HeadFirst.Factories.Models.Birds;

namespace Patterns.HeadFirst.Factories
{
    public class ZooAbstractFactory
    {
        private readonly IFactory<Bird, BirdType> _birdFactory;
        private readonly IFactory<HomeAnimal, AnimalType> _animalFactory;

        public ZooAbstractFactory()
        {
            _birdFactory = new BirdFactory();
            _animalFactory = new AnimalFactory();
        }

        public IEnumerable<HomeAnimal> CreateAnimals(params AnimalType[] animalTypes)
        {
            return animalTypes.Select(animalType => _animalFactory.Create(animalType)).ToList();
        }

        public Bird CreateBird(BirdType birdType)
        {
            return _birdFactory.Create(birdType);
        }

        public IEnumerable<Creature> CreateZooInhabitants(BirdType birdType, params AnimalType[] animalTypes)
        {
            var creatures = new List<Creature>();
            
            creatures.AddRange(CreateAnimals(animalTypes));
            creatures.Add(CreateBird(birdType));

            return creatures;
        }
    }
}
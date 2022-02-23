// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.Factories;
using Patterns.HeadFirst.Factories.Models.Base;

var abstractFactory = new ZooAbstractFactory();

var zoo = abstractFactory.CreateZooInhabitants(BirdType.Eagle, AnimalType.Cat, AnimalType.Dog);

foreach (var creature in zoo)
{
    creature.Introduce();
}

var cat = abstractFactory.CreateAnimals(AnimalType.Cat);
cat.First().Introduce();

var eagle = abstractFactory.CreateBird(BirdType.Eagle);
eagle.Introduce();
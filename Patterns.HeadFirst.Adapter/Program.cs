// See https://aka.ms/new-console-template for more information
using Patterns.HeadFirst.Adapter;

ISmallDoggy husky = new SmallHusky();
IBigDog pitbull = new BigPitbull();
Play.PlayWithBigDog(new DogAdapter(husky));
Play.PlayWithBigDog(pitbull);

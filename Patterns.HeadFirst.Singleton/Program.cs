// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.Singleton;

var first = StaticSingleton.GetInstance();
var second = StaticSingleton.GetInstance();

var staticSingletoneResult = first == second; 
Console.WriteLine(staticSingletoneResult); // True

var third = LockedSingleton.GetInstance();
var forth = LockedSingleton.GetInstance();

var lockedSingletoneResult = third == forth; 
Console.WriteLine(lockedSingletoneResult); // True
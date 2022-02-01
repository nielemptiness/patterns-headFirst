// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.Proxy;

ISubject pseudoSubject = new SimpleProxy();

var resultOne = pseudoSubject.DoSomeWork();

ISubject realSubject = new SomeSubject(); // Handled by proxy
var resultTwo = realSubject.DoSomeWork();

Console.WriteLine(resultOne == resultTwo); // True

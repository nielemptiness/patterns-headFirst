// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.Composite;

var mainComposite = new Composite("First");
var secondaryComposite = new Composite("Second");
var mainElement = new Leaf("Black");
var secondElement = new Leaf("White");
var thirdElement = new Leaf("Grey");

secondaryComposite.Add(secondElement);
secondaryComposite.Add(thirdElement);
mainComposite.Add(mainElement);
mainComposite.Add(secondaryComposite);

mainComposite.Log();
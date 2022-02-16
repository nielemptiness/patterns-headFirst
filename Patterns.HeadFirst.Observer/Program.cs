// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.Observer;

var observer = new Observer();

var listener1 = new DateListener(observer);
var listener2 = new RandomIntListener(observer);

observer.Notify();

listener1.Unsubscribe();

observer.Notify();
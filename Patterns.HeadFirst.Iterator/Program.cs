// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.Iterator;

var list = new List<SomeEntity>()
{
    new (), new (), new ()
};

var iterator = new SimpleIterator<SomeEntity>(list);

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next().Name);
}

var arr = list.ToArray();
var arrIterator = new SimpleIterator<SomeEntity>(arr);
while (arrIterator.HasNext())
{
    Console.WriteLine(arrIterator.Next().Name);
}


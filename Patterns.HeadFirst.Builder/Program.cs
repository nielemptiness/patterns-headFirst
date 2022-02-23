// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Serialization;
using Patterns.HeadFirst.Builder;

void Print(ComplexObject complexObject)
{
    Console.WriteLine(JsonSerializer.Serialize(complexObject, new JsonSerializerOptions()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
    }));
}

const string name = "User";
var object1 = new ComplexObjectBuilder(name).Build();

var obj2 = new ComplexObjectBuilder(name)
    .WithCreator("Me")
    .Build();
var obj3 = new ComplexObjectBuilder(name)
    .WithCreator("You")
    .WithExpiration(DateTime.Now)
    .Build();
var obj4 = new ComplexObjectBuilder(name)
    .WithCreator("They")
    .WithExpiration(DateTime.Now)
    .WithDetails()
    .Build();
    
Print(object1);
Print(obj2);
Print(obj3);
Print(obj4);
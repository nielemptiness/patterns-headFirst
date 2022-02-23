namespace Patterns.HeadFirst.Template
{
    public class HappyYoungJohny : Template
    {
        protected override void CreateAge()
        {
            Console.WriteLine("I am 10 y.o.");
        }

        protected override void Action()
        {
            Console.WriteLine("Johny is fine, thanks!");
        }
    }
}
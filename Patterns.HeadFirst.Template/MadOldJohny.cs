namespace Patterns.HeadFirst.Template
{
    public class MadOldJohny : Template
    {
        protected override void CreateAge()
        {
            Console.WriteLine("I am 50 y.o.");
        }

        protected override void Action()
        {
            Console.WriteLine("JOHNY IS HERE!!");
        }
    }
}
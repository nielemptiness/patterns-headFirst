namespace Patterns.HeadFirst.Template
{
    public abstract class Template
    {
        public void Introduce()
        {
            CreateName();
            CreateAge();
            Action();
        }

        private void CreateName()
        {
            Console.WriteLine("I am Johny!!");
        }

        protected abstract void CreateAge();
        protected abstract void Action();
    }
}
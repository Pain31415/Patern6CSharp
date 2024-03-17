namespace Patern6CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectElements = new IProjectElement[] { new Task(), new Bug() };
            var manager = new Manager();
            var programmer = new Programmer();

            foreach (var element in projectElements)
            {
                element.Accept(manager);
                element.Accept(programmer);
            }
        }
    }
}

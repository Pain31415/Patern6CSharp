namespace Patern6CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparing pizza:");
            CookingTemplate pizza = new Pizza();
            pizza.Cook();

            Console.WriteLine();

            Console.WriteLine("Preparing soup:");
            CookingTemplate soup = new Soup();
            soup.Cook();
        }
    }
}

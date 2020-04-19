using System;

namespace CaffeineBeverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            var coffee = new Coffee();

            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();
            Console.WriteLine();

            Console.WriteLine("Making coffee...");
            coffee.PrepareRecipe();

            Console.Read();
        }
    }
}

using System;

namespace CaffeineBeverage
{
    public class Coffee : CaffeineBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            var answer = GetUserAnswer();
            if (answer.StartsWith("y"))
            {
                return true;
            }

            return false;
        }

        private string GetUserAnswer()
        {
            Console.WriteLine("Would you like milk or sugar with your coffee (y/n)?");
            return Console.ReadLine();
        }
    }
}

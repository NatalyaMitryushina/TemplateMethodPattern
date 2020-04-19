using System;

namespace CaffeineBeverage
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }  
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}

using System.Collections.Generic;

namespace AbstractFactory
{
    public class FLPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IDough CreateDough()
        {
            return new IThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { new IOnion(), new IGarlic() };
        }
    }
}

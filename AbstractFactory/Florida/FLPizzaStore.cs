using System;

namespace AbstractFactory.Florida
{
    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator.
                 CreateInstance(Type.GetType($"PizzaFactory.FL{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }

    }
}

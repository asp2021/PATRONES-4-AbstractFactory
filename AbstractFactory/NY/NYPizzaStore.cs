using System;

namespace AbstractFactory.NY
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            return (Pizza)Activator.
                CreateInstance(Type.GetType($"AbstractFactory.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"), ingredientFactory);

        }

    }

}

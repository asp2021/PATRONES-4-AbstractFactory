using AbstractFactory.NY;
using static System.Console;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("ABSTRACT FACTORY" + '\n');
            WriteLine("Nos permite crear familias de objetos relacionados sin especificar sus clases concretas" + '\n');

            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza(TypeOfPizza.Pepperoni);

            WriteLine($"Pizza {pizza.Name} lista para ser entregada a Daniel");
            ReadLine();
        }
    }
}

using FactoryMethodPattern.PizzaFactories;

namespace FactoryMethodPattern.PizzaBusinesses
{
    public class AmericaPizzaStore : PizzaStore
    {
        public AmericaPizzaStore(AmericaPizzaFactory pizzaFactory) : base(pizzaFactory)
        {
            Console.WriteLine("America");
        }
    }
}

using System.Collections.Generic;

namespace Pizza.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> Pizzas { get; }
        IEnumerable<Pizza> PizzasOfTheWeek { get; }

        Pizza GetPizzaById(int pizzaId); //method to retrieve Pizza by ID
    }
}

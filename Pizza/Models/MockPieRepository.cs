using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Models
{
    public class MockPizzaRepository : IPizzaRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pizza> Pizzas
        {
            get
            {
                return new List<Pizza>
                    {
                        new Pizza(){pizzaId = 1, Name="Strawberry Pizza", Price=15.95M, ShortDescription="lorem ipsum"}
                        new Pizza(){pizzaId = 2, Name="Cheese Pizza", Price=12.95M, ShortDescription="lorem ipsum"}

                        new Pizza(){pizzaId = 3, Name="Rhubarb Pizza", Price=15.95M, ShortDescription="lorem ipsum"}
                        new Pizza(){pizzaId = 4, Name="Pumpkin Pizza", Price=18.95M, ShortDescription="lorem ipsum"}
                };
                }
        }
        public IEnumerable<Pizza> PizzasOfTheWeek { get; }
        public Pizza GetPizzaById(int pizzaID)
        {
            throw new System.NotImplementedException();
        }
    }
}

using System.Collections.Generic;

namespace Pizza.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerble<Category> Categories
        {
            get
            {
                return new List<Category>
                    {
                        new Category{CategoryId=1, CategoryName="Popular Pizzas", Description="All-the-time" },
                        new Category{CategoryId=2, CategoryName="Distinct Pizzas", Description="Unique Flavor" },
                        new Category{CategoryId=3, CategoryName="Seasonal Pizzas", Description="Octoberfest" }

                    };
            }

        }

    }
}
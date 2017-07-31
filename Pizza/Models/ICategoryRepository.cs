using System.Collections.Generic;

namespace Pizza.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}

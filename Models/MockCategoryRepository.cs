using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.Models
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Nike", Description="Nike shoes" },
                new Category{CategoryId=2, CategoryName="Jordan", Description="Jordan shoes" },
                new Category{CategoryId=3, CategoryName="Adidas", Description="Adidas shoes" }
            };
    }
}

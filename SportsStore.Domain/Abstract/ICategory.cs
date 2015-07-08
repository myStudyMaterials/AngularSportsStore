using SportsStore.Domain.Entities;
using System.Collections.Generic;

namespace SportsStore.Domain.Abstract
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        int AddCategory(Category category);
        bool EditCategory(Category category);
        bool DeleteCategory(int id);
    }
}

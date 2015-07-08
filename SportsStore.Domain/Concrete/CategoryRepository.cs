
using System.Collections.Generic;
using System.Linq;

using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    public class CategoryRepository : ICategory
    {
        public IEnumerable<Category> GetCategories()
        {
            IEnumerable<Category> categories = null;

            using (var context = new EFSportsStoreContext())
            {
                categories = context.Category.ToList();
            };

            return categories;
        }

        public int AddCategory(Category category)
        {
            using (var context = new EFSportsStoreContext())
            {
                context.Category.Add(category);
                context.SaveChanges();
            };
            return category.Id;
        }

        public bool EditCategory(Category category)
        {
            var isUpdated = false;
            using (var context = new EFSportsStoreContext())
            {
                var existingcategory = GetExistingCategory(category.Id, context);
                if (existingcategory != null)
                {
                    existingcategory.Name = category.Name;

                    context.Entry(existingcategory).State = EntityState.Modified;
                    context.SaveChanges();
                    isUpdated = true;
                }
            }
            return isUpdated;

        }

        public bool DeleteCategory(int id)
        {
            var isDeleted = false;
            using (var context = new EFSportsStoreContext())
            {
                var existingcategory = GetExistingCategory(id, context);
                if (existingcategory != null)
                {
                    context.Category.Remove(existingcategory);
                    context.SaveChanges();
                    isDeleted = true;
                }
            }
            return isDeleted;
        }


        private Category GetExistingCategory(int id, EFSportsStoreContext context)
        {
            return context.Category.Single(p => p.Id == id);
        }
    }
}

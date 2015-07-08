using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.ViewModals;


namespace SportsStore.Domain.Concrete
{
    public class ProductRepository : IProducts
    {


        public IEnumerable<ProductDetails> GetProducts()
        {
            IEnumerable<ProductDetails> products = null;
            using (var context = new EFSportsStoreContext())
            {
                var query = from p in context.Product
                            from c in context.Category.Where(x => x.Id == p.CategoryId)
                            select new ProductDetails
                            {
                                ProductId = p.Id,
                                CategoryId = c.Id,
                                CategoryName = c.Name,
                                ProductName = p.Name,
                                Price = p.Price,
                                Description = p.Description
                            };
                products = query.ToList<ProductDetails>();
            }
            return products;
        }

        public int AddProduct(Product product)
        {
            using (var context = new EFSportsStoreContext())
            {
                context.Product.Add(product);
                context.SaveChanges();
            };
            return product.Id;
        }

        public bool EditProduct(Product product)
        {
            var isUpdated = false;
            using (var context = new EFSportsStoreContext())
            {
                var existingProduct = GetExistingProduct(product.Id, context);
                if (existingProduct != null)
                {
                    existingProduct.CategoryId = product.CategoryId;
                    existingProduct.Description = product.Description;
                    existingProduct.Name = product.Name;
                    existingProduct.Price = product.Price;
                    context.Entry(existingProduct).State = EntityState.Modified;
                    context.SaveChanges();
                    isUpdated = true;
                }
            }
            return isUpdated;

        }

        public bool DeleteProduct(int id)
        {
            var isDeleted = false;
            using (var context = new EFSportsStoreContext())
            {
                var existingProduct = GetExistingProduct(id, context);
                if (existingProduct != null)
                {
                    context.Product.Remove(existingProduct);
                    context.SaveChanges();
                    isDeleted = true;
                }
            }
            return isDeleted;
        }


        private Product GetExistingProduct(int id, EFSportsStoreContext context)
        {
            return context.Product.Single(p => p.Id == id);
        }

    }
}

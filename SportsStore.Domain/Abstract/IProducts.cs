
using System.Collections.Generic;

using SportsStore.Domain.Entities;
using SportsStore.ViewModals;

namespace SportsStore.Domain.Abstract
{
    public interface IProducts
    {
        IEnumerable<ProductDetails> GetProducts();
        int AddProduct(Product product);
        bool EditProduct(Product product);
        bool DeleteProduct(int id);
    }
}

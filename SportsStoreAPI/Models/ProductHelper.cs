
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStore.ViewModals;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;


namespace SportsStoreAPI.Models
{
    public class ProductHelper
    {
        public static IEnumerable<ProductDetails> GetProducts()
        {
            IProducts products = new ProductRepository();
            return products.GetProducts();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SportsStore.Domain.Abstract;
using SportsStore.ViewModals;
using SportsStore.UI.Infrastructure;


namespace SportsStore.UI.Helpers
{
    public class ProductDetailsHelper
    {
        public static  IEnumerable<ProductDetails> GetProducts()
        {
            var resolver = IocResolver.Resolve<IProducts>();
            return resolver.GetProducts();
        }
    }
}
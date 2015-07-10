using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportsStoreAPI.Models;
using SportsStore.ViewModals;
namespace SportsStoreAPI.Controllers
{
    public class ProductAPIController : ApiController
    {
        [HttpGet]
        public IEnumerable<ProductDetails> GetProducts()
        {
            return ProductHelper.GetProducts();
        }
    }
}

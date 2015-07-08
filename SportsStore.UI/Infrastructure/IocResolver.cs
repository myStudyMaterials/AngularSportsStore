using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Ninject;

using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.Domain.Entities;

namespace SportsStore.UI.Infrastructure
{
    public class IocResolver : IDependencyResolver
    {
        private static IKernel kernel;

        public IocResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public static T Resolve<T>()
        {
            return kernel.Get<T>();
        }

        public static T TryResolve<T>()
        {
            return kernel.CanResolve<T>() ? kernel.Get<T>() : default(T);
        }

        public static void Release(object o)
        {
            kernel.Release(o);
        }

        private void AddBindings()
        {
            kernel.Bind<IProducts>().To<ProductRepository>();
            kernel.Bind<ICategory>().To<CategoryRepository>();
        }
    }
}
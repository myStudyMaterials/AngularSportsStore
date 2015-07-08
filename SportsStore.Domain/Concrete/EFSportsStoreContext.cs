using System.Data.Entity;

using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    internal class EFSportsStoreContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}

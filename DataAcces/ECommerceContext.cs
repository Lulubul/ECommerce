namespace Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ECommerceContext : DbContext
    {
        public ECommerceContext()
            : base("name=ECommerceContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

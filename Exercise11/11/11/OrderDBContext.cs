using System;
using System.Data.Entity;
using System.Linq;

namespace _11
{
    public class OrderDBContext : DbContext
    {

        public OrderDBContext()
            : base("name=OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderDBContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace _11
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderDBContext : DbContext
    {
        
        public OrderDBContext()
            : base("OrderDataBase")
        {
           
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderDBContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
using System;
using Microsoft.EntityFrameworkCore;
namespace _12.Models
{
	public class OrderDBContext : DbContext
	{
		public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options)
		{
			this.Database.EnsureCreated();
		}

		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
	}
}

using Microsoft.EntityFrameworkCore;
using Mvc_Task1.Models;

namespace Mvc_Task1.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Employee> Employees {  get; set; } 
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.;database=MvcT1;trusted_connection=true;trustServerCertificate=true");
		}
	}
}

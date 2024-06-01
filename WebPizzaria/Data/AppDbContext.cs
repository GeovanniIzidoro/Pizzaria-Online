using Microsoft.EntityFrameworkCore;
using WebPizzaria.Models;

namespace WebPizzaria.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<PizzaModel> Pizzas { get; set; }
    }
}

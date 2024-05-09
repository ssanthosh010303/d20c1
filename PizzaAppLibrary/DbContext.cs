/*
 * Author: Sakthi Santhosh
 * Created on: 09/05/2024
 */

using Microsoft.EntityFrameworkCore;

namespace Challenge1.PizzaAppLibrary;

public class AppDbContext : DbContext
{
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Topping> Toppings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=WORK-MACHINE\lad;Integrated Security=True;Initial Catalog=PizzaShop");
    }
}

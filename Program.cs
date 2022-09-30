//Dato il seguente schema, procedete alla realizzazione delle rispettive classi da eleggere a Model per EF (Entity Framework), create ed eseguite una migrazione sempre attraverso gli strumenti visti oggi con EF.

//Una volta che avrete il vostro DB, provate a fare delle operazioni di CRUD (almeno una) per ogni tabella con le due modalità viste di LINQ (Method Syntax e Query Syntax)

using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello World");

public class ECommerce : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ECommerce;Integrated Security=True");
    }
}
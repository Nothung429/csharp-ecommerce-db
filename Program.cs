//Dato il seguente schema, procedete alla realizzazione delle rispettive classi da eleggere a Model per EF (Entity Framework), create ed eseguite una migrazione sempre attraverso gli strumenti visti oggi con EF.

//Una volta che avrete il vostro DB, provate a fare delle operazioni di CRUD (almeno una) per ogni tabella con le due modalità viste di LINQ (Method Syntax e Query Syntax)

using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello World");

using (ECommerce db = new ECommerce())
{
    //MULTIPLE CREATE
    //db.Add(new Customer("John", "Doe", "pioli.@gmail.com"));
    //db.Add(new Customer("Mike", "Poe", "is.@gmail.com"));
    //db.Add(new Customer("Alex", "Foe", "on.@gmail.com"));
    //db.Add(new Customer("Smith", "Goe", "fire.@gmail.com"));

    //db.Add(new Employee("Mike", "Wasosvki", "operario"));
    //db.Add(new Employee("Pino", "Insegno", "junior"));
    //db.Add(new Employee("Piero", "Pirovano", "dirigente"));
    //db.Add(new Employee("Antonio", "Pacciani", "ceo"));

    //db.Add(new Order(new DateTime(2013, 12, 03), 34, true));
    //db.Add(new Order(new DateTime(2013, 08, 13), 12, true));
    //db.Add(new Order(new DateTime(2013, 03, 26), 156, false));
    //db.Add(new Order(new DateTime(2013, 05, 17), 22, true));
    //db.SaveChanges();

    //db.Add(new Payment(new DateTime(2013, 12, 03), 132, false));
    //db.Add(new Payment(new DateTime(2013, 08, 13), 178, false));
    //db.Add(new Payment(new DateTime(2013, 03, 26), 15, true));
    //db.Add(new Payment(new DateTime(2013, 05, 17), 567, false));
    //db.SaveChanges();

    //db.Add(new Product("IPhone", "telefono", 499));
    //db.Add(new Product("IMac", "computer", 1499));
    //db.Add(new Product("IPad", "tablet", 899));
    //db.Add(new Product("AirPods", "cuffie bluetooth", 199));

    //db.SaveChanges();

    //CREATE
    Customer myCustomer = new Customer { Name = "John", Surname = "Doe", Email = "pioli.@gmail.com" };
    db.Add(myCustomer);

    Employee myEmployee = new Employee { Name = "John", Surname = "Doe", Level = "dirigente" };
    db.Add(myEmployee);

    Order myOrder = new Order { Date = new DateTime(2013, 12, 03), Amount = 34, Status = true };
    db.Add(myOrder);

    Payment myPayment = new Payment { Date = new DateTime(2013, 12, 03), Amount = 56, Status = true };
    db.Add(myPayment);

    Product myProduct = new Product { Name = "IPhone", Description = "telefono", Price = 499 };
    db.Add(myProduct);

    //db.SaveChanges();

    //Read
    Console.WriteLine("Recupero lista di Clienti");
    List<Customer> customers = db.Customers.OrderBy(customer => customer.Name).ToList<Customer>();
    foreach (Customer customer in customers)
    {
        Console.WriteLine($"{customer.Name} - {customer.Surname} ------> {customer.Email}");
    }

    Console.WriteLine("Recupero lista di Dipendenti");
    List<Employee> employees = db.Employees.OrderBy(employee => employee.Name).ToList<Employee>();
    foreach (Employee employee in employees)
    {
        Console.WriteLine($"{employee.Name} - {employee.Surname} ------> {employee.Level}");
    }

    Console.WriteLine("Recupero lista di Ordini");
    List<Order> orders = db.Orders.OrderBy(order => order.Id).ToList<Order>();
    foreach (Order order in orders)
    {
        Console.WriteLine($"{order.Date} - {order.Amount} ------> {order.Status}");
    }

    Console.WriteLine("Recupero lista di Pagamenti");
    List<Payment> payments = db.Payments.OrderBy(payment => payment.Id).ToList<Payment>();
    foreach (Payment payment in payments)
    {
        Console.WriteLine($"{payment.Date} - {payment.Amount} ------> {payment.Status}");
    }

    Console.WriteLine("Recupero lista di Prodotti");
    List<Product> products = db.Products.OrderBy(product => product.Name).ToList<Product>();
    foreach (Product product in products)
    {
        Console.WriteLine($"{product.Name} - {product.Description} ------> {product.Price}");
    }
}

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
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

    //one-to-many
    public List<Order> Orders { get; set; }

    //public Customer(string name, string surname, string email)
    //{
    //    Name = name;
    //    Surname = surname;
    //    Email = email;
    //}
}
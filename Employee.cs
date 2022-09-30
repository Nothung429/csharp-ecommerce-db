public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Level { get; set; }

    //one-to-many
    public List<Order> Orders { get; set; }
}
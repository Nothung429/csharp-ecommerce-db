public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public Boolean Status { get; set; }

    //one-to-many
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    //many-to-many
    public List<Payment> Payments { get; set; }
    public List<Product> Products { get; set; }
}
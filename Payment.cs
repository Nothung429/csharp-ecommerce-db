public class Payment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public Boolean Status { get; set; }

    //one-to-many
    public int OrderId { get; set; }
    public Order Order { get; set; }
}
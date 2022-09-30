public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    //many-to-many
    public List<Order> Orders { get; set; }

    //public Product(string name, string description, int price)
    //{
    //    Name = name;
    //    Description = description;
    //    Price = price;
    //}
}
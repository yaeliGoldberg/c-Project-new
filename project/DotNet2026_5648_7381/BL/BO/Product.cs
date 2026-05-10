namespace BO;

public class Product
{
    public int Id { get; init; }
    public string Name { get; set; }
    public Categories Category { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }

    public List<SaleInProduct> ListSaleInProduct { get; set; }

    public Product() : this(-1, "", Categories.LENSES, 0.0, 0, new List<SaleInProduct>()) { }

    public Product(int id, string name, Categories category, double price, int quantityInStack, List<SaleInProduct> listSaleInProduct)
    {
        Id = id;
        Name = name;
        Category = category;
        Price = price;
        Amount = quantityInStack;
        ListSaleInProduct = listSaleInProduct ?? new List<SaleInProduct>();
    }
    public override string ToString() => this.ToStringProperty();
}
  
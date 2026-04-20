using DO;

namespace BO;

public class Product
{
    public int Id { get; init; }
    public string Name { get; set; }
    public Categories C { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }

    public override string ToString() => this.ToStringProperty();
}
  

namespace BO;

public class Customer
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string Adress { get; set; }
    public string Phon { get; set; }

    public override string ToString() => this.ToStringProperty();
}
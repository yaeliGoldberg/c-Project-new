
using System.Net;
using System.Numerics;

namespace BO;

public class Customer
{
    public int Id { get; init; }
    public string Name { get; set; }
    public string Adress { get; set; }
    public string Phon { get; set; }

    public Customer() : this(-1, "", "", "") { }

    public Customer(int id, string name, string address, string phone)
    {
        Id = id;
        Name = name;
        Adress = address;
        Phon = phone;
    }
    public override string ToString() => this.ToStringProperty();
}
using DO;
using System;
namespace BO;

public class Sale
{
    public int id { get; init; }
    public int id_product { get; init; }
    public int min_amount { get; set; }
    public double min_price { get; set; }
    public bool for_who { get; set; }
    public  DateTime start_sale { get; set; }
    public DateTime end_sale { get; set; }


    public Sale() : this(0, -1, 0, 0.0, false, DateTime.Now, DateTime.Now) { }

    public Sale(int id, int id_product, int min_amount, double min_price, bool for_who, DateTime startSale, DateTime endSale)
    {
        this.id = id;
        this.id_product = id_product;
        this.min_amount = min_amount;
        this.min_price = min_price;
        this.for_who = for_who;
        this.start_sale = startSale;
        this.end_sale = endSale;

    }
    public override string ToString() =>
    this.ToStringProperty();
}

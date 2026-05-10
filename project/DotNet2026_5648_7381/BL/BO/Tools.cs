using System.Collections;


namespace BO;

internal static class Tools
{
    internal static string ToStringProperty<T>(this T obj)
    {
       
        string result = "";
        Type type = obj.GetType();
        foreach (var prop in type.GetProperties())
        {
            Type propType = prop.PropertyType;
            var value = prop.GetValue(obj);
            if (value == null)
            {
                result += $"{prop.Name}: null, ";
            }
            else if (value is IEnumerable collection && value is not string)
            {
                result += $"{prop.Name}: [";
                foreach (var item in collection)
                    result += ToStringProperty(item);
                result += "], ";
            }
            else if (!propType.IsPrimitive && propType != typeof(string))
            {
                result += $"{prop.Name}: {ToStringProperty(value)}, ";
            }
            else
            {
                result += $"{prop.Name}: {value}, ";
            }
        }
        return result;
    }


    // המרה מ-DO ל-BO


   
    public static BO.Sale ToBO(this DO.Sale sale) =>
        new BO.Sale(
           sale.id,
           sale.id_product,
           sale.min_amount,
           sale.min_price,
           sale.for_who,
           sale.start_sale,
           sale.end_sale
        );

    // המרה מ-BO ל-DO
    public static DO.Sale ToDO(this BO.Sale sale) =>
        new DO.Sale(
           sale.id,
           sale.id_product,
           sale.min_amount,
           sale.min_price,
           sale.for_who,
           sale.start_sale,
           sale.end_sale
        );

    // המרה מ-DO ל-BO

    public static BO.Customer ToBO(this DO.Customer customer) =>
        new BO.Customer(
            customer.id,
            customer.name,
            customer.adress,
            customer.phon
        );

    // המרה מ-BO ל-DO
    public static DO.Customer ToDO(this BO.Customer customer) =>
        new DO.Customer(
            customer.Id,
            customer.Name,
            customer.Adress,
            customer.Phon
        );

    // המרה מ-DO ל-BO

    /*
    int id,
    string name,
    Categories c,
    double price,
    int amount
     */
    public static BO.Product ToBO(this DO.Products product)
    {
        List<BO.SaleInProduct> saleInProduct = new List<BO.SaleInProduct>();
        return new BO.Product(
            product.id,
            product.name,
            (BO.Categories)product.c,
            product.price,
            product.amount,
            saleInProduct

        );
    }

    // המרה מ-BO ל-DO
    public static DO.Products ToDO(this BO.Product product) =>
        new DO.Products(
            product.Id,
            product.Name,
            (DO.Categories)product.Category,
            product.Price,
            product.Amount
        );
}
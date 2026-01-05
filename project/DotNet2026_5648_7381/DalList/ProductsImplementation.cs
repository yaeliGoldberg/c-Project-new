using DO;
using DalApi;


namespace Dal;
public class ProductsImplementation : Iproducts
{
    public int Create(Products item)
    {
        int newid = DataSource.Products.Count > 0 ? DataSource.Products.Max(c => c.id) + 1 : 1;
        Products newCustomer = item with { id = newid };
        DataSource.Products.Add(newCustomer);
        return newid;
    }
    public Products? Read(int id)
    {


        Products x = DataSource.Products.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new Exception($"coustomer {id}  is not exist");
        return x;


    }
    public List<Products> ReadAll()
    {
        return DataSource.Products.ToList();
    }

    public void Update(Products item)
    {
        Delete(item.id);
        DataSource.Products.Add(item);

    }
    public void Delete(int id)
    {
        int i = DataSource.Products.FindIndex(c => c.id == id);
        if (i == -1) throw new Exception($"coustomer {id}  is not exist");
        DataSource.Products.RemoveAt(i);
    }
}


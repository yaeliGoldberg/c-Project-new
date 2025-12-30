using DO;
using DalApi;

namespace Dal;

internal class SaleImplementation:Isale
{
    public int Create(Sale item)
    {
        int newid = DataSource.Sales.Count > 0 ? DataSource.Sales.Max(c => c.id) + 1 : 1;
        Sale newSales = item with { id = newid };
        DataSource.Sales.Add(newSales);
        return newid;
    }
    public Sale? Read(int id)
    {


        Sale x = DataSource.Sales.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new Exception($"coustomer {id}  is not exist");
        return x;


    }
    public List<Sale> ReadAll()
    {
        return DataSource.Sales.ToList();
    }

    public void Update(Sale item)
    {
        Delete(item.id);
        DataSource.Sales.Add(item);

    }
    public void Delete(int id)
    {
        int i = DataSource.Sales.FindIndex(c => c.id == id);
        if (i == -1) throw new Exception($"coustomer {id}  is not exist");
        DataSource.Sales.RemoveAt(i);
    }
}



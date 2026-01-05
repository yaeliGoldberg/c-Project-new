using DO;
using DalApi;

namespace Dal;

public class CoustomerImplementation:Icoustomer
{
    public int Create(Customer item)
    {
        int newid = DataSource.Customers.Count > 0 ? DataSource.Customers.Max(c => c.id) + 1 : 1;
        Customer newCustomer =item with { id = newid };
        DataSource.Customers.Add(newCustomer);
        return newid;
    }
    public Customer? Read(int id)
    {


        Customer x = DataSource.Customers.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new Exception($"coustomer {id}  is not exist");
        return x;


    }
    public List<Customer> ReadAll()
    {
        return DataSource.Customers.ToList();
    }
   
    public void Update(Customer item)
    {
        Delete(item.id);
        DataSource.Customers.Add(item);

    }
    public void Delete(int id)
    {
        int i= DataSource.Customers.FindIndex(c=>c.id==id);
        if(i==-1) throw new Exception($"coustomer {id}  is not exist");
        DataSource.Customers.RemoveAt(i);
    }
}

using DO;
using DalApi;

namespace Dal;

internal class CoustomerImplementation:Icoustomer
{
    public int Create(Coustomer item)
    {
        int newid = DataSource.Customers.Count > 0 ? DataSource.Customers.Max(c => c.id) + 1 : 1;
        Coustomer newCustomer =item with { id = newid };
        DataSource.Customers.Add(newCustomer);
        return newid;
    }
    public Coustomer? Read(int id)
    {


        Coustomer x = DataSource.Customers.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new Exception($"coustomer {id}  is not exist");
        return x;


    }
    public List<Coustomer> ReadAll()
    {
        return DataSource.Customers.ToList();
    }
   
    public void Update(Coustomer item)
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

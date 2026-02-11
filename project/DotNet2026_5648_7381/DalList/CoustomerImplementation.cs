using DO;
using DalApi;
using System.Linq;

namespace Dal;

internal class CoustomerImplementation : Icoustomer
{
    public int Create(Customer item)
    { 
        int newid = Config3.run_value_static;
        Customer newCustomer = item with { id = newid };

        // בדיקה אם קיים כבר
        if (DataSource.Customers.Any(c => c.id == newid))
            throw new DalAlreadyExistException($"Customer with id {newid} already exists");

        DataSource.Customers.Add(newCustomer);
        return newid;
    }

    public Customer Read(int id)
    {
        // שימוש ב-LINQ במקום Find
        Customer? x = DataSource.Customers.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new DalNotExistException($"Customer with id {id} does not exist");

        return x;
    }

   
    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        return filter == null
            ? DataSource.Customers.ToList()
            : DataSource.Customers.Where(filter).ToList();
    }

    public void Update(Customer item)
    {
        // קודם בודקים אם הקיים
        Customer? existing = DataSource.Customers.FirstOrDefault(c => c.id == item.id);
        if (existing == null)
            throw new DalNotExistException($"Customer with id {item.id} does not exist");

        // מחיקה והוספה מחדש
        DataSource.Customers.Remove(existing);
        DataSource.Customers.Add(item);
    }

    public void Delete(int id)
    {
        // שימוש ב-LINQ במקום FindIndex
        Customer? existing = DataSource.Customers.FirstOrDefault(c => c.id == id);
        if (existing == null)
            throw new DalNotExistException($"Customer with id {id} does not exist");

        DataSource.Customers.Remove(existing);
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        return DataSource.Customers.FirstOrDefault(filter);
    }

}


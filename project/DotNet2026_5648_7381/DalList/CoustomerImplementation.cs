using DO;
using DalApi;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using Tools;

namespace Dal;

internal class CoustomerImplementation : Icoustomer
{
    public int Create(Customer item)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
            "insert to function");
        int newid = Config3.run_value_static;
        Customer newCustomer = item with { id = newid };

        // בדיקה אם קיים כבר
        if (DataSource.Customers.Any(c => c.id == newid))
            throw new DalAlreadyExistException($"Customer with id {newid} already exists");

        DataSource.Customers.Add(newCustomer);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
            "Exiting the function");

        return newid;
    }

    public Customer Read(int id)
    {
        // שימוש ב-LINQ במקום Find
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
            "insert to function");
        Customer? x = DataSource.Customers.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new DalNotExistException($"Customer with id {id} does not exist");

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
   MethodBase.GetCurrentMethod().Name,
    "Exiting the function");

        return x;
    }


    public List<Customer> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
   MethodBase.GetCurrentMethod().Name,
    "insert to function");

        var result = filter == null
            ? DataSource.Customers.ToList()
            : DataSource.Customers.Where(filter).ToList();
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
   MethodBase.GetCurrentMethod().Name,
    "Exiting the function");

        return result;
    }

    public void Update(Customer item)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                             MethodBase.GetCurrentMethod().Name,
                              "insert to function");
        // קודם בודקים אם הקיים
        Customer? existing = DataSource.Customers.FirstOrDefault(c => c.id == item.id);
        if (existing == null)
            throw new DalNotExistException($"Customer with id {item.id} does not exist");

        // מחיקה והוספה מחדש
        DataSource.Customers.Remove(existing);
        DataSource.Customers.Add(item);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                             MethodBase.GetCurrentMethod().Name,
                              "Exiting the function");
    }

    public void Delete(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           MethodBase.GetCurrentMethod().Name,
                            "insert to function");

        // שימוש ב-LINQ במקום FindIndex
        Customer? existing = DataSource.Customers.FirstOrDefault(c => c.id == id);
        if (existing == null)
            throw new DalNotExistException($"Customer with id {id} does not exist");

        DataSource.Customers.Remove(existing);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           MethodBase.GetCurrentMethod().Name,
                            "Exiting the function");
    }
    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           MethodBase.GetCurrentMethod().Name,
                            "insert to function");
        Customer c = DataSource.Customers.FirstOrDefault(filter);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                           MethodBase.GetCurrentMethod().Name,
                            "Exiting the function");
        return c;
    }

}


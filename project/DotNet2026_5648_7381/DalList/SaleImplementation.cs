/*using DO;
using DalApi;


namespace Dal;

internal class SaleImplementation:Isale
{
    public int Create(Sale item)
    {
        int newid =  Config2.run_value_static;
        Sale newSales = item with { id = newid };
        DataSource.Sales.Add(newSales);
        return newid;
    }
    public Sale? Read(int id)
    {


        Sale x = DataSource.Sales.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new DalAlreadyExistException($"coustomer {id}  is not exist");
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
        if (i == -1) throw new DalAlreadyExistException($"coustomer {id}  is not exist");
        DataSource.Sales.RemoveAt(i);
    }
}*/

using DO;
using DalApi;
using System.Linq;

namespace Dal;

internal class SaleImplementation : Isale
{
    public int Create(Sale item)
    {
        int newid = Config2.run_value_static;
        Sale newSale = item with { id = newid };

        // בדיקה אם כבר קיים מוצר עם אותו ID
        if (DataSource.Sales.Any(s => s.id == newid))
            throw new DalAlreadyExistException($"Sale with id {newid} already exists");

        DataSource.Sales.Add(newSale);
        return newid;
    }

    public Sale Read(int id)
    {
        // שימוש ב-LINQ כדי למצוא מכירה לפי ID
        Sale? sale = DataSource.Sales.FirstOrDefault(s => s.id == id);
        if (sale == null)
            throw new DalNotExistException($"Sale with id {id} does not exist");

        return sale;
    }


    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        return filter == null
            ? DataSource.Sales.ToList()
            : DataSource.Sales.Where(filter).ToList();
    }

    public void Update(Sale item)
    {
        // קודם בודקים אם המכירה קיימת
        Sale? existing = DataSource.Sales.FirstOrDefault(s => s.id == item.id);
        if (existing == null)
            throw new DalNotExistException($"Sale with id {item.id} does not exist");

        // הסרה והוספה מחדש
        DataSource.Sales.Remove(existing);
        DataSource.Sales.Add(item);
    }

    public void Delete(int id)
    {
        // מוצאים את המכירה לפי ID
        Sale? existing = DataSource.Sales.FirstOrDefault(s => s.id == id);
        if (existing == null)
            throw new DalNotExistException($"Sale with id {id} does not exist");

        // הסרה מהרשימה
        DataSource.Sales.Remove(existing);
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        return DataSource.Sales.FirstOrDefault(filter);
    }
}




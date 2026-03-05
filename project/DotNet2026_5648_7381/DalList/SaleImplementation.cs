using DO;
using DalApi;
using System.Linq;
using System.Reflection;
using Tools;

namespace Dal;

internal class SaleImplementation : Isale
{
    public int Create(Sale item)
    {

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name,
             "insert to function");

        int newid = Config2.run_value_static;
        Sale newSale = item with { id = newid };

        // בדיקה אם כבר קיים מוצר עם אותו ID
        if (DataSource.Sales.Any(s => s.id == newid))
            throw new DalAlreadyExistException($"Sale with id {newid} already exists");

        DataSource.Sales.Add(newSale);


        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name,
             "Exiting the function");

        return newid;
    }

    public Sale Read(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                   MethodBase.GetCurrentMethod().Name,
                   "insert to function");

        // שימוש ב-LINQ כדי למצוא מכירה לפי ID
        Sale? sale = DataSource.Sales.FirstOrDefault(s => s.id == id);
        if (sale == null)
            throw new DalNotExistException($"Sale with id {id} does not exist");

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                MethodBase.GetCurrentMethod().Name,
                "Exiting the function");

        return sale;
    }


    public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
           "insert to function");
        var s = filter == null
            ? DataSource.Sales.ToList()
            : DataSource.Sales.Where(filter).ToList();

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
           "Exiting the function");

        return s;
    }

    public void Update(Sale item)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
           "insert to function");
        // קודם בודקים אם המכירה קיימת
        Sale? existing = DataSource.Sales.FirstOrDefault(s => s.id == item.id);
        if (existing == null)
            throw new DalNotExistException($"Sale with id {item.id} does not exist");

        // הסרה והוספה מחדש
        DataSource.Sales.Remove(existing);
        DataSource.Sales.Add(item);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
           "Exiting the function");
    }

    public void Delete(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
   MethodBase.GetCurrentMethod().Name,
   "insert to function");
        // מוצאים את המכירה לפי ID
        Sale? existing = DataSource.Sales.FirstOrDefault(s => s.id == id);
        if (existing == null)
            throw new DalNotExistException($"Sale with id {id} does not exist");

        // הסרה מהרשימה
        DataSource.Sales.Remove(existing);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
   MethodBase.GetCurrentMethod().Name,
   "Exiting the function");
    }
    public Sale? Read(Func<Sale, bool> filter)
    {

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
           "insert to function");
        Sale s = DataSource.Sales.FirstOrDefault(filter);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
           MethodBase.GetCurrentMethod().Name,
           "Exiting the function");
        return s;
    }
}




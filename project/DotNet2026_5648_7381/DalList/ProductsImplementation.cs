using DO;
using DalApi;
using System.Linq;
using System.Reflection;
using Tools;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dal;

internal class ProductsImplementation : Iproducts
{
    public int Create(Products item)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                     MethodBase.GetCurrentMethod().Name,
                      "insert to function");

        int newid = Config1.run_value_static;
        Products newProduct = item with { id = newid };

        // בדיקה אם כבר קיים מוצר עם אותו ID
        if (DataSource.Products.Any(p => p.id == newid))
            throw new DalAlreadyExistException($"Product with id {newid} already exists");

        DataSource.Products.Add(newProduct);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
        MethodBase.GetCurrentMethod().Name,
                      "Exiting the function"); 

        return newid;
    }

    public Products Read(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                     MethodBase.GetCurrentMethod().Name,
                      "insert to function");

        // שימוש ב-LINQ כדי למצוא מוצר לפי ID
        Products? product = DataSource.Products.FirstOrDefault(p => p.id == id);
        if (product == null)
            throw new DalNotExistException($"Product with id {id} does not exist");

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                     MethodBase.GetCurrentMethod().Name,
                      "Exiting the function");

        return product;
    }
    public List<Products> ReadAll(Func<Products, bool>? filter = null)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                     MethodBase.GetCurrentMethod().Name,
                      "insert to function");
        var result=filter == null
            ? DataSource.Products.ToList()
            : DataSource.Products.Where(filter).ToList();
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                     MethodBase.GetCurrentMethod().Name,
                      "Exiting the function");


        return result;
    }
 
    public void Update(Products item)
    {

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
             MethodBase.GetCurrentMethod().Name,
              "insert to function");
        // קודם בודקים אם המוצר קיים
        Products? existing = DataSource.Products.FirstOrDefault(p => p.id == item.id);
        if (existing == null)
            throw new DalNotExistException($"Product with id {item.id} does not exist");

        // הסרה והוספה מחדש
        DataSource.Products.Remove(existing);
        DataSource.Products.Add(item);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
             MethodBase.GetCurrentMethod().Name,
              "Exiting the function");

    }

    public void Delete(int id)
    {
                LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
             MethodBase.GetCurrentMethod().Name,
              "insert to function");
        // מוצאים את המוצר לפי ID
        Products? existing = DataSource.Products.FirstOrDefault(p => p.id == id);
        if (existing == null)
            throw new DalNotExistException($"Product with id {id} does not exist");

        // הסרה מהרשימה
        DataSource.Products.Remove(existing);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
             MethodBase.GetCurrentMethod().Name,
              "Exiting the function");
    }
    public Products? Read(Func<Products, bool> filter)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name,
             "insert to function");
        Products p= DataSource.Products.FirstOrDefault(filter);

        LogManager.WriteLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name,
             "Exiting the function");

        return p;
    }

}



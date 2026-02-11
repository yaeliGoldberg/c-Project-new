/*using DO;
using DalApi;


namespace Dal;
internal class ProductsImplementation : Iproducts
{
    public int Create(Products item)
    {//TODO
        int newid = Config1.run_value_static;
        Products newCustomer = item with { id = newid };
        DataSource.Products.Add(newCustomer);
        return newid;
    }
    public Products? Read(int id)
    {


        Products x = DataSource.Products.FirstOrDefault(c => c.id == id);
        if (x == null)
            throw new DalAlreadyExistException($"coustomer {id}  is not exist");
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
        if (i == -1) throw new DalAlreadyExistException($"coustomer {id}  is not exist");
        DataSource.Products.RemoveAt(i);
    }
}*/

using DO;
using DalApi;
using System.Linq;

namespace Dal;

internal class ProductsImplementation : Iproducts
{
    public int Create(Products item)
    {
        int newid = Config1.run_value_static;
        Products newProduct = item with { id = newid };

        // בדיקה אם כבר קיים מוצר עם אותו ID
        if (DataSource.Products.Any(p => p.id == newid))
            throw new DalAlreadyExistException($"Product with id {newid} already exists");

        DataSource.Products.Add(newProduct);
        return newid;
    }

    public Products Read(int id)
    {
        // שימוש ב-LINQ כדי למצוא מוצר לפי ID
        Products? product = DataSource.Products.FirstOrDefault(p => p.id == id);
        if (product == null)
            throw new DalNotExistException($"Product with id {id} does not exist");

        return product;
    }
    public List<Products> ReadAll(Func<Products, bool>? filter = null)
    {
        return filter == null
            ? DataSource.Products.ToList()
            : DataSource.Products.Where(filter).ToList();
    }
 
    public void Update(Products item)
    {
        // קודם בודקים אם המוצר קיים
        Products? existing = DataSource.Products.FirstOrDefault(p => p.id == item.id);
        if (existing == null)
            throw new DalNotExistException($"Product with id {item.id} does not exist");

        // הסרה והוספה מחדש
        DataSource.Products.Remove(existing);
        DataSource.Products.Add(item);
    }

    public void Delete(int id)
    {
        // מוצאים את המוצר לפי ID
        Products? existing = DataSource.Products.FirstOrDefault(p => p.id == id);
        if (existing == null)
            throw new DalNotExistException($"Product with id {id} does not exist");

        // הסרה מהרשימה
        DataSource.Products.Remove(existing);
    }
    public Products? Read(Func<Products, bool> filter)
    {
        return DataSource.Products.FirstOrDefault(filter);
    }

}



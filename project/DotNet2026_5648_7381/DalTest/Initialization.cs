using DalApi;
using DO;
using Dal;

namespace DalTest;

public static class Initialization
{
  
    private static IDal? s_dal;
  

    // המתודה הציבורית שמופעלת מהשכבה שמעל

    public static void Initialize(IDal dal)
    {
        s_dal = dal;
        CreateSales();

        CreateCustomers();
        CreateProducts();

    }

    // אתחול מוצרים
    private static void CreateProducts()
    {
       
        ProductsImplementation p= new ProductsImplementation();
       p.Create(new Products(11, "Johnson Lenses", Categories.LENSES, 50.5, 2));
        p.Create(new Products(12, "Acuvue Oasys", Categories.LENSES, 79.9, 10));
        p.Create(new Products(13, "Ray-Ban Sunglasses", Categories.SUNGLASSES, 399.0, 5));
        p.Create(new Products(14, "Reading Glasses +1.5", Categories.SWIMMING_GOGGLES, 120.0, 20));
        p.Create(new Products(15, "Lens Cleaning Kit", Categories.SOLITION, 25.0, 50));
    }

    // אתחול לקוחות
    private static void CreateCustomers()
    {
        CoustomerImplementation c = new CoustomerImplementation();

        c.Create(new Customer(1, "Ayala", "Meromei Sade", "123456789"));
        c.Create(new Customer(2, "Jon", "Ktsot", "1357925"));
        c.Create(new Customer(3, "Yehudit", "Shaagat Arie", "431221111"));
        c.Create(new Customer(4, "Tovi", "Mesilat Yosef", "464575678"));
        c.Create(new Customer(5, "Shulamit", "Netivot Hamishpat", "78787878"));
        c.Create(new Customer(6, "Dvory", "Rabi Akiva", "57453243"));
        c.Create(new Customer(7, "Tamar", "Petah Tikva", "235437548"));
        c.Create(new Customer(8, "Bina", "Mesilat Yosef", "45636457"));
        c.Create(new Customer(9, "Shosh", "Rashbi", "7456634"));
        c.Create(new Customer(10, "Tsipora", "Meromei Sade", "6547568"));
        c.Create(new Customer(11, "Yael", "Chazon David", "42556578"));
        c.Create(new Customer(12, "Pnini", "Yatkovski 7", "6435342"));
        c.Create(new Customer(13, "David", "Mesilat", "3534645"));
        c.Create(new Customer(14, "Leah", "Meromei Sade", "657658"));
        c.Create(new Customer(15, "Reuven", "Rashbi", "74543"));
        c.Create(new Customer(16, "Dasi", "Avney Nezer", "534465768"));
    }

    // אתחול מבצעים
    private static void CreateSales()
    {
        SaleImplementation s = new SaleImplementation();
        s.Create(new Sale(
            1, 1, 12, 43.8, true,
            new DateTime(2025, 12, 31),
            new DateTime(2026, 12, 31)));

        s.Create(new Sale(
            2, 2, 12, 44, false,
            new DateTime(2026, 1, 1),
            new DateTime(2026, 1, 31)));

        s.Create(new Sale(
            3, 3, 2, 2, true,
            new DateTime(2015, 12, 31),
            new DateTime(2016, 12, 31)));

        s.Create(new Sale(
            4, 4, 1, 98.8, true,
            new DateTime(2015, 12, 31),
            new DateTime(2016, 12, 31)));

        s.Create(new Sale(
            5, 5, 3, 123, true,
            new DateTime(2015, 12, 31),
            new DateTime(2026, 12, 31)));
    }
}


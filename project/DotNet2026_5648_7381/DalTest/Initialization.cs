using DalApi;
using DO;

namespace DalTest;

public static class Initialization
{
    // שדות גישה לממשקים (כפי שנדרש במשימה)
    private static Iproducts? s_dalProducts = null;
    private static Icoustomer? s_dalCustomers = null;
    private static Isale? s_dalSales = null;

    // המתודה הציבורית שמופעלת מהשכבה שמעל
    public static void Initialize(
        Iproducts products,
        Icoustomer customers,
        Isale sales)
    {
        s_dalProducts = products;
        s_dalCustomers = customers;
        s_dalSales = sales;

        CreateProducts();
        CreateCustomers();
        CreateSales();
    }

    // אתחול מוצרים
    private static void CreateProducts()
    {
        s_dalProducts!.Create(new Products(11, "Johnson Lenses", Categories.LENSES, 50.5, 2));
        s_dalProducts.Create(new Products(12, "Acuvue Oasys", Categories.LENSES, 79.9, 10));
        s_dalProducts.Create(new Products(13, "Ray-Ban Sunglasses", Categories.SUNGLASSES, 399.0, 5));
        s_dalProducts.Create(new Products(14, "Reading Glasses +1.5", Categories.SWIMMING_GOGGLES, 120.0, 20));
        s_dalProducts.Create(new Products(15, "Lens Cleaning Kit", Categories.SOLITION, 25.0, 50));
    }

    // אתחול לקוחות
    private static void CreateCustomers()
    {
        s_dalCustomers!.Create(new Coustomer(1, "Ayala", "Meromei Sade", "123456789"));
        s_dalCustomers.Create(new Coustomer(2, "Jon", "Ktsot", "1357925"));
        s_dalCustomers.Create(new Coustomer(3, "Yehudit", "Shaagat Arie", "431221111"));
        s_dalCustomers.Create(new Coustomer(4, "Tovi", "Mesilat Yosef", "464575678"));
        s_dalCustomers.Create(new Coustomer(5, "Shulamit", "Netivot Hamishpat", "78787878"));
        s_dalCustomers.Create(new Coustomer(6, "Dvory", "Rabi Akiva", "57453243"));
        s_dalCustomers.Create(new Coustomer(7, "Tamar", "Petah Tikva", "235437548"));
        s_dalCustomers.Create(new Coustomer(8, "Bina", "Mesilat Yosef", "45636457"));
        s_dalCustomers.Create(new Coustomer(9, "Shosh", "Rashbi", "7456634"));
        s_dalCustomers.Create(new Coustomer(10, "Tsipora", "Meromei Sade", "6547568"));
        s_dalCustomers.Create(new Coustomer(11, "Yael", "Chazon David", "42556578"));
        s_dalCustomers.Create(new Coustomer(12, "Pnini", "Yatkovski 7", "6435342"));
        s_dalCustomers.Create(new Coustomer(13, "David", "Mesilat", "3534645"));
        s_dalCustomers.Create(new Coustomer(14, "Leah", "Meromei Sade", "657658"));
        s_dalCustomers.Create(new Coustomer(15, "Reuven", "Rashbi", "74543"));
        s_dalCustomers.Create(new Coustomer(16, "Dasi", "Avney Nezer", "534465768"));
    }

    // אתחול מבצעים
    private static void CreateSales()
    {
        s_dalSales!.Create(new Sale(
            1, 1, 12, 43.8, true,
            new DateTime(2025, 12, 31),
            new DateTime(2026, 12, 31)));

        s_dalSales.Create(new Sale(
            2, 2, 12, 44, false,
            new DateTime(2026, 1, 1),
            new DateTime(2026, 1, 31)));

        s_dalSales.Create(new Sale(
            3, 3, 2, 2, true,
            new DateTime(2015, 12, 31),
            new DateTime(2016, 12, 31)));

        s_dalSales.Create(new Sale(
            4, 4, 1, 98.8, true,
            new DateTime(2015, 12, 31),
            new DateTime(2016, 12, 31)));

        s_dalSales.Create(new Sale(
            5, 5, 3, 123, true,
            new DateTime(2015, 12, 31),
            new DateTime(2026, 12, 31)));
    }
}


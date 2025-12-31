using DalApi;
using DO;
using Dal;

namespace DalTest;

public static class Initialization
{
    public static void Initialize()
    {
        CreateProducts();
        CreateCustomers();
        CreateSales();
    }

    private static void CreateProducts()
    {
        ProductsImplementation pi = new ProductsImplementation();

        pi.Create(new Products(11, "Johnson Lenses", Categories.LENSES, 50.5, 2));
        pi.Create(new Products(12, "Acuvue Oasys", Categories.LENSES, 79.9, 10));
        pi.Create(new Products(13, "Ray-Ban Sunglasses", Categories.SUNGLASSES, 399.0, 5));
        pi.Create(new Products(14, "Reading Glasses +1.5", Categories.SWIMMING_GOGGLES, 120.0, 20));
        pi.Create(new Products(15, "Lens Cleaning Kit", Categories.SOLITION, 25.0, 50));
    }

    private static void CreateCustomers()
    {
        CoustomerImplementation ci = new CoustomerImplementation();

        ci.Create(new Coustomer(1, "Ayala", "Meromei Sade", "123456789"));
        ci.Create(new Coustomer(2, "Jon", "Ktsot", "1357925"));
        ci.Create(new Coustomer(3, "Yehudit", "Shaagat Arie", "431221111"));
        ci.Create(new Coustomer(4, "Tovi", "Mesilat Yosef", "464575678"));
        ci.Create(new Coustomer(5, "Shulamit", "Netivot Hamishpat", "78787878"));
        ci.Create(new Coustomer(6, "Dvory", "Rabi Akiva", "57453243"));
        ci.Create(new Coustomer(7, "Tamar", "Petah Tikva", "235437548"));
        ci.Create(new Coustomer(8, "Bina", "Mesilat Yosef", "45636457"));
        ci.Create(new Coustomer(9, "Shosh", "Rashbi", "7456634"));
        ci.Create(new Coustomer(10, "Tsipora", "Meromei Sade", "6547568"));
        ci.Create(new Coustomer(11, "Yael", "Chazon David", "42556578"));
        ci.Create(new Coustomer(12, "Pnini", "Yatkovski 7", "6435342"));
        ci.Create(new Coustomer(13, "David", "Mesilat", "3534645"));
        ci.Create(new Coustomer(14, "Leah", "Meromei Sade", "657658"));
        ci.Create(new Coustomer(15, "Reuven", "Rashbi", "74543"));
        ci.Create(new Coustomer(16, "Dasi", "Avney Nezer", "534465768"));
    }

    private static void CreateSales()
    {
        SaleImplementation si = new SaleImplementation();

        si.Create(new Sale(1, 1, 12, 43.8, true,
            new DateTime(2025, 12, 31),
            new DateTime(2026, 12, 31)));

        si.Create(new Sale(2, 2, 12, 44, false,
            new DateTime(2026, 1, 1),
            new DateTime(2026, 1, 31)));

        si.Create(new Sale(3, 3, 2, 2, true,
            new DateTime(2015, 12, 31),
            new DateTime(2016, 12, 31)));

        si.Create(new Sale(4, 4, 1, 98.8, true,
            new DateTime(2015, 12, 31),
            new DateTime(2016, 12, 31)));

        si.Create(new Sale(5, 5, 3, 123, true,
            new DateTime(2015, 12, 31),
            new DateTime(2026, 12, 31)));
    }
}



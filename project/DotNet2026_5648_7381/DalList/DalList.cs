using DalApi;

namespace Dal;

internal sealed class DalList : IDal
{
    // 4 - מופע פרטי יחיד של המחלקה
    private static readonly DalList instance = new DalList();

    // 3 - בנאי פרטי
    private DalList() { }

    // 5 - תכונה ציבורית סטטית שמחזירה את המופע היחיד
    public static DalList Instance
    {
        get { return instance; }
    }

    public Icoustomer Customer => new CoustomerImplementation();
    public Iproducts Products => new ProductsImplementation();
    public Isale Sale => new SaleImplementation();
}
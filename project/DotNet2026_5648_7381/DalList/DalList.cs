using DalApi;

namespace Dal;
public class DalList : IDal
{
    public Icoustomer Customer => new CoustomerImplementation();
    public Iproducts Products => new ProductsImplementation();

    public Isale Sale => new SaleImplementation();


}

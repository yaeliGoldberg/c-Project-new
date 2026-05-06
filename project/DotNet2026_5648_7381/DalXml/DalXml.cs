using DalApi;

namespace Dal;

sealed internal class DalXml : IDal
{
    public Icoustomer Customer { get; } = new ImplementationCustomer();

    public Iproducts Products { get; } = new ImplementationProduct();

    public Isale Sale { get; } = new ImplementationSale();

    private static readonly DalXml instance = new DalXml();

    public static DalXml Instance => instance;
    private DalXml() { }
}

using BlApi;
namespace BlImplementation;

internal class BL:BlApi.IBL
{
    public IOrder Order => new OrderImplementation();
    public Iproduct Product => new ProductImplementation();
    public Icoustomer Customer => new CustomerImplementation();

   public Isale Sale => new SaleImplementation();

    
}

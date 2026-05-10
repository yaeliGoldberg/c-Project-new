namespace BlApi;

public interface IBL
{
    IOrder Order { get; }
    Iproduct Product { get; }
    Icoustomer Customer { get; }
    Isale Sale { get; }
}

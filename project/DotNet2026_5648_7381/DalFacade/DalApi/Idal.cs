namespace DalApi;

public interface IDal
{
    Icoustomer Customer { get; }
    Iproducts Products { get; }
    Isale Sale { get; }
}

namespace DO;

public record  Products
(
    int id,
    string name,
    Categories c,
    double price,
    int amount
)
{
    public Products(): this(0,"",Categories.EYEGLASSES_LENSES,1.1,1)
    {

    }
}

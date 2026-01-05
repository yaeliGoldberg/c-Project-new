namespace DO;

public record Customer
(   int id,
    string name,
    string adress,
    string phon

)
{
    public Customer() : this(0, "", "", "")
    {

    }
}

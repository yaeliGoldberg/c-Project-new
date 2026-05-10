using BO;

namespace BlApi;

public interface Icoustomer: ICrud<Customer>
{
   bool IsExistCustomer(Customer customer);

}

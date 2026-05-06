using BO;
namespace BlApi;

public interface Iproduct: ICrud<Product>
{
    void GetAllRelevantSalesForProduct(ProductInOrder product, bool isFavorite);
}

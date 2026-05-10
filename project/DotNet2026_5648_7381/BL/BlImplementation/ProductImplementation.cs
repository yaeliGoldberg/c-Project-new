using BO;
using DalApi;
using System.Linq;

namespace BlImplementation;

internal class ProductImplementation : BlApi.Iproduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Product product)
    {
        try
        {
            DO.Products doProduct = BO.Tools.ToDO(product);
            return _dal.Products.Create(doProduct);
        }
        catch (DO.DalAlreadyExistException ex)
        {
            throw new BO.BlAlreadyExistException("Product already exists", ex);
        }
    }

    public List<BO.Product> ReadAll(Func<BO.Product, bool> filter)
    {
        try
        {
            var products = _dal.Products.ReadAll(x => true);
            var boProducts = from product in products
                             let bs = BO.Tools.ToBO(product)
                             where filter(bs)
                             select bs;
            return boProducts.ToList();

        }
        catch (DO.DalException ex)
        {
            throw new BO.BlException("Error reading products", ex);
        }
    }
    public BO.Product Read(Func<BO.Product, bool> filter)
    {
        try
        {
            var product = _dal.Products.ReadAll(x => true).Select(s => BO.Tools.ToBO(s)).FirstOrDefault(filter);
            return product;
        }
        catch (DO.DalNotExistException ex)
        {
            throw new BO.BlNotExistException("Error reading products", ex);
        }
    }
    public void Update(BO.Product item)
    {
        try
        {
            var product = BO.Tools.ToDO(item);
            _dal.Products.Update(product);
        }
        catch (DO.DalNotExistException ex)
        {
            throw new BO.BlNotExistException("Error updating products", ex);
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Products.Delete(id);
        }
        catch (DO.DalNotExistException ex)
        {
            throw new BO.BlNotExistException("Error deleting products", ex);
        }
    }

    public void GetAllRelevantSalesForProduct(BO.ProductInOrder product, bool isFavorite)
    {
        try
        {
            var sales = _dal.Sale.ReadAll(s => s.id == product.ProductId)
            .Where(s => s.start_sale <= DateTime.Now && s.end_sale >= DateTime.Now);
            if (!isFavorite)
            {
                sales = sales.Where(s => s.for_who == false);
            }
            var result = sales.Select(s => new BO.SaleInProduct
            {
                SaleId = s.id,
                AmountForSale = s.min_amount,
                Price = s.min_price,
                IsOnlyClub = s.for_who
            });

            product.ListSaleInProduct = result.ToList();
        }
        catch (DO.DalException ex)
        {
            throw new BO.BlException("Error in products", ex);
        }

    }
}

using BO;

namespace BlImplementation
{
    internal class OrderImplementation:BlApi.IOrder   
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int quantity)
        {
            BO.ProductInOrder p = new ProductInOrder();
            bool flag = false;
            foreach (var pr in order.ProductsInOrder)
            {
                if (pr.ProductId == id)
                {
                    flag = true;
                    p = pr;
                    DO.Products doProduct = _dal.Products.Read(x => x.id == id);
                    if (doProduct.amount < quantity + p.AmountInOrder)
                        throw new BO.BlNotEnoughInStackException($"There are only {doProduct.amount} items from product {id}.");
                    else
                        p.AmountInOrder += quantity;
                }
            }
            if (!flag)
            {
                DO.Products doProduct = _dal.Products.Read(x => x.id == id);
                if (doProduct.amount < quantity)
                    throw new BO.BlNotEnoughInStackException($"There are only {doProduct.QuantityInStack} items from product {id}.");
                else
                {
                    p = new ProductInOrder() { ProductId = id, ProductName = doProduct.Name, BasePrice = doProduct.Price, ListSaleInProduct = new List<SaleInProduct>(), AmountInOrder = quantity };

                }
            }
            SearchSaleForProduct(p, order.IsClub);
            CalcTotalPriceForProduct(p);
            order.ProductsInOrder.Add(p);
            CalcTotalPrice(order);
            return p.ListSaleInProduct;
        }
        
        public void CalcTotalPrice(BO.Order order)
        {
            order.FinalPrice = 0;
            foreach (var p in order.ProductsInOrder)
            {
                order.FinalPrice += p.TotalPrice;
            }
        }

        public void CalcTotalPriceForProduct(BO.ProductInOrder product)
        {
            double total = 0;
            List<SaleInProduct> usedSales = new List<SaleInProduct>();
            int count = product.AmountInOrder;
            foreach (var sale in product.ListSaleInProduct)
            {
                if (count < sale.AmountForSale)
                    continue;
                int times = (int)Math.Floor(count / (double)sale.AmountForSale);
                total += (times * sale.Price);
                count -= times * sale.AmountForSale;
                usedSales.Add(sale);
                if (count == 0)
                    break;

            }
            total += (count * product.BasePrice);
            product.TotalPrice = total;
            product.ListSaleInProduct = usedSales.ToList();
        }

        public void DoOrder(BO.Order order)
        {
            foreach (var p in order.ProductsInOrder)
            {
                DO.Products doproduct = _dal.Products.Read(x => x.id == p.ProductId);
                int amount = doproduct.amount;
                DO.Products updatedProd = doproduct with { amount = amount - p.AmountInOrder };
                _dal.Products.Update(updatedProd);
            }
        }
        public void SearchSaleForProduct(BO.ProductInOrder product, bool isFavorite)
        {
            try
            {
                var sales = _dal.Sale.ReadAll(s => s.id == product.ProductId)
                .Where(s => s.start_sale <= DateTime.Now && s.end_sale >= DateTime.Now && product.AmountInOrder >= s.QuantityRequired);
                if (!isFavorite)
                {
                    sales = sales.Where(s => s?.IsOnlyClub == false);
                }
                sales=sales.OrderBy(s => s.TotalPrice / s.QuantityRequired);
                var result = sales.Select(s => new BO.SaleInProduct
                {
                    SaleId = s.Id,
                    AmountForSale = s.QuantityRequired,
                    Price = s.TotalPrice,
                    IsOnlyClub = s.IsOnlyClub
                });

                product.ListSaleInProduct = result.ToList();
            }
            catch (DO.DalException ex)
            {
                throw new BO.BlException("Error reading products", ex);
            }
        }

    }
}

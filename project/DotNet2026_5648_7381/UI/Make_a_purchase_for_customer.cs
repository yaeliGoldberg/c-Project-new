using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;

namespace UI
{
    public partial class Make_a_purchase_for_customer : Form
    {
        private IBL _bl = Factory.Get;

        private List<BO.ProductInOrder> _productsInOrder =
    new List<BO.ProductInOrder>();

        private bool isClub = false;

        public Make_a_purchase_for_customer()
        {
            InitializeComponent();
            ProductsTable.DataSource =
       _bl.Product.ReadAll(x => true);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            int amount = int.Parse(txtAmount.Text);

            if (amount <= 0)
            {
                MessageBox.Show("Invalid amount");
                return;
            }

            BO.Product product =
                (BO.Product)ProductsTable.CurrentRow.DataBoundItem;

            BO.ProductInOrder p = new BO.ProductInOrder()
            {
                ProductId = product.Id,
                AmountInOrder = amount
            };

            _productsInOrder.Add(p);

            MessageBox.Show("Product added");
        }

        private void btnJoinClub_Click(object sender, EventArgs e)
        {

            isClub = true;

            MessageBox.Show("Customer joined the club");
        }

        private void btnRemoveClub_Click(object sender, EventArgs e)
        {
            isClub = false;

            MessageBox.Show("Customer removed from the club");

        }

        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Order order = new BO.Order()
                {
                    IsClub = isClub,
                    ProductsInOrder = _productsInOrder,
                    FinalPrice = 0
                };

                _bl.Order.DoOrder(order);

                MessageBox.Show("Order completed successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}



/*namespace UI
{
    public partial class Product_Order_Management : Form
    {
        public Product_Order_Management()
        {
            InitializeComponent();
        }

        private void Product_Order_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
*/
using BO;
using BlApi;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Product_Order_Management : Form
    {
        IBL bl = Factory.Get; // אם אצלך זה אחרת תעדכני

        public Product_Order_Management()
        {
            InitializeComponent();
        }

        private void Product_Order_Management_Load(object sender, EventArgs e)
        {
            LoadLowStockProducts();
        }

        private void LoadLowStockProducts()
        {
            var products = bl.Product.ReadAll();

            var lowStock = products
                .Where(p => p != null && p.Amount <= 3)
                .ToList();

            dataGridView1.DataSource = lowStock;

            AddOrderButton();
        }

        private void AddOrderButton()
        {
            if (dataGridView1.Columns["Order"] == null)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "Order";
                btn.HeaderText = "הזמנה";
                btn.Text = "הזמן";
                btn.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btn);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex].Name == "Order")
            {
                var product = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // קריאה ל-BL (דוגמה)
                bl.Product.GetAllRelevantSalesForProduct(
                    new ProductInOrder { Id = product.Id },
                    false
                );

                MessageBox.Show("בוצעה הזמנה למוצר");
            }
        }
    }
}
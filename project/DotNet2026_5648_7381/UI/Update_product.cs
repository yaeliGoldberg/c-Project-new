using BlApi;
using BO;

namespace UI
{
    public partial class Update_product : Form
    {
        BO.Product currentProduct;
        IBL bl = Factory.Get;
        public Update_product(BO.Product product)
        {
            InitializeComponent();
            currentProduct = product;

            categoryComboBox.DataSource = Enum.GetValues(typeof(Categories));

            ID.Text = product.Id.ToString();
            nameTextBox.Text = product.Name;
            Price.Text = product.Price.ToString();
            Amount.Text = product.Amount.ToString();

            categoryComboBox.SelectedItem = product.Category;
        }

        private void Update_product_Load(object sender, EventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {

            BO.Product product = new BO.Product()
            {
                Id = int.Parse(ID.Text),
                Name = nameTextBox.Text,
                Category = (Categories)categoryComboBox.SelectedItem,
                Price = double.Parse(Price.Text),
                Amount = int.Parse(Amount.Text)
            };

            bl.Product.Update(product);
        }

        private void Update_product_Load(object sender, EventArgs e)
        {

        }
    }
}

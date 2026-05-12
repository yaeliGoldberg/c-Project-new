using BlApi;


namespace UI
{
    public partial class Product_Management : Form
    {
        IBL bl = Factory.Get;
        public Product_Management()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Name";
        }

        private void Product_List_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var products = bl.Product.ReadAll(p => true);

            foreach (var p in products)
            {
                listBox1.Items.Add(p);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_a_product_Click(object sender, EventArgs e)
        {
            Adding_a_new_product Product = new Adding_a_new_product();
            Product.ShowDialog();
            this.Close();
        }

        private void Update_product_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("יש לבחור מוצר מהרשימה כדי לעדכן אותו");
                return;
            }

            BO.Product product = listBox1.SelectedItem as BO.Product;

            Update_product update = new Update_product(product);
            update.Show();
        }
    }
}

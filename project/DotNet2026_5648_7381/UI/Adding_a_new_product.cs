using BO;
namespace UI;

public partial class Adding_a_new_product : Form
{

    BlApi.IBL bl = BlApi.Factory.Get;
    public Adding_a_new_product()
    {

        InitializeComponent();
        categoryComboBox.DataSource = Enum.GetValues(typeof(Categories));

        categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
        bl.Product.Create(product);
    }
}

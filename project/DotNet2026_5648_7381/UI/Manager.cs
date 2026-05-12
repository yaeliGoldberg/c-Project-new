

namespace UI;

public partial class Manager : Form
{
    public Manager()
    {
        InitializeComponent();
    }
    //ניהול מוצר
    private void Product_Management_Click(object sender, EventArgs e)
    {
        Product_Management Product = new Product_Management();
        Product.Show();
      
    }
    //ניהול הזמנת מוצר
    private void Product_Order_Management_Click(object sender, EventArgs e)
    {

        Product_Order_Management Product_Order = new Product_Order_Management();
        Product_Order.Show();
        
    }
    //ניהול מבצעים
    private void Promotion_Management_Click(object sender, EventArgs e)
    {
        Promotion_Management manager = new Promotion_Management();
        manager.Show();
        
    }
}

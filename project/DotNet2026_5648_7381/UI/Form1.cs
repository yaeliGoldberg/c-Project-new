namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //����
        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }
        
        //;���� ������
        private void Salesperson_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.ShowDialog();
            this.Close();

        }
    }
}

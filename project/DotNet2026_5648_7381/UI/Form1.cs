namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //מנהל
        private void button1_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }
        
        //;סוכן מכירות
        private void Salesperson_Click(object sender, EventArgs e)
        {
            


        }
    }
}

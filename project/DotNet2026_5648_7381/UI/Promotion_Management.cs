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
namespace UI
{
    public partial class Promotion_Management : Form
    {


        private IBL bl = Factory.Get;
        public Promotion_Management()
        {
            InitializeComponent();
        }

        private void btnLoadSales_Click(object sender, EventArgs e)
        {

            try
            {
                var sales = bl.Sale.ReadAll(x => true);

                dgvSales.DataSource = sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            btnAddSale btnAddSal= new btnAddSale();
            btnAddSal.Show();
           

        }
    }

}

using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class btnAddSale : Form
    {
        private IBL bl = Factory.Get;
        public btnAddSale()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                BO.Sale sale = new BO.Sale()
                {
                    id_product = int.Parse(id_product.Text),

                    min_amount = int.Parse(txtMinAmount.Text),

                    min_price = double.Parse(txtMinPrice.Text),

                    for_who = chkForWho.Checked,

                    start_sale = dtpStartSale.Value,

                    end_sale = dtpEndSale.Value
                };

                bl.Sale.Create(sale);

                MessageBox.Show("המבצע נוסף בהצלחה");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}

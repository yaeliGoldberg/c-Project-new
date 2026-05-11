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
using System.Xml.Linq;
using BlApi;
using BO;

namespace UI
{
    public partial class Updating_existing_customer : Form
    {

        private IBL _bl = Factory.Get;
        public Updating_existing_customer()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer customer = new BO.Customer()
                {
                    Id = int.Parse(Id.Text),
                    Name = Nametxt.Text,
                    Phon = Phone.Text,
                    Adress = Address.Text
                };

                _bl.Customer.Update(customer);

                MessageBox.Show("Customer updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

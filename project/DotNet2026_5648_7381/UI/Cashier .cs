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
using BO;


namespace UI
{
    public partial class Cashier : Form
    {


        public Cashier()
        {
            InitializeComponent();
        }

        private void View_the_catalog_Click(object sender, EventArgs e)
        {
            View_the_catalog view_the_catalog = new View_the_catalog();
            view_the_catalog.Show();
            //this.Hide();
        }

        private void Updating_existing_customer_details_Click(object sender, EventArgs e)
        {
            Updating_existing_customer updating_existing_customer = new Updating_existing_customer();
            updating_existing_customer.Show();
            //this.Hide();
        }

        private void Make_a_purchase_for_customer__Click(object sender, EventArgs e)
        {
            Make_a_purchase_for_customer make_a_purchase_for_customer= new Make_a_purchase_for_customer();
            make_a_purchase_for_customer.Show();
           // this.Hide();
        }
    }
}

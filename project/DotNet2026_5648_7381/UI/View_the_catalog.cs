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
    public partial class View_the_catalog : Form
    {
        private IBL _bl = BlApi.Factory.Get;
        public View_the_catalog()
        {
            InitializeComponent();
            Product_table.DataSource = _bl.Product.ReadAll(x => true);
        }

        private void Product_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

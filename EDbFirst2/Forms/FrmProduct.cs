using EDbFirst2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDbFirst2.Forms
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadSuppliers1();
        }
        void LoadSuppliers1()
        {
            NorthwndContext db = new NorthwndContext();
            List<Product> products = db.Products.ToList();
            dtGridProducts.DataSource = products;

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            decimal minPrice = Convert.ToDecimal(txtMin.Text);
            decimal maxPrice = Convert.ToDecimal(txtMax.Text);
            NorthwndContext db = new NorthwndContext();
            List<Product> products = db.Products.Where(x => x.UnitPrice >= minPrice && x.UnitPrice <= maxPrice).ToList();
            dtGridProducts.DataSource = products;
        }

        
    }
}

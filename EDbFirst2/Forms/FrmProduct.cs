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

   

        private void dtGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtGridProducts.CurrentRow.Cells[0].Value);


            NorthwndContext db = new NorthwndContext();
            Product product = db.Products.FirstOrDefault(x => x.ProductId == id);
            if (product != null)
            {
                txtProductName.Text = product.ProductName;
                txtProductUnitPrice.Text = product.UnitPrice.ToString();
                txtProductStock.Text = product.UnitsInStock.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(dtGridProducts.CurrentRow.Cells[0].Value);

            NorthwndContext db = new NorthwndContext();
            Product product = db.Products.FirstOrDefault(x => x.ProductId == id);
            product.ProductName = txtProductName.Text;
            product.UnitPrice = Convert.ToDecimal(txtProductUnitPrice.Text);
            product.UnitsInStock = Convert.ToSByte(txtProductStock.Text);


            if (product.UnitsInStock<0 || product.UnitsInStock>100) 
            {
              
                MessageBox.Show("Lütfen 0 ila 100 arasında stok miktarı giriniz");
            }
            db.SaveChanges();
            LoadSuppliers1();
        }
    }
}

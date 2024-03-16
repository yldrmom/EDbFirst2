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
    public partial class FrmAddProductt : Form
    {
        public FrmAddProductt()
        {
            InitializeComponent();
        }

      

        private void FrmAddProductt_Load(object sender, EventArgs e)
        {
            NorthwndContext db = new NorthwndContext();
            List<Category> categories = db.Categories.ToList();
            cmbCategories.DataSource = categories;

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NorthwndContext db = new NorthwndContext();
            Product product = new Product();
            product.ProductName = txtName.Text;
            product.UnitPrice=Convert.ToDecimal(txtUnitPrice.Text);
            product.UnitsInStock = Convert.ToInt16(txtStock.Text);
            product.CategoryId=(int)cmbCategories.SelectedValue;

            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("ÜRÜN BAŞARIYLA EKLENDİ");
        }
    }
}

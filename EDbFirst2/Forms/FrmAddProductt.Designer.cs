namespace EDbFirst2.Forms
{
    partial class FrmAddProductt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            txtUnitPrice = new TextBox();
            txtStock = new TextBox();
            txtName = new TextBox();
            cmbCategories = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            lblName = new Label();
            lblCategories = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(220, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(110, 195);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(204, 27);
            txtUnitPrice.TabIndex = 16;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(110, 154);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(204, 27);
            txtStock.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 14;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(110, 41);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(204, 28);
            cmbCategories.TabIndex = 13;
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 198);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "Unit Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 11;
            label3.Text = "Stock";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 115);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 10;
            lblName.Text = "Name";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(24, 44);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(80, 20);
            lblCategories.TabIndex = 9;
            lblCategories.Text = "Categories";
            // 
            // FrmAddProductt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtStock);
            Controls.Add(txtName);
            Controls.Add(cmbCategories);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblName);
            Controls.Add(lblCategories);
            Name = "FrmAddProductt";
            Text = "FrmAddProductt";
            Load += FrmAddProductt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtUnitPrice;
        private TextBox txtStock;
        private TextBox txtName;
        private ComboBox cmbCategories;
        private Label label4;
        private Label label3;
        private Label lblName;
        private Label lblCategories;
    }
}
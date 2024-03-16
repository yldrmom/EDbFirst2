namespace EDbFirst2.Forms
{
    partial class FrmProduct
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
            dtGridProducts = new DataGridView();
            lblMin = new Label();
            lblMax = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            btnFilter = new Button();
            lblName = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            txtProductUnitPrice = new TextBox();
            txtProductStock = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridProducts).BeginInit();
            SuspendLayout();
            // 
            // dtGridProducts
            // 
            dtGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridProducts.Location = new Point(12, 111);
            dtGridProducts.Name = "dtGridProducts";
            dtGridProducts.RowHeadersWidth = 51;
            dtGridProducts.Size = new Size(653, 438);
            dtGridProducts.TabIndex = 0;
            dtGridProducts.CellClick += dtGridProducts_CellClick;
           
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(60, 42);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(37, 20);
            lblMin.TabIndex = 1;
            lblMin.Text = "Min:";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(245, 46);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(40, 20);
            lblMax.TabIndex = 2;
            lblMax.Text = "Max:";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(103, 41);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(125, 27);
            txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(282, 43);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(125, 27);
            txtMax.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(437, 41);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(734, 232);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(734, 284);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Unit Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(734, 334);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Stock:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(814, 232);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 9;
            // 
            // txtProductUnitPrice
            // 
            txtProductUnitPrice.Location = new Point(815, 284);
            txtProductUnitPrice.Name = "txtProductUnitPrice";
            txtProductUnitPrice.Size = new Size(125, 27);
            txtProductUnitPrice.TabIndex = 10;
            // 
            // txtProductStock
            // 
            txtProductStock.Location = new Point(815, 334);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new Size(125, 27);
            txtProductStock.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(846, 397);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 561);
            Controls.Add(btnUpdate);
            Controls.Add(txtProductStock);
            Controls.Add(txtProductUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(btnFilter);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(dtGridProducts);
            Name = "FrmProduct";
            Text = "FrmProduct";
            Load += FrmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridProducts;
        private Label lblMin;
        private Label lblMax;
        private TextBox txtMin;
        private TextBox txtMax;
        private Button btnFilter;
        private Label lblName;
        private Label label2;
        private Label label3;
        private TextBox txtProductName;
        private TextBox txtProductUnitPrice;
        private TextBox txtProductStock;
        private Button btnUpdate;
    }
}
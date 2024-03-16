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
            ((System.ComponentModel.ISupportInitialize)dtGridProducts).BeginInit();
            SuspendLayout();
            // 
            // dtGridProducts
            // 
            dtGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridProducts.Location = new Point(12, 111);
            dtGridProducts.Name = "dtGridProducts";
            dtGridProducts.RowHeadersWidth = 51;
            dtGridProducts.Size = new Size(1071, 438);
            dtGridProducts.TabIndex = 0;
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
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 561);
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
    }
}
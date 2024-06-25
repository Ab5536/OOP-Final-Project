
namespace Business_Project_GUI
{
    partial class viewPurchasedProducts
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
            this.prchsedprdctGrid = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prchsedprdctGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // prchsedprdctGrid
            // 
            this.prchsedprdctGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prchsedprdctGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductCategory,
            this.PriceTop,
            this.Number});
            this.prchsedprdctGrid.Location = new System.Drawing.Point(169, 59);
            this.prchsedprdctGrid.Name = "prchsedprdctGrid";
            this.prchsedprdctGrid.RowHeadersWidth = 51;
            this.prchsedprdctGrid.RowTemplate.Height = 24;
            this.prchsedprdctGrid.Size = new System.Drawing.Size(1119, 408);
            this.prchsedprdctGrid.TabIndex = 1;
            this.prchsedprdctGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prchsedprdctGrid_CellContentClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductName.Width = 125;
            // 
            // ProductCategory
            // 
            this.ProductCategory.HeaderText = "Product Category";
            this.ProductCategory.MinimumWidth = 6;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductCategory.Width = 125;
            // 
            // PriceTop
            // 
            this.PriceTop.HeaderText = "Price";
            this.PriceTop.MinimumWidth = 6;
            this.PriceTop.Name = "PriceTop";
            this.PriceTop.ReadOnly = true;
            this.PriceTop.Width = 125;
            // 
            // Number
            // 
            this.Number.HeaderText = "Purchased Items";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(666, 518);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 4;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // viewPurchasedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 812);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.prchsedprdctGrid);
            this.Name = "viewPurchasedProducts";
            this.Text = "View_Purchased_Products";
            this.Load += new System.EventHandler(this.viewPurchasedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prchsedprdctGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prchsedprdctGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.Button backBTN;
    }
}
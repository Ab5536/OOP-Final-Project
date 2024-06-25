
namespace Business_Project_GUI
{
    partial class Carted_Form
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
            this.prdctGrid = new System.Windows.Forms.DataGridView();
            this.stock_GRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_GRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pr_ID_grd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTXT = new System.Windows.Forms.TextBox();
            this.categoryLBL = new System.Windows.Forms.Label();
            this.prHeadLBL = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.buy_OrderBTN = new System.Windows.Forms.Button();
            this.pr_IDTXT = new System.Windows.Forms.TextBox();
            this.stckTXT = new System.Windows.Forms.TextBox();
            this.pr_NmTXT = new System.Windows.Forms.TextBox();
            this.pr_ID_LBL = new System.Windows.Forms.Label();
            this.StckLBL = new System.Windows.Forms.Label();
            this.pr_nameLBL = new System.Windows.Forms.Label();
            this.cartBTN = new System.Windows.Forms.Button();
            this.slctBTN = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SrchBTN = new System.Windows.Forms.Button();
            this.srchTXT = new System.Windows.Forms.TextBox();
            this.SrchLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prdctGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // prdctGrid
            // 
            this.prdctGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prdctGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_Name,
            this.Pr_ID_grd,
            this.category_GRD,
            this.pr_Price,
            this.stock_GRD,
            this.slctBTN});
            this.prdctGrid.Location = new System.Drawing.Point(300, 81);
            this.prdctGrid.Name = "prdctGrid";
            this.prdctGrid.RowHeadersWidth = 51;
            this.prdctGrid.RowTemplate.Height = 24;
            this.prdctGrid.Size = new System.Drawing.Size(898, 225);
            this.prdctGrid.TabIndex = 1;
            this.prdctGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prdctGrid_CellContentClick_1);
            // 
            // stock_GRD
            // 
            this.stock_GRD.HeaderText = "Stock";
            this.stock_GRD.MinimumWidth = 6;
            this.stock_GRD.Name = "stock_GRD";
            this.stock_GRD.ReadOnly = true;
            this.stock_GRD.Width = 125;
            // 
            // pr_Price
            // 
            this.pr_Price.HeaderText = "Product Price";
            this.pr_Price.MinimumWidth = 6;
            this.pr_Price.Name = "pr_Price";
            this.pr_Price.ReadOnly = true;
            this.pr_Price.Width = 125;
            // 
            // category_GRD
            // 
            this.category_GRD.HeaderText = "Category";
            this.category_GRD.MinimumWidth = 6;
            this.category_GRD.Name = "category_GRD";
            this.category_GRD.ReadOnly = true;
            this.category_GRD.Width = 125;
            // 
            // Pr_ID_grd
            // 
            this.Pr_ID_grd.HeaderText = "Product ID";
            this.Pr_ID_grd.MinimumWidth = 6;
            this.Pr_ID_grd.Name = "Pr_ID_grd";
            this.Pr_ID_grd.ReadOnly = true;
            this.Pr_ID_grd.Width = 125;
            // 
            // pr_Name
            // 
            this.pr_Name.HeaderText = "Product Name";
            this.pr_Name.MinimumWidth = 6;
            this.pr_Name.Name = "pr_Name";
            this.pr_Name.ReadOnly = true;
            this.pr_Name.Width = 125;
            // 
            // categoryTXT
            // 
            this.categoryTXT.Location = new System.Drawing.Point(164, 284);
            this.categoryTXT.Name = "categoryTXT";
            this.categoryTXT.Size = new System.Drawing.Size(100, 22);
            this.categoryTXT.TabIndex = 27;
            // 
            // categoryLBL
            // 
            this.categoryLBL.AutoSize = true;
            this.categoryLBL.Location = new System.Drawing.Point(32, 284);
            this.categoryLBL.Name = "categoryLBL";
            this.categoryLBL.Size = new System.Drawing.Size(73, 17);
            this.categoryLBL.TabIndex = 26;
            this.categoryLBL.Text = "Category: ";
            // 
            // prHeadLBL
            // 
            this.prHeadLBL.AutoSize = true;
            this.prHeadLBL.Location = new System.Drawing.Point(114, 57);
            this.prHeadLBL.Name = "prHeadLBL";
            this.prHeadLBL.Size = new System.Drawing.Size(84, 17);
            this.prHeadLBL.TabIndex = 25;
            this.prHeadLBL.Text = "Product Info";
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(35, 349);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 24;
            this.backBTN.Text = "Back: ";
            this.backBTN.UseVisualStyleBackColor = true;
            // 
            // buy_OrderBTN
            // 
            this.buy_OrderBTN.Location = new System.Drawing.Point(189, 349);
            this.buy_OrderBTN.Name = "buy_OrderBTN";
            this.buy_OrderBTN.Size = new System.Drawing.Size(75, 23);
            this.buy_OrderBTN.TabIndex = 23;
            this.buy_OrderBTN.Text = "Buy";
            this.buy_OrderBTN.UseVisualStyleBackColor = true;
            this.buy_OrderBTN.Click += new System.EventHandler(this.buy_OrderBTN_Click);
            // 
            // pr_IDTXT
            // 
            this.pr_IDTXT.Location = new System.Drawing.Point(164, 187);
            this.pr_IDTXT.Name = "pr_IDTXT";
            this.pr_IDTXT.Size = new System.Drawing.Size(100, 22);
            this.pr_IDTXT.TabIndex = 22;
            // 
            // stckTXT
            // 
            this.stckTXT.Location = new System.Drawing.Point(164, 234);
            this.stckTXT.Name = "stckTXT";
            this.stckTXT.Size = new System.Drawing.Size(100, 22);
            this.stckTXT.TabIndex = 21;
            // 
            // pr_NmTXT
            // 
            this.pr_NmTXT.Location = new System.Drawing.Point(164, 137);
            this.pr_NmTXT.Name = "pr_NmTXT";
            this.pr_NmTXT.Size = new System.Drawing.Size(100, 22);
            this.pr_NmTXT.TabIndex = 20;
            this.pr_NmTXT.TextChanged += new System.EventHandler(this.pr_NmTXT_TextChanged);
            // 
            // pr_ID_LBL
            // 
            this.pr_ID_LBL.AutoSize = true;
            this.pr_ID_LBL.Location = new System.Drawing.Point(32, 187);
            this.pr_ID_LBL.Name = "pr_ID_LBL";
            this.pr_ID_LBL.Size = new System.Drawing.Size(82, 17);
            this.pr_ID_LBL.TabIndex = 19;
            this.pr_ID_LBL.Text = "Product ID: ";
            // 
            // StckLBL
            // 
            this.StckLBL.AutoSize = true;
            this.StckLBL.Location = new System.Drawing.Point(32, 234);
            this.StckLBL.Name = "StckLBL";
            this.StckLBL.Size = new System.Drawing.Size(51, 17);
            this.StckLBL.TabIndex = 18;
            this.StckLBL.Text = "Stock: ";
            // 
            // pr_nameLBL
            // 
            this.pr_nameLBL.AutoSize = true;
            this.pr_nameLBL.Location = new System.Drawing.Point(32, 142);
            this.pr_nameLBL.Name = "pr_nameLBL";
            this.pr_nameLBL.Size = new System.Drawing.Size(106, 17);
            this.pr_nameLBL.TabIndex = 17;
            this.pr_nameLBL.Text = "Product Name: ";
            // 
            // cartBTN
            // 
            this.cartBTN.Location = new System.Drawing.Point(362, 341);
            this.cartBTN.Name = "cartBTN";
            this.cartBTN.Size = new System.Drawing.Size(165, 31);
            this.cartBTN.TabIndex = 28;
            this.cartBTN.Text = "Remove from Cart";
            this.cartBTN.UseVisualStyleBackColor = true;
            this.cartBTN.Click += new System.EventHandler(this.cartBTN_Click);
            // 
            // slctBTN
            // 
            this.slctBTN.HeaderText = "Select";
            this.slctBTN.MinimumWidth = 6;
            this.slctBTN.Name = "slctBTN";
            this.slctBTN.Width = 125;
            // 
            // SrchBTN
            // 
            this.SrchBTN.Location = new System.Drawing.Point(888, 25);
            this.SrchBTN.Name = "SrchBTN";
            this.SrchBTN.Size = new System.Drawing.Size(75, 23);
            this.SrchBTN.TabIndex = 31;
            this.SrchBTN.Text = "Search";
            this.SrchBTN.UseVisualStyleBackColor = true;
            // 
            // srchTXT
            // 
            this.srchTXT.Location = new System.Drawing.Point(618, 28);
            this.srchTXT.Name = "srchTXT";
            this.srchTXT.Size = new System.Drawing.Size(100, 22);
            this.srchTXT.TabIndex = 30;
            // 
            // SrchLBL
            // 
            this.SrchLBL.AutoSize = true;
            this.SrchLBL.Location = new System.Drawing.Point(451, 31);
            this.SrchLBL.Name = "SrchLBL";
            this.SrchLBL.Size = new System.Drawing.Size(144, 17);
            this.SrchLBL.TabIndex = 29;
            this.SrchLBL.Text = "Enter Product Name: ";
            // 
            // Carted_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 450);
            this.Controls.Add(this.SrchBTN);
            this.Controls.Add(this.srchTXT);
            this.Controls.Add(this.SrchLBL);
            this.Controls.Add(this.cartBTN);
            this.Controls.Add(this.categoryTXT);
            this.Controls.Add(this.categoryLBL);
            this.Controls.Add(this.prHeadLBL);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.buy_OrderBTN);
            this.Controls.Add(this.pr_IDTXT);
            this.Controls.Add(this.stckTXT);
            this.Controls.Add(this.pr_NmTXT);
            this.Controls.Add(this.pr_ID_LBL);
            this.Controls.Add(this.StckLBL);
            this.Controls.Add(this.pr_nameLBL);
            this.Controls.Add(this.prdctGrid);
            this.Name = "Carted_Form";
            this.Text = "Carted_Form";
            this.Load += new System.EventHandler(this.Carted_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prdctGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prdctGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pr_ID_grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_GRD;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_GRD;
        private System.Windows.Forms.TextBox categoryTXT;
        private System.Windows.Forms.Label categoryLBL;
        private System.Windows.Forms.Label prHeadLBL;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button buy_OrderBTN;
        private System.Windows.Forms.TextBox pr_IDTXT;
        private System.Windows.Forms.TextBox stckTXT;
        private System.Windows.Forms.TextBox pr_NmTXT;
        private System.Windows.Forms.Label pr_ID_LBL;
        private System.Windows.Forms.Label StckLBL;
        private System.Windows.Forms.Label pr_nameLBL;
        private System.Windows.Forms.Button cartBTN;
        private System.Windows.Forms.DataGridViewButtonColumn slctBTN;
        private System.Windows.Forms.Button SrchBTN;
        private System.Windows.Forms.TextBox srchTXT;
        private System.Windows.Forms.Label SrchLBL;
    }
}
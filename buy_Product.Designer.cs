
namespace Business_Project_GUI
{
    partial class buy_Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pr_nameLBL = new System.Windows.Forms.Label();
            this.StckLBL = new System.Windows.Forms.Label();
            this.pr_ID_LBL = new System.Windows.Forms.Label();
            this.SrchLBL = new System.Windows.Forms.Label();
            this.pr_NmTXT = new System.Windows.Forms.TextBox();
            this.srchTXT = new System.Windows.Forms.TextBox();
            this.stckTXT = new System.Windows.Forms.TextBox();
            this.pr_IDTXT = new System.Windows.Forms.TextBox();
            this.buy_OrderBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.SrchBTN = new System.Windows.Forms.Button();
            this.prHeadLBL = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.categoryTXT = new System.Windows.Forms.TextBox();
            this.categoryLBL = new System.Windows.Forms.Label();
            this.cartBTN = new System.Windows.Forms.Button();
            this.pr_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pr_ID_grd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_GRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_GRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slctBTN = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prIDTXT = new System.Windows.Forms.TextBox();
            this.topLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_Name,
            this.Pr_ID_grd,
            this.category_GRD,
            this.pr_Price,
            this.stock_GRD,
            this.slctBTN});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(862, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pr_nameLBL
            // 
            this.pr_nameLBL.AutoSize = true;
            this.pr_nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr_nameLBL.Location = new System.Drawing.Point(469, 141);
            this.pr_nameLBL.Name = "pr_nameLBL";
            this.pr_nameLBL.Size = new System.Drawing.Size(148, 25);
            this.pr_nameLBL.TabIndex = 1;
            this.pr_nameLBL.Text = "Product Name";
            // 
            // StckLBL
            // 
            this.StckLBL.AutoSize = true;
            this.StckLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StckLBL.Location = new System.Drawing.Point(469, 597);
            this.StckLBL.Name = "StckLBL";
            this.StckLBL.Size = new System.Drawing.Size(67, 25);
            this.StckLBL.TabIndex = 3;
            this.StckLBL.Text = "Stock";
            // 
            // pr_ID_LBL
            // 
            this.pr_ID_LBL.AutoSize = true;
            this.pr_ID_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr_ID_LBL.Location = new System.Drawing.Point(469, 287);
            this.pr_ID_LBL.Name = "pr_ID_LBL";
            this.pr_ID_LBL.Size = new System.Drawing.Size(113, 25);
            this.pr_ID_LBL.TabIndex = 4;
            this.pr_ID_LBL.Text = "Product ID";
            // 
            // SrchLBL
            // 
            this.SrchLBL.AutoSize = true;
            this.SrchLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchLBL.Location = new System.Drawing.Point(1136, 54);
            this.SrchLBL.Name = "SrchLBL";
            this.SrchLBL.Size = new System.Drawing.Size(154, 25);
            this.SrchLBL.TabIndex = 5;
            this.SrchLBL.Text = "Product Name ";
            // 
            // pr_NmTXT
            // 
            this.pr_NmTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr_NmTXT.Location = new System.Drawing.Point(474, 169);
            this.pr_NmTXT.Name = "pr_NmTXT";
            this.pr_NmTXT.Size = new System.Drawing.Size(203, 34);
            this.pr_NmTXT.TabIndex = 6;
            this.pr_NmTXT.TextChanged += new System.EventHandler(this.pr_NmTXT_TextChanged);
            // 
            // srchTXT
            // 
            this.srchTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchTXT.Location = new System.Drawing.Point(1139, 83);
            this.srchTXT.Name = "srchTXT";
            this.srchTXT.Size = new System.Drawing.Size(219, 38);
            this.srchTXT.TabIndex = 7;
            this.srchTXT.TextChanged += new System.EventHandler(this.srchTXT_TextChanged);
            // 
            // stckTXT
            // 
            this.stckTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stckTXT.Location = new System.Drawing.Point(474, 634);
            this.stckTXT.Name = "stckTXT";
            this.stckTXT.Size = new System.Drawing.Size(203, 34);
            this.stckTXT.TabIndex = 8;
            this.stckTXT.TextChanged += new System.EventHandler(this.stckTXT_TextChanged);
            // 
            // pr_IDTXT
            // 
            this.pr_IDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr_IDTXT.Location = new System.Drawing.Point(474, 328);
            this.pr_IDTXT.Name = "pr_IDTXT";
            this.pr_IDTXT.Size = new System.Drawing.Size(203, 34);
            this.pr_IDTXT.TabIndex = 9;
            this.pr_IDTXT.TextChanged += new System.EventHandler(this.pr_IDTXT_TextChanged);
            // 
            // buy_OrderBTN
            // 
            this.buy_OrderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy_OrderBTN.Location = new System.Drawing.Point(785, 824);
            this.buy_OrderBTN.Name = "buy_OrderBTN";
            this.buy_OrderBTN.Size = new System.Drawing.Size(75, 31);
            this.buy_OrderBTN.TabIndex = 10;
            this.buy_OrderBTN.Text = "Buy";
            this.buy_OrderBTN.UseVisualStyleBackColor = true;
            this.buy_OrderBTN.Click += new System.EventHandler(this.buy_OrderBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.Black;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBTN.Location = new System.Drawing.Point(1717, 817);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 38);
            this.backBTN.TabIndex = 12;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // SrchBTN
            // 
            this.SrchBTN.BackColor = System.Drawing.Color.Black;
            this.SrchBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SrchBTN.FlatAppearance.BorderSize = 10;
            this.SrchBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.SrchBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SrchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SrchBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SrchBTN.Location = new System.Drawing.Point(1619, 109);
            this.SrchBTN.Name = "SrchBTN";
            this.SrchBTN.Size = new System.Drawing.Size(144, 68);
            this.SrchBTN.TabIndex = 13;
            this.SrchBTN.Text = "Search";
            this.SrchBTN.UseVisualStyleBackColor = false;
            this.SrchBTN.Click += new System.EventHandler(this.SrchBTN_Click);
            // 
            // prHeadLBL
            // 
            this.prHeadLBL.AutoSize = true;
            this.prHeadLBL.Font = new System.Drawing.Font("Algerian", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prHeadLBL.Location = new System.Drawing.Point(393, 25);
            this.prHeadLBL.Name = "prHeadLBL";
            this.prHeadLBL.Size = new System.Drawing.Size(387, 54);
            this.prHeadLBL.TabIndex = 14;
            this.prHeadLBL.Text = "Product\'s Info";
            // 
            // categoryTXT
            // 
            this.categoryTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTXT.Location = new System.Drawing.Point(474, 480);
            this.categoryTXT.Name = "categoryTXT";
            this.categoryTXT.Size = new System.Drawing.Size(203, 34);
            this.categoryTXT.TabIndex = 16;
            // 
            // categoryLBL
            // 
            this.categoryLBL.AutoSize = true;
            this.categoryLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLBL.Location = new System.Drawing.Point(469, 443);
            this.categoryLBL.Name = "categoryLBL";
            this.categoryLBL.Size = new System.Drawing.Size(113, 25);
            this.categoryLBL.TabIndex = 15;
            this.categoryLBL.Text = "Category: ";
            // 
            // cartBTN
            // 
            this.cartBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cartBTN.Location = new System.Drawing.Point(261, 824);
            this.cartBTN.Name = "cartBTN";
            this.cartBTN.Size = new System.Drawing.Size(113, 31);
            this.cartBTN.TabIndex = 17;
            this.cartBTN.Text = "Add to Cart";
            this.cartBTN.UseVisualStyleBackColor = true;
            this.cartBTN.Click += new System.EventHandler(this.cartBTN_Click);
            // 
            // pr_Name
            // 
            this.pr_Name.HeaderText = "Product Name";
            this.pr_Name.MinimumWidth = 6;
            this.pr_Name.Name = "pr_Name";
            this.pr_Name.ReadOnly = true;
            this.pr_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pr_Name.Width = 125;
            // 
            // Pr_ID_grd
            // 
            this.Pr_ID_grd.HeaderText = "Product ID";
            this.Pr_ID_grd.MinimumWidth = 6;
            this.Pr_ID_grd.Name = "Pr_ID_grd";
            this.Pr_ID_grd.ReadOnly = true;
            this.Pr_ID_grd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Pr_ID_grd.Width = 125;
            // 
            // category_GRD
            // 
            this.category_GRD.HeaderText = "Category";
            this.category_GRD.MinimumWidth = 6;
            this.category_GRD.Name = "category_GRD";
            this.category_GRD.ReadOnly = true;
            this.category_GRD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.category_GRD.Width = 125;
            // 
            // pr_Price
            // 
            this.pr_Price.HeaderText = "Product Price";
            this.pr_Price.MinimumWidth = 6;
            this.pr_Price.Name = "pr_Price";
            this.pr_Price.ReadOnly = true;
            this.pr_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pr_Price.Width = 125;
            // 
            // stock_GRD
            // 
            this.stock_GRD.HeaderText = "Stock";
            this.stock_GRD.MinimumWidth = 6;
            this.stock_GRD.Name = "stock_GRD";
            this.stock_GRD.ReadOnly = true;
            this.stock_GRD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stock_GRD.Width = 125;
            // 
            // slctBTN
            // 
            this.slctBTN.HeaderText = "Select";
            this.slctBTN.MinimumWidth = 6;
            this.slctBTN.Name = "slctBTN";
            this.slctBTN.Width = 125;
            // 
            // prIDTXT
            // 
            this.prIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prIDTXT.Location = new System.Drawing.Point(1139, 180);
            this.prIDTXT.Name = "prIDTXT";
            this.prIDTXT.Size = new System.Drawing.Size(219, 38);
            this.prIDTXT.TabIndex = 19;
            this.prIDTXT.TextChanged += new System.EventHandler(this.prIDTXT_TextChanged);
            // 
            // topLBL
            // 
            this.topLBL.AutoSize = true;
            this.topLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLBL.Location = new System.Drawing.Point(1136, 152);
            this.topLBL.Name = "topLBL";
            this.topLBL.Size = new System.Drawing.Size(113, 25);
            this.topLBL.TabIndex = 18;
            this.topLBL.Text = "Product ID";
            // 
            // buy_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.prIDTXT);
            this.Controls.Add(this.topLBL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cartBTN);
            this.Controls.Add(this.categoryTXT);
            this.Controls.Add(this.categoryLBL);
            this.Controls.Add(this.prHeadLBL);
            this.Controls.Add(this.SrchBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.buy_OrderBTN);
            this.Controls.Add(this.pr_IDTXT);
            this.Controls.Add(this.stckTXT);
            this.Controls.Add(this.srchTXT);
            this.Controls.Add(this.pr_NmTXT);
            this.Controls.Add(this.SrchLBL);
            this.Controls.Add(this.pr_ID_LBL);
            this.Controls.Add(this.StckLBL);
            this.Controls.Add(this.pr_nameLBL);
            this.Name = "buy_Product";
            this.Text = "buy_Product";
            this.Load += new System.EventHandler(this.buy_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label pr_nameLBL;
        private System.Windows.Forms.Label StckLBL;
        private System.Windows.Forms.Label pr_ID_LBL;
        private System.Windows.Forms.Label SrchLBL;
        private System.Windows.Forms.TextBox pr_NmTXT;
        private System.Windows.Forms.TextBox srchTXT;
        private System.Windows.Forms.TextBox stckTXT;
        private System.Windows.Forms.TextBox pr_IDTXT;
        private System.Windows.Forms.Button buy_OrderBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button SrchBTN;
        private System.Windows.Forms.Label prHeadLBL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox categoryTXT;
        private System.Windows.Forms.Label categoryLBL;
        private System.Windows.Forms.Button cartBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pr_ID_grd;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_GRD;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_GRD;
        private System.Windows.Forms.DataGridViewButtonColumn slctBTN;
        private System.Windows.Forms.TextBox prIDTXT;
        private System.Windows.Forms.Label topLBL;
    }
}
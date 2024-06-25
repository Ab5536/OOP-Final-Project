
namespace Business_Project_GUI
{
    partial class Manage_Products
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
            this.prName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prNameLBL = new System.Windows.Forms.Label();
            this.PRinpLBL = new System.Windows.Forms.Label();
            this.prIDinpLBL = new System.Windows.Forms.Label();
            this.categryinpLBL = new System.Windows.Forms.Label();
            this.prPriceinpLBL = new System.Windows.Forms.Label();
            this.prStockinpLBL = new System.Windows.Forms.Label();
            this.prHeadLBL = new System.Windows.Forms.Label();
            this.insertBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.dltBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.allCloseBTN = new System.Windows.Forms.Button();
            this.prnameinpTXT = new System.Windows.Forms.TextBox();
            this.prStockinpTXT = new System.Windows.Forms.TextBox();
            this.prPriceinpTXT = new System.Windows.Forms.TextBox();
            this.categoryinpTXT = new System.Windows.Forms.TextBox();
            this.prIDinpTXT = new System.Windows.Forms.TextBox();
            this.prnameTXT = new System.Windows.Forms.TextBox();
            this.srchBTN = new System.Windows.Forms.Button();
            this.prIDTXT = new System.Windows.Forms.TextBox();
            this.prIDLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prName,
            this.PrID,
            this.prCategory,
            this.prPrice,
            this.PrStock,
            this.Edit_Delete});
            this.dataGridView1.Location = new System.Drawing.Point(552, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prName
            // 
            this.prName.HeaderText = "Product Name";
            this.prName.MinimumWidth = 6;
            this.prName.Name = "prName";
            this.prName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prName.Width = 125;
            // 
            // PrID
            // 
            this.PrID.HeaderText = "Product ID";
            this.PrID.MinimumWidth = 6;
            this.PrID.Name = "PrID";
            this.PrID.Width = 125;
            // 
            // prCategory
            // 
            this.prCategory.HeaderText = "Category";
            this.prCategory.MinimumWidth = 6;
            this.prCategory.Name = "prCategory";
            this.prCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prCategory.Width = 125;
            // 
            // prPrice
            // 
            this.prPrice.HeaderText = "Price";
            this.prPrice.MinimumWidth = 6;
            this.prPrice.Name = "prPrice";
            this.prPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prPrice.Width = 125;
            // 
            // PrStock
            // 
            this.PrStock.HeaderText = "Stock";
            this.PrStock.MinimumWidth = 6;
            this.PrStock.Name = "PrStock";
            this.PrStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrStock.Width = 125;
            // 
            // Edit_Delete
            // 
            this.Edit_Delete.HeaderText = "Edit/Delete";
            this.Edit_Delete.MinimumWidth = 6;
            this.Edit_Delete.Name = "Edit_Delete";
            this.Edit_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit_Delete.Width = 125;
            // 
            // prNameLBL
            // 
            this.prNameLBL.AutoSize = true;
            this.prNameLBL.Location = new System.Drawing.Point(548, 25);
            this.prNameLBL.Name = "prNameLBL";
            this.prNameLBL.Size = new System.Drawing.Size(144, 17);
            this.prNameLBL.TabIndex = 1;
            this.prNameLBL.Text = "Enter Product Name: ";
            // 
            // PRinpLBL
            // 
            this.PRinpLBL.AutoSize = true;
            this.PRinpLBL.Location = new System.Drawing.Point(131, 148);
            this.PRinpLBL.Name = "PRinpLBL";
            this.PRinpLBL.Size = new System.Drawing.Size(144, 17);
            this.PRinpLBL.TabIndex = 2;
            this.PRinpLBL.Text = "Enter Product Name: ";
            // 
            // prIDinpLBL
            // 
            this.prIDinpLBL.AutoSize = true;
            this.prIDinpLBL.Location = new System.Drawing.Point(131, 205);
            this.prIDinpLBL.Name = "prIDinpLBL";
            this.prIDinpLBL.Size = new System.Drawing.Size(124, 17);
            this.prIDinpLBL.TabIndex = 3;
            this.prIDinpLBL.Text = "Enter Product ID:  ";
            // 
            // categryinpLBL
            // 
            this.categryinpLBL.AutoSize = true;
            this.categryinpLBL.Location = new System.Drawing.Point(131, 253);
            this.categryinpLBL.Name = "categryinpLBL";
            this.categryinpLBL.Size = new System.Drawing.Size(111, 17);
            this.categryinpLBL.TabIndex = 4;
            this.categryinpLBL.Text = "Enter Category: ";
            // 
            // prPriceinpLBL
            // 
            this.prPriceinpLBL.AutoSize = true;
            this.prPriceinpLBL.Location = new System.Drawing.Point(131, 300);
            this.prPriceinpLBL.Name = "prPriceinpLBL";
            this.prPriceinpLBL.Size = new System.Drawing.Size(139, 17);
            this.prPriceinpLBL.TabIndex = 5;
            this.prPriceinpLBL.Text = "Enter Product Price: ";
            // 
            // prStockinpLBL
            // 
            this.prStockinpLBL.AutoSize = true;
            this.prStockinpLBL.Location = new System.Drawing.Point(131, 354);
            this.prStockinpLBL.Name = "prStockinpLBL";
            this.prStockinpLBL.Size = new System.Drawing.Size(89, 17);
            this.prStockinpLBL.TabIndex = 6;
            this.prStockinpLBL.Text = "Enter Stock: ";
            // 
            // prHeadLBL
            // 
            this.prHeadLBL.AutoSize = true;
            this.prHeadLBL.Location = new System.Drawing.Point(240, 66);
            this.prHeadLBL.Name = "prHeadLBL";
            this.prHeadLBL.Size = new System.Drawing.Size(84, 17);
            this.prHeadLBL.TabIndex = 7;
            this.prHeadLBL.Text = "Product Info";
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(69, 423);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(75, 24);
            this.insertBTN.TabIndex = 8;
            this.insertBTN.Text = "Insert";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new System.Drawing.Point(1269, 514);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 23);
            this.BackBTN.TabIndex = 9;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // dltBTN
            // 
            this.dltBTN.Location = new System.Drawing.Point(471, 424);
            this.dltBTN.Name = "dltBTN";
            this.dltBTN.Size = new System.Drawing.Size(75, 23);
            this.dltBTN.TabIndex = 10;
            this.dltBTN.Text = "Delete";
            this.dltBTN.UseVisualStyleBackColor = true;
            this.dltBTN.Click += new System.EventHandler(this.dltBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(266, 424);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 23);
            this.updateBTN.TabIndex = 11;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // allCloseBTN
            // 
            this.allCloseBTN.Location = new System.Drawing.Point(604, 510);
            this.allCloseBTN.Name = "allCloseBTN";
            this.allCloseBTN.Size = new System.Drawing.Size(88, 30);
            this.allCloseBTN.TabIndex = 12;
            this.allCloseBTN.Text = "Close App";
            this.allCloseBTN.UseVisualStyleBackColor = true;
            this.allCloseBTN.Click += new System.EventHandler(this.allCloseBTN_Click);
            // 
            // prnameinpTXT
            // 
            this.prnameinpTXT.Location = new System.Drawing.Point(338, 148);
            this.prnameinpTXT.Name = "prnameinpTXT";
            this.prnameinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prnameinpTXT.TabIndex = 13;
            this.prnameinpTXT.TextChanged += new System.EventHandler(this.prnameinpTXT_TextChanged);
            // 
            // prStockinpTXT
            // 
            this.prStockinpTXT.Location = new System.Drawing.Point(338, 354);
            this.prStockinpTXT.Name = "prStockinpTXT";
            this.prStockinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prStockinpTXT.TabIndex = 15;
            this.prStockinpTXT.TextChanged += new System.EventHandler(this.prStockinpTXT_TextChanged);
            // 
            // prPriceinpTXT
            // 
            this.prPriceinpTXT.Location = new System.Drawing.Point(338, 311);
            this.prPriceinpTXT.Name = "prPriceinpTXT";
            this.prPriceinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prPriceinpTXT.TabIndex = 16;
            this.prPriceinpTXT.TextChanged += new System.EventHandler(this.prPriceinpTXT_TextChanged);
            // 
            // categoryinpTXT
            // 
            this.categoryinpTXT.Location = new System.Drawing.Point(338, 253);
            this.categoryinpTXT.Name = "categoryinpTXT";
            this.categoryinpTXT.Size = new System.Drawing.Size(100, 22);
            this.categoryinpTXT.TabIndex = 17;
            this.categoryinpTXT.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // prIDinpTXT
            // 
            this.prIDinpTXT.Location = new System.Drawing.Point(338, 205);
            this.prIDinpTXT.Name = "prIDinpTXT";
            this.prIDinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prIDinpTXT.TabIndex = 18;
            this.prIDinpTXT.TextChanged += new System.EventHandler(this.prIDinpTXT_TextChanged);
            // 
            // prnameTXT
            // 
            this.prnameTXT.Location = new System.Drawing.Point(715, 22);
            this.prnameTXT.Name = "prnameTXT";
            this.prnameTXT.Size = new System.Drawing.Size(100, 22);
            this.prnameTXT.TabIndex = 19;
            this.prnameTXT.TextChanged += new System.EventHandler(this.prnameTXT_TextChanged);
            // 
            // srchBTN
            // 
            this.srchBTN.Location = new System.Drawing.Point(1116, 37);
            this.srchBTN.Name = "srchBTN";
            this.srchBTN.Size = new System.Drawing.Size(75, 23);
            this.srchBTN.TabIndex = 20;
            this.srchBTN.Text = "Search";
            this.srchBTN.UseVisualStyleBackColor = true;
            this.srchBTN.Click += new System.EventHandler(this.srchBTN_Click);
            // 
            // prIDTXT
            // 
            this.prIDTXT.Location = new System.Drawing.Point(715, 61);
            this.prIDTXT.Name = "prIDTXT";
            this.prIDTXT.Size = new System.Drawing.Size(100, 22);
            this.prIDTXT.TabIndex = 21;
            // 
            // prIDLBL
            // 
            this.prIDLBL.AutoSize = true;
            this.prIDLBL.Location = new System.Drawing.Point(563, 61);
            this.prIDLBL.Name = "prIDLBL";
            this.prIDLBL.Size = new System.Drawing.Size(86, 17);
            this.prIDLBL.TabIndex = 22;
            this.prIDLBL.Text = "Product ID : ";
            // 
            // Manage_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 593);
            this.Controls.Add(this.prIDLBL);
            this.Controls.Add(this.prIDTXT);
            this.Controls.Add(this.srchBTN);
            this.Controls.Add(this.prnameTXT);
            this.Controls.Add(this.prIDinpTXT);
            this.Controls.Add(this.categoryinpTXT);
            this.Controls.Add(this.prPriceinpTXT);
            this.Controls.Add(this.prStockinpTXT);
            this.Controls.Add(this.prnameinpTXT);
            this.Controls.Add(this.allCloseBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.dltBTN);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.prHeadLBL);
            this.Controls.Add(this.prStockinpLBL);
            this.Controls.Add(this.prPriceinpLBL);
            this.Controls.Add(this.categryinpLBL);
            this.Controls.Add(this.prIDinpLBL);
            this.Controls.Add(this.PRinpLBL);
            this.Controls.Add(this.prNameLBL);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Manage_Products";
            this.Text = "Manage_Products";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Manage_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrStock;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Delete;
        private System.Windows.Forms.Label prNameLBL;
        private System.Windows.Forms.Label PRinpLBL;
        private System.Windows.Forms.Label prIDinpLBL;
        private System.Windows.Forms.Label categryinpLBL;
        private System.Windows.Forms.Label prPriceinpLBL;
        private System.Windows.Forms.Label prStockinpLBL;
        private System.Windows.Forms.Label prHeadLBL;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button dltBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button allCloseBTN;
        private System.Windows.Forms.TextBox prnameinpTXT;
        private System.Windows.Forms.TextBox prStockinpTXT;
        private System.Windows.Forms.TextBox prPriceinpTXT;
        private System.Windows.Forms.TextBox categoryinpTXT;
        private System.Windows.Forms.TextBox prIDinpTXT;
        private System.Windows.Forms.TextBox prnameTXT;
        private System.Windows.Forms.Button srchBTN;
        private System.Windows.Forms.TextBox prIDTXT;
        private System.Windows.Forms.Label prIDLBL;
    }

    partial class CopyOfManage_Products
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
            this.prName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prNameLBL = new System.Windows.Forms.Label();
            this.PRinpLBL = new System.Windows.Forms.Label();
            this.prIDinpLBL = new System.Windows.Forms.Label();
            this.categryinpLBL = new System.Windows.Forms.Label();
            this.prPriceinpLBL = new System.Windows.Forms.Label();
            this.prStockinpLBL = new System.Windows.Forms.Label();
            this.prHeadLBL = new System.Windows.Forms.Label();
            this.insertBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.dltBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.allCloseBTN = new System.Windows.Forms.Button();
            this.prnameinpTXT = new System.Windows.Forms.TextBox();
            this.prStockinpTXT = new System.Windows.Forms.TextBox();
            this.prPriceinpTXT = new System.Windows.Forms.TextBox();
            this.categoryinpTXT = new System.Windows.Forms.TextBox();
            this.prIDinpTXT = new System.Windows.Forms.TextBox();
            this.prnameTXT = new System.Windows.Forms.TextBox();
            this.srchBTN = new System.Windows.Forms.Button();
            this.prIDTXT = new System.Windows.Forms.TextBox();
            this.prIDLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prName,
            this.PrID,
            this.prCategory,
            this.prPrice,
            this.PrStock,
            this.Edit_Delete});
            this.dataGridView1.Location = new System.Drawing.Point(552, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(939, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prName
            // 
            this.prName.HeaderText = "Product Name";
            this.prName.MinimumWidth = 6;
            this.prName.Name = "prName";
            this.prName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prName.Width = 125;
            // 
            // PrID
            // 
            this.PrID.HeaderText = "Product ID";
            this.PrID.MinimumWidth = 6;
            this.PrID.Name = "PrID";
            this.PrID.Width = 125;
            // 
            // prCategory
            // 
            this.prCategory.HeaderText = "Category";
            this.prCategory.MinimumWidth = 6;
            this.prCategory.Name = "prCategory";
            this.prCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prCategory.Width = 125;
            // 
            // prPrice
            // 
            this.prPrice.HeaderText = "Price";
            this.prPrice.MinimumWidth = 6;
            this.prPrice.Name = "prPrice";
            this.prPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prPrice.Width = 125;
            // 
            // PrStock
            // 
            this.PrStock.HeaderText = "Stock";
            this.PrStock.MinimumWidth = 6;
            this.PrStock.Name = "PrStock";
            this.PrStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrStock.Width = 125;
            // 
            // Edit_Delete
            // 
            this.Edit_Delete.HeaderText = "Edit/Delete";
            this.Edit_Delete.MinimumWidth = 6;
            this.Edit_Delete.Name = "Edit_Delete";
            this.Edit_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit_Delete.Width = 125;
            // 
            // prNameLBL
            // 
            this.prNameLBL.AutoSize = true;
            this.prNameLBL.Location = new System.Drawing.Point(548, 25);
            this.prNameLBL.Name = "prNameLBL";
            this.prNameLBL.Size = new System.Drawing.Size(144, 17);
            this.prNameLBL.TabIndex = 1;
            this.prNameLBL.Text = "Enter Product Name: ";
            // 
            // PRinpLBL
            // 
            this.PRinpLBL.AutoSize = true;
            this.PRinpLBL.Location = new System.Drawing.Point(131, 148);
            this.PRinpLBL.Name = "PRinpLBL";
            this.PRinpLBL.Size = new System.Drawing.Size(144, 17);
            this.PRinpLBL.TabIndex = 2;
            this.PRinpLBL.Text = "Enter Product Name: ";
            // 
            // prIDinpLBL
            // 
            this.prIDinpLBL.AutoSize = true;
            this.prIDinpLBL.Location = new System.Drawing.Point(131, 205);
            this.prIDinpLBL.Name = "prIDinpLBL";
            this.prIDinpLBL.Size = new System.Drawing.Size(124, 17);
            this.prIDinpLBL.TabIndex = 3;
            this.prIDinpLBL.Text = "Enter Product ID:  ";
            // 
            // categryinpLBL
            // 
            this.categryinpLBL.AutoSize = true;
            this.categryinpLBL.Location = new System.Drawing.Point(131, 253);
            this.categryinpLBL.Name = "categryinpLBL";
            this.categryinpLBL.Size = new System.Drawing.Size(111, 17);
            this.categryinpLBL.TabIndex = 4;
            this.categryinpLBL.Text = "Enter Category: ";
            // 
            // prPriceinpLBL
            // 
            this.prPriceinpLBL.AutoSize = true;
            this.prPriceinpLBL.Location = new System.Drawing.Point(131, 300);
            this.prPriceinpLBL.Name = "prPriceinpLBL";
            this.prPriceinpLBL.Size = new System.Drawing.Size(139, 17);
            this.prPriceinpLBL.TabIndex = 5;
            this.prPriceinpLBL.Text = "Enter Product Price: ";
            // 
            // prStockinpLBL
            // 
            this.prStockinpLBL.AutoSize = true;
            this.prStockinpLBL.Location = new System.Drawing.Point(131, 354);
            this.prStockinpLBL.Name = "prStockinpLBL";
            this.prStockinpLBL.Size = new System.Drawing.Size(89, 17);
            this.prStockinpLBL.TabIndex = 6;
            this.prStockinpLBL.Text = "Enter Stock: ";
            // 
            // prHeadLBL
            // 
            this.prHeadLBL.AutoSize = true;
            this.prHeadLBL.Location = new System.Drawing.Point(240, 66);
            this.prHeadLBL.Name = "prHeadLBL";
            this.prHeadLBL.Size = new System.Drawing.Size(84, 17);
            this.prHeadLBL.TabIndex = 7;
            this.prHeadLBL.Text = "Product Info";
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(69, 423);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(75, 24);
            this.insertBTN.TabIndex = 8;
            this.insertBTN.Text = "Insert";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new System.Drawing.Point(1269, 514);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 23);
            this.BackBTN.TabIndex = 9;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // dltBTN
            // 
            this.dltBTN.Location = new System.Drawing.Point(471, 424);
            this.dltBTN.Name = "dltBTN";
            this.dltBTN.Size = new System.Drawing.Size(75, 23);
            this.dltBTN.TabIndex = 10;
            this.dltBTN.Text = "Delete";
            this.dltBTN.UseVisualStyleBackColor = true;
            this.dltBTN.Click += new System.EventHandler(this.dltBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(266, 424);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 23);
            this.updateBTN.TabIndex = 11;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // allCloseBTN
            // 
            this.allCloseBTN.Location = new System.Drawing.Point(604, 510);
            this.allCloseBTN.Name = "allCloseBTN";
            this.allCloseBTN.Size = new System.Drawing.Size(88, 30);
            this.allCloseBTN.TabIndex = 12;
            this.allCloseBTN.Text = "Close App";
            this.allCloseBTN.UseVisualStyleBackColor = true;
            this.allCloseBTN.Click += new System.EventHandler(this.allCloseBTN_Click);
            // 
            // prnameinpTXT
            // 
            this.prnameinpTXT.Location = new System.Drawing.Point(338, 148);
            this.prnameinpTXT.Name = "prnameinpTXT";
            this.prnameinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prnameinpTXT.TabIndex = 13;
            this.prnameinpTXT.TextChanged += new System.EventHandler(this.prnameinpTXT_TextChanged);
            // 
            // prStockinpTXT
            // 
            this.prStockinpTXT.Location = new System.Drawing.Point(338, 354);
            this.prStockinpTXT.Name = "prStockinpTXT";
            this.prStockinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prStockinpTXT.TabIndex = 15;
            this.prStockinpTXT.TextChanged += new System.EventHandler(this.prStockinpTXT_TextChanged);
            // 
            // prPriceinpTXT
            // 
            this.prPriceinpTXT.Location = new System.Drawing.Point(338, 311);
            this.prPriceinpTXT.Name = "prPriceinpTXT";
            this.prPriceinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prPriceinpTXT.TabIndex = 16;
            this.prPriceinpTXT.TextChanged += new System.EventHandler(this.prPriceinpTXT_TextChanged);
            // 
            // categoryinpTXT
            // 
            this.categoryinpTXT.Location = new System.Drawing.Point(338, 253);
            this.categoryinpTXT.Name = "categoryinpTXT";
            this.categoryinpTXT.Size = new System.Drawing.Size(100, 22);
            this.categoryinpTXT.TabIndex = 17;
            this.categoryinpTXT.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // prIDinpTXT
            // 
            this.prIDinpTXT.Location = new System.Drawing.Point(338, 205);
            this.prIDinpTXT.Name = "prIDinpTXT";
            this.prIDinpTXT.Size = new System.Drawing.Size(100, 22);
            this.prIDinpTXT.TabIndex = 18;
            this.prIDinpTXT.TextChanged += new System.EventHandler(this.prIDinpTXT_TextChanged);
            // 
            // prnameTXT
            // 
            this.prnameTXT.Location = new System.Drawing.Point(715, 22);
            this.prnameTXT.Name = "prnameTXT";
            this.prnameTXT.Size = new System.Drawing.Size(100, 22);
            this.prnameTXT.TabIndex = 19;
            this.prnameTXT.TextChanged += new System.EventHandler(this.prnameTXT_TextChanged);
            // 
            // srchBTN
            // 
            this.srchBTN.Location = new System.Drawing.Point(1116, 37);
            this.srchBTN.Name = "srchBTN";
            this.srchBTN.Size = new System.Drawing.Size(75, 23);
            this.srchBTN.TabIndex = 20;
            this.srchBTN.Text = "Search";
            this.srchBTN.UseVisualStyleBackColor = true;
            this.srchBTN.Click += new System.EventHandler(this.srchBTN_Click);
            // 
            // prIDTXT
            // 
            this.prIDTXT.Location = new System.Drawing.Point(715, 61);
            this.prIDTXT.Name = "prIDTXT";
            this.prIDTXT.Size = new System.Drawing.Size(100, 22);
            this.prIDTXT.TabIndex = 21;
            // 
            // prIDLBL
            // 
            this.prIDLBL.AutoSize = true;
            this.prIDLBL.Location = new System.Drawing.Point(563, 61);
            this.prIDLBL.Name = "prIDLBL";
            this.prIDLBL.Size = new System.Drawing.Size(86, 17);
            this.prIDLBL.TabIndex = 22;
            this.prIDLBL.Text = "Product ID : ";
            // 
            // CopyOfManage_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 593);
            this.Controls.Add(this.prIDLBL);
            this.Controls.Add(this.prIDTXT);
            this.Controls.Add(this.srchBTN);
            this.Controls.Add(this.prnameTXT);
            this.Controls.Add(this.prIDinpTXT);
            this.Controls.Add(this.categoryinpTXT);
            this.Controls.Add(this.prPriceinpTXT);
            this.Controls.Add(this.prStockinpTXT);
            this.Controls.Add(this.prnameinpTXT);
            this.Controls.Add(this.allCloseBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.dltBTN);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.prHeadLBL);
            this.Controls.Add(this.prStockinpLBL);
            this.Controls.Add(this.prPriceinpLBL);
            this.Controls.Add(this.categryinpLBL);
            this.Controls.Add(this.prIDinpLBL);
            this.Controls.Add(this.PRinpLBL);
            this.Controls.Add(this.prNameLBL);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CopyOfManage_Products";
            this.Text = "CopyOfManage_Products";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Manage_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn prPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrStock;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Delete;
        private System.Windows.Forms.Label prNameLBL;
        private System.Windows.Forms.Label PRinpLBL;
        private System.Windows.Forms.Label prIDinpLBL;
        private System.Windows.Forms.Label categryinpLBL;
        private System.Windows.Forms.Label prPriceinpLBL;
        private System.Windows.Forms.Label prStockinpLBL;
        private System.Windows.Forms.Label prHeadLBL;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button dltBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button allCloseBTN;
        private System.Windows.Forms.TextBox prnameinpTXT;
        private System.Windows.Forms.TextBox prStockinpTXT;
        private System.Windows.Forms.TextBox prPriceinpTXT;
        private System.Windows.Forms.TextBox categoryinpTXT;
        private System.Windows.Forms.TextBox prIDinpTXT;
        private System.Windows.Forms.TextBox prnameTXT;
        private System.Windows.Forms.Button srchBTN;
        private System.Windows.Forms.TextBox prIDTXT;
        private System.Windows.Forms.Label prIDLBL;
    }
}
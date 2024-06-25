
namespace Business_Project_GUI
{
    partial class manage_Customer
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
            this.Customer = new System.Windows.Forms.DataGridView();
            this.UpdteBTN = new System.Windows.Forms.Button();
            this.DLTBTN = new System.Windows.Forms.Button();
            this.custHeadLBL = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.custId_TXT = new System.Windows.Forms.TextBox();
            this.usr_NmTXT = new System.Windows.Forms.TextBox();
            this.cust_ID_LBL = new System.Windows.Forms.Label();
            this.user_nameLBL = new System.Windows.Forms.Label();
            this.extBTN = new System.Windows.Forms.Button();
            this.cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_of_purchased = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyCLM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cust_Name,
            this.Cust_ID,
            this.No_of_purchased,
            this.feedbackNo,
            this.buyCLM,
            this.add_delete});
            this.Customer.Location = new System.Drawing.Point(474, 58);
            this.Customer.Name = "Customer";
            this.Customer.RowHeadersWidth = 51;
            this.Customer.RowTemplate.Height = 24;
            this.Customer.Size = new System.Drawing.Size(964, 256);
            this.Customer.TabIndex = 0;
            this.Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UpdteBTN
            // 
            this.UpdteBTN.Location = new System.Drawing.Point(135, 371);
            this.UpdteBTN.Name = "UpdteBTN";
            this.UpdteBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdteBTN.TabIndex = 42;
            this.UpdteBTN.Text = "Update";
            this.UpdteBTN.UseVisualStyleBackColor = true;
            this.UpdteBTN.Click += new System.EventHandler(this.UpdteBTN_Click);
            // 
            // DLTBTN
            // 
            this.DLTBTN.Location = new System.Drawing.Point(313, 371);
            this.DLTBTN.Name = "DLTBTN";
            this.DLTBTN.Size = new System.Drawing.Size(75, 23);
            this.DLTBTN.TabIndex = 41;
            this.DLTBTN.Text = "Delete";
            this.DLTBTN.UseVisualStyleBackColor = true;
            this.DLTBTN.Click += new System.EventHandler(this.DLTBTN_Click);
            // 
            // custHeadLBL
            // 
            this.custHeadLBL.AutoSize = true;
            this.custHeadLBL.Location = new System.Drawing.Point(214, 40);
            this.custHeadLBL.Name = "custHeadLBL";
            this.custHeadLBL.Size = new System.Drawing.Size(95, 17);
            this.custHeadLBL.TabIndex = 40;
            this.custHeadLBL.Text = "Customer Info";
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(635, 357);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 39;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // custId_TXT
            // 
            this.custId_TXT.Location = new System.Drawing.Point(264, 181);
            this.custId_TXT.Name = "custId_TXT";
            this.custId_TXT.Size = new System.Drawing.Size(100, 22);
            this.custId_TXT.TabIndex = 38;
            this.custId_TXT.TextChanged += new System.EventHandler(this.custId_TXT_TextChanged);
            // 
            // usr_NmTXT
            // 
            this.usr_NmTXT.Location = new System.Drawing.Point(264, 120);
            this.usr_NmTXT.Name = "usr_NmTXT";
            this.usr_NmTXT.Size = new System.Drawing.Size(100, 22);
            this.usr_NmTXT.TabIndex = 36;
            this.usr_NmTXT.TextChanged += new System.EventHandler(this.usr_NmTXT_TextChanged);
            // 
            // cust_ID_LBL
            // 
            this.cust_ID_LBL.AutoSize = true;
            this.cust_ID_LBL.Location = new System.Drawing.Point(132, 184);
            this.cust_ID_LBL.Name = "cust_ID_LBL";
            this.cust_ID_LBL.Size = new System.Drawing.Size(93, 17);
            this.cust_ID_LBL.TabIndex = 35;
            this.cust_ID_LBL.Text = "Customer ID: ";
            // 
            // user_nameLBL
            // 
            this.user_nameLBL.AutoSize = true;
            this.user_nameLBL.Location = new System.Drawing.Point(132, 125);
            this.user_nameLBL.Name = "user_nameLBL";
            this.user_nameLBL.Size = new System.Drawing.Size(83, 17);
            this.user_nameLBL.TabIndex = 33;
            this.user_nameLBL.Text = "UserName: ";
            // 
            // extBTN
            // 
            this.extBTN.Location = new System.Drawing.Point(1110, 357);
            this.extBTN.Name = "extBTN";
            this.extBTN.Size = new System.Drawing.Size(75, 23);
            this.extBTN.TabIndex = 43;
            this.extBTN.Text = "Exit";
            this.extBTN.UseVisualStyleBackColor = true;
            this.extBTN.Click += new System.EventHandler(this.extBTN_Click);
            // 
            // cust_Name
            // 
            this.cust_Name.HeaderText = "Customer Name";
            this.cust_Name.MinimumWidth = 6;
            this.cust_Name.Name = "cust_Name";
            this.cust_Name.ReadOnly = true;
            this.cust_Name.Width = 125;
            // 
            // Cust_ID
            // 
            this.Cust_ID.HeaderText = "Customer ID";
            this.Cust_ID.MinimumWidth = 6;
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.ReadOnly = true;
            this.Cust_ID.Width = 125;
            // 
            // No_of_purchased
            // 
            this.No_of_purchased.HeaderText = "Purchased products";
            this.No_of_purchased.MinimumWidth = 6;
            this.No_of_purchased.Name = "No_of_purchased";
            this.No_of_purchased.ReadOnly = true;
            this.No_of_purchased.Width = 125;
            // 
            // feedbackNo
            // 
            this.feedbackNo.HeaderText = "Feedback Numbers";
            this.feedbackNo.MinimumWidth = 6;
            this.feedbackNo.Name = "feedbackNo";
            this.feedbackNo.ReadOnly = true;
            this.feedbackNo.Width = 125;
            // 
            // buyCLM
            // 
            this.buyCLM.HeaderText = "Total Buying";
            this.buyCLM.MinimumWidth = 6;
            this.buyCLM.Name = "buyCLM";
            this.buyCLM.ReadOnly = true;
            this.buyCLM.Width = 125;
            // 
            // add_delete
            // 
            this.add_delete.HeaderText = "Edit/Delete";
            this.add_delete.MinimumWidth = 6;
            this.add_delete.Name = "add_delete";
            this.add_delete.Width = 125;
            // 
            // manage_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 450);
            this.Controls.Add(this.extBTN);
            this.Controls.Add(this.UpdteBTN);
            this.Controls.Add(this.DLTBTN);
            this.Controls.Add(this.custHeadLBL);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.custId_TXT);
            this.Controls.Add(this.usr_NmTXT);
            this.Controls.Add(this.cust_ID_LBL);
            this.Controls.Add(this.user_nameLBL);
            this.Controls.Add(this.Customer);
            this.Name = "manage_Customer";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.Manage_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Customer;
        private System.Windows.Forms.Button UpdteBTN;
        private System.Windows.Forms.Button DLTBTN;
        private System.Windows.Forms.Label custHeadLBL;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.TextBox custId_TXT;
        private System.Windows.Forms.TextBox usr_NmTXT;
        private System.Windows.Forms.Label cust_ID_LBL;
        private System.Windows.Forms.Label user_nameLBL;
        private System.Windows.Forms.Button extBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_of_purchased;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyCLM;
        private System.Windows.Forms.DataGridViewButtonColumn add_delete;
    }
}
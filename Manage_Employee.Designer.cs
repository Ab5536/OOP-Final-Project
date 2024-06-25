
namespace Business_Project_GUI
{
    partial class Manage_Employee
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
            this.EmpHeadLBL = new System.Windows.Forms.Label();
            this.SrchBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.extBTN = new System.Windows.Forms.Button();
            this.password_TXT = new System.Windows.Forms.TextBox();
            this.RoleTXT = new System.Windows.Forms.TextBox();
            this.srchTXT = new System.Windows.Forms.TextBox();
            this.usr_NmTXT = new System.Windows.Forms.TextBox();
            this.SrchLBL = new System.Windows.Forms.Label();
            this.password_LBL = new System.Windows.Forms.Label();
            this.Role_LBL = new System.Windows.Forms.Label();
            this.user_nameLBL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name_GRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_GRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role_GRD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slctBTN = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dltBTN = new System.Windows.Forms.Button();
            this.insrtBTN = new System.Windows.Forms.Button();
            this.UpdteBTN = new System.Windows.Forms.Button();
            this.srchPassTXT = new System.Windows.Forms.TextBox();
            this.pswrdTopLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpHeadLBL
            // 
            this.EmpHeadLBL.AutoSize = true;
            this.EmpHeadLBL.Location = new System.Drawing.Point(204, 128);
            this.EmpHeadLBL.Name = "EmpHeadLBL";
            this.EmpHeadLBL.Size = new System.Drawing.Size(89, 17);
            this.EmpHeadLBL.TabIndex = 28;
            this.EmpHeadLBL.Text = "Emplyee Info";
            // 
            // SrchBTN
            // 
            this.SrchBTN.Location = new System.Drawing.Point(1050, 63);
            this.SrchBTN.Name = "SrchBTN";
            this.SrchBTN.Size = new System.Drawing.Size(75, 23);
            this.SrchBTN.TabIndex = 27;
            this.SrchBTN.Text = "Search";
            this.SrchBTN.UseVisualStyleBackColor = true;
            this.SrchBTN.Click += new System.EventHandler(this.SrchBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(24, 459);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 26;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // extBTN
            // 
            this.extBTN.Location = new System.Drawing.Point(1186, 472);
            this.extBTN.Name = "extBTN";
            this.extBTN.Size = new System.Drawing.Size(75, 23);
            this.extBTN.TabIndex = 25;
            this.extBTN.Text = "Exit";
            this.extBTN.UseVisualStyleBackColor = true;
            this.extBTN.Click += new System.EventHandler(this.extBTN_Click);
            // 
            // password_TXT
            // 
            this.password_TXT.Location = new System.Drawing.Point(254, 258);
            this.password_TXT.Name = "password_TXT";
            this.password_TXT.Size = new System.Drawing.Size(100, 22);
            this.password_TXT.TabIndex = 23;
            // 
            // RoleTXT
            // 
            this.RoleTXT.Location = new System.Drawing.Point(254, 305);
            this.RoleTXT.Name = "RoleTXT";
            this.RoleTXT.Size = new System.Drawing.Size(100, 22);
            this.RoleTXT.TabIndex = 22;
            this.RoleTXT.Text = "Employee";
            this.RoleTXT.TextChanged += new System.EventHandler(this.stckTXT_TextChanged);
            // 
            // srchTXT
            // 
            this.srchTXT.Location = new System.Drawing.Point(759, 41);
            this.srchTXT.Name = "srchTXT";
            this.srchTXT.Size = new System.Drawing.Size(100, 22);
            this.srchTXT.TabIndex = 21;
            this.srchTXT.TextChanged += new System.EventHandler(this.srchTXT_TextChanged);
            // 
            // usr_NmTXT
            // 
            this.usr_NmTXT.Location = new System.Drawing.Point(254, 208);
            this.usr_NmTXT.Name = "usr_NmTXT";
            this.usr_NmTXT.Size = new System.Drawing.Size(100, 22);
            this.usr_NmTXT.TabIndex = 20;
            this.usr_NmTXT.TextChanged += new System.EventHandler(this.usr_NmTXT_TextChanged);
            // 
            // SrchLBL
            // 
            this.SrchLBL.AutoSize = true;
            this.SrchLBL.Location = new System.Drawing.Point(612, 41);
            this.SrchLBL.Name = "SrchLBL";
            this.SrchLBL.Size = new System.Drawing.Size(121, 17);
            this.SrchLBL.TabIndex = 19;
            this.SrchLBL.Text = "Enter UserName: ";
            // 
            // password_LBL
            // 
            this.password_LBL.AutoSize = true;
            this.password_LBL.Location = new System.Drawing.Point(122, 258);
            this.password_LBL.Name = "password_LBL";
            this.password_LBL.Size = new System.Drawing.Size(77, 17);
            this.password_LBL.TabIndex = 18;
            this.password_LBL.Text = "Password: ";
            // 
            // Role_LBL
            // 
            this.Role_LBL.AutoSize = true;
            this.Role_LBL.Location = new System.Drawing.Point(122, 305);
            this.Role_LBL.Name = "Role_LBL";
            this.Role_LBL.Size = new System.Drawing.Size(45, 17);
            this.Role_LBL.TabIndex = 17;
            this.Role_LBL.Text = "Role: ";
            // 
            // user_nameLBL
            // 
            this.user_nameLBL.AutoSize = true;
            this.user_nameLBL.Location = new System.Drawing.Point(122, 213);
            this.user_nameLBL.Name = "user_nameLBL";
            this.user_nameLBL.Size = new System.Drawing.Size(83, 17);
            this.user_nameLBL.TabIndex = 16;
            this.user_nameLBL.Text = "UserName: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_GRD,
            this.password_GRD,
            this.Role_GRD,
            this.slctBTN});
            this.dataGridView1.Location = new System.Drawing.Point(525, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 225);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // name_GRD
            // 
            this.name_GRD.HeaderText = "UserName";
            this.name_GRD.MinimumWidth = 6;
            this.name_GRD.Name = "name_GRD";
            this.name_GRD.Width = 125;
            // 
            // password_GRD
            // 
            this.password_GRD.HeaderText = "Password";
            this.password_GRD.MinimumWidth = 6;
            this.password_GRD.Name = "password_GRD";
            this.password_GRD.Width = 125;
            // 
            // Role_GRD
            // 
            this.Role_GRD.HeaderText = "Role";
            this.Role_GRD.MinimumWidth = 6;
            this.Role_GRD.Name = "Role_GRD";
            this.Role_GRD.Width = 125;
            // 
            // slctBTN
            // 
            this.slctBTN.HeaderText = "Select";
            this.slctBTN.MinimumWidth = 6;
            this.slctBTN.Name = "slctBTN";
            this.slctBTN.Width = 125;
            // 
            // dltBTN
            // 
            this.dltBTN.Location = new System.Drawing.Point(505, 459);
            this.dltBTN.Name = "dltBTN";
            this.dltBTN.Size = new System.Drawing.Size(75, 23);
            this.dltBTN.TabIndex = 30;
            this.dltBTN.Text = "Delete";
            this.dltBTN.UseVisualStyleBackColor = true;
            this.dltBTN.Click += new System.EventHandler(this.dltBTN_Click);
            // 
            // insrtBTN
            // 
            this.insrtBTN.Location = new System.Drawing.Point(303, 459);
            this.insrtBTN.Name = "insrtBTN";
            this.insrtBTN.Size = new System.Drawing.Size(75, 23);
            this.insrtBTN.TabIndex = 31;
            this.insrtBTN.Text = "Insert";
            this.insrtBTN.UseVisualStyleBackColor = true;
            this.insrtBTN.Click += new System.EventHandler(this.insrtBTN_Click);
            // 
            // UpdteBTN
            // 
            this.UpdteBTN.Location = new System.Drawing.Point(173, 459);
            this.UpdteBTN.Name = "UpdteBTN";
            this.UpdteBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdteBTN.TabIndex = 32;
            this.UpdteBTN.Text = "Update";
            this.UpdteBTN.UseVisualStyleBackColor = true;
            this.UpdteBTN.Click += new System.EventHandler(this.UpdteBTN_Click);
            // 
            // srchPassTXT
            // 
            this.srchPassTXT.Location = new System.Drawing.Point(759, 83);
            this.srchPassTXT.Name = "srchPassTXT";
            this.srchPassTXT.Size = new System.Drawing.Size(100, 22);
            this.srchPassTXT.TabIndex = 33;
            // 
            // pswrdTopLBL
            // 
            this.pswrdTopLBL.AutoSize = true;
            this.pswrdTopLBL.Location = new System.Drawing.Point(612, 83);
            this.pswrdTopLBL.Name = "pswrdTopLBL";
            this.pswrdTopLBL.Size = new System.Drawing.Size(119, 17);
            this.pswrdTopLBL.TabIndex = 34;
            this.pswrdTopLBL.Text = "Enter Password:  ";
            // 
            // Manage_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 588);
            this.Controls.Add(this.pswrdTopLBL);
            this.Controls.Add(this.srchPassTXT);
            this.Controls.Add(this.UpdteBTN);
            this.Controls.Add(this.insrtBTN);
            this.Controls.Add(this.dltBTN);
            this.Controls.Add(this.EmpHeadLBL);
            this.Controls.Add(this.SrchBTN);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.extBTN);
            this.Controls.Add(this.password_TXT);
            this.Controls.Add(this.RoleTXT);
            this.Controls.Add(this.srchTXT);
            this.Controls.Add(this.usr_NmTXT);
            this.Controls.Add(this.SrchLBL);
            this.Controls.Add(this.password_LBL);
            this.Controls.Add(this.Role_LBL);
            this.Controls.Add(this.user_nameLBL);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manage_Employee";
            this.Text = "Manage_Employee";
            this.Load += new System.EventHandler(this.Manage_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpHeadLBL;
        private System.Windows.Forms.Button SrchBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Button extBTN;
        private System.Windows.Forms.TextBox password_TXT;
        private System.Windows.Forms.TextBox RoleTXT;
        private System.Windows.Forms.TextBox srchTXT;
        private System.Windows.Forms.TextBox usr_NmTXT;
        private System.Windows.Forms.Label SrchLBL;
        private System.Windows.Forms.Label password_LBL;
        private System.Windows.Forms.Label Role_LBL;
        private System.Windows.Forms.Label user_nameLBL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_GRD;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_GRD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role_GRD;
        private System.Windows.Forms.DataGridViewButtonColumn slctBTN;
        private System.Windows.Forms.Button dltBTN;
        private System.Windows.Forms.Button insrtBTN;
        private System.Windows.Forms.Button UpdteBTN;
        private System.Windows.Forms.TextBox srchPassTXT;
        private System.Windows.Forms.Label pswrdTopLBL;
    }
}
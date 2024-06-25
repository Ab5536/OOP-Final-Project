
namespace Business_Project_GUI
{
    partial class view_FeedBack
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
            this.custId_TXT = new System.Windows.Forms.TextBox();
            this.usr_NmTXT = new System.Windows.Forms.TextBox();
            this.cust_ID_LBL = new System.Windows.Forms.Label();
            this.user_nameLBL = new System.Windows.Forms.Label();
            this.viewBTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custId_TXT
            // 
            this.custId_TXT.Location = new System.Drawing.Point(723, 82);
            this.custId_TXT.Name = "custId_TXT";
            this.custId_TXT.Size = new System.Drawing.Size(100, 22);
            this.custId_TXT.TabIndex = 44;
            this.custId_TXT.TextChanged += new System.EventHandler(this.custId_TXT_TextChanged);
            // 
            // usr_NmTXT
            // 
            this.usr_NmTXT.Location = new System.Drawing.Point(723, 37);
            this.usr_NmTXT.Name = "usr_NmTXT";
            this.usr_NmTXT.Size = new System.Drawing.Size(100, 22);
            this.usr_NmTXT.TabIndex = 43;
            this.usr_NmTXT.TextChanged += new System.EventHandler(this.usr_NmTXT_TextChanged);
            // 
            // cust_ID_LBL
            // 
            this.cust_ID_LBL.AutoSize = true;
            this.cust_ID_LBL.Location = new System.Drawing.Point(554, 82);
            this.cust_ID_LBL.Name = "cust_ID_LBL";
            this.cust_ID_LBL.Size = new System.Drawing.Size(93, 17);
            this.cust_ID_LBL.TabIndex = 42;
            this.cust_ID_LBL.Text = "Customer ID: ";
            this.cust_ID_LBL.Click += new System.EventHandler(this.cust_ID_LBL_Click);
            // 
            // user_nameLBL
            // 
            this.user_nameLBL.AutoSize = true;
            this.user_nameLBL.Location = new System.Drawing.Point(554, 37);
            this.user_nameLBL.Name = "user_nameLBL";
            this.user_nameLBL.Size = new System.Drawing.Size(83, 17);
            this.user_nameLBL.TabIndex = 41;
            this.user_nameLBL.Text = "UserName: ";
            // 
            // viewBTN
            // 
            this.viewBTN.Location = new System.Drawing.Point(639, 129);
            this.viewBTN.Name = "viewBTN";
            this.viewBTN.Size = new System.Drawing.Size(137, 37);
            this.viewBTN.TabIndex = 46;
            this.viewBTN.Text = "View Feedback";
            this.viewBTN.UseVisualStyleBackColor = true;
            this.viewBTN.Click += new System.EventHandler(this.viewBTN_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(314, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(822, 493);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(178, 695);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(74, 37);
            this.backBTN.TabIndex = 48;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // view_FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 787);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.viewBTN);
            this.Controls.Add(this.custId_TXT);
            this.Controls.Add(this.usr_NmTXT);
            this.Controls.Add(this.cust_ID_LBL);
            this.Controls.Add(this.user_nameLBL);
            this.Name = "view_FeedBack";
            this.Text = "View_Feedback";
            this.Load += new System.EventHandler(this.View_Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox custId_TXT;
        private System.Windows.Forms.TextBox usr_NmTXT;
        private System.Windows.Forms.Label cust_ID_LBL;
        private System.Windows.Forms.Label user_nameLBL;
        private System.Windows.Forms.Button viewBTN;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button backBTN;
    }
}
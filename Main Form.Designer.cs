
namespace Business_Project_GUI
{
    partial class mainForm
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
            this.head = new System.Windows.Forms.Label();
            this.signinUser = new System.Windows.Forms.CheckBox();
            this.Help = new System.Windows.Forms.CheckBox();
            this.customer = new System.Windows.Forms.CheckBox();
            this.enterbtn = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.head.Location = new System.Drawing.Point(1101, 172);
            this.head.Name = "head";
            this.head.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.head.Size = new System.Drawing.Size(633, 58);
            this.head.TabIndex = 0;
            this.head.Text = "Departmental Store Managment System";
            // 
            // signinUser
            // 
            this.signinUser.AutoSize = true;
            this.signinUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinUser.Location = new System.Drawing.Point(1264, 369);
            this.signinUser.Name = "signinUser";
            this.signinUser.Size = new System.Drawing.Size(240, 33);
            this.signinUser.TabIndex = 2;
            this.signinUser.Text = "     SignIn as User";
            this.signinUser.UseVisualStyleBackColor = true;
            this.signinUser.CheckedChanged += new System.EventHandler(this.signinUser_CheckedChanged);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.Location = new System.Drawing.Point(1264, 629);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(125, 33);
            this.Help.TabIndex = 4;
            this.Help.Text = "     Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.CheckedChanged += new System.EventHandler(this.Help_CheckedChanged);
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(1264, 494);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(285, 33);
            this.customer.TabIndex = 5;
            this.customer.Text = "     Enter as Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.CheckedChanged += new System.EventHandler(this.customer_CheckedChanged);
            // 
            // enterbtn
            // 
            this.enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterbtn.Location = new System.Drawing.Point(1686, 751);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(88, 32);
            this.enterbtn.TabIndex = 7;
            this.enterbtn.Text = "Enter ";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBTN.Location = new System.Drawing.Point(1108, 751);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(88, 32);
            this.exitBTN.TabIndex = 9;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Business_Project_GUI.Properties.Resources._2302_w061_n005_95B_p1_95;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 1054);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.signinUser);
            this.Controls.Add(this.head);
            this.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "+ ";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.CheckBox signinUser;
        private System.Windows.Forms.CheckBox Help;
        private System.Windows.Forms.CheckBox customer;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBTN;
    }
}



namespace Business_Project_GUI
{
    partial class Employee_Menu
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
            this.cstmrLBL = new System.Windows.Forms.Label();
            this.PrdctLBL = new System.Windows.Forms.Label();
            this.BillLBL = new System.Windows.Forms.Label();
            this.fedbackLBL = new System.Windows.Forms.Label();
            this.choiceTXT = new System.Windows.Forms.TextBox();
            this.choiceLBL = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bckBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cstmrLBL
            // 
            this.cstmrLBL.AutoSize = true;
            this.cstmrLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cstmrLBL.Location = new System.Drawing.Point(1429, 211);
            this.cstmrLBL.Name = "cstmrLBL";
            this.cstmrLBL.Size = new System.Drawing.Size(151, 17);
            this.cstmrLBL.TabIndex = 35;
            this.cstmrLBL.Text = "1)  Manage Customers";
            // 
            // PrdctLBL
            // 
            this.PrdctLBL.AutoSize = true;
            this.PrdctLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrdctLBL.Location = new System.Drawing.Point(1429, 282);
            this.PrdctLBL.Name = "PrdctLBL";
            this.PrdctLBL.Size = new System.Drawing.Size(140, 17);
            this.PrdctLBL.TabIndex = 36;
            this.PrdctLBL.Text = "2)  Manage Products";
            // 
            // BillLBL
            // 
            this.BillLBL.AutoSize = true;
            this.BillLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BillLBL.Location = new System.Drawing.Point(1429, 450);
            this.BillLBL.Name = "BillLBL";
            this.BillLBL.Size = new System.Drawing.Size(97, 17);
            this.BillLBL.TabIndex = 38;
            this.BillLBL.Text = "4)  Check Bills";
            this.BillLBL.Click += new System.EventHandler(this.BillLBL_Click);
            // 
            // fedbackLBL
            // 
            this.fedbackLBL.AutoSize = true;
            this.fedbackLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fedbackLBL.Location = new System.Drawing.Point(1429, 373);
            this.fedbackLBL.Name = "fedbackLBL";
            this.fedbackLBL.Size = new System.Drawing.Size(135, 17);
            this.fedbackLBL.TabIndex = 39;
            this.fedbackLBL.Text = "3)  Check FeedBack";
            // 
            // choiceTXT
            // 
            this.choiceTXT.Location = new System.Drawing.Point(1619, 592);
            this.choiceTXT.Name = "choiceTXT";
            this.choiceTXT.Size = new System.Drawing.Size(100, 22);
            this.choiceTXT.TabIndex = 41;
            // 
            // choiceLBL
            // 
            this.choiceLBL.AutoSize = true;
            this.choiceLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.choiceLBL.Location = new System.Drawing.Point(1257, 597);
            this.choiceLBL.Name = "choiceLBL";
            this.choiceLBL.Size = new System.Drawing.Size(129, 17);
            this.choiceLBL.TabIndex = 40;
            this.choiceLBL.Text = "Enter Your choice: ";
            // 
            // Enter
            // 
            this.Enter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Enter.Location = new System.Drawing.Point(1774, 801);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 42;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1264, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 69);
            this.label1.TabIndex = 45;
            this.label1.Text = "Employee Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Business_Project_GUI.Properties.Resources.images;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 1039);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bckBTN
            // 
            this.bckBTN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bckBTN.Location = new System.Drawing.Point(1241, 801);
            this.bckBTN.Name = "bckBTN";
            this.bckBTN.Size = new System.Drawing.Size(75, 23);
            this.bckBTN.TabIndex = 46;
            this.bckBTN.Text = "Back";
            this.bckBTN.UseVisualStyleBackColor = true;
            this.bckBTN.Click += new System.EventHandler(this.bckBTN_Click);
            // 
            // Employee_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.bckBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.choiceTXT);
            this.Controls.Add(this.choiceLBL);
            this.Controls.Add(this.fedbackLBL);
            this.Controls.Add(this.BillLBL);
            this.Controls.Add(this.PrdctLBL);
            this.Controls.Add(this.cstmrLBL);
            this.Name = "Employee_Menu";
            this.Text = "Employee_Menu";
            this.Load += new System.EventHandler(this.Employee_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cstmrLBL;
        private System.Windows.Forms.Label PrdctLBL;
        private System.Windows.Forms.Label BillLBL;
        private System.Windows.Forms.Label fedbackLBL;
        private System.Windows.Forms.TextBox choiceTXT;
        private System.Windows.Forms.Label choiceLBL;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bckBTN;
    }
}
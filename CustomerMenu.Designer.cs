
namespace Business_Project_GUI
{
    partial class CustomerMenu
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
            this.buyProdbox = new System.Windows.Forms.CheckBox();
            this.ViewpurchaseBox = new System.Windows.Forms.CheckBox();
            this.feedbackBox = new System.Windows.Forms.CheckBox();
            this.Enterbtn = new System.Windows.Forms.Button();
            this.Head = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.myCart = new System.Windows.Forms.CheckBox();
            this.AllExtBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buyProdbox
            // 
            this.buyProdbox.AutoSize = true;
            this.buyProdbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyProdbox.Location = new System.Drawing.Point(1292, 371);
            this.buyProdbox.Name = "buyProdbox";
            this.buyProdbox.Size = new System.Drawing.Size(275, 40);
            this.buyProdbox.TabIndex = 1;
            this.buyProdbox.Text = "       Buy Product";
            this.buyProdbox.UseVisualStyleBackColor = true;
            this.buyProdbox.CheckedChanged += new System.EventHandler(this.buyProdbox_CheckedChanged);
            // 
            // ViewpurchaseBox
            // 
            this.ViewpurchaseBox.AutoSize = true;
            this.ViewpurchaseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewpurchaseBox.Location = new System.Drawing.Point(1292, 544);
            this.ViewpurchaseBox.Name = "ViewpurchaseBox";
            this.ViewpurchaseBox.Size = new System.Drawing.Size(458, 40);
            this.ViewpurchaseBox.TabIndex = 3;
            this.ViewpurchaseBox.Text = "      View Purchased Products";
            this.ViewpurchaseBox.UseVisualStyleBackColor = true;
            this.ViewpurchaseBox.CheckedChanged += new System.EventHandler(this.ViewpurchaseBox_CheckedChanged);
            // 
            // feedbackBox
            // 
            this.feedbackBox.AutoSize = true;
            this.feedbackBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBox.Location = new System.Drawing.Point(1292, 643);
            this.feedbackBox.Name = "feedbackBox";
            this.feedbackBox.Size = new System.Drawing.Size(306, 40);
            this.feedbackBox.TabIndex = 4;
            this.feedbackBox.Text = "      Give FeedBack";
            this.feedbackBox.UseVisualStyleBackColor = true;
            this.feedbackBox.CheckedChanged += new System.EventHandler(this.feedbackBox_CheckedChanged);
            // 
            // Enterbtn
            // 
            this.Enterbtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Enterbtn.FlatAppearance.BorderSize = 5;
            this.Enterbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Enterbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Enterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterbtn.Location = new System.Drawing.Point(1402, 740);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(106, 37);
            this.Enterbtn.TabIndex = 5;
            this.Enterbtn.Text = "Enter";
            this.Enterbtn.UseVisualStyleBackColor = true;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // Head
            // 
            this.Head.AutoSize = true;
            this.Head.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head.Location = new System.Drawing.Point(1097, 180);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(658, 81);
            this.Head.TabIndex = 6;
            this.Head.Text = "Customer Menu";
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(1734, 883);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 32);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // myCart
            // 
            this.myCart.AutoSize = true;
            this.myCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCart.Location = new System.Drawing.Point(1292, 456);
            this.myCart.Name = "myCart";
            this.myCart.Size = new System.Drawing.Size(236, 40);
            this.myCart.TabIndex = 8;
            this.myCart.Text = "       Your Cart";
            this.myCart.UseVisualStyleBackColor = true;
            this.myCart.CheckedChanged += new System.EventHandler(this.ViewChkBx_CheckedChanged);
            // 
            // AllExtBtn
            // 
            this.AllExtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllExtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllExtBtn.Location = new System.Drawing.Point(1074, 883);
            this.AllExtBtn.Name = "AllExtBtn";
            this.AllExtBtn.Size = new System.Drawing.Size(75, 32);
            this.AllExtBtn.TabIndex = 9;
            this.AllExtBtn.Text = "All Exit";
            this.AllExtBtn.UseVisualStyleBackColor = true;
            this.AllExtBtn.Click += new System.EventHandler(this.AllExtBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Business_Project_GUI.Properties.Resources.boy_inside_a_7_11_convenience_store__drink_aisle_i__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 1060);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AllExtBtn);
            this.Controls.Add(this.myCart);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.feedbackBox);
            this.Controls.Add(this.ViewpurchaseBox);
            this.Controls.Add(this.buyProdbox);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox buyProdbox;
        private System.Windows.Forms.CheckBox ViewpurchaseBox;
        private System.Windows.Forms.CheckBox feedbackBox;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.CheckBox myCart;
        private System.Windows.Forms.Button AllExtBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace Business_Project_GUI
{
    partial class Customer_Form
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
            this.signinCustomer = new System.Windows.Forms.CheckBox();
            this.continuewithoutLogin = new System.Windows.Forms.CheckBox();
            this.signUpCustomer = new System.Windows.Forms.CheckBox();
            this.enter = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.sideMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sideMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.Location = new System.Drawing.Point(1093, 64);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(745, 91);
            this.head.TabIndex = 0;
            this.head.Text = "Departmental Store";
            // 
            // signinCustomer
            // 
            this.signinCustomer.AutoSize = true;
            this.signinCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinCustomer.Location = new System.Drawing.Point(1256, 219);
            this.signinCustomer.Name = "signinCustomer";
            this.signinCustomer.Size = new System.Drawing.Size(342, 40);
            this.signinCustomer.TabIndex = 1;
            this.signinCustomer.Text = "   SignIn as Customer";
            this.signinCustomer.UseVisualStyleBackColor = true;
            this.signinCustomer.CheckedChanged += new System.EventHandler(this.signinCustomer_CheckedChanged);
            // 
            // continuewithoutLogin
            // 
            this.continuewithoutLogin.AutoSize = true;
            this.continuewithoutLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuewithoutLogin.Location = new System.Drawing.Point(1256, 576);
            this.continuewithoutLogin.Name = "continuewithoutLogin";
            this.continuewithoutLogin.Size = new System.Drawing.Size(393, 40);
            this.continuewithoutLogin.TabIndex = 2;
            this.continuewithoutLogin.Text = "   Continue without Login";
            this.continuewithoutLogin.UseVisualStyleBackColor = true;
            this.continuewithoutLogin.CheckedChanged += new System.EventHandler(this.continuewithoutLogin_CheckedChanged);
            // 
            // signUpCustomer
            // 
            this.signUpCustomer.AutoSize = true;
            this.signUpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpCustomer.Location = new System.Drawing.Point(1256, 387);
            this.signUpCustomer.Name = "signUpCustomer";
            this.signUpCustomer.Size = new System.Drawing.Size(356, 40);
            this.signUpCustomer.TabIndex = 4;
            this.signUpCustomer.Text = "   SignUp as Customer";
            this.signUpCustomer.UseVisualStyleBackColor = true;
            this.signUpCustomer.CheckedChanged += new System.EventHandler(this.signUpCustomer_CheckedChanged);
            // 
            // enter
            // 
            this.enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter.Location = new System.Drawing.Point(1714, 777);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 31);
            this.enter.TabIndex = 5;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // backbtn
            // 
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtn.Location = new System.Drawing.Point(1156, 777);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 29);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // sideMenu
            // 
            this.sideMenu.BackgroundImage = global::Business_Project_GUI.Properties.Resources.persona_mirando_movil_en_el_supermercado_plagado_d;
            this.sideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sideMenu.Location = new System.Drawing.Point(2, -2);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(980, 1036);
            this.sideMenu.TabIndex = 7;
            this.sideMenu.TabStop = false;
            this.sideMenu.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.signUpCustomer);
            this.Controls.Add(this.continuewithoutLogin);
            this.Controls.Add(this.signinCustomer);
            this.Controls.Add(this.head);
            this.Name = "Customer_Form";
            this.Text = "Customer_Form";
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sideMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.CheckBox signinCustomer;
        private System.Windows.Forms.CheckBox continuewithoutLogin;
        private System.Windows.Forms.CheckBox signUpCustomer;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.PictureBox sideMenu;
    }
}
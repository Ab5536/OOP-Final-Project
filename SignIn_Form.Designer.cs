
namespace Business_Project_GUI
{
    partial class SignIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn_Form));
            this.enterUsername = new System.Windows.Forms.Label();
            this.enterPassword = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.adminRole = new System.Windows.Forms.CheckBox();
            this.employeeRole = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toppic = new System.Windows.Forms.PictureBox();
            this.Signinbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppic)).BeginInit();
            this.SuspendLayout();
            // 
            // enterUsername
            // 
            resources.ApplyResources(this.enterUsername, "enterUsername");
            this.enterUsername.BackColor = System.Drawing.Color.Transparent;
            this.enterUsername.Name = "enterUsername";
            // 
            // enterPassword
            // 
            resources.ApplyResources(this.enterPassword, "enterPassword");
            this.enterPassword.Name = "enterPassword";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.usernameTxt, "usernameTxt");
            this.usernameTxt.Name = "usernameTxt";
            // 
            // passwordTxt
            // 
            resources.ApplyResources(this.passwordTxt, "passwordTxt");
            this.passwordTxt.Name = "passwordTxt";
            // 
            // backbtn
            // 
            resources.ApplyResources(this.backbtn, "backbtn");
            this.backbtn.Name = "backbtn";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // adminRole
            // 
            resources.ApplyResources(this.adminRole, "adminRole");
            this.adminRole.Name = "adminRole";
            this.adminRole.UseVisualStyleBackColor = true;
            this.adminRole.CheckedChanged += new System.EventHandler(this.adminRole_CheckedChanged);
            // 
            // employeeRole
            // 
            resources.ApplyResources(this.employeeRole, "employeeRole");
            this.employeeRole.Name = "employeeRole";
            this.employeeRole.UseVisualStyleBackColor = true;
            this.employeeRole.CheckedChanged += new System.EventHandler(this.employeeRole_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Business_Project_GUI.Properties.Resources.pngwing_com__1_;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Business_Project_GUI.Properties.Resources.pngwing_com;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // toppic
            // 
            this.toppic.BackColor = System.Drawing.Color.Transparent;
            this.toppic.BackgroundImage = global::Business_Project_GUI.Properties.Resources._360_F_97000908_wwH2goIihwrMoeV9QF3BW6HtpsVFaNVM_removebg_preview;
            resources.ApplyResources(this.toppic, "toppic");
            this.toppic.Name = "toppic";
            this.toppic.TabStop = false;
            // 
            // Signinbtn
            // 
            this.Signinbtn.AutoEllipsis = true;
            resources.ApplyResources(this.Signinbtn, "Signinbtn");
            this.Signinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Signinbtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Signinbtn.FlatAppearance.BorderSize = 5;
            this.Signinbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.UseCompatibleTextRendering = true;
            this.Signinbtn.UseVisualStyleBackColor = false;
            this.Signinbtn.Click += new System.EventHandler(this.Signinbtn_Click);
            // 
            // SignIn_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toppic);
            this.Controls.Add(this.employeeRole);
            this.Controls.Add(this.adminRole);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Signinbtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.enterPassword);
            this.Controls.Add(this.enterUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.SignIn_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterUsername;
        private System.Windows.Forms.Label enterPassword;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.CheckBox adminRole;
        private System.Windows.Forms.CheckBox employeeRole;
        private System.Windows.Forms.PictureBox toppic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Signinbtn;
    }
}
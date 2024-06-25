
namespace Business_Project_GUI
{
    partial class FeedBack_Form
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
            this.fdbckTXT = new System.Windows.Forms.RichTextBox();
            this.feedbackLBL = new System.Windows.Forms.Label();
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fdbckTXT
            // 
            this.fdbckTXT.Location = new System.Drawing.Point(161, 127);
            this.fdbckTXT.Name = "fdbckTXT";
            this.fdbckTXT.Size = new System.Drawing.Size(510, 96);
            this.fdbckTXT.TabIndex = 0;
            this.fdbckTXT.Text = "";
            this.fdbckTXT.TextChanged += new System.EventHandler(this.fdbckTXT_TextChanged);
            // 
            // feedbackLBL
            // 
            this.feedbackLBL.AutoSize = true;
            this.feedbackLBL.Location = new System.Drawing.Point(368, 47);
            this.feedbackLBL.Name = "feedbackLBL";
            this.feedbackLBL.Size = new System.Drawing.Size(71, 17);
            this.feedbackLBL.TabIndex = 1;
            this.feedbackLBL.Text = "FeedBack";
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.Location = new System.Drawing.Point(493, 306);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(75, 23);
            this.SubmitBTN.TabIndex = 2;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = true;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.Location = new System.Drawing.Point(190, 317);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(75, 23);
            this.backBTN.TabIndex = 3;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = true;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // FeedBack_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.SubmitBTN);
            this.Controls.Add(this.feedbackLBL);
            this.Controls.Add(this.fdbckTXT);
            this.Name = "FeedBack_Form";
            this.Text = "FeedBack_Form";
            this.Load += new System.EventHandler(this.FeedBack_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox fdbckTXT;
        private System.Windows.Forms.Label feedbackLBL;
        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.Button backBTN;
    }
}
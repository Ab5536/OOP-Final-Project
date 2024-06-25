
namespace Business_Project_GUI
{
    partial class ViewEarning
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
            this.MainLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainLBL
            // 
            this.MainLBL.AutoSize = true;
            this.MainLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLBL.Location = new System.Drawing.Point(176, 23);
            this.MainLBL.Name = "MainLBL";
            this.MainLBL.Size = new System.Drawing.Size(414, 69);
            this.MainLBL.TabIndex = 1;
            this.MainLBL.Text = "Total Earning ";
            // 
            // ViewEarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLBL);
            this.Name = "ViewEarning";
            this.Text = "ViewEarning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLBL;
    }
}
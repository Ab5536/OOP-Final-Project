using EZInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Project_GUI
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
           // inload();
        }

    
        private void Enter_Click(object sender, EventArgs e)
        {
            if (choiceTXT.Text == "1")
            {
                Manage_Products oneform = new Manage_Products();
                oneform.Show();

            }
            else if (choiceTXT.Text == "2")
            {
                Manage_Employee oneform = new Manage_Employee();
                oneform.Show();
            }
            else if (choiceTXT.Text == "3")
            {
                
            }
        }  

        private void choiceTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void bckBTN_Click(object sender, EventArgs e)
        {
            Program.firstForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

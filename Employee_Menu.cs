using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace Business_Project_GUI
{
    public partial class Employee_Menu : Form
    {
        public Employee_Menu()
        {
            InitializeComponent();
        }
        public void keyPressE()
        {
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                if (choiceTXT.Text == "1")
                {
                    manage_Customer mngCust = new manage_Customer();
                    mngCust.Show();
                    choiceTXT.Text = "";
                }
                else if (choiceTXT.Text == "2")
                {
                    Manage_Products oneform = new Manage_Products();
                    oneform.Show();
                }
                else if (choiceTXT.Text == "3")
                {

                }
            }
            
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            if (choiceTXT.Text == "1")
            {
                manage_Customer mngCust = new manage_Customer();
                mngCust.Show();
                choiceTXT.Text = "";
            }
            else if (choiceTXT.Text == "2")
            {
                Manage_Products oneform = new Manage_Products();
                oneform.Show();
            }
            else if (choiceTXT.Text == "3")
            {
                view_FeedBack viewf = new view_FeedBack();
                viewf.Show();
            }
        }

       
        private void Employee_Menu_Load(object sender, EventArgs e)
        {
            keyPressE();
        }

        private void BillLBL_Click(object sender, EventArgs e)
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

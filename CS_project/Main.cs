using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_project.PL;
namespace CS_project
{
    public partial class Main : Form
    {
        Home HOME;
        USER USER;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadHomePage();
        }

        private void NBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Statusbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void المهام_Click(object sender, EventArgs e)
        {

        }

      //home event
        private void bo_main_Click(object sender, EventArgs e)
        {
            loadHomePage();
           
        }

        private void bo_users_Click(object sender, EventArgs e)
        {
            // declare object from users screen and fill it on screen 
            USER = new USER();
            USER.Dock = DockStyle.Fill;
            //
            panel1.Controls.Clear();
            panel1.Controls.Add(USER);
            pn_status.Text = "المستخدمين";

        }
        private void loadHomePage()
        {
            HOME = new Home();
            HOME.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(HOME);
            pn_status.Text = "الرئيسية";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

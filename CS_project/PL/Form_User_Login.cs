
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CS_project.PL
{
    public partial class Form_User_Login : Form
    {
        DBTaskTrackerEntities db;
        TB_Users Users;
        public int id;
        public byte[] SelectedImageBytes { get; set; }

        public Form_User_Login()
        {
            InitializeComponent();
        }

        private void Form_User_Load(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bo_save_User_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("there is required things!!", "Wrong ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                try
                {
                    db = new DBTaskTrackerEntities();
                    Users = new TB_Users();



                    Users = db.TB_Users.Where(x => x.UserName == txt_username.Text && x.Password == txt_pass.Text).FirstOrDefault();

                    if (Users != null)
                    {
                        // Login

                        Main main = new Main();
                        main.Show();
                        if (Users.Role == "مستخدم")
                        {
                            main.bo_users.Enabled = false;

                        }
                        Users.State = "On";
                        Users.Password = Users.Password;
                        Users.UserName = Users.UserName;
                        Users.FullName = Users.FullName;
                        Users.Role = Users.Role;
                        db.Entry(Users).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        main.lb_userName.Text = Users.FullName;
                        main.lb_Role.Text = Users.Role;
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("wrong !!!");
                    }


                }

                catch
                {
                    MessageBox.Show(
                         "Unable to connect to the database",
                         "Unable to connect to the database",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);

                }

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_pass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.Properties.UseSystemPasswordChar = true;

            }
        }
    }
}


using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CS_project.PL
{
    public partial class Form_User_add : Form
    {
        DBTaskTrackerEntities db;
        TB_Users Users;
        public int id;
        public byte[] SelectedImageBytes { get; set; }

        public Form_User_add()
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
            if (txt_fullName.Text == "" || txt_username.Text == "" || txt_pass.Text == "" || combo_role.Items == null)
            {
                MessageBox.Show(
                    "Complete the rest of the requirements",
                    "There is a problem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
            else
            {
                //duplicated 
                try
                {

                    db = new DBTaskTrackerEntities();
                    Users = new TB_Users();
                    //بحدد اللي انا عايزه
                    var data = db.TB_Users.Where(x => x.UserName == txt_username.Text && x.ID != id).FirstOrDefault();

                    if (data != null)
                    {
                        MessageBox.Show(
                        "Duplecated Username",
                        "There is a problem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (id == 0)
                        {
                            // add 
                            AddData();
                            Close();
                        }
                        else
                        {
                            // edit 
                            editData();
                            Close();
                        }
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

        private void AddData()
        {
            try
            {
                db = new DBTaskTrackerEntities();
                Users = new TB_Users();
                Users.FullName = txt_fullName.Text;
                Users.UserName = txt_username.Text;
                Users.Password = txt_pass.Text;
                Users.Role = combo_role.SelectedItem.ToString();
                Users.State = "OFF";

   
                Users.image = SelectedImageBytes;

                // Save
                db.Entry(Users).State = EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("f66e5a5d-e43d-4a68-9d46-20d520eba532");
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

        private void editData()
        {
            try
            {
                db = new DBTaskTrackerEntities();
                Users = new TB_Users();
                Users.ID = id;

                Users.FullName = txt_fullName.Text;
                Users.UserName = txt_username.Text;
                Users.Password = txt_pass.Text;
                Users.Role = combo_role.SelectedItem.ToString();
                Users.State = Users.State;
                Users.image = SelectedImageBytes;

                // احفظ في الداتا بيز يامعلم
                db.Entry(Users).State = EntityState.Modified;
                db.SaveChanges();
                // تسلم ايدك
                toastNotificationsManager1.ShowNotification("b01df8e2-9ed5-481b-beb4-249210feb074");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = dialog.FileName;

                SelectedImageBytes = System.IO.File.ReadAllBytes(dialog.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked== true) 
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

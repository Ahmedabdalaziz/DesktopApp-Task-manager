
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CS_project.PL
{
    public partial class USER : DevExpress.XtraEditors.XtraUserControl
    {
        // main var

        DBTaskTrackerEntities db;
        TB_Users Users;
        Form_User_add form_add;
        public int id;

        public USER()
        {
            InitializeComponent();
            CS_project.DBTaskTrackerEntities dbContext = new CS_project.DBTaskTrackerEntities();
            dbContext.TB_Users.Load();
            gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
        }

        private void bot_add_Click(object sender, EventArgs e)
        {
            form_add = new Form_User_add();
            form_add.id = 0;
            form_add.bo_save_User.Text = "اضافة";

            if (form_add.ShowDialog() == DialogResult.OK)
            {
                byte[] selectedImageBytes = form_add.SelectedImageBytes;
                SaveImageToDatabase(selectedImageBytes);

            }
            UserUpdate();

        }


        private void bot_edit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
            if (id == 0)
            {
                MessageBox.Show(
                    "There is no data to modify",
                    "what should I do ?",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                db = new DBTaskTrackerEntities();
                Users = new TB_Users();

                Users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                //
                form_add = new Form_User_add();
                form_add.id = id;
                form_add.bo_save_User.Text = "تعديل";
                //

                form_add.txt_fullName.Text = Users.FullName;
                form_add.txt_pass.Text = Users.Password;
                form_add.txt_username.Text = Users.UserName;
                form_add.combo_role.SelectedItem = Users.State;
                form_add.SelectedImageBytes=Users.image;
                //
                if (form_add.ShowDialog() == DialogResult.OK)
                {
                    byte[] selectedImageBytes = form_add.SelectedImageBytes;
                    SaveImageToDatabase(selectedImageBytes);
                }
            }

            UserUpdate();

        }

        private void bot_delete_Click(object sender, EventArgs e)
        {
            var ms = MessageBox.Show("Sure to delete ?", "sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // check if there is column to delete or no

            if (ms == DialogResult.OK)
            {
                try
                {
                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show(
                            "There is no data to delete",
                            "!!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db = new DBTaskTrackerEntities();
                        Users = new TB_Users();
                        // نفس الاي دي اللي في الداتا بيز يامعلم
                        Users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();

                        db.Entry(Users).State = EntityState.Deleted;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("0efb0bb3-c5d1-4244-8498-37a61bd42ffe");
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
            UserUpdate();

        }

        private void SaveImageToDatabase(byte[] imageBytes)
        {
            try
            {
                Users = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                Users.image = imageBytes;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save image to the database: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //update the data to columns
        public void UserUpdate()
        {
            try
            {
                db = new DBTaskTrackerEntities();
                gridControl1.DataSource = db.TB_Users.ToList();
            }
            catch
            {
                MessageBox.Show("faild connection with database!",
                    "there is connection error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}



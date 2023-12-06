using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_project.PL
{
    public partial class Form_User_add : Form
    {
        DBTaskTrackerEntities db;
        TB_Users Users;
        public int id ;


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
            //check faild
            if(txt_fullName.Text==""|| txt_username.Text ==""|| txt_pass.Text ==""||combo_role.Items==null)
            {
                MessageBox.Show(
                    "كمل باقي المتطلبات يحبيب اخوك",
                    "خطأ في الاضافة يامعلم",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
               
            }
            else
            {
                if (id== 0)
                {
                    //add items
                    AddData();
                    Close();
                }
                else
                {
                    // edit item
                    editData();
                    Close();

                }
            }
        }

        private void AddData()
        {
            try {

                db = new DBTaskTrackerEntities();
                Users = new TB_Users();
                Users.FullName = txt_fullName.Text;
                Users.UserName = txt_username.Text;
                Users.Password = txt_pass.Text;
                Users.Role = combo_role.SelectedItem.ToString();
                Users.State = "OFF";

                //save database changes 
                db.Entry(Users).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("f66e5a5d-e43d-4a68-9d46-20d520eba532");
                //notfication 

            }
            catch {
                MessageBox.Show(
                    "مش عارف اوصل للداتا بيز ياعمدة",
                    "فيه حوار مع الاتصال",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            
        private void editData()
        {
            try
            {
                db = new DBTaskTrackerEntities();
                Users = new TB_Users();
                Users.ID = id;
                // 
                Users.FullName = txt_fullName.Text;
                Users.UserName = txt_username.Text;
                Users.Password = txt_pass.Text;
                Users.Role = combo_role.SelectedItem.ToString();
                Users.State = Users.State;

                //save database changes 
                db.Entry(Users).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //notfication 
                toastNotificationsManager1.ShowNotification("b01df8e2-9ed5-481b-beb4-249210feb074");
            }
            catch
            {
                MessageBox.Show(
                    "مش عارف اوصل للداتا بيز ياعمدة",
                    "فيه حوار مع الاتصال",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
    }
}

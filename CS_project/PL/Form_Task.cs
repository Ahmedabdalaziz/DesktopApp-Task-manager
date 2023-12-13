
using DevExpress.XtraCharts;
using DevExpress.XtraGrid;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace CS_project.PL
{
    public partial class Form_Task : Form
    {

        DBTaskTrackerEntities db;
        public string taskState;
        TB_Tasks Tasks;

        public int id;
        public byte[] SelectedImageBytes { get; set; }

        public Form_Task()
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
            if (txt_TaskName.Text == "" || txt_TaskDesc.Text == "")
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
                    Tasks = new TB_Tasks();

                    //بحدد اللي انا عايزه
                    var data = db.TB_Tasks.Where(x => x.Task_Name == txt_TaskName.Text&& x.ID== id).FirstOrDefault();

                    if (data != null)
                    {
                        MessageBox.Show(
                            "Duplicated Project Name",
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
                Tasks = new TB_Tasks();
                var iduser = db.TB_Users.Where(x => x.FullName == combo_user.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                var idproject = db.TB_Projects.Where(x => x.ProjectName == combo_project.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                Tasks.Task_Name = txt_TaskName.Text;
                Tasks.Task_Desc = txt_TaskDesc.Text;
                Tasks.Task_Admin = combo_admin.SelectedItem.ToString();
                Tasks.Task_User = combo_user.SelectedItem.ToString();
                Tasks.Task_Project = combo_project.SelectedItem.ToString();
                Tasks.Task_State = taskState;
                Tasks.Task_End = date_end.Value;
                Tasks.Task_Start = date_start.Value;
                Tasks.Task_Duration = Convert.ToInt16(days.Text);
                Tasks.ID_Project = idproject;
                Tasks.ID_User = iduser;
                // Save
                db.Entry(Tasks).State = EntityState.Added;
                db.SaveChanges();
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
            var data = db.TB_Tasks.Where(x => x.Task_Name == txt_TaskName.Text && x.ID != id).FirstOrDefault();

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
                try
                {
                    db = new DBTaskTrackerEntities();
                    Tasks = new TB_Tasks();
                    Tasks.ID = id;
                    var iduser = db.TB_Users.Where(x => x.FullName == combo_user.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                    var idproject = db.TB_Projects.Where(x => x.ProjectName == combo_project.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                    Tasks.Task_Name = txt_TaskName.Text;
                    Tasks.Task_Admin = combo_admin.SelectedItem.ToString();
                    Tasks.Task_User = combo_user.SelectedItem.ToString();
                    Tasks.Task_Project = combo_project.SelectedItem.ToString();
                    Tasks.Task_Desc = txt_TaskDesc.Text;
                    Tasks.Task_Start = date_start.Value;
                    Tasks.Task_End = date_start.Value;
                    Tasks.Task_Duration = Convert.ToInt16(days.Text);
                    Tasks.Task_State = taskState;
                    Tasks.ID_User = iduser;
                    Tasks.ID_Project = idproject;

                    db.Entry(Tasks).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_projDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form_Task_Activated(object sender, EventArgs e)
        {
            db = new DBTaskTrackerEntities();
            combo_admin.DataSource = db.TB_Users.Select(x=>x.FullName).ToList();
            combo_project.DataSource = db.TB_Projects.Select(x => x.ProjectName).ToList();
            combo_user.DataSource = db.TB_Users.Select(x => x.FullName).ToList();

            combo_admin.SelectedIndex = -1; 
            combo_user.SelectedIndex = -1; 

            FilterAdminComboBox();
            FilterUserComboBox();

        }

        private void FilterUserComboBox()
        {
            var Users = db.TB_Users.Where(u => u.Role == "مستخدم").Select(x => x.FullName).ToList();

            combo_admin.DataSource = Users;
        }

        private void FilterAdminComboBox()
        {
            var admins = db.TB_Users.Where(u => u.Role == "مدير").Select(x => x.FullName).ToList();

            combo_admin.DataSource = admins;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Form_Project project = new Form_Project();
            project.Show();
        }

        private void TaskDate()
        {
            var numberOFdays = (date_end.Value-date_start.Value).Days;
            days.Text = numberOFdays.ToString();

            if (numberOFdays == 0)
            {
                taskState = "النهاردة";
            }
            else if (numberOFdays == 1)
            {
                taskState = "بكرا";
            }
            else if (numberOFdays > 1)
            {
                taskState = " فاضل" + numberOFdays.ToString() + " يوم";
            }
            //else if (numberOFdays < 1)
            //{
            //    taskState = "غير مكتمل";
            //}
            else if (numberOFdays < 0)
            {
                taskState = "فائتة";
                MessageBox.Show(
                        "لا يمكن اضافة مهمة بتاريخ منتهي",
                        "لا يمكن اضافة مهمة بتاريخ منتهي",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

            }
            

        }

        public void date_start_ValueChanged(object sender, EventArgs e)
        {
            TaskDate();
        }

        public void date_end_ValueChanged(object sender, EventArgs e)
        {
            TaskDate();
        }

        private void sBox_Enter(object sender, EventArgs e)
        {

        }

        private void combo_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}


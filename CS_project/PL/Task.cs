using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace CS_project.PL
{
    public partial class Task : DevExpress.XtraEditors.XtraUserControl
    {
        // main var

        DBTaskTrackerEntities db;
        TB_Tasks Tasks;
        Form_Task Form_Task;
        
        public int id;



        public Task()
        {
            InitializeComponent();

           
            CS_project.DBTaskTrackerEntities dbContext = new CS_project.DBTaskTrackerEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Tasks.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Tasks.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void bot_add_Click(object sender, EventArgs e)
        {
            Form_Task = new Form_Task();
            Form_Task.id = 0;
            Form_Task.bo_save_User.Text = "اضافة";
            Form_Task.ShowDialog();

            toastNotificationsManager1.ShowNotification("73551e88-41de-4556-afd9-c94363af8ff6");
            UserUpdate();

        }


        //update data from database

        private void bot_edit_Click(object sender, EventArgs e)
        {

            try
            {

                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id == 0)
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها", "خطأ في عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    db = new DBTaskTrackerEntities();
                    Tasks = new TB_Tasks();
                    Tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();

                    Form_Task = new Form_Task();
                    Form_Task.id = id;
                    Form_Task.bo_save_User.Text = "تعديل";

                    ///
                    Tasks.ID = id;
                    Form_Task.txt_TaskName.Text= Tasks.Task_Name;
                    


                    Form_Task.Show();
                    toastNotificationsManager1.ShowNotification("19f5610e-707b-4ee8-b76a-a16ded18e8d8");
                    UserUpdate();


                }

            }
            catch
            {
                MessageBox.Show("فقد الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void bot_delete_Click(object sender, EventArgs e)
        {
            // Remove

            var ms = MessageBox.Show("sure to delete?", "sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (ms == DialogResult.OK)
            {
                try
                {

                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show(
                        "There is no data to delete",
                        "delete what?",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db = new DBTaskTrackerEntities();
                        Tasks = new TB_Tasks();

                        Tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(Tasks).State = EntityState.Deleted;
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


        //update
        public void UserUpdate()
        {
            try
            {
                db = new DBTaskTrackerEntities();
                gridControl1.DataSource = db.TB_Tasks.ToList();
            }
            catch
            {
                MessageBox.Show("faild connection with database!",
                    "there is connection error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void bom_done_Click(object sender, EventArgs e)
        {
            var ms = MessageBox.Show("sure to Make it done?", "sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (ms == DialogResult.OK)
            {
                try
                {

                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show(
                        "There is no data to Make it",
                        "done what ??",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                    else
                    {
                        db = new DBTaskTrackerEntities();
                        Tasks = new TB_Tasks();
                        Tasks.ID = id;
                        Tasks = db.TB_Tasks.Where(x => x.ID == id).FirstOrDefault();
                        Tasks.Task_Name = Tasks.Task_Name;
                        Tasks.Task_Admin = Tasks.Task_Admin;
                        Tasks.Task_User = Tasks.Task_User;
                        Tasks.Task_Project = Tasks.Task_Project;
                        Tasks.Task_Desc = Tasks.Task_Desc;
                        Tasks.Task_Start = Tasks.Task_Start;
                        Tasks.Task_End = Tasks.Task_End;
                        Tasks.Task_Duration = Tasks.Task_Duration;
                        Tasks.Task_State = "Done!";
                        Tasks.ID_User = Tasks.ID_User;
                        Tasks.ID_Project = Tasks.ID_Project;

                        db.Entry(Tasks).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        toastNotificationsManager1.ShowNotification("e1f9d2a3-8303-4942-8633-6e90d70448cd");
                        UserUpdate();

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
    }
}

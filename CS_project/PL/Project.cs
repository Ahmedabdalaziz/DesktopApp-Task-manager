using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace CS_project.PL
{
    public partial class Project : DevExpress.XtraEditors.XtraUserControl
    {
        // main var

        DBTaskTrackerEntities db;
        TB_Projects Projects;
        public int id;
        Form_Project Form_Project;

        public Project()
        {
            InitializeComponent();
            
            CS_project.DBTaskTrackerEntities dbContext = new CS_project.DBTaskTrackerEntities();
            dbContext.TB_Projects.Load();
            
            gridControl1.DataSource = dbContext.TB_Projects.Local.ToBindingList();
          
            dbContext.TB_Projects.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Projects.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void bot_add_Click(object sender, EventArgs e)
        {
            Form_Project = new Form_Project();
            Form_Project.id = 0;
            Form_Project.bo_save_User.Text = "اضافة";
            Form_Project.ShowDialog();

            UserUpdate();
        }


        //update data from database

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
                Projects = new TB_Projects();

                Projects = db.TB_Projects.Where(x => x.ID == id).FirstOrDefault();
                //
                Form_Project = new Form_Project();
                Form_Project.id = id;
                Form_Project.bo_save_User.Text = "تعديل";
                //

                Form_Project.txt_projName.Text = Projects.ProjectName;
                Form_Project.txt_projDesc.Text = Projects.ProjectDes;
                //
                
            }

            UserUpdate();

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
                        Projects = new TB_Projects();

                        Projects = db.TB_Projects.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(Projects).State = EntityState.Deleted;
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
                gridControl1.DataSource = db.TB_Projects.ToList();
            }
            catch
            {
                MessageBox.Show("faild connection with database!",
                    "there is connection error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


    }
}

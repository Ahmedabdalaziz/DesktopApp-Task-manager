using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CS_project.PL
{
    public partial class Project : DevExpress.XtraEditors.XtraUserControl
    {
        // main var

        DBTaskTrackerEntities db;
        TB_Projects Projects;
        public int id;

        public Project()
        {
            InitializeComponent();
            
            CS_project.DBTaskTrackerEntities dbContext = new CS_project.DBTaskTrackerEntities();
            dbContext.TB_Users.Load();
            
            gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
          
            dbContext.TB_Projects.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Projects.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void bot_add_Click(object sender, EventArgs e)
        {
        }

        private void bot_update_Click(object sender, EventArgs e)
        {
            UserUpdate();
        }
        //update data from database
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

        private void bot_edit_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
            if (id == 0)
            {
                MessageBox.Show(
                "سلامة نظرك, مفيش حاجة تتعدل",
                "نعدلواايه؟",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                db = new DBTaskTrackerEntities();
                Projects = new TB_Projects();

                //هحدد اللي انا عايز اعدلها
                Projects = db.TB_Projects.Where(x => x.ID == id).FirstOrDefault();
               

            }



        }

        private void bot_delete_Click(object sender, EventArgs e)
        {
            // Remove

            var ms = MessageBox.Show("انت متأكد من الحذف؟", "هببت ايه؟", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (ms == DialogResult.OK)
            {
                try
                {

                    id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show(
                        "سلامة نظرك, مفيش حاجة تتمسح",
                        "امسح ايه؟",
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
                        "مش عارف اوصل للداتا بيز ياعمدة",
                        "فيه حوار مع الاتصال ازميلي",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

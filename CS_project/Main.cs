using CS_project.PL;
using System;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;

namespace CS_project
{
    public partial class Main : Form
    {

        DBTaskTrackerEntities db;
        TB_Notes Note;
        Home HOME;
        USER USER;
        Project Project;
        Task Task;
        int id;
        public Main()
        {
            InitializeComponent();

            
            

        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadHomePage();
            Notification();
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

        private void Tasks_Click(object sender, EventArgs e)
        {
            // declare object from users screen and fill it on screen 
            Task = new Task();
            Task.Dock = DockStyle.Fill;
            //
            panel1.Controls.Clear();
            panel1.Controls.Add(Task);
            pn_status.Text = "المهام";

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

        private void bo_project_Click(object sender, EventArgs e)
        {
            Project = new Project();
            Project.Dock = DockStyle.Fill;
            //
            panel1.Controls.Clear();
            panel1.Controls.Add(Project);
            pn_status.Text = "المشروع";
        }

        private void notification_Icon_Click(object sender, EventArgs e)
        {
            transitionManager1.StartTransition(gridControl1);
            gridControl1.Visible = true;
            transitionManager1.EndTransition();
        }



        private void gridControl1_MouseLeave(object sender, EventArgs e)
        {
            transitionManager1.StartTransition(gridControl1);
            gridControl1.Visible = false;
            transitionManager1.EndTransition();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        
        private void Notification()
        {
                    
            db = new DBTaskTrackerEntities();
            gridControl1.DataSource = db.TB_Notes.Where(x => x.Note_User == lb_userName.Text).ToList();

            var countt = db.TB_Notes.Where(x => x.Note_User == lb_userName.Text).Select(x=>x.ID).ToList();

            notification_Icon.Text = countt.Count.ToString();

        }

        private void tileView1_DoubleClick(object sender, EventArgs e)
        {
            

            id = Convert.ToInt16(tileView1.GetFocusedRowCellValue("ID"));
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
                Note = new TB_Notes();
                Note = db.TB_Notes.Where(x => x.ID == id).FirstOrDefault();
                db.Entry(Note).State = EntityState.Deleted;
                db.SaveChanges();
                Notification();
            }
        }

        private void lb_userName_Click(object sender, EventArgs e)
        {

        }
    }
}

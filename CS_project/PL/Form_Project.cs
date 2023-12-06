
using DevExpress.XtraGrid;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CS_project.PL
{
    public partial class Form_Project : Form
    {
        DBTaskTrackerEntities db;
        TB_Projects project;

        public int id;
        public byte[] SelectedImageBytes { get; set; }

        public Form_Project()
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
            if (txt_projName.Text == "" || txt_projDesc.Text == "")
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
                    project = new TB_Projects();

                    //بحدد اللي انا عايزه
                    var data = db.TB_Projects.Where(x => x.ProjectName == txt_projName.Text&& x.ID== id).FirstOrDefault();

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
                project = new TB_Projects();

                project.ProjectName = txt_projName.Text;
                project.ProjectDes = txt_projDesc.Text;

                // Save
                db.Entry(project).State = EntityState.Added;
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
                project = db.TB_Projects.Find(id);

                if (project != null)
                {
                    // Update project properties
                    project.ProjectName = txt_projName.Text;
                    project.ProjectDes = txt_projDesc.Text;

                    // Save changes
                    db.Entry(project).State = EntityState.Modified;
                    db.SaveChanges();
                    toastNotificationsManager1.ShowNotification("b01df8e2-9ed5-481b-beb4-249210feb074");
                }
                else
                {
                    MessageBox.Show(
                        "Project not found",
                        "Unable to update",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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


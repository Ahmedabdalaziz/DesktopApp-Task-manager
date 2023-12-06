namespace CS_project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NBar = new System.Windows.Forms.Panel();
            this.pl_cont = new System.Windows.Forms.FlowLayoutPanel();
            this.bo_main = new DevExpress.XtraEditors.SimpleButton();
            this.bo_users = new DevExpress.XtraEditors.SimpleButton();
            this.bo_tasks = new DevExpress.XtraEditors.SimpleButton();
            this.bo_project = new DevExpress.XtraEditors.SimpleButton();
            this.bo_help = new DevExpress.XtraEditors.SimpleButton();
            this.Statusbar = new System.Windows.Forms.Panel();
            this.pn_status = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lb_Role = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NBar.SuspendLayout();
            this.pl_cont.SuspendLayout();
            this.Statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NBar
            // 
            this.NBar.Controls.Add(this.pl_cont);
            this.NBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NBar.Location = new System.Drawing.Point(0, 0);
            this.NBar.Name = "NBar";
            this.NBar.Size = new System.Drawing.Size(1062, 80);
            this.NBar.TabIndex = 0;
            this.NBar.Paint += new System.Windows.Forms.PaintEventHandler(this.NBar_Paint);
            // 
            // pl_cont
            // 
            this.pl_cont.BackColor = System.Drawing.Color.White;
            this.pl_cont.Controls.Add(this.bo_main);
            this.pl_cont.Controls.Add(this.bo_users);
            this.pl_cont.Controls.Add(this.bo_tasks);
            this.pl_cont.Controls.Add(this.bo_project);
            this.pl_cont.Controls.Add(this.bo_help);
            this.pl_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_cont.Location = new System.Drawing.Point(0, 0);
            this.pl_cont.Name = "pl_cont";
            this.pl_cont.Padding = new System.Windows.Forms.Padding(5);
            this.pl_cont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pl_cont.Size = new System.Drawing.Size(1062, 80);
            this.pl_cont.TabIndex = 0;
            // 
            // bo_main
            // 
            this.bo_main.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_main.Appearance.Options.UseFont = true;
            this.bo_main.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_main.ImageOptions.Image")));
            this.bo_main.Location = new System.Drawing.Point(855, 8);
            this.bo_main.Name = "bo_main";
            this.bo_main.Size = new System.Drawing.Size(194, 66);
            this.bo_main.TabIndex = 0;
            this.bo_main.Text = "الرئيسية";
            this.bo_main.Click += new System.EventHandler(this.bo_main_Click);
            // 
            // bo_users
            // 
            this.bo_users.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_users.Appearance.Options.UseFont = true;
            this.bo_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_users.ImageOptions.Image")));
            this.bo_users.Location = new System.Drawing.Point(655, 8);
            this.bo_users.Name = "bo_users";
            this.bo_users.Size = new System.Drawing.Size(194, 66);
            this.bo_users.TabIndex = 3;
            this.bo_users.Text = "المستخدمين";
            this.bo_users.Click += new System.EventHandler(this.bo_users_Click);
            // 
            // bo_tasks
            // 
            this.bo_tasks.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_tasks.Appearance.Options.UseFont = true;
            this.bo_tasks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_tasks.ImageOptions.Image")));
            this.bo_tasks.Location = new System.Drawing.Point(455, 8);
            this.bo_tasks.Name = "bo_tasks";
            this.bo_tasks.Size = new System.Drawing.Size(194, 66);
            this.bo_tasks.TabIndex = 1;
            this.bo_tasks.Text = "المهام";
            this.bo_tasks.Click += new System.EventHandler(this.Tasks_Click);
            // 
            // bo_project
            // 
            this.bo_project.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_project.Appearance.Options.UseFont = true;
            this.bo_project.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_project.ImageOptions.Image")));
            this.bo_project.Location = new System.Drawing.Point(255, 8);
            this.bo_project.Name = "bo_project";
            this.bo_project.Size = new System.Drawing.Size(194, 66);
            this.bo_project.TabIndex = 2;
            this.bo_project.Text = "المشاريع";
            // 
            // bo_help
            // 
            this.bo_help.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_help.Appearance.Options.UseFont = true;
            this.bo_help.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_help.ImageOptions.Image")));
            this.bo_help.Location = new System.Drawing.Point(55, 8);
            this.bo_help.Name = "bo_help";
            this.bo_help.Size = new System.Drawing.Size(194, 66);
            this.bo_help.TabIndex = 4;
            this.bo_help.Text = "مساعدة";
            this.bo_help.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // Statusbar
            // 
            this.Statusbar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Statusbar.Controls.Add(this.pn_status);
            this.Statusbar.Controls.Add(this.simpleButton1);
            this.Statusbar.Controls.Add(this.lb_Role);
            this.Statusbar.Controls.Add(this.lb_userName);
            this.Statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Statusbar.Location = new System.Drawing.Point(0, 619);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(1062, 54);
            this.Statusbar.TabIndex = 1;
            this.Statusbar.Paint += new System.Windows.Forms.PaintEventHandler(this.Statusbar_Paint);
            // 
            // pn_status
            // 
            this.pn_status.AutoSize = true;
            this.pn_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_status.ForeColor = System.Drawing.Color.White;
            this.pn_status.Location = new System.Drawing.Point(932, 12);
            this.pn_status.Name = "pn_status";
            this.pn_status.Size = new System.Drawing.Size(77, 36);
            this.pn_status.TabIndex = 6;
            this.pn_status.Text = "مستعد";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(50, 51);
            this.simpleButton1.TabIndex = 5;
            // 
            // lb_Role
            // 
            this.lb_Role.AutoSize = true;
            this.lb_Role.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Role.ForeColor = System.Drawing.Color.White;
            this.lb_Role.Location = new System.Drawing.Point(436, 12);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(67, 36);
            this.lb_Role.TabIndex = 2;
            this.lb_Role.Text = "CEO";
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.ForeColor = System.Drawing.Color.White;
            this.lb_userName.Location = new System.Drawing.Point(563, 12);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(63, 36);
            this.lb_userName.TabIndex = 1;
            this.lb_userName.Text = "أحمد";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 539);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.NBar);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaskTracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.NBar.ResumeLayout(false);
            this.pl_cont.ResumeLayout(false);
            this.Statusbar.ResumeLayout(false);
            this.Statusbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NBar;
        private System.Windows.Forms.Panel Statusbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pl_cont;
        private DevExpress.XtraEditors.SimpleButton bo_main;
        private DevExpress.XtraEditors.SimpleButton bo_users;
        private DevExpress.XtraEditors.SimpleButton bo_tasks;
        private DevExpress.XtraEditors.SimpleButton bo_project;
        private DevExpress.XtraEditors.SimpleButton bo_help;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label pn_status;
    }
}


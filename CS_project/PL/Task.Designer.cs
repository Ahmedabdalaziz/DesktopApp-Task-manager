namespace CS_project.PL
{
    partial class Task
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bom_done = new DevExpress.XtraEditors.SimpleButton();
            this.bot_edit = new DevExpress.XtraEditors.SimpleButton();
            this.bot_delete = new DevExpress.XtraEditors.SimpleButton();
            this.bot_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTask_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Project = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Admin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Duration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bom_done);
            this.panel1.Controls.Add(this.bot_edit);
            this.panel1.Controls.Add(this.bot_delete);
            this.panel1.Controls.Add(this.bot_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 84);
            this.panel1.TabIndex = 0;
            // 
            // bom_done
            // 
            this.bom_done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bom_done.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bom_done.Appearance.Options.UseFont = true;
            this.bom_done.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bom_done.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bom_done.ImageOptions.SvgImage")));
            this.bom_done.Location = new System.Drawing.Point(647, 9);
            this.bom_done.Name = "bom_done";
            this.bom_done.Size = new System.Drawing.Size(98, 66);
            this.bom_done.TabIndex = 3;
            this.bom_done.Text = "Delete";
            this.bom_done.Click += new System.EventHandler(this.bom_done_Click);
            // 
            // bot_edit
            // 
            this.bot_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot_edit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_edit.Appearance.Options.UseFont = true;
            this.bot_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bot_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bot_edit.ImageOptions.SvgImage")));
            this.bot_edit.Location = new System.Drawing.Point(543, 9);
            this.bot_edit.Name = "bot_edit";
            this.bot_edit.Size = new System.Drawing.Size(98, 66);
            this.bot_edit.TabIndex = 2;
            this.bot_edit.Text = "Edit";
            this.bot_edit.Click += new System.EventHandler(this.bot_edit_Click);
            // 
            // bot_delete
            // 
            this.bot_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_delete.Appearance.Options.UseFont = true;
            this.bot_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bot_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bot_delete.ImageOptions.SvgImage")));
            this.bot_delete.Location = new System.Drawing.Point(439, 9);
            this.bot_delete.Name = "bot_delete";
            this.bot_delete.Size = new System.Drawing.Size(98, 66);
            this.bot_delete.TabIndex = 2;
            this.bot_delete.Text = "Delete";
            this.bot_delete.Click += new System.EventHandler(this.bot_delete_Click);
            // 
            // bot_add
            // 
            this.bot_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot_add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_add.Appearance.Options.UseFont = true;
            this.bot_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bot_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bot_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bot_add.ImageOptions.SvgImage")));
            this.bot_add.Location = new System.Drawing.Point(335, 9);
            this.bot_add.Name = "bot_add";
            this.bot_add.Size = new System.Drawing.Size(98, 66);
            this.bot_add.TabIndex = 2;
            this.bot_add.Text = "Add";
            this.bot_add.Click += new System.EventHandler(this.bot_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(CS_project.TB_Tasks);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1080, 636);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTask_Name,
            this.colTask_Project,
            this.colTask_Admin,
            this.colTask_User,
            this.colTask_Desc,
            this.colTask_Start,
            this.colTask_End,
            this.colTask_State,
            this.colTask_Duration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colTask_Name
            // 
            this.colTask_Name.Caption = "اسم المهمة";
            this.colTask_Name.FieldName = "Task_Name";
            this.colTask_Name.MinWidth = 25;
            this.colTask_Name.Name = "colTask_Name";
            this.colTask_Name.Visible = true;
            this.colTask_Name.VisibleIndex = 0;
            this.colTask_Name.Width = 94;
            // 
            // colTask_Project
            // 
            this.colTask_Project.Caption = "اسم المشروع";
            this.colTask_Project.FieldName = "Task_Project";
            this.colTask_Project.MinWidth = 25;
            this.colTask_Project.Name = "colTask_Project";
            this.colTask_Project.Visible = true;
            this.colTask_Project.VisibleIndex = 1;
            this.colTask_Project.Width = 94;
            // 
            // colTask_Admin
            // 
            this.colTask_Admin.Caption = "اسم المدير";
            this.colTask_Admin.FieldName = "Task_Admin";
            this.colTask_Admin.MinWidth = 25;
            this.colTask_Admin.Name = "colTask_Admin";
            this.colTask_Admin.Visible = true;
            this.colTask_Admin.VisibleIndex = 2;
            this.colTask_Admin.Width = 94;
            // 
            // colTask_User
            // 
            this.colTask_User.Caption = "اسم المستخدم";
            this.colTask_User.FieldName = "Task_User";
            this.colTask_User.MinWidth = 25;
            this.colTask_User.Name = "colTask_User";
            this.colTask_User.Visible = true;
            this.colTask_User.VisibleIndex = 3;
            this.colTask_User.Width = 94;
            // 
            // colTask_Desc
            // 
            this.colTask_Desc.Caption = "وصف المهمة";
            this.colTask_Desc.FieldName = "Task_Desc";
            this.colTask_Desc.MinWidth = 25;
            this.colTask_Desc.Name = "colTask_Desc";
            this.colTask_Desc.Visible = true;
            this.colTask_Desc.VisibleIndex = 4;
            this.colTask_Desc.Width = 94;
            // 
            // colTask_Start
            // 
            this.colTask_Start.Caption = "البداية";
            this.colTask_Start.FieldName = "Task_Start";
            this.colTask_Start.MinWidth = 25;
            this.colTask_Start.Name = "colTask_Start";
            this.colTask_Start.Visible = true;
            this.colTask_Start.VisibleIndex = 5;
            this.colTask_Start.Width = 94;
            // 
            // colTask_End
            // 
            this.colTask_End.Caption = "النهاية";
            this.colTask_End.FieldName = "Task_End";
            this.colTask_End.MinWidth = 25;
            this.colTask_End.Name = "colTask_End";
            this.colTask_End.Visible = true;
            this.colTask_End.VisibleIndex = 6;
            this.colTask_End.Width = 94;
            // 
            // colTask_State
            // 
            this.colTask_State.Caption = "الحالة";
            this.colTask_State.FieldName = "Task_State";
            this.colTask_State.MinWidth = 25;
            this.colTask_State.Name = "colTask_State";
            this.colTask_State.Visible = true;
            this.colTask_State.VisibleIndex = 7;
            this.colTask_State.Width = 94;
            // 
            // colTask_Duration
            // 
            this.colTask_Duration.Caption = "المدة";
            this.colTask_Duration.FieldName = "Task_Duration";
            this.colTask_Duration.MinWidth = 25;
            this.colTask_Duration.Name = "colTask_Duration";
            this.colTask_Duration.Visible = true;
            this.colTask_Duration.VisibleIndex = 8;
            this.colTask_Duration.Width = 94;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "dbdaf4af-9bcc-471e-bdf3-e8a9a7e615c8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("0efb0bb3-c5d1-4244-8498-37a61bd42ffe", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تم الحذف", "تسلم ايدك تم الحذف", "تسلم ايدك تم الحذف", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("e1f9d2a3-8303-4942-8633-6e90d70448cd", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تم!", "تم!", "تم!", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("73551e88-41de-4556-afd9-c94363af8ff6", null, "ارْمُوا بَنِي إسْمَاعِيلَ، فإنَّ أَبَاكُمْ كانَ رَامِيًا ", "ارْمُوا بَنِي إسْمَاعِيلَ، فإنَّ أَبَاكُمْ كانَ رَامِيًا ", "ارْمُوا بَنِي إسْمَاعِيلَ، فإنَّ أَبَاكُمْ كانَ رَامِيًا ", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("19f5610e-707b-4ee8-b76a-a16ded18e8d8", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications2"))), "تم التعديل", "تم التعديل", "تم التعديل", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(1080, 720);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton bot_add;
        private DevExpress.XtraEditors.SimpleButton bot_edit;
        private DevExpress.XtraEditors.SimpleButton bot_delete;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Project;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Admin;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_User;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Desc;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Start;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_End;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_State;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Duration;
        private DevExpress.XtraEditors.SimpleButton bom_done;
    }
}

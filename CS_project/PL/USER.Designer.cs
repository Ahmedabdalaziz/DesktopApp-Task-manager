namespace CS_project.PL
{
    partial class USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bot_update = new DevExpress.XtraEditors.SimpleButton();
            this.bot_edit = new DevExpress.XtraEditors.SimpleButton();
            this.bot_delete = new DevExpress.XtraEditors.SimpleButton();
            this.bot_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bot_update);
            this.panel1.Controls.Add(this.bot_edit);
            this.panel1.Controls.Add(this.bot_delete);
            this.panel1.Controls.Add(this.bot_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 84);
            this.panel1.TabIndex = 0;
            // 
            // bot_update
            // 
            this.bot_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot_update.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_update.Appearance.Options.UseFont = true;
            this.bot_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bot_update.ImageOptions.Image")));
            this.bot_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bot_update.Location = new System.Drawing.Point(647, 9);
            this.bot_update.Name = "bot_update";
            this.bot_update.Size = new System.Drawing.Size(98, 66);
            this.bot_update.TabIndex = 2;
            this.bot_update.Text = "Update";
            this.bot_update.Click += new System.EventHandler(this.bot_update_Click);
            // 
            // bot_edit
            // 
            this.bot_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot_edit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_edit.Appearance.Options.UseFont = true;
            this.bot_edit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bot_edit.ImageOptions.Image")));
            this.bot_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
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
            this.bot_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bot_delete.ImageOptions.Image")));
            this.bot_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bot_delete.Location = new System.Drawing.Point(439, 9);
            this.bot_delete.Name = "bot_delete";
            this.bot_delete.Size = new System.Drawing.Size(98, 66);
            this.bot_delete.TabIndex = 2;
            this.bot_delete.Text = "Delete";
            // 
            // bot_add
            // 
            this.bot_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot_add.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_add.Appearance.Options.UseFont = true;
            this.bot_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bot_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bot_add.ImageOptions.Image")));
            this.bot_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bot_add.Location = new System.Drawing.Point(335, 9);
            this.bot_add.Name = "bot_add";
            this.bot_add.Size = new System.Drawing.Size(98, 66);
            this.bot_add.TabIndex = 2;
            this.bot_add.Text = "Add";
            this.bot_add.Click += new System.EventHandler(this.bot_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(CS_project.TB_Users);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1080, 636);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colFullName,
            this.colPassword,
            this.colState,
            this.colUserName,
            this.colRole});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colFullName
            // 
            this.colFullName.Caption = "الاسم الكامل";
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 25;
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            this.colFullName.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "كلمة السر";
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.AllowEdit = false;
            this.colPassword.OptionsColumn.ReadOnly = true;
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 1;
            this.colPassword.Width = 94;
            // 
            // colState
            // 
            this.colState.Caption = "الحالة الدخول";
            this.colState.FieldName = "State";
            this.colState.MinWidth = 25;
            this.colState.Name = "colState";
            this.colState.OptionsColumn.AllowEdit = false;
            this.colState.OptionsColumn.ReadOnly = true;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            this.colState.Width = 94;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "اسم المستخدم";
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsColumn.ReadOnly = true;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 3;
            this.colUserName.Width = 94;
            // 
            // colRole
            // 
            this.colRole.Caption = "الصلاحية";
            this.colRole.FieldName = "Role";
            this.colRole.MinWidth = 25;
            this.colRole.Name = "colRole";
            this.colRole.OptionsColumn.AllowEdit = false;
            this.colRole.OptionsColumn.ReadOnly = true;
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 4;
            this.colRole.Width = 94;
            // 
            // USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "USER";
            this.Size = new System.Drawing.Size(1080, 720);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton bot_add;
        private DevExpress.XtraEditors.SimpleButton bot_edit;
        private DevExpress.XtraEditors.SimpleButton bot_delete;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraEditors.SimpleButton bot_update;
    }
}

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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.PushFadeTransition pushFadeTransition1 = new DevExpress.Utils.Animation.PushFadeTransition();
            this.colNote_Desc = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colNote_Manager = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colNote_User = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NBar = new System.Windows.Forms.Panel();
            this.pl_cont = new System.Windows.Forms.FlowLayoutPanel();
            this.bo_main = new DevExpress.XtraEditors.SimpleButton();
            this.bo_tasks = new DevExpress.XtraEditors.SimpleButton();
            this.bo_project = new DevExpress.XtraEditors.SimpleButton();
            this.bo_users = new DevExpress.XtraEditors.SimpleButton();
            this.bo_help = new DevExpress.XtraEditors.SimpleButton();
            this.Statusbar = new System.Windows.Forms.Panel();
            this.pn_status = new System.Windows.Forms.Label();
            this.notification_Icon = new DevExpress.XtraEditors.SimpleButton();
            this.lb_Role = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.NBar.SuspendLayout();
            this.pl_cont.SuspendLayout();
            this.Statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // colNote_Desc
            // 
            this.colNote_Desc.FieldName = "Note_Desc";
            this.colNote_Desc.MinWidth = 25;
            this.colNote_Desc.Name = "colNote_Desc";
            this.colNote_Desc.Visible = true;
            this.colNote_Desc.VisibleIndex = 0;
            this.colNote_Desc.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataSource = typeof(CS_project.TB_Notes);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(373, 619);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1,
            this.gridView1});
            this.gridControl1.Visible = false;
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.MouseLeave += new System.EventHandler(this.gridControl1_MouseLeave);
            // 
            // tileView1
            // 
            this.tileView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNote_Desc,
            this.colNote_Manager,
            this.colNote_User});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 74);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tableSpan1.RowSpan = 2;
            this.tileView1.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.colNote_Desc;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colNote_Desc";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.DoubleClick += new System.EventHandler(this.tileView1_DoubleClick);
            // 
            // colNote_Manager
            // 
            this.colNote_Manager.FieldName = "Note_Manager";
            this.colNote_Manager.MinWidth = 25;
            this.colNote_Manager.Name = "colNote_Manager";
            this.colNote_Manager.Visible = true;
            this.colNote_Manager.VisibleIndex = 1;
            this.colNote_Manager.Width = 94;
            // 
            // colNote_User
            // 
            this.colNote_User.FieldName = "Note_User";
            this.colNote_User.MinWidth = 25;
            this.colNote_User.Name = "colNote_User";
            this.colNote_User.Visible = true;
            this.colNote_User.VisibleIndex = 2;
            this.colNote_User.Width = 94;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.pl_cont.Controls.Add(this.bo_tasks);
            this.pl_cont.Controls.Add(this.bo_project);
            this.pl_cont.Controls.Add(this.bo_users);
            this.pl_cont.Controls.Add(this.bo_help);
            this.pl_cont.Dock = System.Windows.Forms.DockStyle.Top;
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
            // bo_tasks
            // 
            this.bo_tasks.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_tasks.Appearance.Options.UseFont = true;
            this.bo_tasks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_tasks.ImageOptions.Image")));
            this.bo_tasks.Location = new System.Drawing.Point(655, 8);
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
            this.bo_project.Location = new System.Drawing.Point(455, 8);
            this.bo_project.Name = "bo_project";
            this.bo_project.Size = new System.Drawing.Size(194, 66);
            this.bo_project.TabIndex = 2;
            this.bo_project.Text = "المشاريع";
            this.bo_project.Click += new System.EventHandler(this.bo_project_Click);
            // 
            // bo_users
            // 
            this.bo_users.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_users.Appearance.Options.UseFont = true;
            this.bo_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_users.ImageOptions.Image")));
            this.bo_users.Location = new System.Drawing.Point(255, 8);
            this.bo_users.Name = "bo_users";
            this.bo_users.Size = new System.Drawing.Size(194, 66);
            this.bo_users.TabIndex = 3;
            this.bo_users.Text = "المستخدمين";
            this.bo_users.Click += new System.EventHandler(this.bo_users_Click);
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
            this.Statusbar.Controls.Add(this.notification_Icon);
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
            this.pn_status.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_status.ForeColor = System.Drawing.Color.White;
            this.pn_status.Location = new System.Drawing.Point(985, 0);
            this.pn_status.Name = "pn_status";
            this.pn_status.Size = new System.Drawing.Size(77, 36);
            this.pn_status.TabIndex = 6;
            this.pn_status.Text = "مستعد";
            // 
            // notification_Icon
            // 
            this.notification_Icon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_Icon.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.notification_Icon.Appearance.Options.UseFont = true;
            this.notification_Icon.Appearance.Options.UseForeColor = true;
            this.notification_Icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.notification_Icon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("notification_Icon.ImageOptions.SvgImage")));
            this.notification_Icon.Location = new System.Drawing.Point(0, 0);
            this.notification_Icon.Name = "notification_Icon";
            this.notification_Icon.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.notification_Icon.Size = new System.Drawing.Size(74, 54);
            this.notification_Icon.TabIndex = 5;
            this.notification_Icon.Text = "10";
            this.notification_Icon.Click += new System.EventHandler(this.notification_Icon_Click);
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
            this.lb_userName.Size = new System.Drawing.Size(145, 36);
            this.lb_userName.TabIndex = 1;
            this.lb_userName.Text = "mahmoud";
            this.lb_userName.Click += new System.EventHandler(this.lb_userName_Click);
            // 
            // transitionManager1
            // 
            this.transitionManager1.ShowWaitingIndicator = false;
            transition1.BarWaitingIndicatorProperties.Caption = "";
            transition1.BarWaitingIndicatorProperties.Description = "";
            transition1.Control = this.gridControl1;
            transition1.EasingMode = DevExpress.Data.Utils.EasingMode.EaseInOut;
            transition1.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.LineWaitingIndicatorProperties.Caption = "";
            transition1.LineWaitingIndicatorProperties.Description = "";
            transition1.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition1.RingWaitingIndicatorProperties.Caption = "";
            transition1.RingWaitingIndicatorProperties.Description = "";
            transition1.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition1.TransitionType = pushFadeTransition1;
            transition1.WaitingIndicatorProperties.Caption = "";
            transition1.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Controls.Add(this.gridControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.NBar.ResumeLayout(false);
            this.pl_cont.ResumeLayout(false);
            this.Statusbar.ResumeLayout(false);
            this.Statusbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NBar;
        private System.Windows.Forms.Panel Statusbar;
        private System.Windows.Forms.FlowLayoutPanel pl_cont;
        private DevExpress.XtraEditors.SimpleButton bo_main;
        private DevExpress.XtraEditors.SimpleButton bo_users;
        private DevExpress.XtraEditors.SimpleButton bo_tasks;
        private DevExpress.XtraEditors.SimpleButton bo_project;
        private DevExpress.XtraEditors.SimpleButton bo_help;
        private DevExpress.XtraEditors.SimpleButton notification_Icon;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label pn_status;
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_Desc;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_Manager;
        private DevExpress.XtraGrid.Columns.TileViewColumn colNote_User;
    }
}


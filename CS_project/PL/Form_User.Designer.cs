namespace CS_project.PL
{
    partial class Form_User_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_add));
            this.welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_role = new System.Windows.Forms.ComboBox();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.bo_save_User = new DevExpress.XtraEditors.SimpleButton();
            this.txt_pass = new DevExpress.XtraEditors.TextEdit();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_fullName = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Gray;
            this.welcome.Location = new System.Drawing.Point(226, 16);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(236, 40);
            this.welcome.TabIndex = 3;
            this.welcome.Text = "أضافة مستخدم جديد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(387, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "الاسم بالكامل";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(381, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "أسم المستخدم";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(422, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة السر";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(428, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "الصلاحية";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // combo_role
            // 
            this.combo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_role.FormattingEnabled = true;
            this.combo_role.Items.AddRange(new object[] {
            "مدير ",
            "مستخدم"});
            this.combo_role.Location = new System.Drawing.Point(95, 589);
            this.combo_role.Name = "combo_role";
            this.combo_role.Size = new System.Drawing.Size(452, 39);
            this.combo_role.TabIndex = 5;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "dbdaf4af-9bcc-471e-bdf3-e8a9a7e615c8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("f66e5a5d-e43d-4a68-9d46-20d520eba532", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تسلم ايدك يسطا عبدو تم الاضافة", "تسلم ايدك يسطا عبدو تم الاضافة", "تسلم ايدك يسطا عبدو تم الاضافة", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b01df8e2-9ed5-481b-beb4-249210feb074", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تسلم ايدك يسطا عبدو تم التعديل", "تسلم ايدك يسطا عبدو تم التعديل", "تسلم ايدك يسطا عبدو تم التعديل", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // bo_save_User
            // 
            this.bo_save_User.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_save_User.Appearance.Options.UseFont = true;
            this.bo_save_User.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bo_save_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_save_User.ImageOptions.Image")));
            this.bo_save_User.ImageOptions.ImageUri.Uri = "SaveAll";
            this.bo_save_User.Location = new System.Drawing.Point(0, 697);
            this.bo_save_User.Name = "bo_save_User";
            this.bo_save_User.Size = new System.Drawing.Size(642, 83);
            this.bo_save_User.TabIndex = 6;
            this.bo_save_User.Text = "اضافة";
            this.bo_save_User.Click += new System.EventHandler(this.bo_save_User_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(95, 503);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Properties.Appearance.Options.UseFont = true;
            this.txt_pass.Size = new System.Drawing.Size(452, 40);
            this.txt_pass.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(95, 417);
            this.txt_username.Name = "txt_username";
            this.txt_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Properties.Appearance.Options.UseFont = true;
            this.txt_username.Size = new System.Drawing.Size(452, 40);
            this.txt_username.TabIndex = 4;
            this.txt_username.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // txt_fullName
            // 
            this.txt_fullName.EditValue = "";
            this.txt_fullName.Location = new System.Drawing.Point(95, 331);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_fullName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullName.Properties.Appearance.Options.UseBackColor = true;
            this.txt_fullName.Properties.Appearance.Options.UseFont = true;
            this.txt_fullName.Size = new System.Drawing.Size(452, 40);
            this.txt_fullName.TabIndex = 4;
            this.txt_fullName.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(233, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form_User_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 780);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bo_save_User);
            this.Controls.Add(this.combo_role);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_User_add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أضافة مستخدم";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.SimpleButton bo_save_User;
        public DevExpress.XtraEditors.TextEdit txt_fullName;
        public DevExpress.XtraEditors.TextEdit txt_username;
        public DevExpress.XtraEditors.TextEdit txt_pass;
        public System.Windows.Forms.ComboBox combo_role;
        public DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
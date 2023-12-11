namespace CS_project.PL
{
    partial class Form_Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Task));
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bo_save_User = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TaskName = new DevExpress.XtraEditors.TextEdit();
            this.sBox = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.combo_project = new System.Windows.Forms.ComboBox();
            this.combo_user = new System.Windows.Forms.ComboBox();
            this.combo_admin = new System.Windows.Forms.ComboBox();
            this.txt_TaskDesc = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.check_done = new System.Windows.Forms.CheckBox();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.days = new DevExpress.XtraEditors.TextEdit();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TaskName.Properties)).BeginInit();
            this.sBox.SuspendLayout();
            this.timeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "dbdaf4af-9bcc-471e-bdf3-e8a9a7e615c8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("f66e5a5d-e43d-4a68-9d46-20d520eba532", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تسلم ايدك,تم الاضافة", "تسلم ايدك,تم الاضافة", "تسلم ايدك,تم الاضافة", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b01df8e2-9ed5-481b-beb4-249210feb074", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تسلم ايدك,تم التعديل", "تسلم ايدك, تم التعديل", "تسلم ايدك, تم التعديل", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(331, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم المهمة";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bo_save_User
            // 
            this.bo_save_User.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_save_User.Appearance.Options.UseFont = true;
            this.bo_save_User.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bo_save_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_save_User.ImageOptions.Image")));
            this.bo_save_User.ImageOptions.ImageUri.Uri = "SaveAll";
            this.bo_save_User.Location = new System.Drawing.Point(0, 629);
            this.bo_save_User.Name = "bo_save_User";
            this.bo_save_User.Size = new System.Drawing.Size(976, 66);
            this.bo_save_User.TabIndex = 6;
            this.bo_save_User.Text = "اضافة";
            this.bo_save_User.Click += new System.EventHandler(this.bo_save_User_Click);
            // 
            // txt_TaskName
            // 
            this.txt_TaskName.EditValue = "";
            this.txt_TaskName.Location = new System.Drawing.Point(16, 106);
            this.txt_TaskName.Name = "txt_TaskName";
            this.txt_TaskName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_TaskName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaskName.Properties.Appearance.Options.UseBackColor = true;
            this.txt_TaskName.Properties.Appearance.Options.UseFont = true;
            this.txt_TaskName.Size = new System.Drawing.Size(433, 36);
            this.txt_TaskName.TabIndex = 4;
            this.txt_TaskName.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // sBox
            // 
            this.sBox.Controls.Add(this.linkLabel1);
            this.sBox.Controls.Add(this.combo_project);
            this.sBox.Controls.Add(this.combo_user);
            this.sBox.Controls.Add(this.combo_admin);
            this.sBox.Controls.Add(this.txt_TaskDesc);
            this.sBox.Controls.Add(this.label2);
            this.sBox.Controls.Add(this.txt_TaskName);
            this.sBox.Controls.Add(this.label6);
            this.sBox.Controls.Add(this.label4);
            this.sBox.Controls.Add(this.label3);
            this.sBox.Controls.Add(this.label1);
            this.sBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sBox.Location = new System.Drawing.Point(500, 5);
            this.sBox.Name = "sBox";
            this.sBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sBox.Size = new System.Drawing.Size(464, 618);
            this.sBox.TabIndex = 9;
            this.sBox.TabStop = false;
            this.sBox.Text = "تخصيص";
            this.sBox.Enter += new System.EventHandler(this.sBox_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(16, 357);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 23);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "مشروع جديد؟";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // combo_project
            // 
            this.combo_project.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_project.FormattingEnabled = true;
            this.combo_project.Location = new System.Drawing.Point(16, 383);
            this.combo_project.Name = "combo_project";
            this.combo_project.Size = new System.Drawing.Size(433, 43);
            this.combo_project.TabIndex = 11;
            // 
            // combo_user
            // 
            this.combo_user.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_user.FormattingEnabled = true;
            this.combo_user.Location = new System.Drawing.Point(16, 284);
            this.combo_user.Name = "combo_user";
            this.combo_user.Size = new System.Drawing.Size(433, 43);
            this.combo_user.TabIndex = 11;
            // 
            // combo_admin
            // 
            this.combo_admin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_admin.FormattingEnabled = true;
            this.combo_admin.Location = new System.Drawing.Point(16, 190);
            this.combo_admin.Name = "combo_admin";
            this.combo_admin.Size = new System.Drawing.Size(433, 43);
            this.combo_admin.TabIndex = 11;
            // 
            // txt_TaskDesc
            // 
            this.txt_TaskDesc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaskDesc.Location = new System.Drawing.Point(16, 466);
            this.txt_TaskDesc.Name = "txt_TaskDesc";
            this.txt_TaskDesc.Size = new System.Drawing.Size(433, 154);
            this.txt_TaskDesc.TabIndex = 9;
            this.txt_TaskDesc.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(306, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "أسم المشروع";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(374, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "وصف";
            this.label6.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(347, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "المستخدم";
            this.label4.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(375, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "المدير";
            this.label3.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.check_done);
            this.timeBox.Controls.Add(this.date_end);
            this.timeBox.Controls.Add(this.label7);
            this.timeBox.Controls.Add(this.days);
            this.timeBox.Controls.Add(this.date_start);
            this.timeBox.Controls.Add(this.label5);
            this.timeBox.Controls.Add(this.label9);
            this.timeBox.Controls.Add(this.label8);
            this.timeBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(12, 12);
            this.timeBox.Name = "timeBox";
            this.timeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timeBox.Size = new System.Drawing.Size(465, 611);
            this.timeBox.TabIndex = 9;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "الوقت";
            this.timeBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // check_done
            // 
            this.check_done.AutoSize = true;
            this.check_done.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_done.Location = new System.Drawing.Point(292, 493);
            this.check_done.Name = "check_done";
            this.check_done.Size = new System.Drawing.Size(102, 41);
            this.check_done.TabIndex = 9;
            this.check_done.Text = "مكتمل";
            this.check_done.UseVisualStyleBackColor = true;
            this.check_done.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // date_end
            // 
            this.date_end.Location = new System.Drawing.Point(6, 183);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(452, 34);
            this.date_end.TabIndex = 0;
            this.date_end.ValueChanged += new System.EventHandler(this.date_end_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(375, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "النهاية";
            this.label7.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // days
            // 
            this.days.EditValue = "";
            this.days.Location = new System.Drawing.Point(216, 358);
            this.days.Name = "days";
            this.days.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.days.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.Properties.Appearance.Options.UseBackColor = true;
            this.days.Properties.Appearance.Options.UseFont = true;
            this.days.Properties.ReadOnly = true;
            this.days.Size = new System.Drawing.Size(191, 58);
            this.days.TabIndex = 4;
            this.days.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // date_start
            // 
            this.date_start.Location = new System.Drawing.Point(6, 97);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(452, 34);
            this.date_start.TabIndex = 0;
            this.date_start.ValueChanged += new System.EventHandler(this.date_start_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(375, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "البداية";
            this.label5.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(143, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 50);
            this.label9.TabIndex = 8;
            this.label9.Text = "يوم";
            this.label9.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(327, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 50);
            this.label8.TabIndex = 8;
            this.label8.Text = "المدة";
            this.label8.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(976, 695);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.bo_save_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Task";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أضافة مستخدم";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form_Task_Activated);
            this.Load += new System.EventHandler(this.Form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TaskName.Properties)).EndInit();
            this.sBox.ResumeLayout(false);
            this.sBox.PerformLayout();
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.days.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton bo_save_User;
        public DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public DevExpress.XtraEditors.TextEdit txt_TaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sBox;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox txt_TaskDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit days;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.DateTimePicker date_end;
        public System.Windows.Forms.DateTimePicker date_start;
        public System.Windows.Forms.CheckBox check_done;
        public System.Windows.Forms.ComboBox combo_project;
        public System.Windows.Forms.ComboBox combo_user;
        public System.Windows.Forms.ComboBox combo_admin;
    }
}
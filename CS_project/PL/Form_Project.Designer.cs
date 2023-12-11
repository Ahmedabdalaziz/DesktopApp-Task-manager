namespace CS_project.PL
{
    partial class Form_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Project));
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.bo_save_User = new DevExpress.XtraEditors.SimpleButton();
            this.txt_projName = new DevExpress.XtraEditors.TextEdit();
            this.txt_projDesc = new System.Windows.Forms.RichTextBox();
            this.pn_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_projName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "dbdaf4af-9bcc-471e-bdf3-e8a9a7e615c8";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("f66e5a5d-e43d-4a68-9d46-20d520eba532", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تسلم ايدك,تم الاضافة", "تسلم ايدك,تم الاضافة", "تسلم ايدك,تم الاضافة", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b01df8e2-9ed5-481b-beb4-249210feb074", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تسلم ايدك,تم التعديل", "تسلم ايدك, تم التعديل", "تسلم ايدك, تم التعديل", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // bo_save_User
            // 
            this.bo_save_User.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo_save_User.Appearance.Options.UseFont = true;
            this.bo_save_User.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bo_save_User.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bo_save_User.ImageOptions.Image")));
            this.bo_save_User.ImageOptions.ImageUri.Uri = "SaveAll";
            this.bo_save_User.Location = new System.Drawing.Point(0, 596);
            this.bo_save_User.Name = "bo_save_User";
            this.bo_save_User.Size = new System.Drawing.Size(642, 83);
            this.bo_save_User.TabIndex = 6;
            this.bo_save_User.Text = "اضافة";
            this.bo_save_User.Click += new System.EventHandler(this.bo_save_User_Click);
            // 
            // txt_projName
            // 
            this.txt_projName.EditValue = "";
            this.txt_projName.Location = new System.Drawing.Point(95, 112);
            this.txt_projName.Name = "txt_projName";
            this.txt_projName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txt_projName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_projName.Properties.Appearance.Options.UseBackColor = true;
            this.txt_projName.Properties.Appearance.Options.UseFont = true;
            this.txt_projName.Size = new System.Drawing.Size(452, 40);
            this.txt_projName.TabIndex = 4;
            this.txt_projName.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txt_projDesc
            // 
            this.txt_projDesc.Location = new System.Drawing.Point(95, 245);
            this.txt_projDesc.Name = "txt_projDesc";
            this.txt_projDesc.Size = new System.Drawing.Size(452, 280);
            this.txt_projDesc.TabIndex = 7;
            this.txt_projDesc.Text = "";
            this.txt_projDesc.TextChanged += new System.EventHandler(this.txt_projDesc_TextChanged);
            // 
            // pn_status
            // 
            this.pn_status.AutoSize = true;
            this.pn_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_status.ForeColor = System.Drawing.Color.DarkBlue;
            this.pn_status.Location = new System.Drawing.Point(323, 189);
            this.pn_status.Name = "pn_status";
            this.pn_status.Size = new System.Drawing.Size(224, 43);
            this.pn_status.TabIndex = 8;
            this.pn_status.Text = "وصف المشروع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(355, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "أسم المشروع";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_status);
            this.Controls.Add(this.txt_projDesc);
            this.Controls.Add(this.bo_save_User);
            this.Controls.Add(this.txt_projName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Project";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أضافة مستخدم";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_projName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton bo_save_User;
        public DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public DevExpress.XtraEditors.TextEdit txt_projName;
        private System.Windows.Forms.Label pn_status;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox txt_projDesc;
    }
}
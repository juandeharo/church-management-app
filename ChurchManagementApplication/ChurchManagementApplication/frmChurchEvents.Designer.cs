namespace ChurchManagementApplication
{
    partial class frmChurchEvents
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDateSelected = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblMinister = new System.Windows.Forms.Label();
            this.txtMinisterName = new System.Windows.Forms.TextBox();
            this.lblStaffMember = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnRecommendedMinisters = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.pnlEventInput = new System.Windows.Forms.Panel();
            this.btnRemoveMinister = new System.Windows.Forms.Button();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblMinLN = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEventInput.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(10, 301);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 41);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit ";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(36, 40);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(160, 17);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(162, 22);
            this.txtDate.TabIndex = 16;
            this.txtDate.TabStop = false;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDateSelected
            // 
            this.lblDateSelected.AutoSize = true;
            this.lblDateSelected.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSelected.Location = new System.Drawing.Point(9, 18);
            this.lblDateSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateSelected.Name = "lblDateSelected";
            this.lblDateSelected.Size = new System.Drawing.Size(99, 16);
            this.lblDateSelected.TabIndex = 3;
            this.lblDateSelected.Text = "Date Selected: ";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(9, 53);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(92, 16);
            this.lblEventName.TabIndex = 5;
            this.lblEventName.Text = "Event Name: ";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(160, 51);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(162, 22);
            this.txtEventName.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(9, 87);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 16);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description: ";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(160, 86);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(162, 22);
            this.txtDesc.TabIndex = 1;
            // 
            // lblMinister
            // 
            this.lblMinister.AutoSize = true;
            this.lblMinister.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinister.Location = new System.Drawing.Point(9, 191);
            this.lblMinister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinister.Name = "lblMinister";
            this.lblMinister.Size = new System.Drawing.Size(138, 16);
            this.lblMinister.TabIndex = 9;
            this.lblMinister.Text = "Minister First Name: ";
            // 
            // txtMinisterName
            // 
            this.txtMinisterName.Location = new System.Drawing.Point(160, 189);
            this.txtMinisterName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinisterName.Name = "txtMinisterName";
            this.txtMinisterName.ReadOnly = true;
            this.txtMinisterName.Size = new System.Drawing.Size(162, 22);
            this.txtMinisterName.TabIndex = 5;
            this.txtMinisterName.TabStop = false;
            // 
            // lblStaffMember
            // 
            this.lblStaffMember.AutoSize = true;
            this.lblStaffMember.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMember.Location = new System.Drawing.Point(9, 265);
            this.lblStaffMember.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffMember.Name = "lblStaffMember";
            this.lblStaffMember.Size = new System.Drawing.Size(110, 16);
            this.lblStaffMember.TabIndex = 11;
            this.lblStaffMember.Text = "Minister Phone: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(160, 155);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(162, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // btnRecommendedMinisters
            // 
            this.btnRecommendedMinisters.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRecommendedMinisters.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecommendedMinisters.Location = new System.Drawing.Point(91, 377);
            this.btnRecommendedMinisters.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecommendedMinisters.Name = "btnRecommendedMinisters";
            this.btnRecommendedMinisters.Size = new System.Drawing.Size(146, 82);
            this.btnRecommendedMinisters.TabIndex = 1;
            this.btnRecommendedMinisters.Text = "Recommend Ministers:";
            this.btnRecommendedMinisters.UseVisualStyleBackColor = false;
            this.btnRecommendedMinisters.Click += new System.EventHandler(this.btnRecommendedMinisters_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(9, 122);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(41, 16);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(9, 155);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 16);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address: ";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(160, 264);
            this.txtCellPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.ReadOnly = true;
            this.txtCellPhone.Size = new System.Drawing.Size(162, 22);
            this.txtCellPhone.TabIndex = 7;
            this.txtCellPhone.TabStop = false;
            // 
            // pnlEventInput
            // 
            this.pnlEventInput.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlEventInput.Controls.Add(this.btnRemoveMinister);
            this.pnlEventInput.Controls.Add(this.cboCity);
            this.pnlEventInput.Controls.Add(this.txtLastName);
            this.pnlEventInput.Controls.Add(this.lblMinLN);
            this.pnlEventInput.Controls.Add(this.btnClear);
            this.pnlEventInput.Controls.Add(this.lblDateSelected);
            this.pnlEventInput.Controls.Add(this.lblAddress);
            this.pnlEventInput.Controls.Add(this.txtDate);
            this.pnlEventInput.Controls.Add(this.btnSubmit);
            this.pnlEventInput.Controls.Add(this.txtCellPhone);
            this.pnlEventInput.Controls.Add(this.txtEventName);
            this.pnlEventInput.Controls.Add(this.lblCity);
            this.pnlEventInput.Controls.Add(this.lblEventName);
            this.pnlEventInput.Controls.Add(this.txtDesc);
            this.pnlEventInput.Controls.Add(this.lblDescription);
            this.pnlEventInput.Controls.Add(this.lblStaffMember);
            this.pnlEventInput.Controls.Add(this.txtMinisterName);
            this.pnlEventInput.Controls.Add(this.txtAddress);
            this.pnlEventInput.Controls.Add(this.lblMinister);
            this.pnlEventInput.Location = new System.Drawing.Point(354, 35);
            this.pnlEventInput.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEventInput.Name = "pnlEventInput";
            this.pnlEventInput.Size = new System.Drawing.Size(358, 362);
            this.pnlEventInput.TabIndex = 0;
            // 
            // btnRemoveMinister
            // 
            this.btnRemoveMinister.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRemoveMinister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveMinister.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMinister.Location = new System.Drawing.Point(114, 301);
            this.btnRemoveMinister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMinister.Name = "btnRemoveMinister";
            this.btnRemoveMinister.Size = new System.Drawing.Size(128, 41);
            this.btnRemoveMinister.TabIndex = 5;
            this.btnRemoveMinister.Text = "Remove Minister";
            this.btnRemoveMinister.UseVisualStyleBackColor = false;
            this.btnRemoveMinister.Click += new System.EventHandler(this.btnRemoveMinister_Click);
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(160, 120);
            this.cboCity.Margin = new System.Windows.Forms.Padding(2);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(162, 24);
            this.cboCity.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 227);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(162, 22);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.TabStop = false;
            // 
            // lblMinLN
            // 
            this.lblMinLN.AutoSize = true;
            this.lblMinLN.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinLN.Location = new System.Drawing.Point(9, 228);
            this.lblMinLN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinLN.Name = "lblMinLN";
            this.lblMinLN.Size = new System.Drawing.Size(136, 16);
            this.lblMinLN.TabIndex = 21;
            this.lblMinLN.Text = "Minister Last Name: ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(252, 301);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 41);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCancel.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(544, 422);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(402, 422);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Events";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(726, 28);
            this.mnuMainMenu.TabIndex = 21;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmChurchEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(726, 512);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlEventInput);
            this.Controls.Add(this.btnRecommendedMinisters);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChurchEvents";
            this.Text = "Church of God - Event Scheduler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEventInput.ResumeLayout(false);
            this.pnlEventInput.PerformLayout();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDateSelected;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblMinister;
        private System.Windows.Forms.TextBox txtMinisterName;
        private System.Windows.Forms.Label lblStaffMember;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnRecommendedMinisters;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Panel pnlEventInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblMinLN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnRemoveMinister;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}


namespace ChurchManagementApplication
{
    partial class frmMemberQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberQuery));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindNavMember = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.chkLastName = new System.Windows.Forms.CheckBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMemberType = new System.Windows.Forms.TextBox();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            this.txtAgeClassificattion = new System.Windows.Forms.TextBox();
            this.chkMemberType = new System.Windows.Forms.CheckBox();
            this.chkMaritalStatus = new System.Windows.Forms.CheckBox();
            this.chkAgeClassification = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkAttendDate = new System.Windows.Forms.CheckBox();
            this.bindSrcMember = new System.Windows.Forms.BindingSource(this.components);
            this.btnFilter = new System.Windows.Forms.Button();
            this.mcalDateRangePicker = new System.Windows.Forms.MonthCalendar();
            this.lstSortMember = new System.Windows.Forms.ListBox();
            this.chkAscending = new System.Windows.Forms.CheckBox();
            this.chkDescending = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsContributions = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavMember)).BeginInit();
            this.bindNavMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcMember)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bindNavMember);
            this.panel1.Controls.Add(this.dgvMembers);
            this.panel1.Location = new System.Drawing.Point(15, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 811);
            this.panel1.TabIndex = 0;
            // 
            // bindNavMember
            // 
            this.bindNavMember.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindNavMember.CountItem = this.bindingNavigatorCountItem;
            this.bindNavMember.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindNavMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindNavMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindNavMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindNavMember.Location = new System.Drawing.Point(0, 784);
            this.bindNavMember.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindNavMember.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindNavMember.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindNavMember.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindNavMember.Name = "bindNavMember";
            this.bindNavMember.PositionItem = this.bindingNavigatorPositionItem;
            this.bindNavMember.Size = new System.Drawing.Size(1076, 27);
            this.bindNavMember.TabIndex = 1;
            this.bindNavMember.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(4, 4);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1068, 773);
            this.dgvMembers.TabIndex = 0;
            // 
            // chkLastName
            // 
            this.chkLastName.AutoSize = true;
            this.chkLastName.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLastName.Location = new System.Drawing.Point(1321, 58);
            this.chkLastName.Margin = new System.Windows.Forms.Padding(4);
            this.chkLastName.Name = "chkLastName";
            this.chkLastName.Size = new System.Drawing.Size(118, 26);
            this.chkLastName.TabIndex = 4;
            this.chkLastName.Text = "Last Name";
            this.chkLastName.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1132, 62);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // txtMemberType
            // 
            this.txtMemberType.Location = new System.Drawing.Point(1132, 121);
            this.txtMemberType.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberType.Name = "txtMemberType";
            this.txtMemberType.Size = new System.Drawing.Size(132, 22);
            this.txtMemberType.TabIndex = 6;
            // 
            // txtMaritalStatus
            // 
            this.txtMaritalStatus.Location = new System.Drawing.Point(1132, 181);
            this.txtMaritalStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaritalStatus.Name = "txtMaritalStatus";
            this.txtMaritalStatus.Size = new System.Drawing.Size(132, 22);
            this.txtMaritalStatus.TabIndex = 7;
            // 
            // txtAgeClassificattion
            // 
            this.txtAgeClassificattion.Location = new System.Drawing.Point(1132, 239);
            this.txtAgeClassificattion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgeClassificattion.Name = "txtAgeClassificattion";
            this.txtAgeClassificattion.Size = new System.Drawing.Size(132, 22);
            this.txtAgeClassificattion.TabIndex = 8;
            // 
            // chkMemberType
            // 
            this.chkMemberType.AutoSize = true;
            this.chkMemberType.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMemberType.Location = new System.Drawing.Point(1321, 118);
            this.chkMemberType.Margin = new System.Windows.Forms.Padding(4);
            this.chkMemberType.Name = "chkMemberType";
            this.chkMemberType.Size = new System.Drawing.Size(149, 26);
            this.chkMemberType.TabIndex = 9;
            this.chkMemberType.Text = "Member Type";
            this.chkMemberType.UseVisualStyleBackColor = true;
            // 
            // chkMaritalStatus
            // 
            this.chkMaritalStatus.AutoSize = true;
            this.chkMaritalStatus.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaritalStatus.Location = new System.Drawing.Point(1321, 178);
            this.chkMaritalStatus.Margin = new System.Windows.Forms.Padding(4);
            this.chkMaritalStatus.Name = "chkMaritalStatus";
            this.chkMaritalStatus.Size = new System.Drawing.Size(137, 26);
            this.chkMaritalStatus.TabIndex = 10;
            this.chkMaritalStatus.Text = "MaritalStatus";
            this.chkMaritalStatus.UseVisualStyleBackColor = true;
            // 
            // chkAgeClassification
            // 
            this.chkAgeClassification.AutoSize = true;
            this.chkAgeClassification.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgeClassification.Location = new System.Drawing.Point(1321, 238);
            this.chkAgeClassification.Margin = new System.Windows.Forms.Padding(4);
            this.chkAgeClassification.Name = "chkAgeClassification";
            this.chkAgeClassification.Size = new System.Drawing.Size(176, 26);
            this.chkAgeClassification.TabIndex = 11;
            this.chkAgeClassification.Text = "Age Classification";
            this.chkAgeClassification.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1460, 756);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 60);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkAttendDate
            // 
            this.chkAttendDate.AutoSize = true;
            this.chkAttendDate.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAttendDate.Location = new System.Drawing.Point(1132, 506);
            this.chkAttendDate.Margin = new System.Windows.Forms.Padding(4);
            this.chkAttendDate.Name = "chkAttendDate";
            this.chkAttendDate.Size = new System.Drawing.Size(221, 26);
            this.chkAttendDate.TabIndex = 14;
            this.chkAttendDate.Text = "Attendance Begin Date";
            this.chkAttendDate.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(1331, 756);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(121, 59);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter And Sort";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // mcalDateRangePicker
            // 
            this.mcalDateRangePicker.Location = new System.Drawing.Point(1132, 290);
            this.mcalDateRangePicker.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcalDateRangePicker.MaxSelectionCount = 100;
            this.mcalDateRangePicker.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.mcalDateRangePicker.Name = "mcalDateRangePicker";
            this.mcalDateRangePicker.TabIndex = 16;
            // 
            // lstSortMember
            // 
            this.lstSortMember.FormattingEnabled = true;
            this.lstSortMember.ItemHeight = 16;
            this.lstSortMember.Items.AddRange(new object[] {
            "MemberID",
            "Last Name",
            "First Name",
            "Honorific",
            "Gender",
            "Birth Date",
            "Marital Status",
            "Address",
            "City",
            "State",
            "Zip",
            "Phone Number",
            "Email",
            "Member Type",
            "Membership Date",
            "Attendance Begin Date",
            "Attendance Last Date"});
            this.lstSortMember.Location = new System.Drawing.Point(1132, 540);
            this.lstSortMember.Margin = new System.Windows.Forms.Padding(4);
            this.lstSortMember.Name = "lstSortMember";
            this.lstSortMember.Size = new System.Drawing.Size(159, 276);
            this.lstSortMember.TabIndex = 17;
            // 
            // chkAscending
            // 
            this.chkAscending.AutoSize = true;
            this.chkAscending.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAscending.Location = new System.Drawing.Point(1321, 577);
            this.chkAscending.Margin = new System.Windows.Forms.Padding(4);
            this.chkAscending.Name = "chkAscending";
            this.chkAscending.Size = new System.Drawing.Size(117, 26);
            this.chkAscending.TabIndex = 18;
            this.chkAscending.Text = "Ascending";
            this.chkAscending.UseVisualStyleBackColor = true;
            // 
            // chkDescending
            // 
            this.chkDescending.AutoSize = true;
            this.chkDescending.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescending.Location = new System.Drawing.Point(1321, 660);
            this.chkDescending.Margin = new System.Windows.Forms.Padding(4);
            this.chkDescending.Name = "chkDescending";
            this.chkDescending.Size = new System.Drawing.Size(127, 26);
            this.chkDescending.TabIndex = 19;
            this.chkDescending.Text = "Descending";
            this.chkDescending.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1695, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.mtsContributions});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // mtsContributions
            // 
            this.mtsContributions.Name = "mtsContributions";
            this.mtsContributions.Size = new System.Drawing.Size(173, 26);
            this.mtsContributions.Text = "Contributions";
            // 
            // frmMemberQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1695, 864);
            this.Controls.Add(this.chkDescending);
            this.Controls.Add(this.chkAscending);
            this.Controls.Add(this.lstSortMember);
            this.Controls.Add(this.mcalDateRangePicker);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.chkAttendDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkAgeClassification);
            this.Controls.Add(this.chkMaritalStatus);
            this.Controls.Add(this.chkMemberType);
            this.Controls.Add(this.txtAgeClassificattion);
            this.Controls.Add(this.txtMaritalStatus);
            this.Controls.Add(this.txtMemberType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.chkLastName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMemberQuery";
            this.Text = "Church of God - Sort/Filter Members";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavMember)).EndInit();
            this.bindNavMember.ResumeLayout(false);
            this.bindNavMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcMember)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.CheckBox chkLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMemberType;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.TextBox txtAgeClassificattion;
        private System.Windows.Forms.CheckBox chkMemberType;
        private System.Windows.Forms.CheckBox chkMaritalStatus;
        private System.Windows.Forms.CheckBox chkAgeClassification;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkAttendDate;
        private System.Windows.Forms.BindingNavigator bindNavMember;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindSrcMember;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MonthCalendar mcalDateRangePicker;
        private System.Windows.Forms.ListBox lstSortMember;
        private System.Windows.Forms.CheckBox chkAscending;
        private System.Windows.Forms.CheckBox chkDescending;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsContributions;
    }
}


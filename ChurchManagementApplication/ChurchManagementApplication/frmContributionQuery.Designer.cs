namespace ChurchManagementApplication
{
    partial class frmContributionQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContributionQuery));
            this.chkDescendingCont = new System.Windows.Forms.CheckBox();
            this.chkAscendingCont = new System.Windows.Forms.CheckBox();
            this.lstSortCont = new System.Windows.Forms.ListBox();
            this.mcalDateRangePickerCont = new System.Windows.Forms.MonthCalendar();
            this.btnFilterAndSortCont = new System.Windows.Forms.Button();
            this.btnClearCont = new System.Windows.Forms.Button();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkFund = new System.Windows.Forms.CheckBox();
            this.txtFund = new System.Windows.Forms.TextBox();
            this.txtMemberCont = new System.Windows.Forms.TextBox();
            this.chkMemberCont = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindNavCont = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dgvContributions = new System.Windows.Forms.DataGridView();
            this.bindSrcCont = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsMember = new System.Windows.Forms.ToolStripMenuItem();
            this.contributionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavCont)).BeginInit();
            this.bindNavCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContributions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCont)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkDescendingCont
            // 
            this.chkDescendingCont.AutoSize = true;
            this.chkDescendingCont.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescendingCont.Location = new System.Drawing.Point(1310, 556);
            this.chkDescendingCont.Margin = new System.Windows.Forms.Padding(4);
            this.chkDescendingCont.Name = "chkDescendingCont";
            this.chkDescendingCont.Size = new System.Drawing.Size(127, 26);
            this.chkDescendingCont.TabIndex = 35;
            this.chkDescendingCont.Text = "Descending";
            this.chkDescendingCont.UseVisualStyleBackColor = true;
            // 
            // chkAscendingCont
            // 
            this.chkAscendingCont.AutoSize = true;
            this.chkAscendingCont.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAscendingCont.Location = new System.Drawing.Point(1310, 508);
            this.chkAscendingCont.Margin = new System.Windows.Forms.Padding(4);
            this.chkAscendingCont.Name = "chkAscendingCont";
            this.chkAscendingCont.Size = new System.Drawing.Size(117, 26);
            this.chkAscendingCont.TabIndex = 34;
            this.chkAscendingCont.Text = "Ascending";
            this.chkAscendingCont.UseVisualStyleBackColor = true;
            // 
            // lstSortCont
            // 
            this.lstSortCont.FormattingEnabled = true;
            this.lstSortCont.ItemHeight = 16;
            this.lstSortCont.Items.AddRange(new object[] {
            "Contribution No",
            "Member ID",
            "Contribution Date",
            "Amount",
            "Method",
            "Check No",
            "Designated Fund"});
            this.lstSortCont.Location = new System.Drawing.Point(1130, 480);
            this.lstSortCont.Margin = new System.Windows.Forms.Padding(4);
            this.lstSortCont.Name = "lstSortCont";
            this.lstSortCont.Size = new System.Drawing.Size(158, 116);
            this.lstSortCont.TabIndex = 33;
            // 
            // mcalDateRangePickerCont
            // 
            this.mcalDateRangePickerCont.Location = new System.Drawing.Point(1130, 183);
            this.mcalDateRangePickerCont.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcalDateRangePickerCont.MaxSelectionCount = 300;
            this.mcalDateRangePickerCont.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.mcalDateRangePickerCont.Name = "mcalDateRangePickerCont";
            this.mcalDateRangePickerCont.TabIndex = 32;
            // 
            // btnFilterAndSortCont
            // 
            this.btnFilterAndSortCont.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterAndSortCont.Location = new System.Drawing.Point(1130, 662);
            this.btnFilterAndSortCont.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterAndSortCont.Name = "btnFilterAndSortCont";
            this.btnFilterAndSortCont.Size = new System.Drawing.Size(132, 70);
            this.btnFilterAndSortCont.TabIndex = 31;
            this.btnFilterAndSortCont.Text = "Filter And Sort";
            this.btnFilterAndSortCont.UseVisualStyleBackColor = true;
            this.btnFilterAndSortCont.Click += new System.EventHandler(this.btnFilterCont_Click);
            // 
            // btnClearCont
            // 
            this.btnClearCont.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCont.Location = new System.Drawing.Point(1304, 662);
            this.btnClearCont.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearCont.Name = "btnClearCont";
            this.btnClearCont.Size = new System.Drawing.Size(132, 70);
            this.btnClearCont.TabIndex = 29;
            this.btnClearCont.Text = "Clear";
            this.btnClearCont.UseVisualStyleBackColor = true;
            this.btnClearCont.Click += new System.EventHandler(this.btnClearCont_Click);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDate.Location = new System.Drawing.Point(1130, 405);
            this.chkDate.Margin = new System.Windows.Forms.Padding(4);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(182, 26);
            this.chkDate.TabIndex = 27;
            this.chkDate.Text = "Contribution Date";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkFund
            // 
            this.chkFund.AutoSize = true;
            this.chkFund.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFund.Location = new System.Drawing.Point(1308, 123);
            this.chkFund.Margin = new System.Windows.Forms.Padding(4);
            this.chkFund.Name = "chkFund";
            this.chkFund.Size = new System.Drawing.Size(171, 26);
            this.chkFund.TabIndex = 26;
            this.chkFund.Text = "Designated Fund";
            this.chkFund.UseVisualStyleBackColor = true;
            // 
            // txtFund
            // 
            this.txtFund.Location = new System.Drawing.Point(1130, 121);
            this.txtFund.Margin = new System.Windows.Forms.Padding(4);
            this.txtFund.Name = "txtFund";
            this.txtFund.Size = new System.Drawing.Size(132, 22);
            this.txtFund.TabIndex = 23;
            // 
            // txtMemberCont
            // 
            this.txtMemberCont.Location = new System.Drawing.Point(1130, 61);
            this.txtMemberCont.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemberCont.Name = "txtMemberCont";
            this.txtMemberCont.Size = new System.Drawing.Size(132, 22);
            this.txtMemberCont.TabIndex = 22;
            // 
            // chkMemberCont
            // 
            this.chkMemberCont.AutoSize = true;
            this.chkMemberCont.Font = new System.Drawing.Font("Maiandra GD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMemberCont.Location = new System.Drawing.Point(1308, 63);
            this.chkMemberCont.Margin = new System.Windows.Forms.Padding(4);
            this.chkMemberCont.Name = "chkMemberCont";
            this.chkMemberCont.Size = new System.Drawing.Size(128, 26);
            this.chkMemberCont.TabIndex = 21;
            this.chkMemberCont.Text = "Member ID";
            this.chkMemberCont.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bindNavCont);
            this.panel1.Controls.Add(this.dgvContributions);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 811);
            this.panel1.TabIndex = 20;
            // 
            // bindNavCont
            // 
            this.bindNavCont.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindNavCont.CountItem = this.bindingNavigatorCountItem;
            this.bindNavCont.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindNavCont.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindNavCont.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.bindNavCont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindNavCont.Location = new System.Drawing.Point(0, 764);
            this.bindNavCont.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindNavCont.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindNavCont.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindNavCont.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindNavCont.Name = "bindNavCont";
            this.bindNavCont.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindNavCont.PositionItem = this.bindingNavigatorPositionItem;
            this.bindNavCont.Size = new System.Drawing.Size(1076, 47);
            this.bindNavCont.TabIndex = 1;
            this.bindNavCont.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(66, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // dgvContributions
            // 
            this.dgvContributions.AllowUserToAddRows = false;
            this.dgvContributions.AllowUserToDeleteRows = false;
            this.dgvContributions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContributions.Location = new System.Drawing.Point(4, 4);
            this.dgvContributions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContributions.Name = "dgvContributions";
            this.dgvContributions.ReadOnly = true;
            this.dgvContributions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContributions.Size = new System.Drawing.Size(1068, 773);
            this.dgvContributions.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1680, 30);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsMember,
            this.contributionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mtsMember
            // 
            this.mtsMember.Name = "mtsMember";
            this.mtsMember.Size = new System.Drawing.Size(173, 26);
            this.mtsMember.Text = "Members";
            this.mtsMember.Click += new System.EventHandler(this.mtsMember_Click);
            // 
            // contributionsToolStripMenuItem
            // 
            this.contributionsToolStripMenuItem.Name = "contributionsToolStripMenuItem";
            this.contributionsToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.contributionsToolStripMenuItem.Text = "Contributions";
            // 
            // frmContributionQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1680, 888);
            this.Controls.Add(this.chkDescendingCont);
            this.Controls.Add(this.chkAscendingCont);
            this.Controls.Add(this.lstSortCont);
            this.Controls.Add(this.mcalDateRangePickerCont);
            this.Controls.Add(this.btnFilterAndSortCont);
            this.Controls.Add(this.btnClearCont);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.chkFund);
            this.Controls.Add(this.txtFund);
            this.Controls.Add(this.txtMemberCont);
            this.Controls.Add(this.chkMemberCont);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContributionQuery";
            this.Text = "Church of God - Sort/Filter Contributions";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavCont)).EndInit();
            this.bindNavCont.ResumeLayout(false);
            this.bindNavCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContributions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcCont)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDescendingCont;
        private System.Windows.Forms.CheckBox chkAscendingCont;
        private System.Windows.Forms.ListBox lstSortCont;
        private System.Windows.Forms.MonthCalendar mcalDateRangePickerCont;
        private System.Windows.Forms.Button btnFilterAndSortCont;
        private System.Windows.Forms.Button btnClearCont;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkFund;
        private System.Windows.Forms.TextBox txtFund;
        private System.Windows.Forms.TextBox txtMemberCont;
        private System.Windows.Forms.CheckBox chkMemberCont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bindNavCont;
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
        private System.Windows.Forms.DataGridView dgvContributions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsMember;
        private System.Windows.Forms.ToolStripMenuItem contributionsToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindSrcCont;

        private void mtsMember_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
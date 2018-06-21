namespace ChurchManagementApplication
{
    partial class frmMinisterSuggestion
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
            this.txtDateSelected = new System.Windows.Forms.TextBox();
            this.txtCitySelected = new System.Windows.Forms.TextBox();
            this.lblDateSelected = new System.Windows.Forms.Label();
            this.lblCitySelected = new System.Windows.Forms.Label();
            this.dgvMinister = new System.Windows.Forms.DataGridView();
            this.bindSrcMinisters = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcMinisters)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDateSelected
            // 
            this.txtDateSelected.Location = new System.Drawing.Point(156, 31);
            this.txtDateSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDateSelected.Name = "txtDateSelected";
            this.txtDateSelected.Size = new System.Drawing.Size(102, 22);
            this.txtDateSelected.TabIndex = 0;
            this.txtDateSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCitySelected
            // 
            this.txtCitySelected.Location = new System.Drawing.Point(443, 30);
            this.txtCitySelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCitySelected.Name = "txtCitySelected";
            this.txtCitySelected.Size = new System.Drawing.Size(127, 22);
            this.txtCitySelected.TabIndex = 1;
            // 
            // lblDateSelected
            // 
            this.lblDateSelected.AutoSize = true;
            this.lblDateSelected.Location = new System.Drawing.Point(48, 32);
            this.lblDateSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateSelected.Name = "lblDateSelected";
            this.lblDateSelected.Size = new System.Drawing.Size(105, 17);
            this.lblDateSelected.TabIndex = 2;
            this.lblDateSelected.Text = "Date Selected: ";
            // 
            // lblCitySelected
            // 
            this.lblCitySelected.AutoSize = true;
            this.lblCitySelected.Location = new System.Drawing.Point(341, 33);
            this.lblCitySelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCitySelected.Name = "lblCitySelected";
            this.lblCitySelected.Size = new System.Drawing.Size(98, 17);
            this.lblCitySelected.TabIndex = 3;
            this.lblCitySelected.Text = "City Selected: ";
            // 
            // dgvMinister
            // 
            this.dgvMinister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinister.Location = new System.Drawing.Point(51, 72);
            this.dgvMinister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMinister.Name = "dgvMinister";
            this.dgvMinister.RowTemplate.Height = 40;
            this.dgvMinister.Size = new System.Drawing.Size(518, 305);
            this.dgvMinister.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 410);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 410);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMinisterSuggestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 476);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvMinister);
            this.Controls.Add(this.lblCitySelected);
            this.Controls.Add(this.lblDateSelected);
            this.Controls.Add(this.txtCitySelected);
            this.Controls.Add(this.txtDateSelected);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMinisterSuggestion";
            this.Text = "Church of God - Suggest Minister";
            this.Load += new System.EventHandler(this.frmMinisterSuggestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcMinisters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDateSelected;
        private System.Windows.Forms.TextBox txtCitySelected;
        private System.Windows.Forms.Label lblDateSelected;
        private System.Windows.Forms.Label lblCitySelected;
        private System.Windows.Forms.DataGridView dgvMinister;
        private System.Windows.Forms.BindingSource bindSrcMinisters;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
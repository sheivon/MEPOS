namespace InvoicePrinter.Employees
{
    partial class Usersfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empviewer = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Panelmain = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnNewEmployee = new GUIHelper.GButton(this.components);
            this.GButton2 = new GUIHelper.GButton(this.components);
            this.btnEditInfo = new GUIHelper.GButton(this.components);
            this.btnDeleteRec = new GUIHelper.GButton(this.components);
            this.GButton1 = new GUIHelper.GButton(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.txtSearch = new GUIHelper.GTxt();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empviewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.Panelmain.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // empviewer
            // 
            this.empviewer.AllowUserToAddRows = false;
            this.empviewer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empviewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empviewer.AutoGenerateColumns = false;
            this.empviewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empviewer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.empviewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empviewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.empviewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empviewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empviewer.ColumnHeadersHeight = 35;
            this.empviewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.srnameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.firedDataGridViewCheckBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.empviewer.DataSource = this.usersBindingSource;
            this.empviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empviewer.Location = new System.Drawing.Point(0, 54);
            this.empviewer.MultiSelect = false;
            this.empviewer.Name = "empviewer";
            this.empviewer.ReadOnly = true;
            this.empviewer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empviewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.empviewer.RowHeadersVisible = false;
            this.empviewer.RowHeadersWidth = 10;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empviewer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.empviewer.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.empviewer.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empviewer.RowTemplate.Height = 50;
            this.empviewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empviewer.ShowEditingIcon = false;
            this.empviewer.Size = new System.Drawing.Size(1026, 319);
            this.empviewer.TabIndex = 24;
            this.empviewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empviewer_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srnameDataGridViewTextBoxColumn
            // 
            this.srnameDataGridViewTextBoxColumn.DataPropertyName = "Srname";
            this.srnameDataGridViewTextBoxColumn.HeaderText = "Srname";
            this.srnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.srnameDataGridViewTextBoxColumn.Name = "srnameDataGridViewTextBoxColumn";
            this.srnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firedDataGridViewCheckBoxColumn
            // 
            this.firedDataGridViewCheckBoxColumn.DataPropertyName = "Fired";
            this.firedDataGridViewCheckBoxColumn.HeaderText = "Fired";
            this.firedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.firedDataGridViewCheckBoxColumn.Name = "firedDataGridViewCheckBoxColumn";
            this.firedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "RegDate";
            this.regDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            this.regDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            this.passDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Entities.Users);
            // 
            // Panelmain
            // 
            this.Panelmain.Controls.Add(this.empviewer);
            this.Panelmain.Controls.Add(this.Panel1);
            this.Panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelmain.Location = new System.Drawing.Point(5, 78);
            this.Panelmain.Name = "Panelmain";
            this.Panelmain.Size = new System.Drawing.Size(1026, 373);
            this.Panelmain.TabIndex = 9;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnNewEmployee);
            this.Panel1.Controls.Add(this.GButton2);
            this.Panel1.Controls.Add(this.btnEditInfo);
            this.Panel1.Controls.Add(this.btnDeleteRec);
            this.Panel1.Controls.Add(this.GButton1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1026, 54);
            this.Panel1.TabIndex = 7;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewEmployee.FlatAppearance.BorderSize = 0;
            this.btnNewEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnNewEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployee.Image = global::InvoicePrinter.Properties.Resources.Plus;
            this.btnNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEmployee.Location = new System.Drawing.Point(62, 7);
            this.btnNewEmployee.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnNewEmployee.MinimumSize = new System.Drawing.Size(160, 40);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(160, 40);
            this.btnNewEmployee.TabIndex = 2;
            this.btnNewEmployee.Text = "NewEmployee";
            this.btnNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewEmployee.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // GButton2
            // 
            this.GButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GButton2.FlatAppearance.BorderSize = 0;
            this.GButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.GButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GButton2.Location = new System.Drawing.Point(594, 7);
            this.GButton2.MaximumSize = new System.Drawing.Size(171, 49);
            this.GButton2.MinimumSize = new System.Drawing.Size(160, 40);
            this.GButton2.Name = "GButton2";
            this.GButton2.Size = new System.Drawing.Size(160, 40);
            this.GButton2.TabIndex = 7;
            this.GButton2.Text = "Re-Hired Employee";
            this.GButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GButton2.UIStyle = GUIHelper.GButton.Style.Flat;
            this.GButton2.UseVisualStyleBackColor = true;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditInfo.FlatAppearance.BorderSize = 0;
            this.btnEditInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnEditInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInfo.Image = global::InvoicePrinter.Properties.Resources.Edit;
            this.btnEditInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditInfo.Location = new System.Drawing.Point(240, 7);
            this.btnEditInfo.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnEditInfo.MinimumSize = new System.Drawing.Size(160, 40);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(160, 40);
            this.btnEditInfo.TabIndex = 6;
            this.btnEditInfo.Text = "Edit Employee";
            this.btnEditInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditInfo.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnDeleteRec
            // 
            this.btnDeleteRec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteRec.FlatAppearance.BorderSize = 0;
            this.btnDeleteRec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnDeleteRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnDeleteRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRec.Image = global::InvoicePrinter.Properties.Resources.Delete__2_;
            this.btnDeleteRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRec.Location = new System.Drawing.Point(771, 7);
            this.btnDeleteRec.MaximumSize = new System.Drawing.Size(171, 49);
            this.btnDeleteRec.MinimumSize = new System.Drawing.Size(160, 40);
            this.btnDeleteRec.Name = "btnDeleteRec";
            this.btnDeleteRec.Size = new System.Drawing.Size(160, 40);
            this.btnDeleteRec.TabIndex = 5;
            this.btnDeleteRec.Text = "Delete";
            this.btnDeleteRec.UIStyle = GUIHelper.GButton.Style.Flat;
            this.btnDeleteRec.UseVisualStyleBackColor = true;
            // 
            // GButton1
            // 
            this.GButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GButton1.FlatAppearance.BorderSize = 0;
            this.GButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.GButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GButton1.Location = new System.Drawing.Point(417, 7);
            this.GButton1.MaximumSize = new System.Drawing.Size(171, 49);
            this.GButton1.MinimumSize = new System.Drawing.Size(160, 40);
            this.GButton1.Name = "GButton1";
            this.GButton1.Size = new System.Drawing.Size(160, 40);
            this.GButton1.TabIndex = 1;
            this.GButton1.Text = "Fired Employee";
            this.GButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GButton1.UIStyle = GUIHelper.GButton.Style.Flat;
            this.GButton1.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.txtSearch);
            this.TopPanel.Controls.Add(this.Label2);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(5, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(60, 2, 60, 0);
            this.TopPanel.Size = new System.Drawing.Size(1026, 73);
            this.TopPanel.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkOrchid;
            this.txtSearch.Location = new System.Drawing.Point(60, 35);
            this.txtSearch.MaxLength = 2500;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(906, 23);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.WatermarkText = "Search via Username | Sr Name | ID Number | Mobile ";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(60, 2);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(906, 33);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Employee\'s";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Usersfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panelmain);
            this.Controls.Add(this.TopPanel);
            this.Name = "Usersfrm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1036, 456);
            this.Load += new System.EventHandler(this.Usersfrm_Load);
            this.BackColorChanged += new System.EventHandler(this.Usersfrm_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.empviewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.Panelmain.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView empviewer;
        internal System.Windows.Forms.Panel Panelmain;
        internal System.Windows.Forms.Panel Panel1;
        internal GUIHelper.GButton GButton2;
        internal GUIHelper.GButton btnEditInfo;
        internal GUIHelper.GButton btnDeleteRec;
        internal GUIHelper.GButton GButton1;
        internal GUIHelper.GButton btnNewEmployee;
        private System.Windows.Forms.Panel TopPanel;
        internal GUIHelper.GTxt txtSearch;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn firedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
    }
}

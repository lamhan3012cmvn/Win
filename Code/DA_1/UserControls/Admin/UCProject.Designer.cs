namespace DA_1.UserControls.Admin
{
    partial class UCProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Controls = new Guna.UI.WinForms.GunaPanel();
            this.cbx_Search = new Guna.UI.WinForms.GunaComboBox();
            this.txt_SearchName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Container = new Guna.UI.WinForms.GunaPanel();
            this.dtGrid_Manage = new Guna.UI.WinForms.GunaDataGridView();
            this.colProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKoProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Controls.SuspendLayout();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Manage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.cbx_Search);
            this.pnl_Controls.Controls.Add(this.txt_SearchName);
            this.pnl_Controls.Controls.Add(this.gunaLabel2);
            this.pnl_Controls.Controls.Add(this.gunaLabel1);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_Controls.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(1888, 212);
            this.pnl_Controls.TabIndex = 0;
            // 
            // cbx_Search
            // 
            this.cbx_Search.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Search.BaseColor = System.Drawing.Color.White;
            this.cbx_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Search.BorderSize = 1;
            this.cbx_Search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Search.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Search.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Search.ForeColor = System.Drawing.Color.Black;
            this.cbx_Search.FormattingEnabled = true;
            this.cbx_Search.Items.AddRange(new object[] {
            "Project ID",
            "Project Name",
            "Kind of Project",
            "Faculty",
            "Teacher",
            "Team Name"});
            this.cbx_Search.Location = new System.Drawing.Point(992, 98);
            this.cbx_Search.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Search.Name = "cbx_Search";
            this.cbx_Search.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Search.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Search.Radius = 10;
            this.cbx_Search.Size = new System.Drawing.Size(284, 40);
            this.cbx_Search.TabIndex = 3;
            this.cbx_Search.DropDownClosed += new System.EventHandler(this.cbx_Search_DropDownClosed);
            // 
            // txt_SearchName
            // 
            this.txt_SearchName.BackColor = System.Drawing.Color.Transparent;
            this.txt_SearchName.BaseColor = System.Drawing.Color.White;
            this.txt_SearchName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_SearchName.BorderSize = 1;
            this.txt_SearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SearchName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_SearchName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_SearchName.FocusedForeColor = System.Drawing.Color.Black;
            this.txt_SearchName.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchName.ForeColor = System.Drawing.Color.Black;
            this.txt_SearchName.Location = new System.Drawing.Point(384, 92);
            this.txt_SearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.PasswordChar = '\0';
            this.txt_SearchName.Radius = 10;
            this.txt_SearchName.Size = new System.Drawing.Size(916, 63);
            this.txt_SearchName.TabIndex = 2;
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.gunaLabel2.Location = new System.Drawing.Point(748, 21);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(309, 44);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Manage Project:";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.gunaLabel1.Location = new System.Drawing.Point(184, 96);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(145, 44);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Search";
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dtGrid_Manage);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 212);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1888, 982);
            this.pnl_Container.TabIndex = 1;
            // 
            // dtGrid_Manage
            // 
            this.dtGrid_Manage.AllowUserToAddRows = false;
            this.dtGrid_Manage.AllowUserToDeleteRows = false;
            this.dtGrid_Manage.AllowUserToResizeColumns = false;
            this.dtGrid_Manage.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGrid_Manage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_Manage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Manage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtGrid_Manage.BackgroundColor = System.Drawing.Color.White;
            this.dtGrid_Manage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid_Manage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Manage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Manage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_Manage.ColumnHeadersHeight = 80;
            this.dtGrid_Manage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectID,
            this.colProjectName,
            this.colKoProject,
            this.colFaculty,
            this.colTeacher,
            this.colTeamName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Manage.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_Manage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_Manage.EnableHeadersVisualStyles = false;
            this.dtGrid_Manage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Manage.Location = new System.Drawing.Point(0, 0);
            this.dtGrid_Manage.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrid_Manage.Name = "dtGrid_Manage";
            this.dtGrid_Manage.RowHeadersVisible = false;
            this.dtGrid_Manage.RowHeadersWidth = 82;
            this.dtGrid_Manage.RowTemplate.Height = 40;
            this.dtGrid_Manage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_Manage.Size = new System.Drawing.Size(1888, 982);
            this.dtGrid_Manage.TabIndex = 0;
            this.dtGrid_Manage.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGrid_Manage.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Manage.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGrid_Manage.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Manage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGrid_Manage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Manage.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Manage.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Manage.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGrid_Manage.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid_Manage.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Manage.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGrid_Manage.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGrid_Manage.ThemeStyle.HeaderStyle.Height = 80;
            this.dtGrid_Manage.ThemeStyle.ReadOnly = false;
            this.dtGrid_Manage.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Manage.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Manage.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Manage.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_Manage.ThemeStyle.RowsStyle.Height = 40;
            this.dtGrid_Manage.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Manage.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colProjectID
            // 
            this.colProjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProjectID.HeaderText = "Project ID";
            this.colProjectID.MinimumWidth = 10;
            this.colProjectID.Name = "colProjectID";
            this.colProjectID.ReadOnly = true;
            this.colProjectID.Width = 191;
            // 
            // colProjectName
            // 
            this.colProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProjectName.HeaderText = "Project Name";
            this.colProjectName.MinimumWidth = 10;
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            // 
            // colKoProject
            // 
            this.colKoProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKoProject.HeaderText = "Kind of Project";
            this.colKoProject.MinimumWidth = 10;
            this.colKoProject.Name = "colKoProject";
            this.colKoProject.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.MinimumWidth = 10;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colTeacher
            // 
            this.colTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacher.HeaderText = "Teacher";
            this.colTeacher.MinimumWidth = 10;
            this.colTeacher.Name = "colTeacher";
            this.colTeacher.ReadOnly = true;
            // 
            // colTeamName
            // 
            this.colTeamName.HeaderText = "Team Name";
            this.colTeamName.MinimumWidth = 10;
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.ReadOnly = true;
            // 
            // UCProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Controls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCProject";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Manage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Controls;
        private Guna.UI.WinForms.GunaTextBox txt_SearchName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel pnl_Container;
        private Guna.UI.WinForms.GunaComboBox cbx_Search;
        private Guna.UI.WinForms.GunaDataGridView dtGrid_Manage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKoProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
    }
}

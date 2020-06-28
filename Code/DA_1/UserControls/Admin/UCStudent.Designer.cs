namespace DA_1.UserControls.Admin
{
    partial class UCStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_StudentControls = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Search = new Guna.UI.WinForms.GunaPanel();
            this.cbx_Select = new Guna.UI.WinForms.GunaComboBox();
            this.txt_Search = new Guna.UI.WinForms.GunaTextBox();
            this.btn_NewStudent = new Guna.UI.WinForms.GunaButton();
            this.pnl_StudentContain = new Guna.UI.WinForms.GunaPanel();
            this.dtGrid_Students = new Guna.UI.WinForms.GunaDataGridView();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_StudentControls.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_StudentContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_StudentControls
            // 
            this.pnl_StudentControls.BackColor = System.Drawing.Color.White;
            this.pnl_StudentControls.Controls.Add(this.gunaLabel1);
            this.pnl_StudentControls.Controls.Add(this.pnl_Search);
            this.pnl_StudentControls.Controls.Add(this.btn_NewStudent);
            this.pnl_StudentControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_StudentControls.Location = new System.Drawing.Point(0, 0);
            this.pnl_StudentControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_StudentControls.Name = "pnl_StudentControls";
            this.pnl_StudentControls.Size = new System.Drawing.Size(1888, 346);
            this.pnl_StudentControls.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Snap ITC", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.gunaLabel1.Location = new System.Drawing.Point(116, 46);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(362, 89);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Student";
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.cbx_Select);
            this.pnl_Search.Controls.Add(this.txt_Search);
            this.pnl_Search.Location = new System.Drawing.Point(576, 96);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(821, 129);
            this.pnl_Search.TabIndex = 2;
            // 
            // cbx_Select
            // 
            this.cbx_Select.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Select.BaseColor = System.Drawing.Color.White;
            this.cbx_Select.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Select.BorderSize = 1;
            this.cbx_Select.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Select.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Select.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Select.ForeColor = System.Drawing.Color.Black;
            this.cbx_Select.FormattingEnabled = true;
            this.cbx_Select.Items.AddRange(new object[] {
            "Student ID",
            "Student Name",
            "Faculty",
            "Team Name"});
            this.cbx_Select.Location = new System.Drawing.Point(519, 41);
            this.cbx_Select.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Select.Name = "cbx_Select";
            this.cbx_Select.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbx_Select.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Select.Radius = 10;
            this.cbx_Select.Size = new System.Drawing.Size(258, 44);
            this.cbx_Select.TabIndex = 3;
            this.cbx_Select.DropDownClosed += new System.EventHandler(this.cbx_Select_DropDownClosed);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.Transparent;
            this.txt_Search.BaseColor = System.Drawing.Color.White;
            this.txt_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Search.BorderSize = 1;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Search.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Search.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(96, 31);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.Radius = 10;
            this.txt_Search.Size = new System.Drawing.Size(700, 68);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // btn_NewStudent
            // 
            this.btn_NewStudent.AnimationHoverSpeed = 0.07F;
            this.btn_NewStudent.AnimationSpeed = 0.03F;
            this.btn_NewStudent.BackColor = System.Drawing.Color.Transparent;
            this.btn_NewStudent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewStudent.BorderSize = 1;
            this.btn_NewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_NewStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btn_NewStudent.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewStudent.ForeColor = System.Drawing.Color.White;
            this.btn_NewStudent.Image = null;
            this.btn_NewStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NewStudent.Location = new System.Drawing.Point(1472, 112);
            this.btn_NewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewStudent.Name = "btn_NewStudent";
            this.btn_NewStudent.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_NewStudent.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewStudent.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewStudent.OnHoverImage = null;
            this.btn_NewStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NewStudent.Radius = 10;
            this.btn_NewStudent.Size = new System.Drawing.Size(258, 83);
            this.btn_NewStudent.TabIndex = 0;
            this.btn_NewStudent.Text = "New Student";
            this.btn_NewStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_NewStudent.Click += new System.EventHandler(this.btn_NewStudent_Click);
            // 
            // pnl_StudentContain
            // 
            this.pnl_StudentContain.Controls.Add(this.dtGrid_Students);
            this.pnl_StudentContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_StudentContain.Location = new System.Drawing.Point(0, 346);
            this.pnl_StudentContain.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_StudentContain.Name = "pnl_StudentContain";
            this.pnl_StudentContain.Size = new System.Drawing.Size(1888, 848);
            this.pnl_StudentContain.TabIndex = 1;
            // 
            // dtGrid_Students
            // 
            this.dtGrid_Students.AllowUserToAddRows = false;
            this.dtGrid_Students.AllowUserToDeleteRows = false;
            this.dtGrid_Students.AllowUserToResizeColumns = false;
            this.dtGrid_Students.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGrid_Students.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid_Students.BackgroundColor = System.Drawing.Color.White;
            this.dtGrid_Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid_Students.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Students.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_Students.ColumnHeadersHeight = 40;
            this.dtGrid_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colStudentName,
            this.colFaculty,
            this.colTeamName,
            this.colProjectName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_Students.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_Students.EnableHeadersVisualStyles = false;
            this.dtGrid_Students.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Students.Location = new System.Drawing.Point(0, 0);
            this.dtGrid_Students.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrid_Students.Name = "dtGrid_Students";
            this.dtGrid_Students.RowHeadersVisible = false;
            this.dtGrid_Students.RowHeadersWidth = 82;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Students.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrid_Students.RowTemplate.Height = 33;
            this.dtGrid_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_Students.Size = new System.Drawing.Size(1888, 848);
            this.dtGrid_Students.TabIndex = 0;
            this.dtGrid_Students.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGrid_Students.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Students.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGrid_Students.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Students.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGrid_Students.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Students.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Students.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Students.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGrid_Students.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid_Students.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Students.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGrid_Students.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGrid_Students.ThemeStyle.HeaderStyle.Height = 40;
            this.dtGrid_Students.ThemeStyle.ReadOnly = false;
            this.dtGrid_Students.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Students.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Students.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Students.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_Students.ThemeStyle.RowsStyle.Height = 33;
            this.dtGrid_Students.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Students.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Students_CellClick);
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "Student ID";
            this.colStudentID.MinimumWidth = 10;
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            // 
            // colStudentName
            // 
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.MinimumWidth = 10;
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.MinimumWidth = 10;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colTeamName
            // 
            this.colTeamName.HeaderText = "Team Name";
            this.colTeamName.MinimumWidth = 10;
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.ReadOnly = true;
            // 
            // colProjectName
            // 
            this.colProjectName.HeaderText = "Project Name";
            this.colProjectName.MinimumWidth = 10;
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            // 
            // UCStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_StudentContain);
            this.Controls.Add(this.pnl_StudentControls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCStudent";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_StudentControls.ResumeLayout(false);
            this.pnl_StudentControls.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_StudentContain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_StudentControls;
        private Guna.UI.WinForms.GunaPanel pnl_StudentContain;
        private Guna.UI.WinForms.GunaDataGridView dtGrid_Students;
        private Guna.UI.WinForms.GunaButton btn_NewStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel pnl_Search;
        private Guna.UI.WinForms.GunaComboBox cbx_Select;
        private Guna.UI.WinForms.GunaTextBox txt_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
    }
}

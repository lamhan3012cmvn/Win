namespace DA_1.UserControls.Admin
{
    partial class UCTeacher
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
            this.pnl_StudentContain = new Guna.UI.WinForms.GunaPanel();
            this.dtGrid_Teacher = new Guna.UI.WinForms.GunaDataGridView();
            this.colTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_TeacherControls = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Search = new Guna.UI.WinForms.GunaPanel();
            this.cbx_Select = new Guna.UI.WinForms.GunaComboBox();
            this.txt_Search = new Guna.UI.WinForms.GunaTextBox();
            this.btn_NewTeacher = new Guna.UI.WinForms.GunaButton();
            this.pnl_StudentContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Teacher)).BeginInit();
            this.pnl_TeacherControls.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_StudentContain
            // 
            this.pnl_StudentContain.Controls.Add(this.dtGrid_Teacher);
            this.pnl_StudentContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_StudentContain.Location = new System.Drawing.Point(0, 346);
            this.pnl_StudentContain.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_StudentContain.Name = "pnl_StudentContain";
            this.pnl_StudentContain.Size = new System.Drawing.Size(1888, 848);
            this.pnl_StudentContain.TabIndex = 3;
            // 
            // dtGrid_Teacher
            // 
            this.dtGrid_Teacher.AllowUserToAddRows = false;
            this.dtGrid_Teacher.AllowUserToDeleteRows = false;
            this.dtGrid_Teacher.AllowUserToResizeColumns = false;
            this.dtGrid_Teacher.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGrid_Teacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_Teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Teacher.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid_Teacher.BackgroundColor = System.Drawing.Color.White;
            this.dtGrid_Teacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid_Teacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Teacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Teacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_Teacher.ColumnHeadersHeight = 40;
            this.dtGrid_Teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeacherID,
            this.colTeacherName,
            this.colFaculty,
            this.colPosition,
            this.colAL,
            this.colProjectName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_Teacher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_Teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_Teacher.EnableHeadersVisualStyles = false;
            this.dtGrid_Teacher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Teacher.Location = new System.Drawing.Point(0, 0);
            this.dtGrid_Teacher.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrid_Teacher.Name = "dtGrid_Teacher";
            this.dtGrid_Teacher.RowHeadersVisible = false;
            this.dtGrid_Teacher.RowHeadersWidth = 82;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Teacher.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrid_Teacher.RowTemplate.Height = 33;
            this.dtGrid_Teacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_Teacher.Size = new System.Drawing.Size(1888, 848);
            this.dtGrid_Teacher.TabIndex = 0;
            this.dtGrid_Teacher.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGrid_Teacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Teacher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGrid_Teacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Teacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGrid_Teacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Teacher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Teacher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Teacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGrid_Teacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid_Teacher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Teacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGrid_Teacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGrid_Teacher.ThemeStyle.HeaderStyle.Height = 40;
            this.dtGrid_Teacher.ThemeStyle.ReadOnly = false;
            this.dtGrid_Teacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Teacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Teacher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Teacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_Teacher.ThemeStyle.RowsStyle.Height = 33;
            this.dtGrid_Teacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Teacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_Teacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Teacher_CellClick);
            // 
            // colTeacherID
            // 
            this.colTeacherID.HeaderText = "Teacher ID";
            this.colTeacherID.MinimumWidth = 10;
            this.colTeacherID.Name = "colTeacherID";
            this.colTeacherID.ReadOnly = true;
            // 
            // colTeacherName
            // 
            this.colTeacherName.HeaderText = "Teacher Name";
            this.colTeacherName.MinimumWidth = 10;
            this.colTeacherName.Name = "colTeacherName";
            this.colTeacherName.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.MinimumWidth = 10;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Position";
            this.colPosition.MinimumWidth = 10;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            // 
            // colAL
            // 
            this.colAL.HeaderText = "Academic Level";
            this.colAL.MinimumWidth = 10;
            this.colAL.Name = "colAL";
            this.colAL.ReadOnly = true;
            // 
            // colProjectName
            // 
            this.colProjectName.HeaderText = "Project Name";
            this.colProjectName.MinimumWidth = 10;
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            // 
            // pnl_TeacherControls
            // 
            this.pnl_TeacherControls.BackColor = System.Drawing.Color.White;
            this.pnl_TeacherControls.Controls.Add(this.gunaLabel1);
            this.pnl_TeacherControls.Controls.Add(this.pnl_Search);
            this.pnl_TeacherControls.Controls.Add(this.btn_NewTeacher);
            this.pnl_TeacherControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TeacherControls.Location = new System.Drawing.Point(0, 0);
            this.pnl_TeacherControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TeacherControls.Name = "pnl_TeacherControls";
            this.pnl_TeacherControls.Size = new System.Drawing.Size(1888, 346);
            this.pnl_TeacherControls.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Snap ITC", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.gunaLabel1.Location = new System.Drawing.Point(116, 46);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(352, 89);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Teacher";
            // 
            // pnl_Search
            // 
            this.pnl_Search.Controls.Add(this.cbx_Select);
            this.pnl_Search.Controls.Add(this.txt_Search);
            this.pnl_Search.Location = new System.Drawing.Point(576, 96);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(869, 129);
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
            this.cbx_Select.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Select.ForeColor = System.Drawing.Color.Black;
            this.cbx_Select.FormattingEnabled = true;
            this.cbx_Select.Items.AddRange(new object[] {
            "Teacher ID",
            "Teacher Name",
            "Faculty",
            "Position",
            "Academic Level",
            "Project Name"});
            this.cbx_Select.Location = new System.Drawing.Point(519, 41);
            this.cbx_Select.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Select.Name = "cbx_Select";
            this.cbx_Select.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Select.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Select.Radius = 10;
            this.cbx_Select.Size = new System.Drawing.Size(258, 40);
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
            // btn_NewTeacher
            // 
            this.btn_NewTeacher.AnimationHoverSpeed = 0.07F;
            this.btn_NewTeacher.AnimationSpeed = 0.03F;
            this.btn_NewTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btn_NewTeacher.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewTeacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewTeacher.BorderSize = 1;
            this.btn_NewTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewTeacher.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_NewTeacher.FocusedColor = System.Drawing.Color.Empty;
            this.btn_NewTeacher.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewTeacher.ForeColor = System.Drawing.Color.White;
            this.btn_NewTeacher.Image = null;
            this.btn_NewTeacher.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NewTeacher.Location = new System.Drawing.Point(1472, 112);
            this.btn_NewTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewTeacher.Name = "btn_NewTeacher";
            this.btn_NewTeacher.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_NewTeacher.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewTeacher.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_NewTeacher.OnHoverImage = null;
            this.btn_NewTeacher.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NewTeacher.Radius = 10;
            this.btn_NewTeacher.Size = new System.Drawing.Size(258, 83);
            this.btn_NewTeacher.TabIndex = 0;
            this.btn_NewTeacher.Text = "New Teacher";
            this.btn_NewTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_NewTeacher.Click += new System.EventHandler(this.btn_NewTeacher_Click);
            // 
            // UCTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_StudentContain);
            this.Controls.Add(this.pnl_TeacherControls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTeacher";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_StudentContain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Teacher)).EndInit();
            this.pnl_TeacherControls.ResumeLayout(false);
            this.pnl_TeacherControls.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_StudentContain;
        private Guna.UI.WinForms.GunaDataGridView dtGrid_Teacher;
        private Guna.UI.WinForms.GunaPanel pnl_TeacherControls;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel pnl_Search;
        private Guna.UI.WinForms.GunaComboBox cbx_Select;
        private Guna.UI.WinForms.GunaTextBox txt_Search;
        private Guna.UI.WinForms.GunaButton btn_NewTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
    }
}

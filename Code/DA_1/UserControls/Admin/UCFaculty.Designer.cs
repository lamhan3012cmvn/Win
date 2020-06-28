namespace DA_1.UserControls.Admin
{
    partial class UCFaculty
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
            this.timeLoad = new System.Windows.Forms.Timer(this.components);
            this.pnl_Controls = new Guna.UI.WinForms.GunaPanel();
            this.btn_Del = new Guna.UI.WinForms.GunaButton();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.lbl_FacultyName = new Guna.UI.WinForms.GunaLabel();
            this.lbl_FacultyID = new Guna.UI.WinForms.GunaLabel();
            this.txt_FacultyName = new Guna.UI.WinForms.GunaTextBox();
            this.txt_FacultyId = new Guna.UI.WinForms.GunaTextBox();
            this.btn_AddNewFaculty = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Container = new Guna.UI.WinForms.GunaPanel();
            this.dtGrid_Faculty = new Guna.UI.WinForms.GunaDataGridView();
            this.colFacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Controls.SuspendLayout();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Faculty)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.BackColor = System.Drawing.Color.White;
            this.pnl_Controls.Controls.Add(this.btn_Del);
            this.pnl_Controls.Controls.Add(this.btn_Edit);
            this.pnl_Controls.Controls.Add(this.btn_Back);
            this.pnl_Controls.Controls.Add(this.btn_Add);
            this.pnl_Controls.Controls.Add(this.lbl_FacultyName);
            this.pnl_Controls.Controls.Add(this.lbl_FacultyID);
            this.pnl_Controls.Controls.Add(this.txt_FacultyName);
            this.pnl_Controls.Controls.Add(this.txt_FacultyId);
            this.pnl_Controls.Controls.Add(this.btn_AddNewFaculty);
            this.pnl_Controls.Controls.Add(this.gunaLabel1);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_Controls.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(1888, 356);
            this.pnl_Controls.TabIndex = 0;
            // 
            // btn_Del
            // 
            this.btn_Del.AnimationHoverSpeed = 0.07F;
            this.btn_Del.AnimationSpeed = 0.03F;
            this.btn_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_Del.BaseColor = System.Drawing.Color.White;
            this.btn_Del.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Del.BorderSize = 1;
            this.btn_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Del.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Del.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Del.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Del.Image = null;
            this.btn_Del.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Del.Location = new System.Drawing.Point(1540, 256);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Del.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Del.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Del.OnHoverImage = null;
            this.btn_Del.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Del.Radius = 10;
            this.btn_Del.Size = new System.Drawing.Size(282, 73);
            this.btn_Del.TabIndex = 4;
            this.btn_Del.Text = "DELETE";
            this.btn_Del.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Del.Visible = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AnimationHoverSpeed = 0.07F;
            this.btn_Edit.AnimationSpeed = 0.03F;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BaseColor = System.Drawing.Color.White;
            this.btn_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.BorderSize = 1;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Edit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.Image = null;
            this.btn_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Edit.Location = new System.Drawing.Point(1192, 256);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Radius = 10;
            this.btn_Edit.Size = new System.Drawing.Size(282, 73);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Edit.Visible = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.AnimationHoverSpeed = 0.07F;
            this.btn_Back.AnimationSpeed = 0.03F;
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BaseColor = System.Drawing.Color.White;
            this.btn_Back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.BorderSize = 1;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Back.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.Image = null;
            this.btn_Back.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Back.Location = new System.Drawing.Point(1192, 256);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Back.Radius = 10;
            this.btn_Back.Size = new System.Drawing.Size(282, 73);
            this.btn_Back.TabIndex = 28;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BaseColor = System.Drawing.Color.White;
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.BorderSize = 1;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.Image = null;
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(1540, 256);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Add.Radius = 10;
            this.btn_Add.Size = new System.Drawing.Size(282, 73);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "ADD";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_FacultyName
            // 
            this.lbl_FacultyName.AutoSize = true;
            this.lbl_FacultyName.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FacultyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.lbl_FacultyName.Location = new System.Drawing.Point(952, 167);
            this.lbl_FacultyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FacultyName.Name = "lbl_FacultyName";
            this.lbl_FacultyName.Size = new System.Drawing.Size(275, 44);
            this.lbl_FacultyName.TabIndex = 9;
            this.lbl_FacultyName.Text = "Faculty Name:";
            this.lbl_FacultyName.Visible = false;
            // 
            // lbl_FacultyID
            // 
            this.lbl_FacultyID.AutoSize = true;
            this.lbl_FacultyID.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FacultyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.lbl_FacultyID.Location = new System.Drawing.Point(248, 167);
            this.lbl_FacultyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FacultyID.Name = "lbl_FacultyID";
            this.lbl_FacultyID.Size = new System.Drawing.Size(209, 44);
            this.lbl_FacultyID.TabIndex = 10;
            this.lbl_FacultyID.Text = "Faculty ID:";
            this.lbl_FacultyID.Visible = false;
            // 
            // txt_FacultyName
            // 
            this.txt_FacultyName.BackColor = System.Drawing.Color.Transparent;
            this.txt_FacultyName.BaseColor = System.Drawing.Color.White;
            this.txt_FacultyName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyName.BorderSize = 1;
            this.txt_FacultyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FacultyName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_FacultyName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyName.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyName.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FacultyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyName.Location = new System.Drawing.Point(1262, 156);
            this.txt_FacultyName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FacultyName.Name = "txt_FacultyName";
            this.txt_FacultyName.PasswordChar = '\0';
            this.txt_FacultyName.Radius = 10;
            this.txt_FacultyName.Size = new System.Drawing.Size(308, 81);
            this.txt_FacultyName.TabIndex = 2;
            this.txt_FacultyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_FacultyName.Visible = false;
            // 
            // txt_FacultyId
            // 
            this.txt_FacultyId.BackColor = System.Drawing.Color.Transparent;
            this.txt_FacultyId.BaseColor = System.Drawing.Color.White;
            this.txt_FacultyId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyId.BorderSize = 1;
            this.txt_FacultyId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FacultyId.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_FacultyId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyId.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyId.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FacultyId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_FacultyId.Location = new System.Drawing.Point(488, 156);
            this.txt_FacultyId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FacultyId.Name = "txt_FacultyId";
            this.txt_FacultyId.PasswordChar = '\0';
            this.txt_FacultyId.Radius = 10;
            this.txt_FacultyId.Size = new System.Drawing.Size(308, 81);
            this.txt_FacultyId.TabIndex = 1;
            this.txt_FacultyId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_FacultyId.Visible = false;
            // 
            // btn_AddNewFaculty
            // 
            this.btn_AddNewFaculty.AnimationHoverSpeed = 0.07F;
            this.btn_AddNewFaculty.AnimationSpeed = 0.03F;
            this.btn_AddNewFaculty.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddNewFaculty.BaseColor = System.Drawing.Color.White;
            this.btn_AddNewFaculty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddNewFaculty.BorderSize = 1;
            this.btn_AddNewFaculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNewFaculty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddNewFaculty.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddNewFaculty.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddNewFaculty.Image = null;
            this.btn_AddNewFaculty.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddNewFaculty.Location = new System.Drawing.Point(668, 148);
            this.btn_AddNewFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddNewFaculty.Name = "btn_AddNewFaculty";
            this.btn_AddNewFaculty.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddNewFaculty.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_AddNewFaculty.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AddNewFaculty.OnHoverImage = null;
            this.btn_AddNewFaculty.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_AddNewFaculty.Radius = 10;
            this.btn_AddNewFaculty.Size = new System.Drawing.Size(608, 79);
            this.btn_AddNewFaculty.TabIndex = 10;
            this.btn_AddNewFaculty.Text = "Add New Faculty";
            this.btn_AddNewFaculty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddNewFaculty.Click += new System.EventHandler(this.btn_AddNewFaculty_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.gunaLabel1.Location = new System.Drawing.Point(66, 29);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(211, 62);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Faculty";
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dtGrid_Faculty);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 356);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1888, 736);
            this.pnl_Container.TabIndex = 1;
            // 
            // dtGrid_Faculty
            // 
            this.dtGrid_Faculty.AllowUserToAddRows = false;
            this.dtGrid_Faculty.AllowUserToDeleteRows = false;
            this.dtGrid_Faculty.AllowUserToResizeColumns = false;
            this.dtGrid_Faculty.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGrid_Faculty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_Faculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_Faculty.BackgroundColor = System.Drawing.Color.White;
            this.dtGrid_Faculty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid_Faculty.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Faculty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_Faculty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_Faculty.ColumnHeadersHeight = 46;
            this.dtGrid_Faculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFacultyID,
            this.colFacultyName,
            this.colAmountStudent,
            this.colAmountTeacher});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_Faculty.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_Faculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_Faculty.EnableHeadersVisualStyles = false;
            this.dtGrid_Faculty.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Faculty.Location = new System.Drawing.Point(0, 0);
            this.dtGrid_Faculty.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrid_Faculty.Name = "dtGrid_Faculty";
            this.dtGrid_Faculty.RowHeadersVisible = false;
            this.dtGrid_Faculty.RowHeadersWidth = 82;
            this.dtGrid_Faculty.RowTemplate.Height = 33;
            this.dtGrid_Faculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_Faculty.Size = new System.Drawing.Size(1888, 736);
            this.dtGrid_Faculty.TabIndex = 3;
            this.dtGrid_Faculty.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGrid_Faculty.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Faculty.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGrid_Faculty.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Faculty.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGrid_Faculty.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGrid_Faculty.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Faculty.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Faculty.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGrid_Faculty.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid_Faculty.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Faculty.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGrid_Faculty.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGrid_Faculty.ThemeStyle.HeaderStyle.Height = 46;
            this.dtGrid_Faculty.ThemeStyle.ReadOnly = false;
            this.dtGrid_Faculty.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_Faculty.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_Faculty.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_Faculty.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_Faculty.ThemeStyle.RowsStyle.Height = 33;
            this.dtGrid_Faculty.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_Faculty.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_Faculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_Faculty_CellClick);
            // 
            // colFacultyID
            // 
            this.colFacultyID.HeaderText = "FacultyID";
            this.colFacultyID.MinimumWidth = 10;
            this.colFacultyID.Name = "colFacultyID";
            this.colFacultyID.ReadOnly = true;
            // 
            // colFacultyName
            // 
            this.colFacultyName.HeaderText = "Faculty Name";
            this.colFacultyName.MinimumWidth = 10;
            this.colFacultyName.Name = "colFacultyName";
            this.colFacultyName.ReadOnly = true;
            // 
            // colAmountStudent
            // 
            this.colAmountStudent.HeaderText = "Amount of Student";
            this.colAmountStudent.MinimumWidth = 10;
            this.colAmountStudent.Name = "colAmountStudent";
            this.colAmountStudent.ReadOnly = true;
            // 
            // colAmountTeacher
            // 
            this.colAmountTeacher.HeaderText = "Amount of Teacher";
            this.colAmountTeacher.MinimumWidth = 10;
            this.colAmountTeacher.Name = "colAmountTeacher";
            this.colAmountTeacher.ReadOnly = true;
            // 
            // UCFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Controls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCFaculty";
            this.Size = new System.Drawing.Size(1888, 1092);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Faculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timeLoad;
        private Guna.UI.WinForms.GunaPanel pnl_Controls;
        private Guna.UI.WinForms.GunaPanel pnl_Container;
        private Guna.UI.WinForms.GunaLabel lbl_FacultyName;
        private Guna.UI.WinForms.GunaLabel lbl_FacultyID;
        private Guna.UI.WinForms.GunaTextBox txt_FacultyName;
        private Guna.UI.WinForms.GunaTextBox txt_FacultyId;
        private Guna.UI.WinForms.GunaButton btn_AddNewFaculty;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dtGrid_Faculty;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaButton btn_Del;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountTeacher;
    }
}

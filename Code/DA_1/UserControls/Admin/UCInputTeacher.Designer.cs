namespace DA_1.UserControls.Admin
{
    partial class UCInputTeacher
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
            this.btn_AddInfor = new Guna.UI.WinForms.GunaButton();
            this.cbx_AcademicLevel = new Guna.UI.WinForms.GunaComboBox();
            this.cbx_Position = new Guna.UI.WinForms.GunaComboBox();
            this.cbx_Faculty = new Guna.UI.WinForms.GunaComboBox();
            this.dtp_Birthday = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_Faculty = new Guna.UI.WinForms.GunaLabel();
            this.txt_Email = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_Email = new Guna.UI.WinForms.GunaLabel();
            this.txt_Phone = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_Phone = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Birthday = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Name = new Guna.UI.WinForms.GunaLabel();
            this.lbl_AcademicLevel = new Guna.UI.WinForms.GunaLabel();
            this.txt_TeacherId = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_TeacherId = new Guna.UI.WinForms.GunaLabel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.lbl_Title = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.txt_Confirm = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Password = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_UserName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Control.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddInfor
            // 
            this.btn_AddInfor.AnimationHoverSpeed = 0.07F;
            this.btn_AddInfor.AnimationSpeed = 0.03F;
            this.btn_AddInfor.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddInfor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddInfor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddInfor.BorderSize = 2;
            this.btn_AddInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddInfor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddInfor.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddInfor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddInfor.ForeColor = System.Drawing.Color.White;
            this.btn_AddInfor.Image = null;
            this.btn_AddInfor.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddInfor.Location = new System.Drawing.Point(1266, 785);
            this.btn_AddInfor.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AddInfor.Name = "btn_AddInfor";
            this.btn_AddInfor.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_AddInfor.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddInfor.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddInfor.OnHoverImage = null;
            this.btn_AddInfor.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddInfor.Radius = 10;
            this.btn_AddInfor.Size = new System.Drawing.Size(510, 81);
            this.btn_AddInfor.TabIndex = 12;
            this.btn_AddInfor.Text = "Add Information";
            this.btn_AddInfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddInfor.Click += new System.EventHandler(this.btn_AddInfor_Click);
            // 
            // cbx_AcademicLevel
            // 
            this.cbx_AcademicLevel.BackColor = System.Drawing.Color.Transparent;
            this.cbx_AcademicLevel.BaseColor = System.Drawing.Color.White;
            this.cbx_AcademicLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_AcademicLevel.BorderSize = 1;
            this.cbx_AcademicLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_AcademicLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_AcademicLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_AcademicLevel.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_AcademicLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_AcademicLevel.ForeColor = System.Drawing.Color.Black;
            this.cbx_AcademicLevel.FormattingEnabled = true;
            this.cbx_AcademicLevel.Location = new System.Drawing.Point(1266, 142);
            this.cbx_AcademicLevel.Margin = new System.Windows.Forms.Padding(6);
            this.cbx_AcademicLevel.Name = "cbx_AcademicLevel";
            this.cbx_AcademicLevel.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_AcademicLevel.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_AcademicLevel.Radius = 10;
            this.cbx_AcademicLevel.Size = new System.Drawing.Size(346, 44);
            this.cbx_AcademicLevel.TabIndex = 6;
            // 
            // cbx_Position
            // 
            this.cbx_Position.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Position.BaseColor = System.Drawing.Color.White;
            this.cbx_Position.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Position.BorderSize = 1;
            this.cbx_Position.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Position.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Position.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Position.ForeColor = System.Drawing.Color.Black;
            this.cbx_Position.FormattingEnabled = true;
            this.cbx_Position.Location = new System.Drawing.Point(1266, 354);
            this.cbx_Position.Margin = new System.Windows.Forms.Padding(6);
            this.cbx_Position.Name = "cbx_Position";
            this.cbx_Position.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Position.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Position.Radius = 10;
            this.cbx_Position.Size = new System.Drawing.Size(346, 44);
            this.cbx_Position.TabIndex = 8;
            // 
            // cbx_Faculty
            // 
            this.cbx_Faculty.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Faculty.BaseColor = System.Drawing.Color.White;
            this.cbx_Faculty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Faculty.BorderSize = 1;
            this.cbx_Faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Faculty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Faculty.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Faculty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Faculty.ForeColor = System.Drawing.Color.Black;
            this.cbx_Faculty.FormattingEnabled = true;
            this.cbx_Faculty.Location = new System.Drawing.Point(1266, 246);
            this.cbx_Faculty.Margin = new System.Windows.Forms.Padding(6);
            this.cbx_Faculty.Name = "cbx_Faculty";
            this.cbx_Faculty.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Faculty.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Faculty.Radius = 10;
            this.cbx_Faculty.Size = new System.Drawing.Size(346, 44);
            this.cbx_Faculty.TabIndex = 7;
            // 
            // dtp_Birthday
            // 
            this.dtp_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.dtp_Birthday.BaseColor = System.Drawing.Color.White;
            this.dtp_Birthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_Birthday.BorderSize = 1;
            this.dtp_Birthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_Birthday.CustomFormat = "dd/MM/yyyy";
            this.dtp_Birthday.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_Birthday.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_Birthday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtp_Birthday.ForeColor = System.Drawing.Color.Black;
            this.dtp_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Birthday.Location = new System.Drawing.Point(426, 360);
            this.dtp_Birthday.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_Birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Birthday.Name = "dtp_Birthday";
            this.dtp_Birthday.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_Birthday.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_Birthday.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtp_Birthday.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_Birthday.Radius = 10;
            this.dtp_Birthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_Birthday.Size = new System.Drawing.Size(350, 58);
            this.dtp_Birthday.TabIndex = 3;
            this.dtp_Birthday.Text = "04/05/2020";
            this.dtp_Birthday.Value = new System.DateTime(2020, 5, 4, 21, 18, 0, 334);
            // 
            // lbl_Faculty
            // 
            this.lbl_Faculty.AutoSize = true;
            this.lbl_Faculty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Faculty.Location = new System.Drawing.Point(962, 250);
            this.lbl_Faculty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Faculty.Name = "lbl_Faculty";
            this.lbl_Faculty.Size = new System.Drawing.Size(140, 37);
            this.lbl_Faculty.TabIndex = 0;
            this.lbl_Faculty.Text = "Faculty:";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.Transparent;
            this.txt_Email.BaseColor = System.Drawing.Color.White;
            this.txt_Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Email.BorderSize = 1;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(426, 571);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.Radius = 10;
            this.txt_Email.Size = new System.Drawing.Size(350, 63);
            this.txt_Email.TabIndex = 5;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(154, 587);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(114, 37);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.BackColor = System.Drawing.Color.Transparent;
            this.txt_Phone.BaseColor = System.Drawing.Color.White;
            this.txt_Phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Phone.BorderSize = 1;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Phone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Phone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Phone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(426, 467);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.Radius = 10;
            this.txt_Phone.Size = new System.Drawing.Size(350, 63);
            this.txt_Phone.TabIndex = 4;
            this.txt_Phone.TextChanged += new System.EventHandler(this.txt_Phone_TextChanged);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(154, 477);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(122, 37);
            this.lbl_Phone.TabIndex = 0;
            this.lbl_Phone.Text = "Phone:";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(154, 367);
            this.lbl_Birthday.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(156, 37);
            this.lbl_Birthday.TabIndex = 0;
            this.lbl_Birthday.Text = "Birthday:";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.Transparent;
            this.txt_Name.BaseColor = System.Drawing.Color.White;
            this.txt_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Name.BorderSize = 1;
            this.txt_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(426, 250);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Radius = 10;
            this.txt_Name.Size = new System.Drawing.Size(350, 63);
            this.txt_Name.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(962, 360);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(153, 37);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Position:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(154, 260);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(113, 37);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_AcademicLevel
            // 
            this.lbl_AcademicLevel.AutoSize = true;
            this.lbl_AcademicLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AcademicLevel.Location = new System.Drawing.Point(962, 150);
            this.lbl_AcademicLevel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_AcademicLevel.Name = "lbl_AcademicLevel";
            this.lbl_AcademicLevel.Size = new System.Drawing.Size(271, 37);
            this.lbl_AcademicLevel.TabIndex = 0;
            this.lbl_AcademicLevel.Text = "Academic Level:";
            // 
            // txt_TeacherId
            // 
            this.txt_TeacherId.BackColor = System.Drawing.Color.Transparent;
            this.txt_TeacherId.BaseColor = System.Drawing.Color.White;
            this.txt_TeacherId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_TeacherId.BorderSize = 1;
            this.txt_TeacherId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TeacherId.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_TeacherId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_TeacherId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_TeacherId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeacherId.Location = new System.Drawing.Point(426, 138);
            this.txt_TeacherId.Margin = new System.Windows.Forms.Padding(6);
            this.txt_TeacherId.Name = "txt_TeacherId";
            this.txt_TeacherId.PasswordChar = '\0';
            this.txt_TeacherId.Radius = 10;
            this.txt_TeacherId.Size = new System.Drawing.Size(350, 63);
            this.txt_TeacherId.TabIndex = 1;
            this.txt_TeacherId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeacherId_KeyPress);
            // 
            // lbl_TeacherId
            // 
            this.lbl_TeacherId.AutoSize = true;
            this.lbl_TeacherId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeacherId.Location = new System.Drawing.Point(154, 150);
            this.lbl_TeacherId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_TeacherId.Name = "lbl_TeacherId";
            this.lbl_TeacherId.Size = new System.Drawing.Size(189, 37);
            this.lbl_TeacherId.TabIndex = 0;
            this.lbl_TeacherId.Text = "Teacher ID:";
            // 
            // btn_Back
            // 
            this.btn_Back.AnimationHoverSpeed = 0.07F;
            this.btn_Back.AnimationSpeed = 0.03F;
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.BorderSize = 1;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Back.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Back.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Image = null;
            this.btn_Back.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Back.Location = new System.Drawing.Point(108, 56);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.Radius = 15;
            this.btn_Back.Size = new System.Drawing.Size(320, 81);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(654, 56);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(804, 73);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Input Information Teacher";
            // 
            // pnl_Control
            // 
            this.pnl_Control.BackColor = System.Drawing.Color.White;
            this.pnl_Control.Controls.Add(this.txt_Confirm);
            this.pnl_Control.Controls.Add(this.txt_Password);
            this.pnl_Control.Controls.Add(this.gunaLabel3);
            this.pnl_Control.Controls.Add(this.gunaLabel1);
            this.pnl_Control.Controls.Add(this.txt_UserName);
            this.pnl_Control.Controls.Add(this.gunaLabel4);
            this.pnl_Control.Controls.Add(this.btn_Edit);
            this.pnl_Control.Controls.Add(this.btn_AddInfor);
            this.pnl_Control.Controls.Add(this.cbx_AcademicLevel);
            this.pnl_Control.Controls.Add(this.cbx_Position);
            this.pnl_Control.Controls.Add(this.cbx_Faculty);
            this.pnl_Control.Controls.Add(this.dtp_Birthday);
            this.pnl_Control.Controls.Add(this.lbl_Faculty);
            this.pnl_Control.Controls.Add(this.txt_Email);
            this.pnl_Control.Controls.Add(this.lbl_Email);
            this.pnl_Control.Controls.Add(this.txt_Phone);
            this.pnl_Control.Controls.Add(this.lbl_Phone);
            this.pnl_Control.Controls.Add(this.lbl_Birthday);
            this.pnl_Control.Controls.Add(this.txt_Name);
            this.pnl_Control.Controls.Add(this.gunaLabel2);
            this.pnl_Control.Controls.Add(this.lbl_Name);
            this.pnl_Control.Controls.Add(this.lbl_AcademicLevel);
            this.pnl_Control.Controls.Add(this.txt_TeacherId);
            this.pnl_Control.Controls.Add(this.lbl_TeacherId);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Control.Location = new System.Drawing.Point(0, 192);
            this.pnl_Control.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1888, 1002);
            this.pnl_Control.TabIndex = 3;
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.txt_Confirm.BaseColor = System.Drawing.Color.White;
            this.txt_Confirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Confirm.BorderSize = 1;
            this.txt_Confirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Confirm.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Confirm.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Confirm.FocusedForeColor = System.Drawing.Color.Black;
            this.txt_Confirm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Confirm.ForeColor = System.Drawing.Color.Black;
            this.txt_Confirm.Location = new System.Drawing.Point(1266, 685);
            this.txt_Confirm.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.PasswordChar = '\0';
            this.txt_Confirm.Radius = 10;
            this.txt_Confirm.Size = new System.Drawing.Size(350, 63);
            this.txt_Confirm.TabIndex = 11;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.BaseColor = System.Drawing.Color.White;
            this.txt_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Password.BorderSize = 1;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Password.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Password.FocusedForeColor = System.Drawing.Color.Black;
            this.txt_Password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(1266, 577);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.Radius = 10;
            this.txt_Password.Size = new System.Drawing.Size(350, 63);
            this.txt_Password.TabIndex = 10;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(962, 694);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(150, 37);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Confirm:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(962, 587);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(177, 37);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Password:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.Transparent;
            this.txt_UserName.BaseColor = System.Drawing.Color.White;
            this.txt_UserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_UserName.BorderSize = 1;
            this.txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UserName.Enabled = false;
            this.txt_UserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_UserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_UserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_UserName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(1266, 467);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '\0';
            this.txt_UserName.Radius = 10;
            this.txt_UserName.Size = new System.Drawing.Size(350, 63);
            this.txt_UserName.TabIndex = 9;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(962, 477);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(193, 37);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "User Name:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.AnimationHoverSpeed = 0.07F;
            this.btn_Edit.AnimationSpeed = 0.03F;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.BorderSize = 2;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Edit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = null;
            this.btn_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Edit.Location = new System.Drawing.Point(1266, 785);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.Radius = 10;
            this.btn_Edit.Size = new System.Drawing.Size(510, 81);
            this.btn_Edit.TabIndex = 13;
            this.btn_Edit.Text = "Edit Information";
            this.btn_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btn_Back);
            this.gunaPanel1.Controls.Add(this.lbl_Title);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1888, 192);
            this.gunaPanel1.TabIndex = 2;
            // 
            // UCInputTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Control);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCInputTeacher";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_AddInfor;
        private Guna.UI.WinForms.GunaComboBox cbx_AcademicLevel;
        private Guna.UI.WinForms.GunaComboBox cbx_Position;
        private Guna.UI.WinForms.GunaComboBox cbx_Faculty;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_Birthday;
        private Guna.UI.WinForms.GunaLabel lbl_Faculty;
        private Guna.UI.WinForms.GunaTextBox txt_Email;
        private Guna.UI.WinForms.GunaLabel lbl_Email;
        private Guna.UI.WinForms.GunaTextBox txt_Phone;
        private Guna.UI.WinForms.GunaLabel lbl_Phone;
        private Guna.UI.WinForms.GunaLabel lbl_Birthday;
        private Guna.UI.WinForms.GunaTextBox txt_Name;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lbl_Name;
        private Guna.UI.WinForms.GunaLabel lbl_AcademicLevel;
        private Guna.UI.WinForms.GunaTextBox txt_TeacherId;
        private Guna.UI.WinForms.GunaLabel lbl_TeacherId;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaLabel lbl_Title;
        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaTextBox txt_Confirm;
        private Guna.UI.WinForms.GunaTextBox txt_Password;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_UserName;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}

namespace DA_1.UserControls.Admin
{
    partial class UCInputStudent
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.cbx_Faculty = new Guna.UI.WinForms.GunaComboBox();
            this.dtp_Birthday = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lbl_Faculty = new Guna.UI.WinForms.GunaLabel();
            this.txt_Confirm = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Password = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Email = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Email = new Guna.UI.WinForms.GunaLabel();
            this.txt_UserName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_Phone = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_Phone = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Birthday = new Guna.UI.WinForms.GunaLabel();
            this.txt_Name = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_Name = new Guna.UI.WinForms.GunaLabel();
            this.txt_StudentId = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_StudentId = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.pnl_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btn_Back);
            this.gunaPanel1.Controls.Add(this.lbl_title);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1888, 192);
            this.gunaPanel1.TabIndex = 0;
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
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(654, 56);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(782, 73);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Input Information Student";
            // 
            // pnl_Control
            // 
            this.pnl_Control.BackColor = System.Drawing.Color.White;
            this.pnl_Control.Controls.Add(this.btn_Edit);
            this.pnl_Control.Controls.Add(this.btn_Add);
            this.pnl_Control.Controls.Add(this.cbx_Faculty);
            this.pnl_Control.Controls.Add(this.dtp_Birthday);
            this.pnl_Control.Controls.Add(this.lbl_Faculty);
            this.pnl_Control.Controls.Add(this.txt_Confirm);
            this.pnl_Control.Controls.Add(this.txt_Password);
            this.pnl_Control.Controls.Add(this.gunaLabel3);
            this.pnl_Control.Controls.Add(this.txt_Email);
            this.pnl_Control.Controls.Add(this.gunaLabel2);
            this.pnl_Control.Controls.Add(this.lbl_Email);
            this.pnl_Control.Controls.Add(this.txt_UserName);
            this.pnl_Control.Controls.Add(this.gunaLabel1);
            this.pnl_Control.Controls.Add(this.txt_Phone);
            this.pnl_Control.Controls.Add(this.lbl_Phone);
            this.pnl_Control.Controls.Add(this.lbl_Birthday);
            this.pnl_Control.Controls.Add(this.txt_Name);
            this.pnl_Control.Controls.Add(this.lbl_Name);
            this.pnl_Control.Controls.Add(this.txt_StudentId);
            this.pnl_Control.Controls.Add(this.lbl_StudentId);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Control.Location = new System.Drawing.Point(0, 192);
            this.pnl_Control.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1888, 1002);
            this.pnl_Control.TabIndex = 1;
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
            this.btn_Edit.Location = new System.Drawing.Point(1210, 694);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.Radius = 10;
            this.btn_Edit.Size = new System.Drawing.Size(510, 81);
            this.btn_Edit.TabIndex = 11;
            this.btn_Edit.Text = "Edit Information";
            this.btn_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.BorderSize = 2;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = null;
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(1210, 694);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.Radius = 10;
            this.btn_Add.Size = new System.Drawing.Size(510, 81);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add Information";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.cbx_Faculty.Location = new System.Drawing.Point(550, 673);
            this.cbx_Faculty.Margin = new System.Windows.Forms.Padding(6);
            this.cbx_Faculty.Name = "cbx_Faculty";
            this.cbx_Faculty.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Faculty.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Faculty.Radius = 10;
            this.cbx_Faculty.Size = new System.Drawing.Size(346, 44);
            this.cbx_Faculty.TabIndex = 6;
            this.cbx_Faculty.SelectedIndexChanged += new System.EventHandler(this.cbx_Faculty_SelectedIndexChanged);
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
            this.dtp_Birthday.Location = new System.Drawing.Point(550, 342);
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
            this.lbl_Faculty.Location = new System.Drawing.Point(278, 679);
            this.lbl_Faculty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Faculty.Name = "lbl_Faculty";
            this.lbl_Faculty.Size = new System.Drawing.Size(140, 37);
            this.lbl_Faculty.TabIndex = 0;
            this.lbl_Faculty.Text = "Faculty:";
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
            this.txt_Confirm.Location = new System.Drawing.Point(1314, 452);
            this.txt_Confirm.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.PasswordChar = '\0';
            this.txt_Confirm.Radius = 10;
            this.txt_Confirm.Size = new System.Drawing.Size(350, 63);
            this.txt_Confirm.TabIndex = 9;
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
            this.txt_Password.Location = new System.Drawing.Point(1314, 344);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.Radius = 10;
            this.txt_Password.Size = new System.Drawing.Size(350, 63);
            this.txt_Password.TabIndex = 8;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(1042, 463);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(150, 37);
            this.gunaLabel3.TabIndex = 0;
            this.gunaLabel3.Text = "Confirm:";
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
            this.txt_Email.FocusedForeColor = System.Drawing.Color.Red;
            this.txt_Email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Red;
            this.txt_Email.Location = new System.Drawing.Point(550, 562);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.Radius = 10;
            this.txt_Email.Size = new System.Drawing.Size(350, 63);
            this.txt_Email.TabIndex = 5;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(1042, 358);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(177, 37);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Password:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(278, 573);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(114, 37);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email:";
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
            this.txt_UserName.Location = new System.Drawing.Point(1314, 235);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '\0';
            this.txt_UserName.Radius = 10;
            this.txt_UserName.Size = new System.Drawing.Size(350, 63);
            this.txt_UserName.TabIndex = 7;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1042, 246);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(193, 37);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "User Name:";
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
            this.txt_Phone.Location = new System.Drawing.Point(550, 452);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Phone.MaxLength = 10;
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
            this.lbl_Phone.Location = new System.Drawing.Point(278, 463);
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
            this.lbl_Birthday.Location = new System.Drawing.Point(278, 354);
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
            this.txt_Name.Location = new System.Drawing.Point(550, 235);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.Radius = 10;
            this.txt_Name.Size = new System.Drawing.Size(350, 63);
            this.txt_Name.TabIndex = 2;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(278, 246);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(113, 37);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name:";
            // 
            // txt_StudentId
            // 
            this.txt_StudentId.BackColor = System.Drawing.Color.Transparent;
            this.txt_StudentId.BaseColor = System.Drawing.Color.White;
            this.txt_StudentId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_StudentId.BorderSize = 1;
            this.txt_StudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StudentId.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_StudentId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_StudentId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_StudentId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentId.Location = new System.Drawing.Point(550, 125);
            this.txt_StudentId.Margin = new System.Windows.Forms.Padding(6);
            this.txt_StudentId.Name = "txt_StudentId";
            this.txt_StudentId.PasswordChar = '\0';
            this.txt_StudentId.Radius = 10;
            this.txt_StudentId.Size = new System.Drawing.Size(350, 63);
            this.txt_StudentId.TabIndex = 1;
            // 
            // lbl_StudentId
            // 
            this.lbl_StudentId.AutoSize = true;
            this.lbl_StudentId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentId.Location = new System.Drawing.Point(278, 137);
            this.lbl_StudentId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_StudentId.Name = "lbl_StudentId";
            this.lbl_StudentId.Size = new System.Drawing.Size(185, 37);
            this.lbl_StudentId.TabIndex = 0;
            this.lbl_StudentId.Text = "Student ID:";
            // 
            // UCInputStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Control);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCInputStudent";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaTextBox txt_StudentId;
        private Guna.UI.WinForms.GunaLabel lbl_StudentId;
        private Guna.UI.WinForms.GunaLabel lbl_Faculty;
        private Guna.UI.WinForms.GunaTextBox txt_Email;
        private Guna.UI.WinForms.GunaLabel lbl_Email;
        private Guna.UI.WinForms.GunaTextBox txt_Phone;
        private Guna.UI.WinForms.GunaLabel lbl_Phone;
        private Guna.UI.WinForms.GunaLabel lbl_Birthday;
        private Guna.UI.WinForms.GunaTextBox txt_Name;
        private Guna.UI.WinForms.GunaLabel lbl_Name;
        private Guna.UI.WinForms.GunaComboBox cbx_Faculty;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_Birthday;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaTextBox txt_Confirm;
        private Guna.UI.WinForms.GunaTextBox txt_Password;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_UserName;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

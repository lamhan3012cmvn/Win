namespace DA_1.UserControls.Teacher
{
    partial class UCAddProject
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
            this.pnl_Main = new Guna.UI.WinForms.GunaPanel();
            this.dtp_DateTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtp_DateFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txt_ProjectName = new Guna.UI.WinForms.GunaTextBox();
            this.txt_ProjectID = new Guna.UI.WinForms.GunaTextBox();
            this.cbx_Process = new Guna.UI.WinForms.GunaComboBox();
            this.cbx_KoP = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.lbl_title = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.dtp_DateTo);
            this.pnl_Main.Controls.Add(this.dtp_DateFrom);
            this.pnl_Main.Controls.Add(this.txt_ProjectName);
            this.pnl_Main.Controls.Add(this.txt_ProjectID);
            this.pnl_Main.Controls.Add(this.cbx_Process);
            this.pnl_Main.Controls.Add(this.cbx_KoP);
            this.pnl_Main.Controls.Add(this.gunaLabel6);
            this.pnl_Main.Controls.Add(this.gunaLabel3);
            this.pnl_Main.Controls.Add(this.gunaLabel5);
            this.pnl_Main.Controls.Add(this.gunaLabel4);
            this.pnl_Main.Controls.Add(this.gunaLabel2);
            this.pnl_Main.Controls.Add(this.gunaLabel1);
            this.pnl_Main.Controls.Add(this.btn_Add);
            this.pnl_Main.Controls.Add(this.lbl_title);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Main.TabIndex = 0;
            // 
            // dtp_DateTo
            // 
            this.dtp_DateTo.BackColor = System.Drawing.Color.Transparent;
            this.dtp_DateTo.BaseColor = System.Drawing.Color.White;
            this.dtp_DateTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_DateTo.BorderSize = 1;
            this.dtp_DateTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_DateTo.CustomFormat = "dd/MM/yyyy";
            this.dtp_DateTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_DateTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_DateTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtp_DateTo.ForeColor = System.Drawing.Color.Black;
            this.dtp_DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateTo.Location = new System.Drawing.Point(974, 740);
            this.dtp_DateTo.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_DateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_DateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_DateTo.Name = "dtp_DateTo";
            this.dtp_DateTo.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_DateTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_DateTo.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtp_DateTo.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_DateTo.Radius = 10;
            this.dtp_DateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_DateTo.Size = new System.Drawing.Size(414, 58);
            this.dtp_DateTo.TabIndex = 64;
            this.dtp_DateTo.Text = "04/05/2020";
            this.dtp_DateTo.Value = new System.DateTime(2020, 5, 4, 21, 18, 0, 334);
            // 
            // dtp_DateFrom
            // 
            this.dtp_DateFrom.BackColor = System.Drawing.Color.Transparent;
            this.dtp_DateFrom.BaseColor = System.Drawing.Color.White;
            this.dtp_DateFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_DateFrom.BorderSize = 1;
            this.dtp_DateFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_DateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtp_DateFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_DateFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_DateFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtp_DateFrom.ForeColor = System.Drawing.Color.Black;
            this.dtp_DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateFrom.Location = new System.Drawing.Point(974, 612);
            this.dtp_DateFrom.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_DateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_DateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_DateFrom.Name = "dtp_DateFrom";
            this.dtp_DateFrom.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp_DateFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.dtp_DateFrom.OnHoverForeColor = System.Drawing.Color.Black;
            this.dtp_DateFrom.OnPressedColor = System.Drawing.Color.Black;
            this.dtp_DateFrom.Radius = 10;
            this.dtp_DateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_DateFrom.Size = new System.Drawing.Size(414, 58);
            this.dtp_DateFrom.TabIndex = 63;
            this.dtp_DateFrom.Text = "04/05/2020";
            this.dtp_DateFrom.Value = new System.DateTime(2020, 5, 4, 21, 18, 0, 334);
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.BackColor = System.Drawing.Color.Transparent;
            this.txt_ProjectName.BaseColor = System.Drawing.Color.White;
            this.txt_ProjectName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_ProjectName.BorderSize = 1;
            this.txt_ProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProjectName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_ProjectName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_ProjectName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ProjectName.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProjectName.Location = new System.Drawing.Point(974, 479);
            this.txt_ProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.PasswordChar = '\0';
            this.txt_ProjectName.Radius = 10;
            this.txt_ProjectName.Size = new System.Drawing.Size(414, 63);
            this.txt_ProjectName.TabIndex = 62;
            this.txt_ProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ProjectID
            // 
            this.txt_ProjectID.BackColor = System.Drawing.Color.Transparent;
            this.txt_ProjectID.BaseColor = System.Drawing.Color.White;
            this.txt_ProjectID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_ProjectID.BorderSize = 1;
            this.txt_ProjectID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ProjectID.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_ProjectID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_ProjectID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ProjectID.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProjectID.Location = new System.Drawing.Point(974, 337);
            this.txt_ProjectID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProjectID.Name = "txt_ProjectID";
            this.txt_ProjectID.PasswordChar = '\0';
            this.txt_ProjectID.Radius = 10;
            this.txt_ProjectID.Size = new System.Drawing.Size(414, 63);
            this.txt_ProjectID.TabIndex = 62;
            this.txt_ProjectID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbx_Process
            // 
            this.cbx_Process.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Process.BaseColor = System.Drawing.Color.White;
            this.cbx_Process.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Process.BorderSize = 1;
            this.cbx_Process.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Process.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Process.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_Process.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Process.ForeColor = System.Drawing.Color.Black;
            this.cbx_Process.FormattingEnabled = true;
            this.cbx_Process.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbx_Process.Location = new System.Drawing.Point(974, 881);
            this.cbx_Process.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_Process.Name = "cbx_Process";
            this.cbx_Process.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_Process.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_Process.Radius = 10;
            this.cbx_Process.Size = new System.Drawing.Size(414, 52);
            this.cbx_Process.TabIndex = 61;
            // 
            // cbx_KoP
            // 
            this.cbx_KoP.BackColor = System.Drawing.Color.Transparent;
            this.cbx_KoP.BaseColor = System.Drawing.Color.White;
            this.cbx_KoP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_KoP.BorderSize = 1;
            this.cbx_KoP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_KoP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_KoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_KoP.FocusedColor = System.Drawing.Color.Empty;
            this.cbx_KoP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_KoP.ForeColor = System.Drawing.Color.Black;
            this.cbx_KoP.FormattingEnabled = true;
            this.cbx_KoP.Location = new System.Drawing.Point(974, 208);
            this.cbx_KoP.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_KoP.Name = "cbx_KoP";
            this.cbx_KoP.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.cbx_KoP.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbx_KoP.Radius = 10;
            this.cbx_KoP.Size = new System.Drawing.Size(414, 52);
            this.cbx_KoP.TabIndex = 61;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(556, 888);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(216, 51);
            this.gunaLabel6.TabIndex = 60;
            this.gunaLabel6.Text = "Process :";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(556, 337);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(249, 51);
            this.gunaLabel3.TabIndex = 60;
            this.gunaLabel3.Text = "Project ID :";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(556, 748);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(203, 51);
            this.gunaLabel5.TabIndex = 60;
            this.gunaLabel5.Text = "Date To :";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(556, 617);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(260, 51);
            this.gunaLabel4.TabIndex = 60;
            this.gunaLabel4.Text = "Date From :";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(556, 487);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(323, 51);
            this.gunaLabel2.TabIndex = 60;
            this.gunaLabel2.Text = "Project Name :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(556, 208);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(353, 51);
            this.gunaLabel1.TabIndex = 60;
            this.gunaLabel1.Text = "Kind of Project :";
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.BorderSize = 1;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Image = null;
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(1410, 1027);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.Radius = 10;
            this.btn_Add.Size = new System.Drawing.Size(352, 81);
            this.btn_Add.TabIndex = 59;
            this.btn_Add.Text = "ADD";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Bauhaus 93", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.lbl_title.Location = new System.Drawing.Point(688, 40);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(606, 84);
            this.lbl_title.TabIndex = 49;
            this.lbl_title.Text = "Add New Project";
            // 
            // UCAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCAddProject";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Main;
        private Guna.UI.WinForms.GunaLabel lbl_title;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaTextBox txt_ProjectID;
        private Guna.UI.WinForms.GunaComboBox cbx_KoP;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox txt_ProjectName;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_DateTo;
        private Guna.UI.WinForms.GunaDateTimePicker dtp_DateFrom;
        private Guna.UI.WinForms.GunaComboBox cbx_Process;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
    }
}

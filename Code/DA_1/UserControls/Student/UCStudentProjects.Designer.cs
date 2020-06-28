namespace DA_1.UserControls
{
    partial class UCStudentProjects
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
            this.pnl_Title = new Guna.UI.WinForms.GunaPanel();
            this.btn_ProjectFinish = new Guna.UI.WinForms.GunaButton();
            this.pnl_ProjectItems = new Guna.UI.WinForms.GunaPanel();
            this.btn_ManageProject = new Guna.UI.WinForms.GunaButton();
            this.pnl_ProjectItem = new Guna.UI.WinForms.GunaPanel();
            this.txt_Link = new Guna.UI.WinForms.GunaTextBox();
            this.pnl_MemberTeam = new Guna.UI.WinForms.GunaPanel();
            this.pnl_ProcessItems = new Guna.UI.WinForms.GunaPanel();
            this.lbl_PointValue = new Guna.UI.WinForms.GunaLabel();
            this.lbl_DateFrom = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Team = new Guna.UI.WinForms.GunaLabel();
            this.lbl_KoProject = new Guna.UI.WinForms.GunaLabel();
            this.btn_Submit = new Guna.UI.WinForms.GunaButton();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_Delete = new Guna.UI.WinForms.GunaButton();
            this.lbl_Link = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Point = new Guna.UI.WinForms.GunaLabel();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.btn_Process = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Days = new System.Windows.Forms.Label();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.pgb_Deadline = new Guna.UI.WinForms.GunaProgressBar();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_ProjectName = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Title.SuspendLayout();
            this.pnl_ProjectItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.White;
            this.pnl_Title.Controls.Add(this.btn_ProjectFinish);
            this.pnl_Title.Controls.Add(this.pnl_ProjectItems);
            this.pnl_Title.Controls.Add(this.btn_ManageProject);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(1888, 262);
            this.pnl_Title.TabIndex = 0;
            // 
            // btn_ProjectFinish
            // 
            this.btn_ProjectFinish.AnimationHoverSpeed = 0.07F;
            this.btn_ProjectFinish.AnimationSpeed = 0.03F;
            this.btn_ProjectFinish.BackColor = System.Drawing.Color.Transparent;
            this.btn_ProjectFinish.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ProjectFinish.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ProjectFinish.BorderSize = 1;
            this.btn_ProjectFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ProjectFinish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ProjectFinish.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ProjectFinish.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProjectFinish.ForeColor = System.Drawing.Color.White;
            this.btn_ProjectFinish.Image = null;
            this.btn_ProjectFinish.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ProjectFinish.Location = new System.Drawing.Point(544, 23);
            this.btn_ProjectFinish.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ProjectFinish.Name = "btn_ProjectFinish";
            this.btn_ProjectFinish.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_ProjectFinish.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ProjectFinish.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ProjectFinish.OnHoverImage = null;
            this.btn_ProjectFinish.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ProjectFinish.Radius = 15;
            this.btn_ProjectFinish.Size = new System.Drawing.Size(392, 81);
            this.btn_ProjectFinish.TabIndex = 37;
            this.btn_ProjectFinish.Text = "Project was finished";
            this.btn_ProjectFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ProjectFinish.Click += new System.EventHandler(this.btn_ProjectFinish_Click);
            // 
            // pnl_ProjectItems
            // 
            this.pnl_ProjectItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_ProjectItems.Location = new System.Drawing.Point(0, 116);
            this.pnl_ProjectItems.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_ProjectItems.Name = "pnl_ProjectItems";
            this.pnl_ProjectItems.Size = new System.Drawing.Size(1888, 146);
            this.pnl_ProjectItems.TabIndex = 30;
            // 
            // btn_ManageProject
            // 
            this.btn_ManageProject.AnimationHoverSpeed = 0.07F;
            this.btn_ManageProject.AnimationSpeed = 0.03F;
            this.btn_ManageProject.BackColor = System.Drawing.Color.Transparent;
            this.btn_ManageProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ManageProject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ManageProject.BorderSize = 1;
            this.btn_ManageProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageProject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ManageProject.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ManageProject.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageProject.ForeColor = System.Drawing.Color.White;
            this.btn_ManageProject.Image = null;
            this.btn_ManageProject.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ManageProject.Location = new System.Drawing.Point(98, 23);
            this.btn_ManageProject.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ManageProject.Name = "btn_ManageProject";
            this.btn_ManageProject.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_ManageProject.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ManageProject.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ManageProject.OnHoverImage = null;
            this.btn_ManageProject.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ManageProject.Radius = 15;
            this.btn_ManageProject.Size = new System.Drawing.Size(392, 81);
            this.btn_ManageProject.TabIndex = 29;
            this.btn_ManageProject.Text = "Manage Project";
            this.btn_ManageProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ManageProject.Click += new System.EventHandler(this.btn_ManageProject_Click);
            // 
            // pnl_ProjectItem
            // 
            this.pnl_ProjectItem.BackColor = System.Drawing.Color.White;
            this.pnl_ProjectItem.Controls.Add(this.txt_Link);
            this.pnl_ProjectItem.Controls.Add(this.pnl_MemberTeam);
            this.pnl_ProjectItem.Controls.Add(this.pnl_ProcessItems);
            this.pnl_ProjectItem.Controls.Add(this.lbl_PointValue);
            this.pnl_ProjectItem.Controls.Add(this.lbl_DateFrom);
            this.pnl_ProjectItem.Controls.Add(this.lbl_Team);
            this.pnl_ProjectItem.Controls.Add(this.lbl_KoProject);
            this.pnl_ProjectItem.Controls.Add(this.btn_Submit);
            this.pnl_ProjectItem.Controls.Add(this.btn_Edit);
            this.pnl_ProjectItem.Controls.Add(this.btn_Delete);
            this.pnl_ProjectItem.Controls.Add(this.lbl_Link);
            this.pnl_ProjectItem.Controls.Add(this.lbl_Point);
            this.pnl_ProjectItem.Controls.Add(this.btn_Back);
            this.pnl_ProjectItem.Controls.Add(this.btn_Process);
            this.pnl_ProjectItem.Controls.Add(this.gunaLabel3);
            this.pnl_ProjectItem.Controls.Add(this.lbl_Days);
            this.pnl_ProjectItem.Controls.Add(this.gunaLabel4);
            this.pnl_ProjectItem.Controls.Add(this.pgb_Deadline);
            this.pnl_ProjectItem.Controls.Add(this.gunaLabel2);
            this.pnl_ProjectItem.Controls.Add(this.gunaLabel1);
            this.pnl_ProjectItem.Controls.Add(this.lbl_ProjectName);
            this.pnl_ProjectItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ProjectItem.ForeColor = System.Drawing.Color.Black;
            this.pnl_ProjectItem.Location = new System.Drawing.Point(0, 262);
            this.pnl_ProjectItem.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_ProjectItem.Name = "pnl_ProjectItem";
            this.pnl_ProjectItem.Size = new System.Drawing.Size(1888, 932);
            this.pnl_ProjectItem.TabIndex = 1;
            this.pnl_ProjectItem.Visible = false;
            // 
            // txt_Link
            // 
            this.txt_Link.BackColor = System.Drawing.Color.Transparent;
            this.txt_Link.BaseColor = System.Drawing.Color.White;
            this.txt_Link.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Link.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Link.Enabled = false;
            this.txt_Link.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Link.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_Link.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Link.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Link.Location = new System.Drawing.Point(1170, 706);
            this.txt_Link.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Link.Name = "txt_Link";
            this.txt_Link.PasswordChar = '\0';
            this.txt_Link.Radius = 10;
            this.txt_Link.Size = new System.Drawing.Size(514, 65);
            this.txt_Link.TabIndex = 61;
            // 
            // pnl_MemberTeam
            // 
            this.pnl_MemberTeam.Location = new System.Drawing.Point(332, 352);
            this.pnl_MemberTeam.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_MemberTeam.Name = "pnl_MemberTeam";
            this.pnl_MemberTeam.Size = new System.Drawing.Size(504, 338);
            this.pnl_MemberTeam.TabIndex = 31;
            // 
            // pnl_ProcessItems
            // 
            this.pnl_ProcessItems.Location = new System.Drawing.Point(1134, 421);
            this.pnl_ProcessItems.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_ProcessItems.Name = "pnl_ProcessItems";
            this.pnl_ProcessItems.Size = new System.Drawing.Size(504, 188);
            this.pnl_ProcessItems.TabIndex = 30;
            // 
            // lbl_PointValue
            // 
            this.lbl_PointValue.AutoSize = true;
            this.lbl_PointValue.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PointValue.Location = new System.Drawing.Point(1234, 648);
            this.lbl_PointValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PointValue.Name = "lbl_PointValue";
            this.lbl_PointValue.Size = new System.Drawing.Size(298, 42);
            this.lbl_PointValue.TabIndex = 29;
            this.lbl_PointValue.Text = "********************";
            // 
            // lbl_DateFrom
            // 
            this.lbl_DateFrom.AutoSize = true;
            this.lbl_DateFrom.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateFrom.Location = new System.Drawing.Point(1234, 194);
            this.lbl_DateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DateFrom.Name = "lbl_DateFrom";
            this.lbl_DateFrom.Size = new System.Drawing.Size(150, 42);
            this.lbl_DateFrom.TabIndex = 29;
            this.lbl_DateFrom.Text = "**/**/****";
            // 
            // lbl_Team
            // 
            this.lbl_Team.AutoSize = true;
            this.lbl_Team.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Team.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team.Location = new System.Drawing.Point(536, 273);
            this.lbl_Team.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Team.Name = "lbl_Team";
            this.lbl_Team.Size = new System.Drawing.Size(298, 42);
            this.lbl_Team.TabIndex = 29;
            this.lbl_Team.Text = "********************";
            this.lbl_Team.Click += new System.EventHandler(this.lbl_Team_Click);
            // 
            // lbl_KoProject
            // 
            this.lbl_KoProject.AutoSize = true;
            this.lbl_KoProject.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KoProject.Location = new System.Drawing.Point(536, 194);
            this.lbl_KoProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KoProject.Name = "lbl_KoProject";
            this.lbl_KoProject.Size = new System.Drawing.Size(298, 42);
            this.lbl_KoProject.TabIndex = 29;
            this.lbl_KoProject.Text = "********************";
            // 
            // btn_Submit
            // 
            this.btn_Submit.AnimationHoverSpeed = 0.07F;
            this.btn_Submit.AnimationSpeed = 0.03F;
            this.btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Submit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Submit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Submit.BorderSize = 1;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Submit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Submit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Image = null;
            this.btn_Submit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Submit.Location = new System.Drawing.Point(1560, 812);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Submit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Submit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Submit.OnHoverImage = null;
            this.btn_Submit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Submit.Radius = 15;
            this.btn_Submit.Size = new System.Drawing.Size(232, 81);
            this.btn_Submit.TabIndex = 26;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Submit.Visible = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.AnimationHoverSpeed = 0.07F;
            this.btn_Edit.AnimationSpeed = 0.03F;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.BorderSize = 1;
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Edit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = null;
            this.btn_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Edit.Location = new System.Drawing.Point(1560, 812);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Edit.Radius = 15;
            this.btn_Edit.Size = new System.Drawing.Size(232, 81);
            this.btn_Edit.TabIndex = 26;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AnimationHoverSpeed = 0.07F;
            this.btn_Delete.AnimationSpeed = 0.03F;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Delete.BorderSize = 1;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = null;
            this.btn_Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Delete.Location = new System.Drawing.Point(1216, 812);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Delete.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Delete.OnHoverImage = null;
            this.btn_Delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete.Radius = 15;
            this.btn_Delete.Size = new System.Drawing.Size(232, 81);
            this.btn_Delete.TabIndex = 26;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Link.ForeColor = System.Drawing.Color.Black;
            this.lbl_Link.Location = new System.Drawing.Point(1018, 715);
            this.lbl_Link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(106, 42);
            this.lbl_Link.TabIndex = 9;
            this.lbl_Link.Text = "Link :";
            // 
            // lbl_Point
            // 
            this.lbl_Point.AutoSize = true;
            this.lbl_Point.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Point.ForeColor = System.Drawing.Color.Black;
            this.lbl_Point.Location = new System.Drawing.Point(1018, 648);
            this.lbl_Point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(122, 42);
            this.lbl_Point.TabIndex = 9;
            this.lbl_Point.Text = "Point :";
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
            this.btn_Back.Location = new System.Drawing.Point(866, 812);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Back.Radius = 15;
            this.btn_Back.Size = new System.Drawing.Size(232, 81);
            this.btn_Back.TabIndex = 28;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Process
            // 
            this.btn_Process.AutoSize = true;
            this.btn_Process.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Process.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.ForeColor = System.Drawing.Color.Black;
            this.btn_Process.Location = new System.Drawing.Point(1018, 352);
            this.btn_Process.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(171, 42);
            this.btn_Process.TabIndex = 8;
            this.btn_Process.Text = "Process :";
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(204, 273);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(128, 42);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Team :";
            // 
            // lbl_Days
            // 
            this.lbl_Days.AutoSize = true;
            this.lbl_Days.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Days.Location = new System.Drawing.Point(1670, 273);
            this.lbl_Days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Days.Name = "lbl_Days";
            this.lbl_Days.Size = new System.Drawing.Size(94, 42);
            this.lbl_Days.TabIndex = 6;
            this.lbl_Days.Text = "days";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(1018, 273);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(181, 42);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Deadline :";
            // 
            // pgb_Deadline
            // 
            this.pgb_Deadline.BorderColor = System.Drawing.Color.Black;
            this.pgb_Deadline.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.pgb_Deadline.IdleColor = System.Drawing.Color.Gainsboro;
            this.pgb_Deadline.Location = new System.Drawing.Point(1242, 277);
            this.pgb_Deadline.Margin = new System.Windows.Forms.Padding(4);
            this.pgb_Deadline.Name = "pgb_Deadline";
            this.pgb_Deadline.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.pgb_Deadline.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.pgb_Deadline.Size = new System.Drawing.Size(396, 37);
            this.pgb_Deadline.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(1018, 194);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(212, 42);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Date From :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(204, 194);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(287, 42);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Kind Of Project :";
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectName.ForeColor = System.Drawing.Color.Black;
            this.lbl_ProjectName.Location = new System.Drawing.Point(100, 71);
            this.lbl_ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(284, 49);
            this.lbl_ProjectName.TabIndex = 0;
            this.lbl_ProjectName.Text = "Project Name";
            // 
            // UCStudentProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_ProjectItem);
            this.Controls.Add(this.pnl_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCStudentProjects";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_ProjectItem.ResumeLayout(false);
            this.pnl_ProjectItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Title;
        private Guna.UI.WinForms.GunaPanel pnl_ProjectItem;
        private Guna.UI.WinForms.GunaLabel lbl_ProjectName;
        private System.Windows.Forms.Label lbl_Days;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaProgressBar pgb_Deadline;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_Point;
        private Guna.UI.WinForms.GunaLabel btn_Process;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btn_ManageProject;
        private Guna.UI.WinForms.GunaButton btn_Delete;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaLabel lbl_PointValue;
        private Guna.UI.WinForms.GunaLabel lbl_DateFrom;
        private Guna.UI.WinForms.GunaLabel lbl_Team;
        private Guna.UI.WinForms.GunaLabel lbl_KoProject;
        private Guna.UI.WinForms.GunaPanel pnl_ProjectItems;
        private Guna.UI.WinForms.GunaPanel pnl_ProcessItems;
        private Guna.UI.WinForms.GunaPanel pnl_MemberTeam;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaLabel lbl_Link;
        private Guna.UI.WinForms.GunaTextBox txt_Link;
        private Guna.UI.WinForms.GunaButton btn_Submit;
        private Guna.UI.WinForms.GunaButton btn_ProjectFinish;
    }
}

namespace DA_1.UserControls.Teacher
{
    partial class UCMangeProject
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
            this.pnl_Container = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Teams = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_ProName = new Guna.UI.WinForms.GunaLabel();
            this.pnl_TeamInfor = new Guna.UI.WinForms.GunaPanel();
            this.btn_Finish = new Guna.UI.WinForms.GunaButton();
            this.txt_Link = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Point = new Guna.UI.WinForms.GunaTextBox();
            this.pnl_Process = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Members = new Guna.UI.WinForms.GunaPanel();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.btn_DeleteTeam = new Guna.UI.WinForms.GunaButton();
            this.lbl_Link = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Point = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Delete = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pnl_ProjectItems = new Guna.UI.WinForms.GunaPanel();
            this.pnl_ItemsFinished = new Guna.UI.WinForms.GunaPanel();
            this.btn_ProjectFinish = new Guna.UI.WinForms.GunaButton();
            this.btn_ManageProject = new Guna.UI.WinForms.GunaButton();
            this.pnl_Main.SuspendLayout();
            this.pnl_Container.SuspendLayout();
            this.pnl_TeamInfor.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.pnl_ProjectItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.pnl_Container);
            this.pnl_Main.Controls.Add(this.gunaPanel1);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.pnl_Teams);
            this.pnl_Container.Controls.Add(this.gunaLabel2);
            this.pnl_Container.Controls.Add(this.lbl_ProName);
            this.pnl_Container.Controls.Add(this.pnl_TeamInfor);
            this.pnl_Container.Controls.Add(this.btn_Delete);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 262);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1888, 932);
            this.pnl_Container.TabIndex = 1;
            this.pnl_Container.Visible = false;
            // 
            // pnl_Teams
            // 
            this.pnl_Teams.BackColor = System.Drawing.Color.White;
            this.pnl_Teams.Location = new System.Drawing.Point(6, 150);
            this.pnl_Teams.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Teams.Name = "pnl_Teams";
            this.pnl_Teams.Size = new System.Drawing.Size(1882, 125);
            this.pnl_Teams.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(220, 96);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(151, 49);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Team :";
            // 
            // lbl_ProName
            // 
            this.lbl_ProName.AutoSize = true;
            this.lbl_ProName.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProName.Location = new System.Drawing.Point(88, 27);
            this.lbl_ProName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProName.Name = "lbl_ProName";
            this.lbl_ProName.Size = new System.Drawing.Size(284, 49);
            this.lbl_ProName.TabIndex = 0;
            this.lbl_ProName.Text = "Project Name";
            // 
            // pnl_TeamInfor
            // 
            this.pnl_TeamInfor.Controls.Add(this.btn_Finish);
            this.pnl_TeamInfor.Controls.Add(this.txt_Link);
            this.pnl_TeamInfor.Controls.Add(this.txt_Point);
            this.pnl_TeamInfor.Controls.Add(this.pnl_Process);
            this.pnl_TeamInfor.Controls.Add(this.pnl_Members);
            this.pnl_TeamInfor.Controls.Add(this.btn_Edit);
            this.pnl_TeamInfor.Controls.Add(this.btn_Back);
            this.pnl_TeamInfor.Controls.Add(this.btn_DeleteTeam);
            this.pnl_TeamInfor.Controls.Add(this.lbl_Link);
            this.pnl_TeamInfor.Controls.Add(this.lbl_Point);
            this.pnl_TeamInfor.Controls.Add(this.gunaLabel6);
            this.pnl_TeamInfor.Controls.Add(this.gunaLabel1);
            this.pnl_TeamInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_TeamInfor.Location = new System.Drawing.Point(0, 284);
            this.pnl_TeamInfor.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_TeamInfor.Name = "pnl_TeamInfor";
            this.pnl_TeamInfor.Size = new System.Drawing.Size(1888, 648);
            this.pnl_TeamInfor.TabIndex = 2;
            this.pnl_TeamInfor.Visible = false;
            // 
            // btn_Finish
            // 
            this.btn_Finish.AnimationHoverSpeed = 0.07F;
            this.btn_Finish.AnimationSpeed = 0.03F;
            this.btn_Finish.BackColor = System.Drawing.Color.Transparent;
            this.btn_Finish.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Finish.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Finish.BorderSize = 1;
            this.btn_Finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Finish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Finish.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Finish.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finish.ForeColor = System.Drawing.Color.White;
            this.btn_Finish.Image = null;
            this.btn_Finish.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Finish.Location = new System.Drawing.Point(1594, 496);
            this.btn_Finish.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Finish.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Finish.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Finish.OnHoverImage = null;
            this.btn_Finish.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Finish.Radius = 15;
            this.btn_Finish.Size = new System.Drawing.Size(232, 81);
            this.btn_Finish.TabIndex = 34;
            this.btn_Finish.Text = "FINISH";
            this.btn_Finish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Finish.Visible = false;
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // txt_Link
            // 
            this.txt_Link.BackColor = System.Drawing.Color.Transparent;
            this.txt_Link.BaseColor = System.Drawing.Color.White;
            this.txt_Link.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(28)))), ((int)(((byte)(100)))));
            this.txt_Link.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Link.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Link.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(28)))), ((int)(((byte)(100)))));
            this.txt_Link.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Link.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Link.Location = new System.Drawing.Point(242, 496);
            this.txt_Link.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Link.Name = "txt_Link";
            this.txt_Link.PasswordChar = '\0';
            this.txt_Link.Radius = 10;
            this.txt_Link.Size = new System.Drawing.Size(412, 63);
            this.txt_Link.TabIndex = 33;
            this.txt_Link.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Point
            // 
            this.txt_Point.BackColor = System.Drawing.Color.Transparent;
            this.txt_Point.BaseColor = System.Drawing.Color.White;
            this.txt_Point.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(28)))), ((int)(((byte)(100)))));
            this.txt_Point.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Point.Enabled = false;
            this.txt_Point.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Point.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(28)))), ((int)(((byte)(100)))));
            this.txt_Point.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Point.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Point.Location = new System.Drawing.Point(1184, 388);
            this.txt_Point.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Point.Name = "txt_Point";
            this.txt_Point.PasswordChar = '\0';
            this.txt_Point.Radius = 10;
            this.txt_Point.Size = new System.Drawing.Size(208, 63);
            this.txt_Point.TabIndex = 33;
            this.txt_Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_Process
            // 
            this.pnl_Process.Location = new System.Drawing.Point(1154, 127);
            this.pnl_Process.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Process.Name = "pnl_Process";
            this.pnl_Process.Size = new System.Drawing.Size(540, 223);
            this.pnl_Process.TabIndex = 32;
            // 
            // pnl_Members
            // 
            this.pnl_Members.Location = new System.Drawing.Point(190, 127);
            this.pnl_Members.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Members.Name = "pnl_Members";
            this.pnl_Members.Size = new System.Drawing.Size(464, 323);
            this.pnl_Members.TabIndex = 31;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AnimationHoverSpeed = 0.07F;
            this.btn_Edit.AnimationSpeed = 0.03F;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.BorderSize = 1;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Edit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Image = null;
            this.btn_Edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Edit.Location = new System.Drawing.Point(1594, 496);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Edit.Radius = 15;
            this.btn_Edit.Size = new System.Drawing.Size(232, 81);
            this.btn_Edit.TabIndex = 29;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
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
            this.btn_Back.Location = new System.Drawing.Point(1003, 496);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Back.OnHoverImage = null;
            this.btn_Back.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Back.Radius = 15;
            this.btn_Back.Size = new System.Drawing.Size(232, 81);
            this.btn_Back.TabIndex = 30;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_DeleteTeam
            // 
            this.btn_DeleteTeam.AnimationHoverSpeed = 0.07F;
            this.btn_DeleteTeam.AnimationSpeed = 0.03F;
            this.btn_DeleteTeam.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteTeam.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_DeleteTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_DeleteTeam.BorderSize = 1;
            this.btn_DeleteTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteTeam.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_DeleteTeam.FocusedColor = System.Drawing.Color.Empty;
            this.btn_DeleteTeam.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTeam.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteTeam.Image = null;
            this.btn_DeleteTeam.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_DeleteTeam.Location = new System.Drawing.Point(1302, 496);
            this.btn_DeleteTeam.Margin = new System.Windows.Forms.Padding(6);
            this.btn_DeleteTeam.Name = "btn_DeleteTeam";
            this.btn_DeleteTeam.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_DeleteTeam.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_DeleteTeam.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_DeleteTeam.OnHoverImage = null;
            this.btn_DeleteTeam.OnPressedColor = System.Drawing.Color.Black;
            this.btn_DeleteTeam.Radius = 15;
            this.btn_DeleteTeam.Size = new System.Drawing.Size(232, 81);
            this.btn_DeleteTeam.TabIndex = 30;
            this.btn_DeleteTeam.Text = "DELETE";
            this.btn_DeleteTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_DeleteTeam.Click += new System.EventHandler(this.btn_DeleteTeam_Click);
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Link.Location = new System.Drawing.Point(89, 506);
            this.lbl_Link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(126, 49);
            this.lbl_Link.TabIndex = 1;
            this.lbl_Link.Text = "Link :";
            // 
            // lbl_Point
            // 
            this.lbl_Point.AutoSize = true;
            this.lbl_Point.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Point.Location = new System.Drawing.Point(1032, 402);
            this.lbl_Point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Point.Name = "lbl_Point";
            this.lbl_Point.Size = new System.Drawing.Size(145, 49);
            this.lbl_Point.TabIndex = 1;
            this.lbl_Point.Text = "Point :";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(1032, 50);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(203, 49);
            this.gunaLabel6.TabIndex = 1;
            this.gunaLabel6.Text = "Process :";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(88, 50);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(225, 49);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Members :";
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
            this.btn_Delete.Location = new System.Drawing.Point(1621, 57);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Delete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Delete.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Delete.OnHoverImage = null;
            this.btn_Delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete.Radius = 15;
            this.btn_Delete.Size = new System.Drawing.Size(232, 81);
            this.btn_Delete.TabIndex = 30;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.pnl_ProjectItems);
            this.gunaPanel1.Controls.Add(this.btn_ProjectFinish);
            this.gunaPanel1.Controls.Add(this.btn_ManageProject);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1888, 262);
            this.gunaPanel1.TabIndex = 0;
            // 
            // pnl_ProjectItems
            // 
            this.pnl_ProjectItems.Controls.Add(this.pnl_ItemsFinished);
            this.pnl_ProjectItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_ProjectItems.Location = new System.Drawing.Point(0, 116);
            this.pnl_ProjectItems.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_ProjectItems.Name = "pnl_ProjectItems";
            this.pnl_ProjectItems.Size = new System.Drawing.Size(1888, 146);
            this.pnl_ProjectItems.TabIndex = 37;
            // 
            // pnl_ItemsFinished
            // 
            this.pnl_ItemsFinished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ItemsFinished.Location = new System.Drawing.Point(0, 0);
            this.pnl_ItemsFinished.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_ItemsFinished.Name = "pnl_ItemsFinished";
            this.pnl_ItemsFinished.Size = new System.Drawing.Size(1888, 146);
            this.pnl_ItemsFinished.TabIndex = 38;
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
            this.btn_ProjectFinish.Location = new System.Drawing.Point(566, 23);
            this.btn_ProjectFinish.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ProjectFinish.Name = "btn_ProjectFinish";
            this.btn_ProjectFinish.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_ProjectFinish.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ProjectFinish.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_ProjectFinish.OnHoverImage = null;
            this.btn_ProjectFinish.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ProjectFinish.Radius = 15;
            this.btn_ProjectFinish.Size = new System.Drawing.Size(392, 81);
            this.btn_ProjectFinish.TabIndex = 36;
            this.btn_ProjectFinish.Text = "Project was finished";
            this.btn_ProjectFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ProjectFinish.Click += new System.EventHandler(this.btn_ProjectFinish_Click);
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
            this.btn_ManageProject.TabIndex = 36;
            this.btn_ManageProject.Text = "Manage Project";
            this.btn_ManageProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ManageProject.Click += new System.EventHandler(this.btn_ManageProject_Click);
            // 
            // UCMangeProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCMangeProject";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.pnl_TeamInfor.ResumeLayout(false);
            this.pnl_TeamInfor.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.pnl_ProjectItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Main;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_ManageProject;
        private Guna.UI.WinForms.GunaPanel pnl_Container;
        private Guna.UI.WinForms.GunaLabel lbl_ProName;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel pnl_TeamInfor;
        private Guna.UI.WinForms.GunaLabel lbl_Point;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaButton btn_Delete;
        private Guna.UI.WinForms.GunaPanel pnl_ProjectItems;
        private Guna.UI.WinForms.GunaPanel pnl_Teams;
        private Guna.UI.WinForms.GunaPanel pnl_Members;
        private Guna.UI.WinForms.GunaPanel pnl_Process;
        private Guna.UI.WinForms.GunaTextBox txt_Point;
        private Guna.UI.WinForms.GunaButton btn_Finish;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaButton btn_DeleteTeam;
        private Guna.UI.WinForms.GunaPanel pnl_ItemsFinished;
        private Guna.UI.WinForms.GunaButton btn_ProjectFinish;
        private Guna.UI.WinForms.GunaTextBox txt_Link;
        private Guna.UI.WinForms.GunaLabel lbl_Link;
    }
}

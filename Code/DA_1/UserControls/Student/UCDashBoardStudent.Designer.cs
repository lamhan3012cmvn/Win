namespace DA_1.UserControls.Student
{
    partial class UCDashBoardStudent
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
            this.btn_Information = new Guna.UI.WinForms.GunaButton();
            this.btn_Projects = new Guna.UI.WinForms.GunaButton();
            this.btn_Logout = new Guna.UI.WinForms.GunaLabel();
            this.lbl_StudentName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btn_AddProject = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // btn_Information
            // 
            this.btn_Information.AnimationHoverSpeed = 0.07F;
            this.btn_Information.AnimationSpeed = 0.03F;
            this.btn_Information.BackColor = System.Drawing.Color.Transparent;
            this.btn_Information.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Information.BorderColor = System.Drawing.Color.Black;
            this.btn_Information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Information.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Information.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Information.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Information.ForeColor = System.Drawing.Color.White;
            this.btn_Information.Image = null;
            this.btn_Information.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Information.Location = new System.Drawing.Point(166, 396);
            this.btn_Information.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Information.Name = "btn_Information";
            this.btn_Information.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Information.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Information.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Information.OnHoverImage = null;
            this.btn_Information.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Information.OnPressedDepth = 50;
            this.btn_Information.Radius = 10;
            this.btn_Information.Size = new System.Drawing.Size(345, 139);
            this.btn_Information.TabIndex = 3;
            this.btn_Information.Text = "INFORMATION";
            this.btn_Information.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Information.Click += new System.EventHandler(this.btn_Information_Click);
            // 
            // btn_Projects
            // 
            this.btn_Projects.AnimationHoverSpeed = 0.07F;
            this.btn_Projects.AnimationSpeed = 0.03F;
            this.btn_Projects.BackColor = System.Drawing.Color.Transparent;
            this.btn_Projects.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Projects.BorderColor = System.Drawing.Color.Black;
            this.btn_Projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Projects.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Projects.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Projects.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Projects.ForeColor = System.Drawing.Color.White;
            this.btn_Projects.Image = null;
            this.btn_Projects.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Projects.Location = new System.Drawing.Point(160, 778);
            this.btn_Projects.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Projects.Name = "btn_Projects";
            this.btn_Projects.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_Projects.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Projects.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Projects.OnHoverImage = null;
            this.btn_Projects.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Projects.OnPressedDepth = 50;
            this.btn_Projects.Radius = 10;
            this.btn_Projects.Size = new System.Drawing.Size(351, 135);
            this.btn_Projects.TabIndex = 4;
            this.btn_Projects.Text = "PROJECTS";
            this.btn_Projects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Projects.Click += new System.EventHandler(this.btn_Projects_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.AutoSize = true;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(151, 1117);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(178, 51);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentName.Location = new System.Drawing.Point(94, 227);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(277, 57);
            this.lbl_StudentName.TabIndex = 6;
            this.lbl_StudentName.Text = "Name Student";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(-9, 35);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(500, 123);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Student";
            // 
            // btn_AddProject
            // 
            this.btn_AddProject.AnimationHoverSpeed = 0.07F;
            this.btn_AddProject.AnimationSpeed = 0.03F;
            this.btn_AddProject.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddProject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddProject.BorderColor = System.Drawing.Color.Black;
            this.btn_AddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddProject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddProject.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddProject.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProject.ForeColor = System.Drawing.Color.White;
            this.btn_AddProject.Image = null;
            this.btn_AddProject.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddProject.Location = new System.Drawing.Point(160, 579);
            this.btn_AddProject.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddProject.Name = "btn_AddProject";
            this.btn_AddProject.OnHoverBaseColor = System.Drawing.Color.White;
            this.btn_AddProject.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_AddProject.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddProject.OnHoverImage = null;
            this.btn_AddProject.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddProject.OnPressedDepth = 50;
            this.btn_AddProject.Radius = 10;
            this.btn_AddProject.Size = new System.Drawing.Size(351, 135);
            this.btn_AddProject.TabIndex = 14;
            this.btn_AddProject.Text = "Add New Project";
            this.btn_AddProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddProject.Click += new System.EventHandler(this.btn_AddProject_Click);
            // 
            // UCDashBoardStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.Controls.Add(this.btn_AddProject);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lbl_StudentName);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Information);
            this.Controls.Add(this.btn_Projects);
            this.Name = "UCDashBoardStudent";
            this.Size = new System.Drawing.Size(480, 1271);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btn_Information;
        private Guna.UI.WinForms.GunaButton btn_Projects;
        private Guna.UI.WinForms.GunaLabel btn_Logout;
        private Guna.UI.WinForms.GunaLabel lbl_StudentName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton btn_AddProject;
    }
}

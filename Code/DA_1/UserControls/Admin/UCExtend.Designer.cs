namespace DA_1.UserControls.Admin
{
    partial class UCExtend
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
            this.pnl_Controls = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Menu = new Guna.UI.WinForms.GunaPanel();
            this.btn_KoTopic = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Faculty = new Guna.UI.WinForms.GunaCircleButton();
            this.pnl_Container = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Controls.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.pnl_Menu);
            this.pnl_Controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Controls.Location = new System.Drawing.Point(0, 0);
            this.pnl_Controls.Name = "pnl_Controls";
            this.pnl_Controls.Size = new System.Drawing.Size(1888, 102);
            this.pnl_Controls.TabIndex = 0;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btn_KoTopic);
            this.pnl_Menu.Controls.Add(this.btn_Faculty);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(1888, 101);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_KoTopic
            // 
            this.btn_KoTopic.AnimationHoverSpeed = 0.07F;
            this.btn_KoTopic.AnimationSpeed = 0.03F;
            this.btn_KoTopic.BaseColor = System.Drawing.Color.White;
            this.btn_KoTopic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_KoTopic.BorderSize = 1;
            this.btn_KoTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KoTopic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_KoTopic.FocusedColor = System.Drawing.Color.Empty;
            this.btn_KoTopic.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KoTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_KoTopic.Image = null;
            this.btn_KoTopic.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_KoTopic.Location = new System.Drawing.Point(463, 12);
            this.btn_KoTopic.Name = "btn_KoTopic";
            this.btn_KoTopic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_KoTopic.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_KoTopic.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_KoTopic.OnHoverImage = null;
            this.btn_KoTopic.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_KoTopic.Size = new System.Drawing.Size(203, 70);
            this.btn_KoTopic.TabIndex = 2;
            this.btn_KoTopic.Text = "Kind of Topic";
            this.btn_KoTopic.Click += new System.EventHandler(this.btn_KoTopic_Click);
            // 
            // btn_Faculty
            // 
            this.btn_Faculty.AnimationHoverSpeed = 0.07F;
            this.btn_Faculty.AnimationSpeed = 0.03F;
            this.btn_Faculty.BaseColor = System.Drawing.Color.White;
            this.btn_Faculty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Faculty.BorderSize = 1;
            this.btn_Faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Faculty.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Faculty.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Faculty.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Faculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Faculty.Image = null;
            this.btn_Faculty.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_Faculty.Location = new System.Drawing.Point(180, 12);
            this.btn_Faculty.Name = "btn_Faculty";
            this.btn_Faculty.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Faculty.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Faculty.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Faculty.OnHoverImage = null;
            this.btn_Faculty.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Faculty.Size = new System.Drawing.Size(203, 70);
            this.btn_Faculty.TabIndex = 0;
            this.btn_Faculty.Text = "Faculty";
            this.btn_Faculty.Click += new System.EventHandler(this.btn_Faculty_Click);
            // 
            // pnl_Container
            // 
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 102);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1888, 1092);
            this.pnl_Container.TabIndex = 1;
            // 
            // UCExtend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Controls);
            this.Name = "UCExtend";
            this.Size = new System.Drawing.Size(1888, 1194);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Controls;
        private Guna.UI.WinForms.GunaPanel pnl_Container;
        private Guna.UI.WinForms.GunaPanel pnl_Menu;
        private Guna.UI.WinForms.GunaCircleButton btn_Faculty;
        private Guna.UI.WinForms.GunaCircleButton btn_KoTopic;
    }
}

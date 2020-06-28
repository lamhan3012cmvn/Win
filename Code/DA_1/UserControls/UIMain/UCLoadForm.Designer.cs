namespace DA_1.UserControls.UIMain
{
    partial class UCLoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoadForm));
            this.pnl_Container = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Title = new Guna.UI.WinForms.GunaPanel();
            this.btn_Exit = new Guna.UI.WinForms.GunaPictureBox();
            this.pnl_DashBoard = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.AutoSize = true;
            this.pnl_Container.BackColor = System.Drawing.Color.White;
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(240, 40);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(944, 621);
            this.pnl_Container.TabIndex = 8;
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.White;
            this.pnl_Title.Controls.Add(this.btn_Exit);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(240, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(944, 40);
            this.pnl_Title.TabIndex = 7;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.BaseColor = System.Drawing.Color.White;
            this.btn_Exit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ErrorImage")));
            this.btn_Exit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.InitialImage")));
            this.btn_Exit.Location = new System.Drawing.Point(911, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pnl_DashBoard
            // 
            this.pnl_DashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_DashBoard.Location = new System.Drawing.Point(0, 0);
            this.pnl_DashBoard.Name = "pnl_DashBoard";
            this.pnl_DashBoard.Size = new System.Drawing.Size(240, 661);
            this.pnl_DashBoard.TabIndex = 6;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.pnl_Title;
            // 
            // UCLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Title);
            this.Controls.Add(this.pnl_DashBoard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCLoadForm";
            this.Size = new System.Drawing.Size(1184, 661);
            this.pnl_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Container;
        private Guna.UI.WinForms.GunaPanel pnl_Title;
        private Guna.UI.WinForms.GunaPanel pnl_DashBoard;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox btn_Exit;
    }
}

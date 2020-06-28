namespace DA_1.UserControls.Admin
{
    partial class UCKoTopic
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
            this.pnl_Controls = new Guna.UI.WinForms.GunaPanel();
            this.btn_Del = new Guna.UI.WinForms.GunaButton();
            this.btn_Edit = new Guna.UI.WinForms.GunaButton();
            this.btn_Back = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.lbl_KoTopicName = new Guna.UI.WinForms.GunaLabel();
            this.lbl_KoTopicID = new Guna.UI.WinForms.GunaLabel();
            this.txt_KoTopicName = new Guna.UI.WinForms.GunaTextBox();
            this.txt_KoTopicID = new Guna.UI.WinForms.GunaTextBox();
            this.btn_AddNewKoTopic = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.pnl_Container = new Guna.UI.WinForms.GunaPanel();
            this.dtGrid_KoTopic = new Guna.UI.WinForms.GunaDataGridView();
            this.colKoTopicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKoTopicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.pnl_Controls.SuspendLayout();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_KoTopic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Controls
            // 
            this.pnl_Controls.Controls.Add(this.btn_Del);
            this.pnl_Controls.Controls.Add(this.btn_Edit);
            this.pnl_Controls.Controls.Add(this.btn_Back);
            this.pnl_Controls.Controls.Add(this.btn_Add);
            this.pnl_Controls.Controls.Add(this.lbl_KoTopicName);
            this.pnl_Controls.Controls.Add(this.lbl_KoTopicID);
            this.pnl_Controls.Controls.Add(this.txt_KoTopicName);
            this.pnl_Controls.Controls.Add(this.txt_KoTopicID);
            this.pnl_Controls.Controls.Add(this.btn_AddNewKoTopic);
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
            this.btn_Del.Location = new System.Drawing.Point(1550, 256);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Del.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Del.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Del.OnHoverImage = null;
            this.btn_Del.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Del.Radius = 10;
            this.btn_Del.Size = new System.Drawing.Size(282, 73);
            this.btn_Del.TabIndex = 31;
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
            this.btn_Edit.Location = new System.Drawing.Point(1196, 256);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Edit.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Edit.OnHoverImage = null;
            this.btn_Edit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Edit.Radius = 10;
            this.btn_Edit.Size = new System.Drawing.Size(282, 73);
            this.btn_Edit.TabIndex = 27;
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
            this.btn_Back.Location = new System.Drawing.Point(1196, 256);
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
            this.btn_Add.Location = new System.Drawing.Point(1550, 256);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_Add.Radius = 10;
            this.btn_Add.Size = new System.Drawing.Size(282, 73);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "ADD";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_KoTopicName
            // 
            this.lbl_KoTopicName.AutoSize = true;
            this.lbl_KoTopicName.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KoTopicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.lbl_KoTopicName.Location = new System.Drawing.Point(960, 165);
            this.lbl_KoTopicName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KoTopicName.Name = "lbl_KoTopicName";
            this.lbl_KoTopicName.Size = new System.Drawing.Size(380, 44);
            this.lbl_KoTopicName.TabIndex = 16;
            this.lbl_KoTopicName.Text = "Kind of Topic Name:";
            this.lbl_KoTopicName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_KoTopicName.Visible = false;
            // 
            // lbl_KoTopicID
            // 
            this.lbl_KoTopicID.AutoSize = true;
            this.lbl_KoTopicID.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KoTopicID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.lbl_KoTopicID.Location = new System.Drawing.Point(140, 165);
            this.lbl_KoTopicID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KoTopicID.Name = "lbl_KoTopicID";
            this.lbl_KoTopicID.Size = new System.Drawing.Size(314, 44);
            this.lbl_KoTopicID.TabIndex = 17;
            this.lbl_KoTopicID.Text = "Kind of Topic ID:";
            this.lbl_KoTopicID.Visible = false;
            // 
            // txt_KoTopicName
            // 
            this.txt_KoTopicName.BackColor = System.Drawing.Color.Transparent;
            this.txt_KoTopicName.BaseColor = System.Drawing.Color.White;
            this.txt_KoTopicName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicName.BorderSize = 1;
            this.txt_KoTopicName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KoTopicName.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_KoTopicName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicName.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicName.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KoTopicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicName.Location = new System.Drawing.Point(1374, 154);
            this.txt_KoTopicName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KoTopicName.Name = "txt_KoTopicName";
            this.txt_KoTopicName.PasswordChar = '\0';
            this.txt_KoTopicName.Radius = 10;
            this.txt_KoTopicName.Size = new System.Drawing.Size(308, 81);
            this.txt_KoTopicName.TabIndex = 14;
            this.txt_KoTopicName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KoTopicName.Visible = false;
            // 
            // txt_KoTopicID
            // 
            this.txt_KoTopicID.BackColor = System.Drawing.Color.Transparent;
            this.txt_KoTopicID.BaseColor = System.Drawing.Color.White;
            this.txt_KoTopicID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicID.BorderSize = 1;
            this.txt_KoTopicID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KoTopicID.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_KoTopicID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicID.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicID.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KoTopicID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.txt_KoTopicID.Location = new System.Drawing.Point(496, 154);
            this.txt_KoTopicID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KoTopicID.Name = "txt_KoTopicID";
            this.txt_KoTopicID.PasswordChar = '\0';
            this.txt_KoTopicID.Radius = 10;
            this.txt_KoTopicID.Size = new System.Drawing.Size(308, 81);
            this.txt_KoTopicID.TabIndex = 15;
            this.txt_KoTopicID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_KoTopicID.Visible = false;
            // 
            // btn_AddNewKoTopic
            // 
            this.btn_AddNewKoTopic.AnimationHoverSpeed = 0.07F;
            this.btn_AddNewKoTopic.AnimationSpeed = 0.03F;
            this.btn_AddNewKoTopic.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddNewKoTopic.BaseColor = System.Drawing.Color.White;
            this.btn_AddNewKoTopic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddNewKoTopic.BorderSize = 1;
            this.btn_AddNewKoTopic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNewKoTopic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddNewKoTopic.FocusedColor = System.Drawing.Color.Empty;
            this.btn_AddNewKoTopic.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewKoTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddNewKoTopic.Image = null;
            this.btn_AddNewKoTopic.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_AddNewKoTopic.Location = new System.Drawing.Point(656, 146);
            this.btn_AddNewKoTopic.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddNewKoTopic.Name = "btn_AddNewKoTopic";
            this.btn_AddNewKoTopic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.btn_AddNewKoTopic.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_AddNewKoTopic.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_AddNewKoTopic.OnHoverImage = null;
            this.btn_AddNewKoTopic.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_AddNewKoTopic.Radius = 10;
            this.btn_AddNewKoTopic.Size = new System.Drawing.Size(608, 79);
            this.btn_AddNewKoTopic.TabIndex = 13;
            this.btn_AddNewKoTopic.Text = "Add New Kind of Topic";
            this.btn_AddNewKoTopic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddNewKoTopic.Click += new System.EventHandler(this.btn_AddNewKoTopic_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            this.gunaLabel1.Location = new System.Drawing.Point(56, 27);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(360, 62);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "Kind of Topic";
            // 
            // pnl_Container
            // 
            this.pnl_Container.Controls.Add(this.dtGrid_KoTopic);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 356);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(1888, 736);
            this.pnl_Container.TabIndex = 1;
            // 
            // dtGrid_KoTopic
            // 
            this.dtGrid_KoTopic.AllowUserToAddRows = false;
            this.dtGrid_KoTopic.AllowUserToDeleteRows = false;
            this.dtGrid_KoTopic.AllowUserToResizeColumns = false;
            this.dtGrid_KoTopic.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGrid_KoTopic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid_KoTopic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_KoTopic.BackgroundColor = System.Drawing.Color.White;
            this.dtGrid_KoTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrid_KoTopic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_KoTopic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(38)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid_KoTopic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrid_KoTopic.ColumnHeadersHeight = 46;
            this.dtGrid_KoTopic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKoTopicID,
            this.colKoTopicName,
            this.colAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid_KoTopic.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrid_KoTopic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrid_KoTopic.EnableHeadersVisualStyles = false;
            this.dtGrid_KoTopic.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_KoTopic.Location = new System.Drawing.Point(0, 0);
            this.dtGrid_KoTopic.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrid_KoTopic.Name = "dtGrid_KoTopic";
            this.dtGrid_KoTopic.RowHeadersVisible = false;
            this.dtGrid_KoTopic.RowHeadersWidth = 82;
            this.dtGrid_KoTopic.RowTemplate.Height = 33;
            this.dtGrid_KoTopic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid_KoTopic.Size = new System.Drawing.Size(1888, 736);
            this.dtGrid_KoTopic.TabIndex = 1;
            this.dtGrid_KoTopic.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGrid_KoTopic.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_KoTopic.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGrid_KoTopic.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGrid_KoTopic.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGrid_KoTopic.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGrid_KoTopic.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_KoTopic.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_KoTopic.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGrid_KoTopic.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGrid_KoTopic.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_KoTopic.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGrid_KoTopic.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGrid_KoTopic.ThemeStyle.HeaderStyle.Height = 46;
            this.dtGrid_KoTopic.ThemeStyle.ReadOnly = false;
            this.dtGrid_KoTopic.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGrid_KoTopic.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGrid_KoTopic.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGrid_KoTopic.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_KoTopic.ThemeStyle.RowsStyle.Height = 33;
            this.dtGrid_KoTopic.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGrid_KoTopic.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGrid_KoTopic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrid_KoTopic_CellClick);
            // 
            // colKoTopicID
            // 
            this.colKoTopicID.HeaderText = "Kind of Topic ID";
            this.colKoTopicID.MinimumWidth = 10;
            this.colKoTopicID.Name = "colKoTopicID";
            this.colKoTopicID.ReadOnly = true;
            // 
            // colKoTopicName
            // 
            this.colKoTopicName.HeaderText = "Kind of Topic Name";
            this.colKoTopicName.MinimumWidth = 10;
            this.colKoTopicName.Name = "colKoTopicName";
            this.colKoTopicName.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount of Topics";
            this.colAmount.MinimumWidth = 10;
            this.colAmount.Name = "colAmount";
            // 
            // UCKoTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Controls);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCKoTopic";
            this.Size = new System.Drawing.Size(1888, 1092);
            this.pnl_Controls.ResumeLayout(false);
            this.pnl_Controls.PerformLayout();
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_KoTopic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Controls;
        private Guna.UI.WinForms.GunaPanel pnl_Container;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaLabel lbl_KoTopicName;
        private Guna.UI.WinForms.GunaLabel lbl_KoTopicID;
        private Guna.UI.WinForms.GunaTextBox txt_KoTopicName;
        private Guna.UI.WinForms.GunaTextBox txt_KoTopicID;
        private Guna.UI.WinForms.GunaButton btn_AddNewKoTopic;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView dtGrid_KoTopic;
        private System.Windows.Forms.Timer timerLoad;
        private Guna.UI.WinForms.GunaButton btn_Edit;
        private Guna.UI.WinForms.GunaButton btn_Back;
        private Guna.UI.WinForms.GunaButton btn_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKoTopicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKoTopicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}

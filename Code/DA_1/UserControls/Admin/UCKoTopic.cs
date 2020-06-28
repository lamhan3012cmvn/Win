using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_1.Controllers;
using DA_1.Library;

namespace DA_1.UserControls.Admin
{
    public partial class UCKoTopic : UserControl
    {
        #region Field
        ControllerAdmin cAdmin;
        private bool isLocationBtnBack;
        #endregion
        #region Contructor
        public UCKoTopic()
        {
            InitializeComponent();
            cAdmin = new ControllerAdmin();
            this.dtGrid_KoTopic.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 38, 100);
            this.dtGrid_KoTopic.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dtGrid_KoTopic.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            this.dtGrid_KoTopic.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGrid_KoTopic.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGrid_KoTopic.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.isLocationBtnBack = false;
            this.loadData();
        }
        #endregion
        #region Methods
        private void loadData()
        {
            this.dtGrid_KoTopic.Rows.Clear();
            cAdmin.loadDataK().ForEach(kot =>
            {
                this.dtGrid_KoTopic.Rows.Add(
                    new object[]
                    {
                        kot.KotID,kot.name,kot.Topics.Count
                    });
            });
        }
        private void change(bool x, bool y)
        {
            this.btn_AddNewKoTopic.Visible = x;
            this.lbl_KoTopicID.Visible = y;
            this.lbl_KoTopicName.Visible = y;
            this.txt_KoTopicID.Visible = y;
            this.txt_KoTopicName.Visible = y;
            this.btn_Add.Visible = y;
            this.btn_Back.Visible = y;
        }
        private void showBtnCellClick()
        {
            if (!isLocationBtnBack)
            {
                btn_Back.Location = new Point(btn_Back.Location.X - 174, btn_Back.Location.Y);
                this.isLocationBtnBack = true;
            }
            this.change(false, true);
            btn_Add.Visible = false;
            btn_Del.Visible = true;
            btn_Edit.Visible = true;
            this.txt_KoTopicID.Enabled = false;

        }
        private void create()
        {
            this.txt_KoTopicID.ResetText();
            this.txt_KoTopicName.ResetText();
            this.txt_KoTopicID.Enabled = true;
            this.change(true, false);
            this.btn_Del.Visible = false;
            this.btn_Edit.Visible = false;
            if (isLocationBtnBack)
            {
                btn_Back.Location = new Point(btn_Back.Location.X + 174, btn_Back.Location.Y);
                this.isLocationBtnBack = false;
            }
        }
        #endregion
        #region Btn
        private void btn_AddNewKoTopic_Click(object sender, EventArgs e)
        {
            this.change(false, true);
            this.txt_KoTopicID.Text = "K" + cAdmin.getIDKoT();
            this.txt_KoTopicID.Enabled = false;
            btn_Del.Visible = false;
            btn_Edit.Visible = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.cAdmin.addK(this.txt_KoTopicID.Text, this.txt_KoTopicName.Text);
            create();
            loadData();
            cMainControl.showNotification("ADD KIND OF TOPIC", "SUCCESS!");
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.change(true, false);
            btn_Del.Visible = false;
            btn_Edit.Visible = false;
            create();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.cAdmin.updateK(this.txt_KoTopicID.Text, this.txt_KoTopicName.Text);
            create();
            loadData();
            cMainControl.showNotification("EDIT KIND OF TOPIC", "SUCCESS!");

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            this.cAdmin.deleteK(this.txt_KoTopicID.Text);
            create();
            loadData();
            cMainControl.showNotification("DELETE KIND OF TOPIC", "SUCCESS!");

        }
        private void dtGrid_KoTopic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                showBtnCellClick();
                this.txt_KoTopicID.Text = this.dtGrid_KoTopic.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                this.txt_KoTopicName.Text = this.dtGrid_KoTopic.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            }
        }

        #endregion
    }
}

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
    public partial class UCFaculty : UserControl
    {
        #region Field
        private ControllerAdmin cAdmin;
        private bool isLocationBtnBack;
        #endregion
        #region Contructor
        public UCFaculty()
        {
            InitializeComponent();
            cAdmin = new ControllerAdmin();
            this.dtGrid_Faculty.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 38, 100);
            this.dtGrid_Faculty.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dtGrid_Faculty.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            this.dtGrid_Faculty.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGrid_Faculty.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGrid_Faculty.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.isLocationBtnBack = false;
            this.loadData();
        }
        #endregion
        #region Btn
        private void btn_AddNewFaculty_Click(object sender, EventArgs e)
        {
            //Ẩn hiện nút
            this.change(false, true);
            btn_Del.Visible = false;
            btn_Edit.Visible = false;
            this.txt_FacultyId.Text = cAdmin.getFacultyID().ToString();
            this.txt_FacultyId.Enabled = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.cAdmin.addF(this.txt_FacultyId.Text, this.txt_FacultyName.Text);
            create();
            loadData();
            cMainControl.showNotification("ADD FACULTY", "SUCCESS!");

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
            this.cAdmin.updateF(this.txt_FacultyId.Text, this.txt_FacultyName.Text);
            create();
            loadData();
            cMainControl.showNotification("EDIT FACULTY", "SUCCESS!");

        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            this.cAdmin.deleteF(this.txt_FacultyId.Text);
            create();

            loadData();
            cMainControl.showNotification("DELETE FACULTY", "SUCCESS!");

        }
        #endregion
        #region Methods
        private void loadData()
        {
            this.dtGrid_Faculty.Rows.Clear();
            this.cAdmin.loadDataF().ForEach(f => {
                int countTeacher = (f.Teachers.Count());
                int countStudent = (f.Students.Count());
                this.dtGrid_Faculty.Rows.Add(
                    new object[]
                    {
                         f.FacultyID,f.FacultyName,countStudent,countTeacher
                    });
            });
        }
        private void change(bool x, bool y)
        {
            btn_AddNewFaculty.Visible = x;
            lbl_FacultyID.Visible = y;
            lbl_FacultyName.Visible = y;
            txt_FacultyId.Visible = y;
            txt_FacultyName.Visible = y;
            btn_Add.Visible = y;
            btn_Back.Visible = y;
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
            this.txt_FacultyId.Enabled = false;

        }
        private void create()
        {
            this.txt_FacultyId.ResetText();
            this.txt_FacultyName.ResetText();
            this.txt_FacultyId.Enabled = true;
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
        #region envent
        private void dtGrid_Faculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                showBtnCellClick();
                this.txt_FacultyId.Text = this.dtGrid_Faculty.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                this.txt_FacultyName.Text = this.dtGrid_Faculty.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            }
        }
        #endregion    
    }
}

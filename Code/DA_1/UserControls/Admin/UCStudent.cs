using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_1.Library;
using DA_1.Controllers;
using DA_1.Models;

namespace DA_1.UserControls.Admin
{
    public partial class UCStudent : UserControl
    {
        #region Field
        private Control pnl_Container;
        private ControllerAdmin cAdmin;
        #endregion
        #region Methods
        private void loadData(List<DA_1.Models.Student> students)
        {
            StringBuilder teamwork = new StringBuilder();
            StringBuilder project = new StringBuilder();
            this.dtGrid_Students.Rows.Clear();

            students.ForEach(current =>
            {
                teamwork.Clear();
                project.Clear();
                teamwork.Append("\n");
                project.Append("\n");
                current.TeamWorks.ToList().ForEach(tw =>
                {
                    teamwork.Append(tw.name.Trim());
                    teamwork.Append("\n");
                    project.Append(tw.Topic.name.Trim());
                    project.Append("\n");

                });


                this.dtGrid_Students.Rows.Add(new object[] {
                        current.studentID,
                        current.name,
                        current.Faculty.FacultyName,
                        teamwork.ToString(),
                        project.ToString()});

            });
        }
        #endregion
        #region Contructor
        public UCStudent(Control pnl_Container)
        {
            InitializeComponent();
            this.pnl_Container = pnl_Container;
            this.cAdmin = new ControllerAdmin();
            this.dtGrid_Students.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 38, 100);
            this.dtGrid_Students.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dtGrid_Students.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            this.cbx_Select.Text = this.cbx_Select.Items[0].ToString();
            this.dtGrid_Students.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dtGrid_Students.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dtGrid_Students.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dtGrid_Students.Columns[3].DefaultCellStyle.Padding = new Padding(40, 0, 0, 0);
            this.dtGrid_Students.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            loadData(cAdmin.loadData("", this.cbx_Select.Text.Trim().ToLower()));

        }
        #endregion
        #region Btn
        private void btn_NewStudent_Click(object sender, EventArgs e)
        {
            UCInputStudent ucInputStudent = new UCInputStudent(true, pnl_Container);

            cMainControl.addControl(pnl_Container, ucInputStudent);
            this.Dispose();
        }
        #endregion
        #region Events
        private void dtGrid_Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var st = cAdmin.getInforStudent(this.dtGrid_Students.Rows[e.RowIndex].Cells[0].Value.ToString());
                UCStudentInfor ucInfor = new UCStudentInfor(st, this.pnl_Container);
                cMainControl.addControl(pnl_Container, ucInfor);
                this.Dispose();

            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            loadData(cAdmin.loadData(this.txt_Search.Text.Trim(), this.cbx_Select.Text.Trim().ToLower()));
        }

        private void cbx_Select_DropDownClosed(object sender, EventArgs e)
        {
            this.txt_Search.Text = "";
            loadData(cAdmin.loadData(this.txt_Search.Text, this.cbx_Select.Text.Trim().ToLower()));
        }
        #endregion
    }
}
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
    public partial class UCTeacher : UserControl
    {
        #region Field
        private Control pnlContainer;
        private ControllerAdmin cAdmin;

        #endregion
        #region Methods
        private void loadData(List<DA_1.Models.Teacher> teachers)
        {
            this.dtGrid_Teacher.Rows.Clear();
            StringBuilder project = new StringBuilder();
            teachers.ForEach(teacher =>
            {
                project.Clear();
                project.Append("\n");

                teacher.Topics.ToList().ForEach(tp =>
                {
                    project.Append(tp.name.Trim());
                    project.Append("\n");
                });
                this.dtGrid_Teacher.Rows.Add(new object[]
                {
                    teacher.teacherID,
                    teacher.name,
                    teacher.Faculty.FacultyName,
                    teacher.Position.name,
                    teacher.Academic.name,
                    project.ToString()
                }); ;
            });
        }
        #endregion
        #region Contructor
        public UCTeacher(Control pnlContainer)
        {
            InitializeComponent();
            cAdmin = new ControllerAdmin();
            this.pnlContainer = pnlContainer;
            this.dtGrid_Teacher.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 38, 100);
            this.dtGrid_Teacher.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dtGrid_Teacher.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            this.cbx_Select.Text = this.cbx_Select.Items[0].ToString();
            this.dtGrid_Teacher.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtGrid_Teacher.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            loadData(cAdmin.loadDataT("", this.cbx_Select.Text.Trim().ToLower()));
        }

        #endregion
        #region Btn
        private void btn_NewTeacher_Click(object sender, EventArgs e)
        {
            UCInputTeacher ucInputTeacher = new UCInputTeacher(pnlContainer);
            cMainControl.addControl(pnlContainer, ucInputTeacher);

            this.Dispose();

        }

        #endregion
        #region Events
        private void dtGrid_Teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                UCTeacherInfor ucTeacherInfor = new UCTeacherInfor(this.dtGrid_Teacher.Rows[e.RowIndex].Cells[0].Value.ToString().Trim(), pnlContainer);
                cMainControl.addControl(pnlContainer, ucTeacherInfor);
                this.Dispose();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            loadData(cAdmin.loadDataT(this.txt_Search.Text, this.cbx_Select.Text.Trim().ToLower()));
        }

        private void cbx_Select_DropDownClosed(object sender, EventArgs e)
        {
            this.txt_Search.Text = "";
            loadData(cAdmin.loadDataT(this.txt_Search.Text, this.cbx_Select.Text.Trim().ToLower()));
        }
        #endregion
    }
}

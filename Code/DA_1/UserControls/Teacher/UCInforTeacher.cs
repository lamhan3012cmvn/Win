using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_1.Models;
using DA_1.UserControls.Admin;
using DA_1.Library;

namespace DA_1.UserControls.Teacher
{
    public partial class UCInforTeacher : UserControl
    {
        #region Field
        private DA_1.Models.Teacher teacher;
        private Control pnl_Container;
        #endregion
        #region Contructor
        public UCInforTeacher(DA_1.Models.Teacher teacher, Control pnl_Container)
        {
            InitializeComponent();
            this.pnl_Container = pnl_Container;
            this.teacher = teacher;
            this.lbl_AcademicLevel.Text = this.teacher.Academic.name.Trim();
            var birthday = this.teacher.birth;
            this.lbl_Birthday.Text = birthday.ToString();
            this.lbl_Email.Text = this.teacher.mail.Trim();
            this.lbl_Faculty.Text = this.teacher.Faculty.FacultyName.Trim();
            this.lbl_Name.Text = this.teacher.name.Trim();
            this.lbl_Phone.Text = this.teacher.phone.Trim();
            this.lbl_Position.Text = this.teacher.Position.name.Trim();
            this.lbl_TeacherID.Text = this.teacher.teacherID.Trim();
        }

        #endregion
        #region Btn
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UCInputTeacher ucInputTeacher = new UCInputTeacher(this.pnl_Container, teacher.teacherID, true);
            cMainControl.addControl(this.pnl_Container, ucInputTeacher);
            this.Dispose();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}

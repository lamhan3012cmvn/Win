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
    public partial class UCTeacherInfor : UserControl
    {
        #region Field
        private Control pnlContainer;
        private string teacherID;
        ControllerTeacher cTeacher;

        #endregion
        #region Methods
        private void loadData()
        {
            var tc = cTeacher.getInforTeacher(teacherID);
            this.lbl_TeacherID.Text = tc.teacherID;
            this.lbl_Name.Text = tc.name;
            var birth = (tc.birth).ToString().Split(' ');
            this.lbl_Birthday.Text = birth[0];
            this.lbl_Phone.Text = tc.phone;
            this.lbl_Email.Text = tc.mail;
            this.lbl_Faculty.Text = tc.Faculty.FacultyName;
            this.lbl_Position.Text = tc.Position.name;
            this.lbl_AcademicLevel.Text = tc.Academic.name;
        }
        #endregion
        #region Contructor
        public UCTeacherInfor(string teacherID, Control pnlContainer)
        {
            InitializeComponent();
            this.pnlContainer = pnlContainer;
            this.teacherID = teacherID;
            cTeacher = new ControllerTeacher();
            loadData();
        }

        #endregion
        #region Btn
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();

            UCTeacher ucTeacher = new UCTeacher(pnlContainer);
            cMainControl.addControl(pnlContainer, ucTeacher);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UCInputTeacher ucInputTeacher = new UCInputTeacher(pnlContainer, lbl_TeacherID.Text.Trim());
            cMainControl.addControl(pnlContainer, ucInputTeacher);

            this.Dispose();


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            cTeacher.deleteTeacher(teacherID);
            UCTeacher ucTeacher = new UCTeacher(pnlContainer);
            cMainControl.addControl(pnlContainer, ucTeacher);
            this.Dispose();
            cMainControl.showNotification("DELETE TEACHER", "SUCCESS!");

        }

        #endregion
    }
}

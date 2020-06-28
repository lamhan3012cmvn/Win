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
using DA_1.UserControls.Login;

namespace DA_1.UserControls.Admin
{
    public partial class UCDashBoard : UserControl
    {
        #region Field
        private Control pnlContainer;
        private Control pnlMain;
        #endregion
        #region Methods
        private void reset_Btn()
        {
            this.btn_Student.BaseColor = cColor.pink();
            this.btn_Student.ForeColor = Color.White;

            this.btn_Teacher.BaseColor = cColor.pink();
            this.btn_Teacher.ForeColor = Color.White;

            this.btn_Project.BaseColor = cColor.pink();
            this.btn_Project.ForeColor = Color.White;

            this.btn_About.BaseColor = cColor.pink();
            this.btn_About.ForeColor = Color.White;

            this.btn_Extend.BaseColor = cColor.pink();
            this.btn_Extend.ForeColor = Color.White;
        }
        #endregion
        #region Contructor
        public UCDashBoard(Control pnlContainer, Control pnlMain)
        {
            InitializeComponent();
            this.pnlContainer = pnlContainer;
            this.pnlMain = pnlMain;
            UCStudent ucStudent = new UCStudent(pnlContainer);
            cMainControl.addControl(pnlContainer, ucStudent);
        }
        #endregion
        #region Btn
        private void btn_Student_Click(object sender, EventArgs e)
        {
            reset_Btn();
            if (btn_Student.BackColor != Color.White)
            {
                btn_Student.BaseColor = Color.White;
                btn_Student.ForeColor = cColor.pink();
            }
            UCStudent ucStudent = new UCStudent(pnlContainer);
            cMainControl.addControl(pnlContainer, ucStudent);
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            reset_Btn();
            if (btn_Teacher.BackColor != Color.White)
            {
                btn_Teacher.BaseColor = Color.White;
                btn_Teacher.ForeColor = cColor.pink();
            }
            UCTeacher ucTeacher = new UCTeacher(pnlContainer);
            cMainControl.addControl(pnlContainer, ucTeacher);
        }

        private void btn_Project_Click(object sender, EventArgs e)
        {
            reset_Btn();
            if (btn_Project.BackColor != Color.White)
            {
                btn_Project.BaseColor = Color.White;
                btn_Project.ForeColor = cColor.pink();
            }
            UCProject ucProject = new UCProject();
            cMainControl.addControl(pnlContainer, ucProject);
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            reset_Btn();
            if (btn_About.BackColor != Color.White)
            {
                btn_About.BaseColor = Color.White;
                btn_About.ForeColor = cColor.pink();
            }
            UCAbout ucAbout = new UCAbout();
            cMainControl.addControl(pnlContainer, ucAbout);
        }

        private void btn_Extend_Click(object sender, EventArgs e)
        {
            reset_Btn();
            if (btn_Extend.BackColor != Color.White)
            {
                btn_Extend.BaseColor = Color.White;
                btn_Extend.ForeColor = cColor.pink();
            }
            UCExtend ucExtend = new UCExtend();
            cMainControl.addControl(pnlContainer, ucExtend);
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            UCLogin ucLogin = new UCLogin(this.pnlMain);
            cMainControl.addControl(this.pnlMain, ucLogin);
            this.Dispose();
        }
        #endregion
    }
}

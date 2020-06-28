using DA_1.Controllers;
using DA_1.Library;
using DA_1.Models;
using DA_1.UserControls.Login;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DA_1.UserControls.Teacher
{
    public partial class UCDashBoardTeacher : UserControl
    {
        #region Field
        private Control pnl_Container;
        UCInforTeacher ucInforTeacher;
        UCMangeProject ucManageProject;
        UCAddProject ucAddProject;
        private ControllerTeacher cTeacher;
        private DA_1.Models.Teacher teacher;
        private Control pnlMain;
        #endregion
        #region Contructor
        public UCDashBoardTeacher(Control pnl_Container, Control pnlMain, string id)
        {
            InitializeComponent();
            this.pnl_Container = pnl_Container;
            this.pnlMain = pnlMain;
            cTeacher = new ControllerTeacher();
            this.teacher = cTeacher.getInforTeacher(id);
            this.lbl_TeacherName.Text = this.teacher.name;
        }
        #endregion
        #region Btn
        private void btn_AddProject_Click(object sender, EventArgs e)
        {
            this.reset_Btn();
            this.btn_AddProject.BaseColor = Color.White;
            this.btn_AddProject.ForeColor = cColor.pink();


            if (!(ucManageProject is null))
            {
                ucManageProject.Dispose();
            }
            if (!(ucInforTeacher is null))
            {
                ucInforTeacher.Dispose();
            }
            ucAddProject = new UCAddProject(teacher, pnl_Container);
            cMainControl.addControl(this.pnl_Container, ucAddProject);
        }

        private void btn_Information_Click(object sender, EventArgs e)
        {
            this.reset_Btn();
            this.btn_Information.BaseColor = Color.White;
            this.btn_Information.ForeColor = cColor.pink();

            if (!(ucManageProject is null))
            {
                ucManageProject.Dispose();
            }
            if (!(ucAddProject is null))
            {
                ucAddProject.Dispose();
            }
            ucInforTeacher = new UCInforTeacher(teacher, this.pnl_Container);
            cMainControl.addControl(this.pnl_Container, ucInforTeacher);
        }

        private void btn_ManageProjects_Click(object sender, EventArgs e)
        {

            this.reset_Btn();
            this.btn_ManageProjects.BaseColor = Color.White;
            this.btn_ManageProjects.ForeColor = cColor.pink();

            if (!(ucInforTeacher is null))
            {
                ucInforTeacher.Dispose();
            }
            if (!(ucAddProject is null))
            {
                ucAddProject.Dispose();
            }
            ucManageProject = new UCMangeProject(teacher, this.pnl_Container);
            cMainControl.addControl(this.pnl_Container, ucManageProject);
        }
        #region methods
        private void reset_Btn()
        {
            this.btn_Information.BaseColor = cColor.pink();
            this.btn_Information.ForeColor = Color.White;

            this.btn_AddProject.BaseColor = cColor.pink();
            this.btn_AddProject.ForeColor = Color.White;

            this.btn_ManageProjects.BaseColor = cColor.pink();
            this.btn_ManageProjects.ForeColor = Color.White;


        }


        #endregion

        private void txt_LogOut_Click(object sender, EventArgs e)
        {

            if (!(ucInforTeacher is null))
            {
                ucInforTeacher.Dispose();
            }
            if (!(ucAddProject is null))
            {
                ucAddProject.Dispose();
            }
            if (!(ucManageProject is null))
            {
                ucManageProject.Dispose();
            }
            if (!(ucAddProject is null))
            {
                ucAddProject.Dispose();
            }
            UCLogin ucLogin = new UCLogin(this.pnlMain);
            cMainControl.addControl(this.pnlMain, ucLogin);
            this.Dispose();
        }
        #endregion
    }
}

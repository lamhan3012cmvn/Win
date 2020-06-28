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
using DA_1.UserControls.Login;

namespace DA_1.UserControls.Student
{
    public partial class UCDashBoardStudent : UserControl
    {
        #region Field
        private Control container;
        private UCInforStudent UCInfor;
        private UCStudentProjects UCProjects;
        private UCRegisterProject UCRegister;
        private ControllerStudent controllerStudent;
        private Control pnlMain;
        private DA_1.Models.Student st;
        private string id;
        #endregion
        #region Contructor
        public UCDashBoardStudent(Control container, Control pnlMain, string id)
        {
            InitializeComponent();
            this.container = container;
            this.pnlMain = pnlMain;
            controllerStudent = new ControllerStudent();
            this.id = id;
            st = controllerStudent.getInforStudent(id);
            this.lbl_StudentName.Text = st.name;
        }
        #endregion
        #region Btn
        private void btn_Information_Click(object sender, EventArgs e)
        {
            this.reset_Btn();
            this.btn_Information.BaseColor = Color.White;
            this.btn_Information.ForeColor = cColor.pink();

            if (!(UCProjects is null))
            {
                UCProjects.Dispose();
            }
            if (!(UCRegister is null))
            {
                UCRegister.Dispose();
            }
            UCInfor = new UCInforStudent(st, container);
            cMainControl.addControl(this.container, UCInfor);


        }

        private void btn_Projects_Click(object sender, EventArgs e)
        {
            this.reset_Btn();
            this.btn_Projects.BaseColor = Color.White;
            this.btn_Projects.ForeColor = cColor.pink();

            if (!(UCInfor is null))
            {
                UCInfor.Dispose();
            }
            if (!(UCRegister is null))
            {
                UCRegister.Dispose();
            }

            UCProjects = new UCStudentProjects(st.studentID);
            cMainControl.addControl(this.container, UCProjects);
        }
        private void btn_AddProject_Click(object sender, EventArgs e)
        {
            this.reset_Btn();
            this.btn_AddProject.BaseColor = Color.White;
            this.btn_AddProject.ForeColor = cColor.pink();

            if (!(UCProjects is null))
            {
                UCProjects.Dispose();
            }
            if (!(UCInfor is null))
            {
                UCInfor.Dispose();
            }

            UCRegister = new UCRegisterProject(st.studentID.Trim(),this.container);
            cMainControl.addControl(this.container, UCRegister);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {

            if (!(UCProjects is null))
            {
                UCProjects.Dispose();
            }
            if (!(UCInfor is null))
            {
                UCInfor.Dispose();
            }
            if (!(UCRegister is null))
            {
                UCRegister.Dispose();
            }
            UCLogin ucLogin = new UCLogin(this.pnlMain);
            cMainControl.addControl(this.pnlMain, ucLogin);
            this.Dispose();
        }
        #endregion
        #region Methods
        private void reset_Btn()
        {
            this.btn_Information.BaseColor = cColor.pink();
            this.btn_Information.ForeColor = Color.White;

            this.btn_AddProject.BaseColor = cColor.pink();
            this.btn_AddProject.ForeColor = Color.White;

            this.btn_Projects.BaseColor = cColor.pink();
            this.btn_Projects.ForeColor = Color.White;

        }


        #endregion 
    }
}

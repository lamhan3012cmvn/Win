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
using DA_1.UserControls.Teacher;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace DA_1.UserControls.Admin
{
    public partial class UCInputTeacher : UserControl
    {
        #region Field
        ControllerTeacher cTeacher;
        private Control pnlContainer;
        private bool flag;
        private cRegular regular;
        #endregion
        #region Methods
        private void loadItemCbox()
        {
            loadCollectionCboxFaculty();
            loadCollectionCboxAcedemicLevel();
            loadCollectionCboxPosition();
        }
        private void loadCollectionCboxFaculty()
        {
            cTeacher.loadCboxFaculty().ForEach(facultyName => {
                this.cbx_Faculty.Items.Add(facultyName);
            });
        }
        private void loadCollectionCboxAcedemicLevel()
        {
            cTeacher.loadCboxAcademicLevel().ForEach(academicLevelName =>
            {
                this.cbx_AcademicLevel.Items.Add(academicLevelName);
            });

        }
        private void loadCollectionCboxPosition()
        {

            cTeacher.loadCboxPosition().ForEach(positionName =>
            {
                this.cbx_Position.Items.Add(positionName);
            });

        }
        private bool checkInput()
        {
            if (this.txt_Name.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT NAME", "IS EMPTY");
                return false;
            }
            if ((DateTime.Now - this.dtp_Birthday.Value).TotalDays < 365 * 25)
            {
                cMainControl.showNotification("TEACHER < 25 YEARS OLD", "INPUT AGAIN");
                return false;
            }
            if (this.txt_Phone.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT PHONE NUMBER", "WRONG");
                return false;
            }
            if (this.txt_Phone.ForeColor == Color.Red)
            {
                cMainControl.showNotification("INPUT PHONE ", "PHONE IS FAIL");
                return false;
            }
            if (this.txt_Email.Text.Trim() == String.Empty)
            {

                cMainControl.showNotification("INPUT EMAIL", "IS EMPTY");

                return false;
            }
            if (this.txt_Email.ForeColor == Color.Red)
            {

                cMainControl.showNotification("INPUT EMAIL", "EMAIL IS FAIL");

                return false;
            }
            if (this.cbx_AcademicLevel.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT ACADEMIC LEVEL", "IS EMPTY");
                return false;
            }
            if (this.cbx_Faculty.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT FACULTY", "IS EMPTY");
                return false;
            }
            if (this.cbx_Position.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT POSITION", "IS EMPTY");
                return false;
            }
            if (this.txt_Password.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT PASSWORD", "IS EMPTY");
                return false;
            }
            if (this.txt_Confirm.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT CONFIRM", "IS EMPTY");
                return false;
            }

            if (this.txt_Password.Text.Trim() != this.txt_Confirm.Text.Trim())
            {
                cMainControl.showNotification("CONFIRM IS DIFFERENT FROM PASSWORD", "INPUT AGAIN");
                return false;
            }

            return true;
        }
        #endregion
        #region Contructor
        public UCInputTeacher(Control pnlContainer)
        {
            InitializeComponent();
            regular = new cRegular();
            this.pnlContainer = pnlContainer;
            cTeacher = new ControllerTeacher();
            loadItemCbox();
            this.btn_AddInfor.Visible = true;
            this.btn_Edit.Visible = false;
            string id = "GV" + cTeacher.getTeacherID();
            this.txt_TeacherId.Text = id;
            this.txt_TeacherId.Enabled = false;
            string userName = "GSPK" + cTeacher.getUserNameTeacher();
            this.txt_UserName.Text = userName;
            this.flag = false;
        }
        public UCInputTeacher(Control pnlContainer, string idTeach)
        {
            InitializeComponent();
            regular = new cRegular();
            this.pnlContainer = pnlContainer;
            cTeacher = new ControllerTeacher();
            loadItemCbox();
            this.lbl_Title.Text = "Edit Information Teacher";
            var teacher = cTeacher.getInforTeacher(idTeach);
            this.btn_AddInfor.Visible = false;
            this.btn_Edit.Visible = true;
            this.txt_Name.Text = teacher.name.Trim();
            this.txt_TeacherId.Text = teacher.teacherID.Trim();
            this.txt_Phone.Text = teacher.phone.Trim();
            this.txt_Email.Text = teacher.mail.Trim();
            this.dtp_Birthday.Value = teacher.birth.Value;


            this.cbx_Faculty.Text = teacher.Faculty.FacultyName.Trim();
            this.cbx_Position.Text = teacher.Position.name.Trim();
            this.cbx_AcademicLevel.Text = teacher.Academic.name.Trim();
            this.txt_TeacherId.Enabled = false;
            this.txt_UserName.Text = teacher.userName.Trim();
            this.txt_Password.Text = teacher.Acount.pass.Trim();
            this.txt_Confirm.Text = teacher.Acount.pass.Trim();
            this.flag = false;
        }
        public UCInputTeacher(Control pnlContainer, string idTeach, bool flag)
        {
            InitializeComponent();
            regular = new cRegular();
            this.pnlContainer = pnlContainer;
            cTeacher = new ControllerTeacher();
            loadItemCbox();
            this.lbl_Title.Text = "Edit Information Teacher";
            var teacher = cTeacher.getInforTeacher(idTeach);
            this.btn_AddInfor.Visible = false;
            this.btn_Edit.Visible = true;
            this.txt_Name.Text = teacher.name.Trim();
            this.txt_TeacherId.Text = teacher.teacherID.Trim();
            this.txt_Phone.Text = teacher.phone.Trim();
            this.txt_Email.Text = teacher.mail.Trim();
            this.dtp_Birthday.Value = teacher.birth.Value;


            this.cbx_Faculty.Text = teacher.Faculty.FacultyName.Trim();
            this.cbx_Position.Text = teacher.Position.name.Trim();
            this.cbx_AcademicLevel.Text = teacher.Academic.name.Trim();
            this.txt_TeacherId.Enabled = false;
            this.txt_UserName.Text = teacher.userName.Trim();
            this.txt_Password.Text = teacher.Acount.pass.Trim();
            this.txt_Confirm.Text = teacher.Acount.pass.Trim();
            this.flag = flag;
            this.cbx_Faculty.Enabled = false;
        }

        #endregion
        #region Btn
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (this.flag == false)
            {
                UCTeacher ucTeacher = new UCTeacher(pnlContainer);
                cMainControl.addControl(pnlContainer, ucTeacher);
            }
            else
            {
                UCInforTeacher ucTeacher = new UCInforTeacher(cTeacher.getInforTeacher(this.txt_TeacherId.Text.Trim()), this.pnlContainer);
                cMainControl.addControl(pnlContainer, ucTeacher);
            }
            this.Dispose();
        }

        private void btn_AddInfor_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                List<string> data = new List<string>()
            {
                this.txt_TeacherId.Text, this.txt_Name.Text, this.dtp_Birthday.Value.ToString(), this.txt_Phone.Text, this.txt_Email.Text,
                this.cbx_AcademicLevel.Text, this.cbx_Faculty.Text, this.cbx_Position.Text,this.txt_UserName.Text,this.txt_Password.Text
            };
                cTeacher.addTeacher(data);
                UCTeacher ucTeacher = new UCTeacher(pnlContainer);
                cMainControl.addControl(pnlContainer, ucTeacher);
                this.Dispose();
                cMainControl.showNotification("ADD TEACHER", "SUCCESS!");
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {

            cTeacher.edit(this.txt_TeacherId.Text, this.txt_Name.Text, this.dtp_Birthday.Value, this.txt_Phone.Text, this.txt_Email.Text,
                this.cbx_AcademicLevel.Text, this.cbx_Faculty.Text, this.cbx_Position.Text);
            if (this.flag == false)
            {
                UCTeacher ucTeacher = new UCTeacher(pnlContainer);
                cMainControl.addControl(pnlContainer, ucTeacher);
            }
            else
            {
                cTeacher = new ControllerTeacher();
                var teacher = cTeacher.getInforTeacher(this.txt_TeacherId.Text.Trim());
                UCInforTeacher ucTeacher = new UCInforTeacher(teacher, this.pnlContainer);
                cMainControl.addControl(pnlContainer, ucTeacher);
            }

            this.Dispose();
            cMainControl.showNotification("EDIT TEACHER", "SUCCESS!");

        }
        #endregion
        #region TextChanged
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            var check = this.regular.isCheckMail(this.txt_Email.Text.Trim());
            this.txt_Email.FocusedForeColor = check ? Color.Black : Color.Red;
            this.txt_Email.ForeColor = check ? Color.Black : Color.Red;
        }
        private void txt_TeacherId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (this.txt_TeacherId.Text.Length > 8 && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }
        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            var check = this.regular.isCheckPhone(this.txt_Phone.Text.Trim());
            this.txt_Phone.FocusedForeColor = check ? Color.Black : Color.Red;
            this.txt_Phone.ForeColor = check ? Color.Black : Color.Red;
        }
        #endregion   
    }
}


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
using DA_1.Models;
using DA_1.Library;
using DA_1.UserControls.Student;
using System.Collections;
using System.Threading;
using System.Text.RegularExpressions;

namespace DA_1.UserControls.Admin
{
    public partial class UCInputStudent : UserControl
    {
        #region Field
        ControllerStudent cStudent;
        private Control pnlContainer;
        private bool flag;
        private Hashtable faculties;
        private bool isStudent;
        int indexFaculty;
        private cRegular regular;
        #endregion
        #region Methods
        private bool checkInput()
        {

            if (this.txt_Name.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT NAME", "IS EMPTY");
                return false;
            }
            if ((DateTime.Now - this.dtp_Birthday.Value).TotalDays < 365 * 18)
            {
                cMainControl.showNotification("STUDENT < 18 YEARS OLD", "INPUT AGAIN");
                return false;
            }
            if (this.txt_Phone.Text.Trim()==String.Empty)
            {
                cMainControl.showNotification("INPUT PHONE NUMBER", "WRONG");
                return false;
            }
            if (this.txt_Phone.ForeColor == Color.Red)
            {

                cMainControl.showNotification("INPUT PHONE", "PHONE ONLY USE NUMBER");

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
            if (this.cbx_Faculty.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT FACULTY", "IS EMPTY");
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
        private void loadCollectionCboxFaculty()
        {
            faculties = new Hashtable();
            cStudent.loadCboxFaculty().ForEach(f => {
                this.faculties.Add(f.FacultyName.Trim(), f);
                this.cbx_Faculty.Items.Add(f.FacultyName.Trim());
            });
        }
        #endregion
        #region Contructor
        public UCInputStudent(bool isInputOrEdit, Control pnlContainer)
        {
            InitializeComponent();
            regular = new cRegular();
            cStudent = new ControllerStudent();
            this.pnlContainer = pnlContainer;
            flag = false;
            if (isInputOrEdit)
            {
                this.lbl_title.Text = "Input Information Student";
                this.btn_Add.Visible = true;
                this.btn_Edit.Visible = false;
                string id = "SV" + cStudent.getStudentID();
                this.txt_StudentId.Text = id;
                this.txt_StudentId.Enabled = false;
                string userName = "SPK" + cStudent.getUserNameStudent();
                this.txt_UserName.Text = userName;

            }
            else
            {
                this.lbl_title.Text = "Edit Information Student";
                this.btn_Add.Visible = false;
                this.btn_Edit.Visible = true;
                this.cbx_Faculty.Enabled = false;

            }
            loadCollectionCboxFaculty();
        }
        public UCInputStudent(bool isStudent,bool isInputOrEdit, string idStudent, Control pnlContainer)
        {
            InitializeComponent();
            regular = new cRegular();
            cStudent = new ControllerStudent();
            this.isStudent = isStudent;
            this.pnlContainer = pnlContainer;
            loadCollectionCboxFaculty();
            flag = true;
            if (isInputOrEdit)
            {
                this.lbl_title.Text = "Input Information Student";
                this.btn_Add.Visible = true;
                this.btn_Edit.Visible = false;
                string id = "SV" + cStudent.getStudentID();
                this.txt_StudentId.Text = id;
                this.txt_StudentId.Enabled = false;
                string userName = "SPK" + cStudent.getUserNameStudent();
                this.txt_UserName.Text = userName;
            }

            else
            {
                this.lbl_title.Text = "Edit Information Student";
                this.btn_Add.Visible = false;
                this.btn_Edit.Visible = true;

                this.cbx_Faculty.Enabled = false;

                var student = cStudent.getInforStudent(idStudent);
                this.txt_StudentId.Text = student.studentID.Trim();
                this.txt_Name.Text = student.name.Trim();
                this.txt_Phone.Text = student.phone.Trim();
                this.txt_Email.Text = student.mail.Trim();
                this.cbx_Faculty.Text = student.Faculty.FacultyName.Trim();
                this.txt_UserName.Text = student.userName.Trim();
                this.txt_Password.Text = student.Acount.pass.Trim();
                this.txt_Confirm.Text = student.Acount.pass.Trim();
                this.txt_StudentId.Enabled = false;
                var birth = student.birth.ToString().Split('/',' ');
                this.dtp_Birthday.Value = new DateTime(int.Parse(birth[2]),int.Parse(birth[0]),int.Parse(birth[1]));
            }
        }
        #endregion
        #region Btn
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (this.flag == false)
            {
                UCStudent ucStudent = new UCStudent(pnlContainer);
                cMainControl.addControl(pnlContainer, ucStudent);
            }
            else if (isStudent == true)
            {
                UCInforStudent ucStudent = new UCInforStudent(cStudent.getInforStudent(this.txt_StudentId.Text.Trim()), this.pnlContainer);
                cMainControl.addControl(pnlContainer, ucStudent);
            }
            else
            {
                UCStudentInfor ucStudent = new UCStudentInfor(cStudent.getInforStudent(this.txt_StudentId.Text.Trim()), this.pnlContainer);
                cMainControl.addControl(pnlContainer, ucStudent);
            }

            this.Dispose();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {

                cStudent.addStudent(this.txt_StudentId.Text, this.txt_Name.Text, this.dtp_Birthday.Value,
                    this.txt_Phone.Text, (this.faculties[cbx_Faculty.Text] as DA_1.Models.Faculty).FacultyID.Trim(), this.txt_Email.Text, this.txt_UserName.Text, this.txt_Password.Text);

                UCStudent ucStudent = new UCStudent(pnlContainer);
                cMainControl.addControl(pnlContainer, ucStudent);
                this.Dispose();
                cMainControl.showNotification("ADD STUDENT", "SUCCESS!");
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                var check = cStudent.UpdateStudent(this.txt_StudentId.Text, this.txt_Name.Text, this.dtp_Birthday.Value,
                    this.txt_Phone.Text, this.txt_Email.Text);

                if (this.flag == false)
                {

                    UCStudent ucStudent = new UCStudent(pnlContainer);
                    cMainControl.addControl(pnlContainer, ucStudent);
                }
                else if (isStudent == true)
                {
                    UCInforStudent ucStudent = new UCInforStudent(cStudent.getInforStudent(this.txt_StudentId.Text.Trim()), this.pnlContainer);
                    cMainControl.addControl(pnlContainer, ucStudent);
                }
                else
                {
                    UCStudentInfor ucStudent = new UCStudentInfor(cStudent.getInforStudent(this.txt_StudentId.Text.Trim()), this.pnlContainer);
                    cMainControl.addControl(pnlContainer, ucStudent);
                }
                this.Dispose();
                if (check == true)
                {
                    cMainControl.showNotification("EDIT INFORMATION STUDENT", "SUCCESS!");
                }
                else
                {
                    cMainControl.showNotification("EDIT INFORMATION STUDENT", "FAIL!");
                }
            }

        }
        #endregion
        #region TextChanged
        

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            var check = this.regular.isCheckMail(this.txt_Email.Text.Trim());
            this.txt_Email.FocusedForeColor = check ? Color.Black : Color.Red;
            this.txt_Email.ForeColor = check ? Color.Black : Color.Red;
        }

        private void cbx_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexFaculty = this.cbx_Faculty.SelectedIndex;
        }
        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            var check = this.regular.isCheckPhone(this.txt_Phone.Text.Trim());
            this.txt_Phone.FocusedForeColor = check ? Color.Black : Color.Red;
            this.txt_Phone.ForeColor = check ? Color.Black : Color.Red;
        }
        #endregion*
    }
}

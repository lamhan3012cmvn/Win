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

namespace DA_1.UserControls.Student
{
    
    public partial class UCInforStudent : UserControl
    {
        #region Field
        private Control pnl_Container;
        public static bool flagEdit;
        #endregion
        #region Contructor
        public UCInforStudent(DA_1.Models.Student st, Control pnl_Container)
        {
            InitializeComponent();
            this.pnl_Container = pnl_Container;
            var birth = st.birth.ToString().Split('/',' ');
            this.lbl_Birthday.Text = birth[1]+"/"+birth[0]+"/"+birth[2];
            this.lbl_Email.Text = st.mail.Trim();
            this.lbl_Faculty.Text = st.Faculty.FacultyName.Trim();
            this.lbl_Name.Text = st.name.Trim();
            this.lbl_Phone.Text = st.phone.Trim();
            this.lbl_StudentID.Text = st.studentID.Trim();
            flagEdit = false;
        }

        #endregion
        #region Btn
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UCInputStudent ucInputStudent = new UCInputStudent(true,false, this.lbl_StudentID.Text.Trim(), this.pnl_Container);
            cMainControl.addControl(this.pnl_Container, ucInputStudent);
            this.Dispose();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}

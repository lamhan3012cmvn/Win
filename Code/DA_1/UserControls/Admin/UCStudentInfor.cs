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
using DA_1.Controllers;
using DA_1.Library;
using Guna.UI.WinForms;

namespace DA_1.UserControls.Admin
{
    public partial class UCStudentInfor : UserControl
    {
        #region Field
        private DA_1.Models.Student st;
        private ControllerAdmin cAmin;
        private Control pnlContain;
        #endregion
        #region Methods
        private GunaLabel createLabel(Point location, string text)
        {
            GunaLabel lbl = new GunaLabel();
            lbl.Text = text;
            lbl.Font = new Font("Arial", 14, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = location;
            //lbl.Font.Size = new Size(14);
            return lbl;
        }

        #endregion
        #region Contructor
        public UCStudentInfor(DA_1.Models.Student st, Control pnlContain)
        {
            InitializeComponent();
            this.st = st;
            this.cAmin = new ControllerAdmin();
            this.pnlContain = pnlContain;
            var birth = (this.st.birth).ToString().Split('/',' ');
            this.lbl_Birthday.Text = birth[1] + "/" + birth[0] + "/" + birth[2];
            this.lbl_Email.Text = this.st.mail;
            this.lbl_Faculty.Text = this.st.Faculty.FacultyName;
            this.lbl_Name.Text = this.st.name;
            this.lbl_Phone.Text = this.st.phone;
            this.lbl_StudentID.Text = this.st.studentID;
            this.pnl_Projects.Visible = false;

            int i = 0;

            this.st.TeamWorks.ToList().ForEach(tw => {
                this.pnl_Projects.Controls.Add(createLabel(new Point(25, 25 + 25 * i), "Project Name: " + tw.Topic.name));
                i += 2;
                this.pnl_Projects.Controls.Add(createLabel(new Point(60, 25 + 25 * i), "Team Name: " + tw.name));
                i++;
                this.pnl_Projects.Controls.Add(createLabel(new Point(60, 25 + 25 * i), "Techer Name: " + tw.Topic.Teacher.name));
                i += 2;
            });
        }

        #endregion
        #region Btn
        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCStudent ucStudent = new UCStudent(pnlContain);
            cMainControl.addControl(this.pnlContain, ucStudent);
            this.Dispose();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cAmin.deleteStudent(this.st.studentID);
            this.Dispose();
            UCStudent ucStudent = new UCStudent(this.pnlContain);
            cMainControl.addControl(this.pnlContain, ucStudent);
            cMainControl.showNotification("DELETE STUDENT", "SUCCESS!");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            UCInputStudent ucInputStudent = new UCInputStudent(false,false, this.st.studentID, pnlContain);
            cMainControl.addControl(this.pnlContain, ucInputStudent);
            this.Dispose();
        }

        #endregion
        #region Events
        private void lbl_Projects_Click(object sender, EventArgs e)
        {
            this.pnl_Projects.Visible = true;
        }
        #endregion
    }
}

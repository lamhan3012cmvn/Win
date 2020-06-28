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

namespace DA_1.UserControls.Teacher
{
    public partial class UCAddProject : UserControl
    {
        #region Field
        private ControllerTeacher cTeacher;
        private DA_1.Models.Teacher teacher;
        private Control pnlContainer;
        #endregion
        #region Methods
        private void loadCollectioKot()
        {

            cTeacher.loadCboxKindOfProject().ForEach(kot => {
                this.cbx_KoP.Items.Add(kot.Trim());
            });
        }
        private bool checkInput()
        {
            if (this.cbx_KoP.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT KIND OF PROJECT", "IS EMPTY");
                return false;
            }
            if (this.txt_ProjectName.Text.Trim()==String.Empty)
            {
                cMainControl.showNotification("INPUT PROJECT NAME", "IS EMPTY");
                return false;
            }
            if ((this.dtp_DateFrom.Value-DateTime.Now).TotalDays < 3)
            {
                cMainControl.showNotification("DATE FROM MUST LARGER THAN NOW", "DATE FROM > NOW: 3 DAYS");
                return false;
            }
            if ((this.dtp_DateTo.Value - this.dtp_DateFrom.Value).TotalDays < 90)
            {
                cMainControl.showNotification("DATE TO MUST LARGER THAN DATE FROM", "DATE TO > DATE FROM: 3 MONTHS");
                return false;
            }
            
            if (this.cbx_Process.Text.Trim() == String.Empty)
            {
                cMainControl.showNotification("INPUT PROCESS", "IS EMPTY");
                return false;
            }
            return true;
        }

        #endregion
        #region Contructor
        public UCAddProject(DA_1.Models.Teacher teacher,Control pnlContainer)
        {
            InitializeComponent();
            cTeacher = new ControllerTeacher();
            loadCollectioKot();
            this.teacher = teacher;
            this.txt_ProjectID.Enabled = false;
            int max = cTeacher.getProjectID();
            this.txt_ProjectID.Text = "TP" + max.ToString();
            this.dtp_DateFrom.Value = DateTime.Now;
            this.dtp_DateTo.Value = DateTime.Now;
            this.pnlContainer = pnlContainer;
        }
        #endregion
        #region Btn
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                cTeacher.addProject(this.cbx_KoP.Text, this.txt_ProjectID.Text, this.txt_ProjectName.Text, this.dtp_DateTo.Value, this.dtp_DateFrom.Value, int.Parse(this.cbx_Process.Text), teacher.teacherID);
                UCAddProject uc = new UCAddProject(cTeacher.getInforTeacher(teacher.teacherID.Trim()), this.pnlContainer);
                cMainControl.addControl(this.pnlContainer, uc);
           
                cMainControl.showNotification("ADD A NEW TOPIC", "SUCCESS!");
            }
        }
        #endregion
    }
}

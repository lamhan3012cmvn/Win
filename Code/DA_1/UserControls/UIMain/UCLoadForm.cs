using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_1.UserControls.Student;
using DA_1.Library;
using DA_1.UserControls.Teacher;
using DA_1.UserControls.Admin;

namespace DA_1.UserControls.UIMain
{
    public partial class UCLoadForm : UserControl
    {
        #region Field
        private Control pnlMain;
        #endregion
        #region Contructor
        public UCLoadForm(Control pnlMain)
        {
            InitializeComponent();
            this.pnlMain = pnlMain;
            this.pnlMain.SendToBack();
            UCDashBoard dash = new UCDashBoard(this.pnl_Container, this.pnlMain);
            cMainControl.addControl(this.pnl_DashBoard, dash);

        }
        public UCLoadForm(int z, string id, Control pnlMain)
        {
            InitializeComponent();
            //this.SendToBack();
            this.pnlMain = pnlMain;
            if (z == 1)//GG
            {
                UCDashBoardTeacher dash = new UCDashBoardTeacher(this.pnl_Container, this.pnlMain, id);
                cMainControl.addControl(this.pnl_DashBoard, dash);
            }
            else if (z == 2)//Sv
            {
                UCDashBoardStudent dash = new UCDashBoardStudent(this.pnl_Container, this.pnlMain, id);
                cMainControl.addControl(this.pnl_DashBoard, dash);
            }

        }
        #endregion

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

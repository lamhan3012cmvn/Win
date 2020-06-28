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
using DA_1.UserControls;
using DA_1.UserControls.UIMain;
using DA_1.UserControls.Teacher;
using DA_1.Library;
using System.Threading;

namespace DA_1.UserControls.Login
{
    public partial class UCLogin : UserControl
    {
        #region Field
        private ControllerLogin login;
        private Control pnlContainer;
        private UCLoadForm load;
        #endregion
        #region Contructor
        public UCLogin(Control pnlContainer)
        {
            login = new ControllerLogin();
            this.pnlContainer = pnlContainer;
            InitializeComponent();

        }

        #endregion
        #region Btn
        private void btn_Login_Click(object sender, EventArgs e)
        {
            var result = login.checkLogin(this.txt_UserName.Text.Trim().ToLower(), this.txt_Password.Text.Trim());
            if (result != null)
            {
                if (result.Equals("admin"))
                {
                    load = new UCLoadForm(this.pnlContainer);
                    cMainControl.addControl(this.pnlContainer, this.load);
                    this.Dispose();
                    cMainControl.showNotification("ADMIN LOGIN", "SUCCESS!");
                }
                else if (result.Contains("GV"))
                {
                    load = new UCLoadForm(1, result, this.pnlContainer);
                    cMainControl.addControl(this.pnlContainer, this.load);
                    this.Dispose();
                    cMainControl.showNotification("TEACHER LOGIN", "SUCCESS!");
                }
                else
                {
                    load = new UCLoadForm(2, result, this.pnlContainer);

                    cMainControl.addControl(this.pnlContainer, this.load);
                    this.Dispose();
                    cMainControl.showNotification("STUDENT LOGIN", "SUCCESS!");
                }

            }
            else
            {
                cMainControl.showNotification("LOGIN", "FAIL???");
            }

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}

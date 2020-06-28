using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_1.Library;
using DA_1.UserControls.Login;
using DA_1.UserControls.UIMain;


namespace DA_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            UCLogin ucLogin = new UCLogin(this.pnl_Main);
            cMainControl.addControl(this.pnl_Main, ucLogin);
        }
    }
}

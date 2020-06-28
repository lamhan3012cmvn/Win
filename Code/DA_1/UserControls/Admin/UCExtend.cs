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

namespace DA_1.UserControls.Admin
{
    public partial class UCExtend : UserControl
    {
        #region Methods
        private void reset()
        {
            this.btn_Faculty.BaseColor = Color.White;
            this.btn_Faculty.ForeColor = cColor.pink();

            this.btn_KoTopic.BaseColor = Color.White;
            this.btn_KoTopic.ForeColor = cColor.pink();
        }
        #endregion
        #region Contructor
        public UCExtend()
        {
            InitializeComponent();
            UCFaculty ucFaculty = new UCFaculty();
            cMainControl.addControl(pnl_Container, ucFaculty);
            this.btn_Faculty.BaseColor = Color.FromArgb(253, 38, 100);
            this.btn_Faculty.ForeColor = Color.White;
        }
        #endregion
        #region Btn
        private void btn_Faculty_Click(object sender, EventArgs e)
        {
            reset();
            this.btn_Faculty.BaseColor = cColor.pink();
            this.btn_Faculty.ForeColor = Color.White;

            UCFaculty ucFaculty = new UCFaculty();
            cMainControl.addControl(pnl_Container, ucFaculty);

        }

        private void btn_KoTopic_Click(object sender, EventArgs e)
        {
            reset();
            this.btn_KoTopic.BaseColor = cColor.pink();
            this.btn_KoTopic.ForeColor = Color.White;

            UCKoTopic ucKoTopic = new UCKoTopic();
            cMainControl.addControl(pnl_Container, ucKoTopic);
        }
        #endregion
    }
}

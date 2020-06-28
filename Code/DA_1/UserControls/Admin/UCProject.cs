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
namespace DA_1.UserControls.Admin
{

    public partial class UCProject : UserControl
    {
        #region Field
        private ControllerAdmin cAdmin;
        #endregion
        #region Methods
        private void loadData(List<DA_1.Models.Topic> topics)
        {
            this.dtGrid_Manage.Rows.Clear();
            StringBuilder teamname = new StringBuilder();

            topics.ForEach(tp =>
            {
                teamname.Clear();
                teamname.Append("\n");
                tp.TeamWorks.ToList().ForEach(tw =>
                {
                    teamname.Append(tw.name.Trim());
                    teamname.Append("\n");
                });
                this.dtGrid_Manage.Rows.Add(new object[] {
                        tp.TopicID,
                        tp.name,
                        tp.KindOfTopic.name,
                        tp.Faculty.FacultyName,
                        tp.Teacher.name,
                        teamname.ToString()
                       });
            });

        }
        #endregion
        #region Contructor
        public UCProject()
        {
            InitializeComponent();
            this.dtGrid_Manage.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cAdmin = new ControllerAdmin();
            this.dtGrid_Manage.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(253, 38, 100);
            this.dtGrid_Manage.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dtGrid_Manage.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            this.cbx_Search.Text = this.cbx_Search.Items[0].ToString();
            loadData(cAdmin.loadDataP("", this.cbx_Search.Text.Trim().ToLower()));
        }
        #endregion
        #region Events
        private void cbx_Search_DropDownClosed(object sender, EventArgs e)
        {
            this.txt_SearchName.Text = "";
            loadData(cAdmin.loadDataP(this.txt_SearchName.Text, this.cbx_Search.Text.Trim().ToLower()));
        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            loadData(cAdmin.loadDataP(this.txt_SearchName.Text, this.cbx_Search.Text.Trim().ToLower()));
        }
        #endregion
    }
}

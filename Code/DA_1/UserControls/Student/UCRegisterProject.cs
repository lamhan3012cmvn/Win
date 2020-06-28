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
using System.Collections;
using DA_1.Models;
using System.Threading;
using DA_1.Library;

namespace DA_1.UserControls.Student
{
    public partial class UCRegisterProject : UserControl
    {
        #region Field
       
        private ControllerStudent cStudent;
        private List<DA_1.Models.Topic> listProject;
        private DA_1.Models.Topic currentTopic;
        private string st;
        private Control pnlContainer;
        #endregion
        #region Contructor
        public UCRegisterProject( string st,Control pnlContainer)
        {
            InitializeComponent();
            
            
            cStudent = new ControllerStudent();
            this.st = st;
            this.pnlContainer = pnlContainer;
            createRegister();
            this.cbx_TeamName.DropDownStyle = ComboBoxStyle.DropDown;
           
        }
        #endregion
        #region Btn
        private void btn_Register_Click(object sender, EventArgs e)
        {

            this.cbx_ProjectNameValue.Items.Clear();
            if (rbtn_RegisterNewTeam.Checked == true)
            {

                int max = cStudent.getTeamID();
                string teamID = "TW" + max.ToString();
                cStudent.addnew(st, teamID, this.txt_TeamName.Text.Trim(), currentTopic.TopicID);

                createRegister();
                return;

            }
            else if (rbtn_RegisterAnExistentTeam.Checked == true)
            {
                currentTopic.TeamWorks.ToList().ForEach(tw => {
                    if (tw.name.Trim().Equals(this.cbx_TeamName.Text.Trim()))
                    {
                        cStudent.addExistent(tw.teamID, st);
                        createRegister();
                        return;
                    }
                });

            }

        }
        #endregion
        #region Envents
        private void cbx_ProjectNameValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbx_TeamName.Items.Clear();
            currentTopic = this.listProject[this.cbx_ProjectNameValue.SelectedIndex];
            currentTopic.TeamWorks.ToList().ForEach(tw => {

                this.cbx_TeamName.Items.Add(tw.name.Trim());

            });

          

            this.lbl_TeacherNameValue.Text = this.listProject[this.cbx_ProjectNameValue.SelectedIndex].Teacher.name.Trim();
           
            this.lbl_KoPValue.Text = this.listProject[this.cbx_ProjectNameValue.SelectedIndex].KindOfTopic.name.Trim();
           
            this.lbl_DateFromValue.Text = this.listProject[this.cbx_ProjectNameValue.SelectedIndex].dateForm.ToString().Trim();
            
            this.lbl_DateToValue.Text = this.listProject[this.cbx_ProjectNameValue.SelectedIndex].dateTo.ToString().Trim();
            showControl(true);
        }

        private void rbtn_RegisterNewTeam_CheckedChanged(object sender, EventArgs e)
        {
            this.lbl_TeamName.Visible = true;
            if (rbtn_RegisterNewTeam.Checked == true)
            {
                this.cbx_TeamName.Visible = false;
                this.txt_TeamName.Visible = true;
            }

        }

        private void rbtn_RegisterAnExistentTeam_CheckedChanged(object sender, EventArgs e)
        {
            this.lbl_TeamName.Visible = true;
            if (rbtn_RegisterAnExistentTeam.Checked == true)
            {
                this.cbx_TeamName.Visible = true;
                this.txt_TeamName.Visible = false;
            }
        }
        #endregion
        #region Method
        private void createRegister()
        {
            listProject = new List<DA_1.Models.Topic>();
            loadCollectionProjects();
            showControl(false);
            this.cbx_ProjectNameValue.Text = "";
            this.txt_TeamName.Text = "";
            this.cbx_TeamName.Text = "";
            this.rbtn_RegisterAnExistentTeam.Checked = false;
            this.rbtn_RegisterNewTeam.Checked = false;
            this.txt_TeamName.Visible = false;
            this.cbx_TeamName.Visible = false;
            this.lbl_TeamName.Visible = false;
        }
        private void showControl(bool flag)
        {
            this.lbl_DateForm.Visible = flag;
            this.lbl_DateFromValue.Visible = flag;
           

            this.lbl_DateTo.Visible = flag;
            this.lbl_DateToValue.Visible = flag;

            this.lbl_KoP.Visible = flag;
            this.lbl_KoPValue.Visible = flag;
            this.lbl_TeacherName.Visible = flag;
            this.lbl_TeacherNameValue.Visible = flag;
            this.lbl_TeamName.Visible = flag;
        }
        public void loadCollectionProjects()
        {
            listProject = cStudent.getTopicInFaculty(cStudent.getInforStudent(st).facultyID.Trim(), st);
            listProject.ForEach(t => {
                this.cbx_ProjectNameValue.Items.Add(t.name.Trim());
            });


        }
        #endregion

    }
}

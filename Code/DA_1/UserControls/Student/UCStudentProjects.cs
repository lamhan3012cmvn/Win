using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using DA_1.Models;
using System.Collections;
using Microsoft.VisualBasic;
using DA_1.Controllers;
using DA_1.Library;
using System.Threading;

namespace DA_1.UserControls
{
    public partial class UCStudentProjects : UserControl
    {
        #region Field
        private string student;
        private Hashtable team;
        private ControllerStudent cStudent;
        private string nameLblClicked;
        private string teamID;
        private bool flag;
        private bool isFisnish;
        #endregion
        #region Contructor
        public UCStudentProjects(string st)
        {
            InitializeComponent();
            this.student = st;
            cStudent = new ControllerStudent();
            flag = false;
        }
        #endregion
        #region Btn
        private void btn_ManageProject_Click(object sender, EventArgs e)
        {
            this.isFisnish = false;
            showProject(1);
        }
        private void btn_ProjectFinish_Click(object sender, EventArgs e)
        {
            this.isFisnish = true;
            showProject(-1);
        }
        private void Lbl_Click(object sender, EventArgs e)
        {
            int i;
            this.pnl_MemberTeam.Visible = false;
            this.pnl_ProcessItems.Visible = false;
            var lbl = sender as GunaLabel;
            this.lbl_ProjectName.Text = "Project Name: " + lbl.Text;
            var currentTeam = this.team[lbl.Text.Trim()] as DA_1.Models.TeamWork;
            teamID = currentTeam.teamID;
            this.nameLblClicked = lbl.Text.Trim();
           
            int check = getValueDeadline(DateTime.Parse(currentTeam.Topic.dateTo.ToString()));
            if (check < 0)
            {
                this.pgb_Deadline.Value = 0;
                cMainControl.showNotification("NOTICE", "THIS PROJECT WAS CLOSED");
                showControlBtn();
                this.lbl_Days.Text = "CLOSED";
                this.lbl_Point.Visible = true;
                this.lbl_PointValue.Visible = true;
                this.pnl_ProcessItems.Visible = true;
            }
            else if (check > 100)
            {
                this.pgb_Deadline.Value = 100;
                this.lbl_Days.Text = this.pgb_Deadline.Value.ToString() + " Days";
                showControlBtn();
                this.lbl_Point.Visible = true;
                this.lbl_PointValue.Visible = false;
                this.pnl_ProcessItems.Visible = true;
            }
            else
            {
                this.pgb_Deadline.Value = check;
                this.lbl_Days.Text = this.pgb_Deadline.Value.ToString() + " Days";
                showControlBtn();
                this.lbl_Point.Visible = true;
                this.lbl_PointValue.Visible = false;
                this.pnl_ProcessItems.Visible = true;
            }
            this.lbl_KoProject.Text = currentTeam.Topic.KindOfTopic.name;
            this.lbl_DateFrom.Text = currentTeam.Topic.dateForm.ToString();


            i = 0;
            this.pnl_MemberTeam.Controls.Clear();

            this.lbl_Team.Text = currentTeam.name.Trim();
            

            var menbers = cStudent.getMemberTeam(currentTeam.teamID.Trim());
            menbers.ToList().ForEach(st => {
                this.pnl_MemberTeam.Controls.Add(createLabel(new Point(0, 30 * i), i.ToString() + ". " + st.name.Trim()));
                i++;
            });


            i = 0;
            this.pnl_ProcessItems.Controls.Clear();
            //int countCheck = 0;
            currentTeam.Topic.ProcessTopics.ToList().ForEach(p => {
                this.pnl_ProcessItems.Controls.Add(createLabel(new Point(0, 25 * i), p.Process.name));
                GunaCheckBox checkbox = createCheckBox(new Point(130, 27 * i), (bool)p.isPass);
                checkbox.Enabled = false;

                this.pnl_ProcessItems.Controls.Add(checkbox);
                i++;
            });
            if (!(currentTeam.point is null))
                this.lbl_PointValue.Text = currentTeam.point.Trim();
            else
                this.lbl_PointValue.Text = "";
            if (!(currentTeam.link is null))
            {
                this.lbl_Link.Visible = true;
                this.txt_Link.Visible = true;
                this.txt_Link.Enabled = false;
                this.txt_Link.Text = currentTeam.link.Trim();
            }
            else
                this.txt_Link.Text = "";


            this.pnl_ProjectItem.Visible = true;
        }
        private void btn_Process_Click(object sender, EventArgs e)
        {
            this.lbl_Point.Visible = true;
            this.lbl_PointValue.Visible = true;
            this.pnl_ProcessItems.Visible = true;
        }

        private void lbl_Team_Click(object sender, EventArgs e)
        {
            this.pnl_MemberTeam.Visible = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.pnl_ProjectItem.Visible = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.pnl_ProjectItems.Controls.Clear();
            var tp = team[nameLblClicked] as DA_1.Models.TeamWork;
            cStudent.deleteTopicStudent(tp.teamID, student);

            if (!isFisnish)
                showProject(1);
            else showProject(-1);
           
            cMainControl.showNotification("DELETE TOPIC", "SUCCESS!");

        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.btn_Edit.Visible = false;
            this.btn_Submit.Visible = true;
            this.txt_Link.Enabled = true;
            this.txt_Link.Text = "";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (this.txt_Link.Text.Length > 0)
            {
                flag = true;
            }
            if (flag == true)
            {
                cStudent.editLink(student, teamID, this.txt_Link.Text.Trim());
                cMainControl.showNotification("INPUT LINK", "SUCCESS!");
                this.btn_Submit.Visible = false;
                this.btn_Edit.Visible = true;
            }
            else
            {
                cMainControl.showNotification("INPUT LINK", "FAIL!");
                return;
            }
            this.txt_Link.Visible = true;
            this.txt_Link.Enabled = false;
        }
        #endregion
        #region Methods
        private void showProject(int flag)
        {
            this.pnl_ProjectItems.Controls.Clear();
            this.pnl_ProjectItem.Visible = false;
            int i = 0;
            this.team = new Hashtable();
            cStudent = new ControllerStudent();
            cStudent.getInforStudent(this.student.Trim()).TeamWorks.ToList().ForEach(tw =>
            {
                if (flag*(tw.Topic.dateTo.Value - DateTime.Now).TotalDays > 0)
                {
                    GunaLabel lbl = new GunaLabel();
                    this.team.Add(tw.Topic.name, tw);

                    if (i < 3)
                    {
                        lbl = createLabel(new Point(100 + 100 * (i) * 3, 10), tw.Topic.name);
                        lbl.Cursor = Cursors.Hand;
                    }
                    else if (i < 6)
                    {
                        lbl = createLabel(new Point(100 + 100 * (i - 3) * 3, 40), tw.Topic.name);
                        lbl.Cursor = Cursors.Hand;
                    }
                    this.pnl_ProjectItems.Controls.Add(lbl);
                    lbl.Click += Lbl_Click;
                    i++;
                }
            });
        }
        private void showControlBtn()
        {
            this.btn_Edit.Visible = !isFisnish;
            if(isFisnish)
            {
                this.btn_Delete.Location = new Point(780, 422);
                this.btn_Back.Location = new Point(608, 422);
            }
            else
            {
                this.btn_Delete.Location = new Point(608, 422);
                this.btn_Back.Location = new Point(433, 422);
            }

        }
        private GunaLabel createLabel(Point location,string text)
        {
            GunaLabel lbl = new GunaLabel();
            lbl.Text = text;
            lbl.Font = new Font("Arial", 14, FontStyle.Regular);
            lbl.AutoSize = true;
            lbl.Location = location;
            //lbl.Font.Size = new Size(14);
            //lbl.Cursor =Cursors.Hand;
            return lbl;
        }

        private GunaCheckBox createCheckBox(Point location, bool value)
        {
            GunaCheckBox check = new GunaCheckBox();
            check.Location = location;
            check.Checked = value;
            check.FillColor = Color.FromArgb(253, 38, 100);
            check.CheckedOnColor = Color.White;
            return check;
        }
        private int getValueDeadline(DateTime dateTo)
        {
            return Convert.ToInt32((dateTo - DateTime.Now).TotalDays);
        }

        #endregion

    }
}

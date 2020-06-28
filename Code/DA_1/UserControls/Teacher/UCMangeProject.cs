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
using Guna.UI.WinForms;
using System.Collections;
using DA_1.Controllers;
using DA_1.Library;

namespace DA_1.UserControls.Teacher
{
    public partial class UCMangeProject : UserControl
    {
        #region Field
        ControllerTeacher cTeacher;
        private DA_1.Models.Teacher teacher;
        private Hashtable topics;
        private Hashtable teamWorks;
        private List<GunaCheckBox> checkProcess;
        private TeamWork currentTeam;
        private Topic currTopic;
        private Control pnl_ContainerMain;
        private bool isFisnish;//true đã hoàn thành, false đã chưa hoàn thành
        #endregion
        #region Contructor
        public UCMangeProject(DA_1.Models.Teacher teacher,Control pnl)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.cTeacher = new ControllerTeacher();
            pnl_ContainerMain = pnl;
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
            GunaLabel lbl = sender as GunaLabel;
            DA_1.Models.Topic currentTopic = this.topics[lbl.Text.Trim()] as DA_1.Models.Topic;
            currTopic = currentTopic;
            i = 0;
            this.pnl_Teams.Controls.Clear();
            this.teamWorks = new Hashtable();
            this.lbl_ProName.Text = "Project Name: "+currentTopic.name;
            currentTopic.TeamWorks.ToList().ForEach(ct => {
                teamWorks.Add(ct.name.Trim(), ct);
                GunaLabel lbl_ct = createLabel(new Point(100 + 400 * i, 10), ct.name.Trim());

                this.pnl_Teams.Controls.Add(lbl_ct);

                i++;
                lbl_ct.Click += Lbl_ct_Click;
                lbl_ct.Cursor = Cursors.Hand;
            });
            this.pnl_Container.Visible = true;
            this.pnl_Teams.Visible = true;
            this.btn_Delete.Visible = true;
            this.pnl_TeamInfor.Visible = false;
        }

        private void Lbl_ct_Click(object sender, EventArgs e)
        {
            this.btn_Delete.Visible = false;

            this.checkProcess = new List<GunaCheckBox>();
            int i;
            this.pnl_TeamInfor.Visible = true;
            var currentTeam = this.teamWorks[(sender as GunaLabel).Text] as TeamWork;
            this.currentTeam = currentTeam;
            i = 0;
            this.pnl_Members.Controls.Clear();
            currentTeam.Students.ToList().ForEach(st => {
                this.pnl_Members.Controls.Add(createLabel(new Point(10, 10 + 25 * i), st.name));
                i++;
            });
            this.pnl_Process.Controls.Clear();
            i = 0;
            currentTeam.Topic.ProcessTopics.ToList().ForEach(p =>
            {
                GunaLabel lbl = createLabel(new Point(10, 10 + 20 * i), p.Process.name.Trim());
                this.pnl_Process.Controls.Add(lbl);
                GunaCheckBox check = createCheckBox(new Point(130, 10 + 20 * i), (bool)p.isPass);
                check.Enabled = false;
                this.pnl_Process.Controls.Add(check);
                this.checkProcess.Add(check);
                i++;
            });
            this.txt_Link.Text = currentTeam.link.Trim();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            this.txt_Point.Enabled = true;
            this.checkProcess.ForEach(c => { c.Enabled = true; });
            this.btn_Finish.Visible = true;
            this.btn_Edit.Visible = false;
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            List<bool> process = new List<bool>();
            this.checkProcess.ForEach(c => {
                c.Enabled = false;
                process.Add(c.Checked);
            });
            this.btn_Finish.Visible = false;
            this.btn_Edit.Visible = true;
            this.txt_Point.Enabled = false;
            cTeacher.editpoint(process, this.txt_Point.Text.Trim(), this.currentTeam.teamID, currentTeam.topicID);
            cMainControl.showNotification("EDIT PROCESS & POINT", "SUCCESS!");
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            cTeacher.deleteTopic(currTopic.TopicID);
            cMainControl.showNotification("DELETE TOPIC", "SUCCESS!");
            if (!isFisnish)
                showProject(1);
            else showProject(-1);
        }

        private void btn_DeleteTeam_Click(object sender, EventArgs e)
        {
            cTeacher.deleteTeam(currentTeam.teamID);
            cMainControl.showNotification("DELETE TEAM", "SUCCESS!");
            if (!isFisnish)
                showProject(1);
            else showProject(-1);
        }
        #endregion
        #region Methods
        private void createStatusBtn(bool flag)
        {
            btn_Delete.Visible = flag;
            btn_DeleteTeam.Visible = flag;
            btn_Edit.Visible = flag;
        }
        private void createStatusPnl(bool flag)
        {
            this.pnl_ProjectItems.Controls.Clear();
            this.pnl_Teams.Visible = flag;
            this.pnl_TeamInfor.Visible = flag;
            this.pnl_Container.Visible = flag;
        }
        private void showProject(int flag)
        {
            createStatusPnl(false);
            createStatusBtn(true);
            this.teacher = cTeacher.getInforTeacher(teacher.teacherID.Trim());
            int i = 0;
            this.topics = new Hashtable();
            teacher.Topics.ToList().ForEach(tw => {
                if (flag*(tw.dateTo.Value - DateTime.Now).TotalDays > 0)
                {
                    GunaLabel lbl = new GunaLabel();

                    this.topics.Add(tw.name, tw);
                    if (i < 3)
                    {
                        lbl = createLabel(new Point(100 + 100 * (i) * 3, 10), tw.name);
                        lbl.Cursor = Cursors.Hand;
                    }
                    else if (i < 6)
                    {
                        lbl = createLabel(new Point(100 + 100 * (i - 3) * 3, 30), tw.name);
                        lbl.Cursor = Cursors.Hand;

                    }
                    this.pnl_ProjectItems.Controls.Add(lbl);
                    lbl.Click += Lbl_Click;
                    i++;
                }
            });
        }
        private GunaLabel createLabel(Point location, string text)
        {
            GunaLabel lbl = new GunaLabel();
            lbl.Text = text;
            lbl.Font = new Font("Arial", 14, FontStyle.Regular);
            lbl.AutoSize = true;
            lbl.Location = location;
            //lbl.Font.Size = new Size(14);
            return lbl;
        }

        private GunaCheckBox createCheckBox(Point location,bool value)
        {
            GunaCheckBox check = new GunaCheckBox();
            check.Location = location;
            check.Checked = value;
            check.FillColor = Color.FromArgb(253, 38, 100);
            check.CheckedOnColor = Color.White;
            return check;
        }

        #endregion
    }
}

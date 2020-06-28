using DA_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1.Controllers
{
    
    public class ControllerStudent
    {

        private win0613Entities db;
        private ControllerTeacher cTeacher=new ControllerTeacher();
        public ControllerStudent()
        {
            db = new win0613Entities();
        }
        public Student getInforStudent(string id)
        {
            return db.Students.Find(id);
        }
        public int getStudentID()
        {
            int max = Int32.MinValue;
            db.Students.ToList().ForEach(user =>
            {
                if (max < int.Parse(user.studentID.Substring(2)))
                    max = int.Parse(user.studentID.Substring(2));
            });
            return max != int.MinValue ? max + 1 : 1;
        }
        public int getUserNameStudent()
        {
            int max = Int32.MinValue;
            db.Students.ToList().ForEach(user =>
            {
                if (max < int.Parse(user.userName.Substring(3)))
                        max = int.Parse(user.userName.Substring(3));
            });
            return max != int.MinValue ? max + 1 : 1;
        }
        public List<Student> getMemberTeam(string id)
        {
            return db.TeamWorks.Find(id).Students.ToList();
        }
        public List<Faculty> loadCboxFaculty()
        {
            return db.Faculties.ToList();
        }

        public List<Topic> getTopicInFaculty(string faculyID, string studentID)
        {
            var student = db.Students.Find(studentID);
            var listTopicS = student.TeamWorks.Select(t => t.Topic);
            var listTopicF = new List<Topic>();
            db.Topics.ToList().ForEach(f => {
                if (f.facultyID.Trim().Equals(faculyID) && ((f.dateForm.Value - DateTime.Now).TotalDays > 0))
                    listTopicF.Add(f);
                });
           
            listTopicS.ToList().ForEach(ts => {
                listTopicF.Remove(ts);
            });
            
            return listTopicF;
        }
        public int getTeamID()
        {
            int max = Int32.MinValue;
            db.TeamWorks.ToList().ForEach(tw =>
            {
                if (max < int.Parse(tw.teamID.Substring(2)))
                    max = int.Parse(tw.teamID.Substring(2));
            });
            return max + 1;
        }


        public void addStudent(
            string stID, string stName, DateTime stBirthday,
            string stPhone, string stFaculty, string stMail, string stUserName, string stPassword)
        {
            var st = new Student()
            {
                studentID = stID,
                name = stName,
                birth = stBirthday,
                phone = stPhone,
                mail = stMail,
                userName = stUserName,
                facultyID = stFaculty
            };
            var account = new Acount()
            {
                userName = stUserName,
                pass = stPassword
            };

           
            db.Students.Add(st);
            db.Acounts.Add(account);

            db.SaveChanges();
        }
        public void addnew(string studentID, string teamID, string teamname, string topicId)
        {
            var st = db.Students.Find(studentID);
            var tw = new TeamWork();
            tw.teamID = teamID;
            tw.name = teamname;
            tw.topicID = topicId;
            tw.link = null;
            tw.point = null;
            tw.Students.Add(st);
            db.TeamWorks.Add(tw);
            db.SaveChanges();
        }
        public void addExistent(string idTeam,string idStudent)
        {
            db.TeamWorks.Find(idTeam).Students.Add(db.Students.Find(idStudent));
            db.SaveChanges();
        }
        public bool editLink(string studentID,string teamID,string link)
        {
            var student = db.Students.Find(studentID.Trim());
            student.TeamWorks.ToList().ForEach(tw => {
                if (tw.teamID.Trim().Equals(teamID.Trim()))
                    tw.link = link;
            });
            db.SaveChanges();
            return true;
        }
        public bool UpdateStudent(string stID, string stName, DateTime stBirthday,
            string stPhone, string stMail)
        {
            try
            {
                var student = db.Students.Find(stID);
                if (student.name != stName)
                {
                    student.name = stName;
                }
                if (student.birth != stBirthday)
                {
                    student.birth = stBirthday;
                }
                if (student.phone != stPhone)
                {
                    student.phone = stPhone;
                }

                if (student.mail != stMail)
                {
                    student.mail = stMail;
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void deleteTopicStudent(string teamID,string studentID)
        {
            var delStudent = db.TeamWorks.Find(teamID);
            if(delStudent.Students.Count==1)
            {
                cTeacher.deleteTeam(teamID);
            }
            else
                delStudent.Students.Remove(db.Students.Find(studentID));
            
            db.SaveChanges();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DA_1.Models;
namespace DA_1.Controllers
{
    public class ControllerTeacher
    {
        private win0613Entities db;

        public ControllerTeacher()
        {
            db = new win0613Entities();
        }
        public Teacher getInforTeacher(string id)
        {
            return db.Teachers.Find(id);
        }
        public int getTeacherID()
        {
            int max = Int32.MinValue;
            db.Teachers.ToList().ForEach(user =>
            {
                if (max < int.Parse(user.teacherID.Substring(2)))
                    max = int.Parse(user.teacherID.Substring(2));
            });
            return max != int.MinValue ? max + 1 : 1;
        }
        public void deleteTeam(string teamID)
        {
            var team = db.TeamWorks.Find(teamID);
            team.Students.ToList().ForEach(st => {
                team.Students.Remove(st);
            });
            db.TeamWorks.Remove(team);
            db.SaveChanges();
        }
        public void deleteTopic(string topicID)
        {
            var topic = db.Topics.Find(topicID);
            topic.TeamWorks.ToList().ForEach(tw => {
                tw.Students.ToList().ForEach(st => {
                    tw.Students.Remove(st);
                });
                db.TeamWorks.Remove(tw);
            });
            topic.ProcessTopics.ToList().ForEach(pt => {
                db.ProcessTopics.Remove(pt);
            });
            db.Topics.Remove(topic);
            db.SaveChanges();
        }
        public int getUserNameTeacher()
        {
            int max = Int32.MinValue;
            db.Teachers.ToList().ForEach(user =>
            {
                    if (max < int.Parse(user.userName.Substring(4)))
                        max = int.Parse(user.userName.Substring(4));
            });
            return max + 1;
        }
        public int getProjectID()
        {
            int max = Int32.MinValue;
            db.Topics.ToList().ForEach(tp =>
            {
                if (max < int.Parse(tp.TopicID.Substring(2)))
                    max = int.Parse(tp.TopicID.Substring(2));
            });
            return max + 1;
        }
        public List<string> loadCboxKindOfProject()
        {
            return db.KindOfTopics.Select(kot => kot.name).ToList();
        }
        public List<string> loadCboxFaculty()
        {
            return db.Faculties.Select(fa => fa.FacultyName).ToList();
        }
        public List<string> loadCboxAcademicLevel()
        {
            return db.Academics.Select(al => al.name).ToList();
        }
        public List<string> loadCboxPosition()
        {
            return db.Positions.Select(pos => pos.name).ToList();
        }
        public void addTeacher(List<string> data)
        {
            var infor = new Teacher();

            infor.teacherID = data[0];
            infor.name = data[1];
            infor.birth = DateTime.Parse(data[2]);
            infor.mail = data[4];
            infor.phone = data[3];
            infor.userName = data[8];
            var account = new Acount()
            {
                userName = data[8],
                pass = data[9]
            };
            string facultyName = data[6].ToString();
            var b = db.Faculties.Where(f => f.FacultyName == facultyName).SingleOrDefault();
            infor.facultyID = b.FacultyID;
            
            string academicName = data[5];
            string positionName = data[7];

            infor.academicID = db.Academics.Where(a => a.name == academicName).SingleOrDefault().academicLevelID;
            infor.positionID = db.Positions.Where(p => p.name == positionName).SingleOrDefault().PositionID;
           
           
            db.Teachers.Add(infor);
            db.Acounts.Add(account);
            db.SaveChanges();
        }
        public void addProject(string kot, string projectId, string projectName, DateTime dataTo, DateTime dataFrom, int process, string teachId)
        {
            var teacher = getInforTeacher(teachId);
            var topic = new Topic()
            {
                TopicID = projectId,
                name = projectName,
                kotID = db.KindOfTopics.Where(k => k.name == kot).SingleOrDefault().KotID.Trim(),
                dateTo = dataTo,
                dateForm = dataFrom,
                // Mai tạo process
                teacherID = teacher.teacherID,
                facultyID = teacher.facultyID,
            };
            


            for (int i = 1; i <= process; i++)
            {
                var processTopic = new ProcessTopic()
                {
                    processID = "P" + i.ToString(),
                    isPass = false
                };
                topic.ProcessTopics.Add(processTopic);
            }
            db.Topics.Add(topic);
            db.SaveChanges();
        }
        public void edit(string TeacherId, string teacherName, DateTime Birthday, string Phone, string Email,
                string AcademicLevel, string Faculty, string Position)
        {
            var teacher = db.Teachers.Find(TeacherId);
            if (teacher.name != teacherName)
            {
                teacher.name = teacherName;
            }
            if (teacher.birth != Birthday)
            {
                teacher.birth = Birthday;
            }
            if (teacher.phone != Phone)
            {
                teacher.phone = Phone;
            }
            if (teacher.mail != Email)
            {
                teacher.mail = Email;
            }
            if (teacher.Academic.name != AcademicLevel)
            {
                teacher.academicID = db.Academics.Where(a => a.name == AcademicLevel).SingleOrDefault().academicLevelID.Trim();
            }
            if (teacher.Faculty.FacultyName != Faculty)
            {
                teacher.facultyID = db.Faculties.Where(f => f.FacultyName == Faculty).SingleOrDefault().FacultyID.Trim();
            }
            if (teacher.Position.name != Position)
            {
                teacher.positionID = db.Positions.Where(p => p.name == Position).SingleOrDefault().PositionID.Trim();
            }
            db.SaveChanges();
        }
        public void editpoint(List<bool> process, string point, string teamID, string topicID)
        {
            var topic = db.Topics.Find(topicID);
            var teamwork = db.TeamWorks.Find(teamID);
            int i = 0;
            topic.ProcessTopics.ToList().ForEach(pc =>
            {
                if(pc.isPass != process[i])
                    pc.isPass = process[i];
                i++;
            });
            topic.TeamWorks.ToList().ForEach(tw => { 
                if(tw.teamID==teamwork.teamID)
                {
                    tw.point = point;
                }
            });
            db.SaveChanges();
        }
        public void deleteTeacher(string teacherID)
        {
            var del = db.Teachers.Find(teacherID);
            if (!(del is null))
            {
                del.Topics.Clear();
                db.Acounts.Remove(db.Acounts.Find(del.userName));

                db.Teachers.Remove(del);

            }
            db.SaveChanges();
        }
    }
}

using DA_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_1.Controllers
{
    public class ControllerAdmin
    {
        private win0613Entities db;

        public ControllerAdmin()
        {
            this.db = new win0613Entities();
        }
        public Student getInforStudent(string id)
        {
            return db.Students.Find(id);
        }
        public Teacher getInforTeacher(string id)
        {
            return db.Teachers.Find(id);
        }
        public int getIDKoT()
        {
            int max = int.MinValue;
            db.KindOfTopics.Select(kot => kot.KotID.Trim()).ToList().ForEach(id => {
                max = int.Parse(id.Trim().Substring(1)) > max ? int.Parse(id.Trim().Substring(1)) : max;
            });
            return max != int.MinValue ? max + 1 : 1;
        }
        public List<Student> loadData(string str, string cbx)
        {
            if (cbx.Equals("student id"))
            {
                return db.Students.Where(st => st.studentID.Contains(str)).ToList();
            }
            else if (cbx.Equals("student name"))
            {
                return db.Students.Where(st => st.name.Contains(str)).ToList();
            }
            else if (cbx.Equals("faculty"))
            {
                return db.Students.Where(fa => fa.Faculty.FacultyName.Contains(str)).ToList();
            }
            else if (cbx.Equals("team name"))
            {
                var st = new List<Student>();
                var teams = db.TeamWorks.Where(tw => tw.name.Contains(str)).ToList();
                teams.ForEach(t =>
                {
                    t.Students.ToList().ForEach(s =>
                    {
                        st.Add(db.Students.Find(s.studentID));
                    });
                });
                return st;
            }
            return new List<Student>();
        }
        public List<Faculty> loadDataF()
        {
            return db.Faculties.ToList();
        }
        public List<Teacher> loadDataT(string str, string cbx)
        {
            if (cbx.Equals("teacher id"))
            {
                return db.Teachers.Where(tc => tc.teacherID.Contains(str)).ToList();
            }
            else if (cbx.Equals("teacher name"))
            {
                return db.Teachers.Where(tc => tc.name.Contains(str)).ToList();
            }
            else if (cbx.Equals("faculty"))
            {
                return db.Teachers.Where(fa => fa.Faculty.FacultyName.Contains(str)).ToList();
            }
            else if (cbx.Equals("position"))
            {
                return db.Teachers.Where(fa => fa.Position.name.Contains(str)).ToList();
            }
            else if (cbx.Equals("academic level"))
            {
                return db.Teachers.Where(fa => fa.Academic.name.Contains(str)).ToList();
            }
            else if (cbx.Equals("project name"))
            {
                var teacher = new List<Teacher>();
                var topics = db.Topics.Where(tp => tp.name.Contains(str));
                topics.ToList().ForEach(t =>
                {
                    teacher.Add(t.Teacher);
                });
                return teacher.Distinct().ToList();
            }
            return new List<Teacher>();
        }
        public List<Topic> loadDataP(string str, string cbx)
        {
            if (cbx.Equals("project id"))
            {
                return db.Topics.Where(pro => pro.TopicID.Contains(str)).ToList();
            }


            else if (cbx.Equals("project name"))
            {
                return db.Topics.Where(pro => pro.name.Contains(str)).ToList();
            }
            else if (cbx.Equals("kind of project"))
            {
                return db.Topics.Where(kop => kop.KindOfTopic.name.Contains(str)).ToList();
            }
            else if (cbx.Equals("faculty"))
            {
                return db.Topics.Where(fa => fa.Faculty.FacultyName.Contains(str)).ToList();
            }
            else if (cbx.Equals("teacher"))
            {
                return db.Topics.Where(tc => tc.Teacher.name.Contains(str)).ToList();
            }
            else if (cbx.Equals("team name"))
            {
                var topics = new List<Topic>();
                var teamname = db.TeamWorks.Where(tw => tw.name.Contains(str)).ToList();
                teamname.ForEach(t=> {
                    topics.Add(t.Topic);
                });
                return topics.Distinct().ToList();
            }

            return new List<Topic>();
        }
        public List<KindOfTopic> loadDataK()
        {
            return db.KindOfTopics.ToList();
        }
        public int getFacultyID()
        {
            int max = int.MinValue;
            db.Faculties.Select(f => f.FacultyID.Trim()).ToList().ForEach(id=> {
                max = int.Parse(id) > max ? int.Parse(id) : max;
            });
            return max != int.MinValue ? max + 1 :110;
        }
        public void addK(string kotID, string kotName)
        {
            KindOfTopic kot = new KindOfTopic();
            kot.KotID = kotID;
            kot.name = kotName;
            db.KindOfTopics.Add(kot);
            db.SaveChanges();
        }
        public void updateK(string kotID, string kotName)
        {
            var updateKot = db.KindOfTopics.Find(kotID);
            if (!(updateKot is null))
            {
                if (updateKot.name != kotName)
                {
                    updateKot.name = kotName;
                    db.SaveChanges();
                }

            }
        }
        public void deleteK(string kotID)
        {
            var delKot = db.KindOfTopics.Find(kotID);
            if(!(delKot is null))
            {
                delKot.Topics.ToList().ForEach(t => 
                {
                    t.ProcessTopics.ToList().ForEach(pt => 
                    {
                            db.ProcessTopics.Remove(pt);
                    });
                    t.TeamWorks.ToList().ForEach(tw =>
                    {
                        tw.Students.ToList().ForEach(st => {
                            tw.Students.Remove(st);
                        });
                        db.TeamWorks.Remove(tw);
                    });
                    db.Topics.Remove(t);
                });
            }
            db.KindOfTopics.Remove(delKot);
            db.SaveChanges();
        }
        public void deleteStudent(string id)
        {
            db.Students.Find(id).TeamWorks.Clear();
            db.Acounts.Remove(db.Students.Find(id).Acount);
            db.Students.Remove(db.Students.Find(id));
            db.SaveChanges();
        }

        //faculty
        public void addF(string facultyID, string facultyName)
        {
            Faculty faculty = new Faculty();
            faculty.FacultyID = facultyID;
            faculty.FacultyName = facultyName;
            db.Faculties.Add(faculty);
            db.SaveChanges();
        }
        public void updateF(string facultyID, string facultyName)
        {
            var updateFaculty = db.Faculties.Find(facultyID);
            if (!(updateFaculty is null))
            {
                if (updateFaculty.FacultyName != facultyName)
                {
                    updateFaculty.FacultyName = facultyName;
                    db.SaveChanges();
                }

            }
        }
        public void deleteF(string facultyID)
        {
            var delFaculty = db.Faculties.Find(facultyID);
            if (!(delFaculty is null))
            {

                delFaculty.Students.ToList().ForEach(t => {
                    t.TeamWorks.ToList().ForEach(tw => {
                        tw.Students.ToList().ForEach(tws => {
                            tw.Students.Remove(tws);
                        });
                        db.TeamWorks.Remove(tw);
                    });
                    db.Acounts.Remove(t.Acount);
                    db.Students.Remove(t);
                   
                });
                delFaculty.Teachers.ToList().ForEach(t => {
                    db.Acounts.Remove(t.Acount);
                    db.Teachers.Remove(t);
                });
                delFaculty.Topics.ToList().ForEach(t => {
                    
                    t.ProcessTopics.ToList().ForEach(pt => {
                        db.ProcessTopics.Remove(pt);
                    });
                    
                    db.Topics.Remove(t);
                });
                delFaculty.Students.Clear();
                delFaculty.Teachers.Clear();
                delFaculty.Topics.Clear();
                db.Faculties.Remove(delFaculty);
                db.SaveChanges();
            }
        }
    }
}

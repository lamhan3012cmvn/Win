using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_1.Models;
namespace DA_1.Controllers
{
    public class ControllerLogin
    {
        private win0613Entities db;
        public ControllerLogin()
        {
            db = new win0613Entities();
        }

       
        public Teacher getInforTeacher(string id)
        {
            return db.Teachers.Find(id);
        }
        public string checkLogin(string userName,string pass)
        {
            var result = db.Acounts.Find(userName);
            if (result is null)
            {
                return null;
            }
            if (result.userName.Trim().ToLower().Equals(userName) && result.pass.Trim().Equals(pass))
            {
                if (userName.Equals("admin"))
                    return userName;
                var infor = result.Students.Where(tc => tc.userName.Trim().ToLower() == userName).SingleOrDefault();
                if(!(infor is null))
                    return infor.studentID;
                var inforTeacher = result.Teachers.Where(tc => tc.userName.Trim().ToLower() == userName).SingleOrDefault();
                if (!(inforTeacher is null))
                    return inforTeacher.teacherID;
            }
            return null;
        }

    }
}

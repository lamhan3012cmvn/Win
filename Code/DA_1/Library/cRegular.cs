using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace DA_1.Library
{
    public class cRegular
    {
        private Regex regularMail;
        private Regex regularPhone;

        public cRegular()
        {
            regularMail = new Regex(@"\A\w+@(gmail|student.hcmute|hcmute|fit.hcmute).(com|edu.vn)\Z");
            regularPhone = new Regex(@"\A0\d{9}\Z");
        }
        public bool isCheckMail(string mail)
        {
            return regularMail.IsMatch(mail);
        }
        public bool isCheckPhone(string phone)
        {
            return regularPhone.IsMatch(phone);
        }
    }
}

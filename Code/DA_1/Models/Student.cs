//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA_1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.TeamWorks = new HashSet<TeamWork>();
        }
    
        public string studentID { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> birth { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string facultyID { get; set; }
        public string userName { get; set; }
    
        public virtual Acount Acount { get; set; }
        public virtual Faculty Faculty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamWork> TeamWorks { get; set; }
    }
}
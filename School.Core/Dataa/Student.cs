using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Dataa
{
    public partial class Student
    {
        public Student()
        {
            Logins = new HashSet<Login>();
            Stdcourses = new HashSet<Stdcourse>();
        }

        public decimal Student_Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Dateofbirth { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<Stdcourse> Stdcourses { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Dataa
{
    public partial class Course
    {
        public Course()
        {
            Stdcourses = new HashSet<Stdcourse>();
        }

        public decimal Course_Id { get; set; }
        public string Coursename { get; set; }
        public decimal? Caregory_Id { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public DateTime? S_Date { get; set; }
        public DateTime? E_Date { get; set; }

        public virtual Category Caregory { get; set; }
        public virtual ICollection<Stdcourse> Stdcourses { get; set; }
    }
}

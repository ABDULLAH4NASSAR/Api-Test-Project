using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Dataa
{
    public partial class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
        }

        public decimal Category_Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}

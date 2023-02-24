using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Dataa
{
    public partial class Stdcourse
    {
        public decimal Id { get; set; }
        public decimal? Stdid { get; set; }
        public decimal? Courdeid { get; set; }
        public decimal? Markofstd { get; set; }
        public DateTime? Dateofregister { get; set; }

        public virtual Course Courde { get; set; }
        public virtual Student Std { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Dataa
{
    public partial class Login
    {
        public decimal Login_Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal? Role_Id { get; set; }
        public decimal? Student_Id { get; set; }

        public virtual Role Role { get; set; }
        public virtual Student Student { get; set; }
    }
}

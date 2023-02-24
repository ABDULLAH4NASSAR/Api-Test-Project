using System;
using System.Collections.Generic;

#nullable disable

namespace School.Core.Dataa
{
    public partial class Role
    {
        public Role()
        {
            Logins = new HashSet<Login>();
        }

        public decimal Role_Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
    }
}

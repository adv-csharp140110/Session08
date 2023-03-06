using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.Models
{
    public class PermissionRole
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        //Navigation Property
        public Role Role { get; set; }
        public Permission Permission { get; set; }
    }
}

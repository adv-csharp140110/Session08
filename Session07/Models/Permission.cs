using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.Models
{
    public class Permission
    {
        public int Id { get; set; }

        public string ButtonName { get; set; }
        public string FormName { get; set; }


        public ICollection<PermissionRole> PermissionRoles { get; set;}
    }
}

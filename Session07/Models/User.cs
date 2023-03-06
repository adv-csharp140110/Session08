using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.Models
{
    public class User
    {
        //GUID - Cluster ID
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Boolean IsActive { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}

using Session07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session07.utils
{
    static class AppData
    {
        public static User User { get; set; }
        public static List<Permission> Permissions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string Name { get; set; } // Optional: Full name of the user
        public string Role { get; set; } // "Admin", "TeamLeader", "Worker"
        public UserDto(string userName, string name, string role)
        {
            UserName = userName;
            Name = name;
            Role = role;
        }
    }
}

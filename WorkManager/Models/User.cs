using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; } // Optional: Full name of the user
        public string Password { get; set; }
        public string Role { get; set; } // "Admin", "TeamLeader", "Worker"
        public User(int userID, string userName,string name, string password, string role)
        {
            UserID = userID;
            UserName = userName;
            Name = name;
            Password = password;
            Role = role;
        }
        public override string ToString()
        {
            return $"{UserName} ({Role})";
        }
    }
}

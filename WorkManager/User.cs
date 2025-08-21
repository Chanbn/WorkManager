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
        public string Password { get; set; }
        public string Role { get; set; } // "Admin", "TeamLeader", "Worker"
        public User(int userID, string userName, string password, string role)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            Role = role;
        }
        public override string ToString()
        {
            return $"{UserName} ({Role})";
        }
    }
}

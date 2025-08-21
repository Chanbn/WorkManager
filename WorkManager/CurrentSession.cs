using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkManager
{
    public static class CurrentSession
    {
        public static int UserID { get; private set; }
        public static string UserName { get; private set; }
        public static string Role { get; private set; }

        public static void SetLoggedInUser(int userID, string userName, string role)
        {
            UserID = userID;
            UserName = userName;
            Role = role;
        }

        public static void ClearSession()
        {
            UserID = 0;
            UserName = string.Empty;
            Role = string.Empty;
        }
    }
}

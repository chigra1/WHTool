using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours.Common
{
    public class UserData
    {
        public string username;
        public UserType type;

        public UserData(string username, UserType type)
        {
            this.username = username;
            this.type = type;
        }

        public enum UserType { UNKNOWN = -1, Administrator = 0, RegularUser = 1 };
    }
}

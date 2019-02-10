using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours.Employees
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set;}
        public string surname { get; set; }
        public EmployeeStatus status { get; set; }
        public EmployeePosition position { get; set; }
        public string username { get; set; }
        public UserType type { get; set; }

        public enum UserType { UNKNOWN = -1, Administrator = 1, RegularUser = 2 };

        public enum EmployeeStatus { INTERNAL = 1, EXTERNAL = 2}
        public enum EmployeePosition { TEAM_LEADER = 1, ENGINEER = 2, TECHNICIAN = 3}

        public Employee()
        {

        }

        public Employee (int id, string name, string surname, EmployeeStatus status, EmployeePosition position, string username, UserType type)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.status = status;
            this.position = position;
            this.username = username;
            this.type = type;
        }
    }
}

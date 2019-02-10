using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingHours.Projects
{
    public class Project
    {
        public int id { get; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public Active active { get; set; }

        public enum Active { ACTIVE = 1, INACTIVE = 2 }

        /// <summary>
        /// Constructor to retreive project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public Project(int id, string name, string code, string description, Active active)
        {
            this.id = id;
            this.name = name;
            this.code = code;
            this.description = description;
            this.active = active;
        }

        /// <summary>
        /// Constructor for adding new project
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        public Project(string name, string code, string description, Active active)
        {
            this.name = name;
            this.code = code;
            this.description = description;
            this.active = active;
        }
    }
}

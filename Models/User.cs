using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public enum Role
    {
        Admin, ProjectManager, Developer, Submitter
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }


        public ICollection<Project> Projects { get; set; }

    }


}

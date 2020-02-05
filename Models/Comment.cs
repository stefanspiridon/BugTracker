using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Comment
    {
        public string Message { get; set; }
        public DateTime CreatedDateTime { get; set; }

        public User Commenter { get; set; }
    }
}

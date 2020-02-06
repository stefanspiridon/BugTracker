using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public enum Status
    {
        New, Open, InProgress, Resolved, AdditionalInfoRequired
    }

    public enum Priority
    {
        None, Low, Medium, High
    }

    public enum Type
    {
        Bugs, FeatureRequests, OtherComments, Training
    }
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public Type Type { get; set; }

        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        //public Project Project { get; set; }
        public User? Submitter { get; set; }
        public User? Developer { get; set; }
        public ICollection<Attachment>? Attachments { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using Type = BugTracker.Models.Type;

namespace BugTracker.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BugTrackerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new List<User>();
            var projects = new List<Project>();
            var tickets = new List<Ticket>();
            var comments = new List<Comment>();
            var attachments = new List<Attachment>();

            Project project = new Project {Title = "project", Description = "description", Tickets = tickets};

            projects.Add(project);

            User Andrei = new User {Name = "Andrei", Email = "andrei@gmail.com", Id = 1, Projects = projects, Role = Role.Admin};
            User Stefan = new User {Name = "Stefan", Email = "stefan@gmail.com", Id = 2, Projects = projects, Role = Role.ProjectManager};
            User Greg = new User {Name = "Greg", Email = "greg@gmail.com", Id = 3, Projects = projects, Role = Role.Developer};
            User Robert =new User {Name = "Robert", Email = "robert@gmail.com", Id = 4, Projects = projects, Role = Role.Submitter};


            Ticket ticket = new Ticket
            {
                Title = "ticket", Description = "description", Developer = Greg,
                Priority = Priority.High,
                Status = Status.InProgress, Submitter = Robert,
                Type = Type.Bugs, CreatedDateTime = DateTime.Now,
                UpdatedDateTime = DateTime.Now, Comments = comments, Attachments = attachments
            };

            project.Tickets.Add(ticket);

            Comment comment = new Comment{Commenter = Andrei, CreatedDateTime = DateTime.Now, Message = "make better"};

            ticket.Comments.Add(comment);

            Attachment attachment = new Attachment{CreatedDateTime = DateTime.Now, Notes = "null file", Uploader = Andrei};

            ticket.Attachments.Add(attachment);

            
            users.Add(Andrei);
            users.Add(Stefan);
            users.Add(Greg);
            users.Add(Robert);
            tickets.Add(ticket);
            comments.Add(comment);
            attachments.Add(attachment);

            foreach ( User u in users )
            {
                context.Users.Add(u);
            }

            context.SaveChanges();

            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }

            context.SaveChanges();

            foreach (Ticket t in tickets)
            {
                context.Tickets.Add(t);
            }

            context.SaveChanges();

            foreach (Comment c in comments)
            {
                context.Comments.Add(c);
            }

            context.SaveChanges();

            foreach (Attachment a in attachments)
            {
                context.Attachments.Add(a);
            }

            context.SaveChanges();




        }
    }
}

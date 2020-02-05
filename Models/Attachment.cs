#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BugTracker.Models
{
    public class Attachment
    {
        public string Notes { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public IFormFile? File { get; set; }
        public User Uploader { get; set; }
    }
}
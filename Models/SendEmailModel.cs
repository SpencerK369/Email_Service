using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email_Service.Models
{
    public class SendEmailModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
    }
}

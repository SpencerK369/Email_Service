using Email_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email_Service.Repositories.Interfaces
{
    public interface IEmailsRepository
    {
        IQueryable<SendEmailModel> GetAllEmails();
    }
}

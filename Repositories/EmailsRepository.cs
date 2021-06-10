using Email_Service.DbContexts;
using Email_Service.Models;
using Email_Service.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email_Service.Repositories
{
    public class EmailsRepository : IEmailsRepository
    {
        EmailsDbContext _context;

        public EmailsRepository(EmailsDbContext context)
        {
            _context = context;
        }

        public IQueryable<SendEmailModel> GetAllEmails()
            => _context.Emails;
    }
}

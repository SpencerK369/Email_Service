using Email_Service.DbContexts;
using Email_Service.Models;
using Email_Service.Repositories.Interfaces;
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

        public async Task<IQueryable<SendEmailModel>> GetAllEmailsAsync()
            => await Task.Run(() =>_context.Emails);

        public async Task<SendEmailModel> CreateEmailAsync(SendEmailModel email)
        {
            var newEmail = await _context.AddAsync(email);
            var result = await _context.SaveChangesAsync();

            return result > 0 ? newEmail.Entity : new SendEmailModel();
        }
    }
}

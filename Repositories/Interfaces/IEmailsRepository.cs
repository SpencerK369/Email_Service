using Email_Service.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Email_Service.Repositories.Interfaces
{
    public interface IEmailsRepository
    {
        Task<IQueryable<SendEmailModel>> GetAllEmailsAsync();

        public Task<SendEmailModel> CreateEmailAsync(SendEmailModel email);
    }
}

using Email_Service.Models;
using Email_Service.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Email_Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailsController : ControllerBase
    {
        private readonly ILogger<EmailsController> _logger;

        private IEmailsRepository _repo;

        public EmailsController(ILogger<EmailsController> logger, IEmailsRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        //[HttpPost]
        //public async Task<IActionResult> Email(SendEmailModel email)
        //{
        //    var apiKey = "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";
        //    var client = new SendGridClient(apiKey);
        //    var from = new EmailAddress("spencerkrug.aultcare@gmail.com", "Example User");
        //    var subject = "Sending with Twilio SendGrid is Fun";
        //    var to = new EmailAddress("spncrkrug@gmail.com", "Example User");
        //    var plainTextContent = "and easy to do anywhere, even with C#";
        //    var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
        //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        //    var response = await client.SendEmailAsync(msg).ConfigureAwait(false);

        //    return Ok();
        //}

        [HttpGet]
        public async Task<IActionResult> GetEmails()
            => Ok(await _repo.GetAllEmailsAsync());

        [HttpPost]
        public async Task<IActionResult> CreateEmail(SendEmailModel email)
            => Ok(await _repo.CreateEmailAsync(email));
    }
}

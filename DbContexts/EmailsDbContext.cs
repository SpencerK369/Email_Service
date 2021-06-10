using Email_Service.DbContexts.ModelBuilders;
using Email_Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email_Service.DbContexts
{
    public class EmailsDbContext : DbContext
    {
        public EmailsDbContext(DbContextOptions<EmailsDbContext> options)
    : base(options) { }

        public DbSet<SendEmailModel> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmailsModelBuilder());
        }
    }
}

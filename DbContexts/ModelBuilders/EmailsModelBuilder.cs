using Email_Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email_Service.DbContexts.ModelBuilders
{
    public class EmailsModelBuilder : IEntityTypeConfiguration<SendEmailModel>
    {
        public void Configure(EntityTypeBuilder<SendEmailModel> builder)
        {
            builder.ToTable("Emails", "dbo");

            builder.HasKey(x => x.Id)
                .HasName("Id");

            builder.Property(e => e.Subject)
                    .HasColumnName("Subject");

            builder.Property(e => e.Body)
                    .HasColumnName("Body");

            builder.Property(e => e.From)
                    .HasColumnName("From");
        }
    }
}

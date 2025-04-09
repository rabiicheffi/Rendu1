using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Infrastructure.Configurations
{
    public class BilanConfiguration : IEntityTypeConfiguration<Bilan>
    {
        public void Configure(EntityTypeBuilder<Bilan> builder)
        {
            builder.HasKey(b => new { b.CodeInfirmier, b.CodePatient, b.DatePrelevement });

            builder.HasOne(b=>b.Infirimier)
                .WithMany(i=>i.BilanList)
                .HasForeignKey(b=>b.CodeInfirmier)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b=>b.Patient)
                .WithMany(p=>p.BilanList)
                .HasForeignKey(b=>b.CodePatient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using System;
using System.Linq;
using Accredit.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accredit.Domain.ModelBuilders
{
    public class HumanResourceStatusModelBuilder : IContextModelBuilder
    {
        public void Construct(ModelBuilder builder)
        {
            builder.Entity<HumanResourceStatus>().HasKey(k => k.HumanResourceStatusId);
            builder.Entity<HumanResourceStatus>().Property(p => p.HumanResourceStatusId).HasConversion<int>();

            //seed enum values in DB
            builder.Entity<HumanResourceStatus>().HasData(Enum.GetValues(typeof(Shared.Enums.HumanResourceStatus))
                .Cast<Shared.Enums.HumanResourceStatus>()
                .Select(e => new HumanResourceStatus
                {
                    HumanResourceStatusId = e,
                    Name = e.ToString()
                }));
        }
    }
}

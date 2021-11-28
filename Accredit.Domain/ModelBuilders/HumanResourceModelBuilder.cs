using System;
using System.Linq;
using Accredit.Shared.Entities;
using Accredit.Shared.Enums;
using Microsoft.EntityFrameworkCore;

namespace Accredit.Domain.ModelBuilders
{
    public class HumanResourceModelBuilder : IContextModelBuilder
    {
        public void Construct(ModelBuilder builder)
        {
            builder.Entity<HumanResource>().HasKey(k => k.Id);
        }
    }
}

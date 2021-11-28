using System;
using Accredit.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using HumanResourceStatus = Accredit.Shared.Enums.HumanResourceStatus;

namespace Accredit.Domain.ModelBuilders
{
    public class HumanResourceModelBuilder : IContextModelBuilder
    {
        public void Construct(ModelBuilder builder)
        {
            builder.Entity<HumanResource>().HasKey(k => k.Id);


            //seed data
            builder.Entity<HumanResource>().HasData(
                new HumanResource
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    FirstName = "Joe Bloggs",
                    LastName = "Bloggs",
                    Email = "jbloggs@hr.com",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    DepartmentName = "IT",
                    HumanResourceStatusId = HumanResourceStatus.Approved,
                    EmployeeNumber = "01"
                },
                new HumanResource
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    FirstName = "Simon",
                    LastName = "Hayes",
                    Email = "shayes@hr.com",
                    DateOfBirth = new DateTime(1984, 11, 28),
                    DepartmentName = "Marketing",
                    HumanResourceStatusId = HumanResourceStatus.Disabled,
                    EmployeeNumber = "02"
                }
                );
        }
    }
}

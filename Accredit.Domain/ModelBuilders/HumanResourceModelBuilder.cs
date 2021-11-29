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
                    FirstName = "Joe",
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
                    FirstName = "Harvey",
                    LastName = "Patel",
                    Email = "hpatel@hr.com",
                    DateOfBirth = new DateTime(2002, 11, 28),
                    DepartmentName = "Sales",
                    HumanResourceStatusId = HumanResourceStatus.Disabled,
                    EmployeeNumber = "03"
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
                    HumanResourceStatusId = HumanResourceStatus.Approved,
                    EmployeeNumber = "03"
                },
                new HumanResource
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    FirstName = "Zoe",
                    LastName = "Murphy",
                    Email = "zmurphy@hr.com",
                    DateOfBirth = new DateTime(1978, 06, 13),
                    DepartmentName = "IT",
                    HumanResourceStatusId = HumanResourceStatus.Pending,
                    EmployeeNumber = "04"
                },
                new HumanResource
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    FirstName = "Charlie",
                    LastName = "Hawkins",
                    Email = "chawkins@hr.com",
                    DateOfBirth = new DateTime(1994, 02, 14),
                    DepartmentName = "Call Center",
                    HumanResourceStatusId = HumanResourceStatus.Approved,
                    EmployeeNumber = "05"
                },
                new HumanResource
                {
                    Id = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    FirstName = "Alisha",
                    LastName = "Bishop",
                    Email = "abishop@hr.com",
                    DateOfBirth = new DateTime(1982, 02, 17),
                    DepartmentName = "IT",
                    HumanResourceStatusId = HumanResourceStatus.Approved,
                    EmployeeNumber = "06"
                }
                );
        }
    }
}

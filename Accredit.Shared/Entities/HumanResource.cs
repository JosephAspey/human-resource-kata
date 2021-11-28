using System;
using System.ComponentModel.DataAnnotations;
using Accredit.Shared.Entities.Base;


namespace Accredit.Shared.Entities
{
    public class HumanResource : BaseEntity<Guid>
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string DepartmentName { get; set; }
        public Enums.HumanResourceStatus HumanResourceStatusId { get; set; }
        public string Email { get; set; }
        public string EmployeeNumber { get; set; }


        public HumanResourceStatus HumanResourceStatus { get; set; }
    }
}

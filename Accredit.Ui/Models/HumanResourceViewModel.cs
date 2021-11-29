using System;
using Accredit.Shared.Enums;

namespace Accredit.Ui.Models
{
    public class HumanResourceViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public HumanResourceStatus Status { get; set; }
        public string EmployeeNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}

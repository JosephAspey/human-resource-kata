using System.Collections.Generic;

namespace Accredit.Shared.Entities
{
    public class HumanResourceStatus
    {
        public Enums.HumanResourceStatus HumanResourceStatusId { get; set; }
        public string Name { get; set; }

        public  List<HumanResource> HumanResources { get; set; }
    }
}

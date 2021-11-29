using System.Collections.Generic;
using System.Threading.Tasks;
using Accredit.Shared.Entities;

namespace Accredit.Domain.Repositories
{
    public interface IHumanResourceRepository
    {
        Task<ICollection<HumanResource>> GetHumanResources();
    }
}

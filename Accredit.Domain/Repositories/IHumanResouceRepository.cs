using System.Threading.Tasks;
using Accredit.Core.Areas.Paging;
using Accredit.Shared.Entities;

namespace Accredit.Domain.Repositories
{
    public interface IHumanResourceRepository
    {
        Task<PaginatedList<HumanResource>> GetHumanResources(int? pageNumber);
    }
}

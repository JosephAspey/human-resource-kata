using System.Linq;
using System.Threading.Tasks;
using Accredit.Core.Areas.Paging;
using Accredit.Core.Areas.Paging.Settings;
using Accredit.Domain.Context;
using Accredit.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Accredit.Domain.Repositories
{
    public class HumanResourceRepository : IHumanResourceRepository
    {
        private readonly HumanResourceContext _dbContext;
        private readonly PagingSettings _pagingSettings;

        public HumanResourceRepository(HumanResourceContext dbContext, IOptions<PagingSettings> pagingSettings)
        {
            _dbContext = dbContext;
            _pagingSettings = pagingSettings.Value;
        }

        public async Task<PaginatedList<HumanResource>> GetHumanResources(int? pageNumber)
        {
            var resources =  _dbContext.HumanResources
                .Include(x => x.HumanResourceStatus)
                .OrderBy(x => x.EmployeeNumber)
                .AsNoTracking();
            
            var pageSize = _pagingSettings.TotalResultsPerPage;
            var paginatedResults = await PaginatedList<HumanResource>.CreateAsync(resources, pageNumber ?? 1, pageSize);

            return paginatedResults;
        }
    }
}
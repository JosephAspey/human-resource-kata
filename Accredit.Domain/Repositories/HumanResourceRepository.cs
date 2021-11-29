using System.Collections.Generic;
using System.Threading.Tasks;
using Accredit.Domain.Context;
using Accredit.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accredit.Domain.Repositories
{
    public class HumanResourceRepository : IHumanResourceRepository
    {
        private readonly HumanResourceContext _dbContext;

        public HumanResourceRepository(HumanResourceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<HumanResource>> GetHumanResources()
        {
            var resources = await _dbContext.HumanResources
                .Include(x => x.HumanResourceStatus)
                .ToListAsync();

            return resources;
        }
    }
}
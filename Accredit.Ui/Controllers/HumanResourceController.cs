using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Accredit.Core.Areas.Paging;
using Accredit.Domain.Repositories;
using Accredit.Ui.Models;
using AutoMapper;

namespace Accredit.Ui.Controllers
{
    public class HumanResourceController : Controller
    {
        private readonly IHumanResourceRepository _humanResourceRepository;
        private readonly IMapper _mapper;

        public HumanResourceController(IHumanResourceRepository humanResourceRepository, IMapper mapper)
        {
            _humanResourceRepository = humanResourceRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            var humanResources = await _humanResourceRepository.GetHumanResources(pageNumber);

            var humanResourcesViewModel
                = _mapper.Map<PaginatedList<HumanResourceViewModel>>(humanResources);

            //TODO: include pagination when mapping to ViewModel with AutoMapper
            humanResourcesViewModel.PageIndex = humanResources.PageIndex;
            humanResourcesViewModel.TotalPages = humanResources.TotalPages;

            return View("Index", humanResourcesViewModel);
        }
    }
}

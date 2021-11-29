using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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

        public async Task<IActionResult> Index()
        {
            var humanResources = await _humanResourceRepository.GetHumanResources();

            var humanResourcesViewModel
                = _mapper.Map<List<HumanResourceViewModel>>(humanResources);

            return View(humanResourcesViewModel);
        }
    }
}

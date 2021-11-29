using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Accredit.Domain.Repositories;
using Accredit.Ui.Models;
using Accredit.Ui.Settings;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace Accredit.Ui.Controllers
{
    public class HumanResourceController : Controller
    {

        private readonly IHumanResourceRepository _humanResourceRepository;
        private readonly IMapper _mapper;
        private readonly UiSettings _uiSettings;

        public HumanResourceController(IHumanResourceRepository humanResourceRepository, IMapper mapper, IOptions<UiSettings> uiSettings)
        {
            _humanResourceRepository = humanResourceRepository;
            _mapper = mapper;
            _uiSettings = uiSettings.Value;
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

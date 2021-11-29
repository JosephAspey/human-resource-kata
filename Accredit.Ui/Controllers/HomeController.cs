using Accredit.Ui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using Accredit.Domain.Repositories;

namespace Accredit.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHumanResourceRepository _humanResourceRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IHumanResourceRepository humanResourceRepository, ILogger<HomeController> logger)
        {
            _humanResourceRepository = humanResourceRepository;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var resources = await _humanResourceRepository.GetHumanResources();



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

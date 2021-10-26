using GenshinImpact.Models;
using GenshinImpact.Repository.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GenshinDataService _service;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _service = new GenshinDataService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Characters()
        {

            var listCharacter = _service.getCharactersAsync();

            var chars = listCharacter.Result;

            return View(chars);
        }


        [HttpPost]
        public IActionResult getCharacters()
        {
            List<Characters> character = new List<Characters>();
            try
            {
                var listCharacter = _service.getCharactersAsync();

                var chars = listCharacter.Result;

                return View(chars);
            }
            catch (Exception)
            {

                throw;
            }

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

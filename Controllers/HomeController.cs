using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerShop.Models;
using SneakerShop.ViewModels;

namespace SneakerShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;

        public HomeController(ISneakerRepository sneakerRepository)
        {
            _sneakerRepository = sneakerRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SneakerOfTheWeek = _sneakerRepository.SneakerOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerShop.Models;
using SneakerShop.ViewModels;

namespace SneakerShop.Controllers
{
    public class SneakerController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ICategoryRepository _categoryRepository;

        public SneakerController(ISneakerRepository sneakerRepository, ICategoryRepository categoryRepository)
        {
            _sneakerRepository = sneakerRepository;
            _categoryRepository = categoryRepository;
        }

        

        public IActionResult Details(int id)
        {
            var sneaker = _sneakerRepository.GetSneakerById(id);
            if (sneaker == null)
                return NotFound();
            return View(sneaker);
        }

        public ViewResult List(string category)
        {
            IEnumerable<Sneaker> sneakers;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                sneakers = _sneakerRepository.AllSneakers.OrderBy(p => p.SneakerId);
                currentCategory = "All sneakers";
            }
            else
            {
                sneakers = _sneakerRepository.AllSneakers.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.SneakerId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new SneakersListViewModel
            {
                Sneakers = sneakers,
                CurrentCategory = currentCategory
            });
        }


     

    }
}

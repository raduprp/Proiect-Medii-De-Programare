using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakerShop.Models;
using SneakerShop.ViewModels;

namespace SneakerShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISneakerRepository sneakerRepository, ShoppingCart shoppingCart )
        {
            _sneakerRepository = sneakerRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int sneakerId)
        {
            var selectedSneaker = _sneakerRepository.AllSneakers.FirstOrDefault(p => p.SneakerId == sneakerId);

            if (selectedSneaker != null)
            {
                _shoppingCart.AddToCart(selectedSneaker, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int sneakerId)
        {
            var selectedSneaker = _sneakerRepository.AllSneakers.FirstOrDefault(p => p.SneakerId == sneakerId);

            if (selectedSneaker != null)
            {
                _shoppingCart.RemoveFromCart(selectedSneaker);
            }
            return RedirectToAction("Index");
        }
    }
}

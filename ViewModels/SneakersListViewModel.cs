using SneakerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.ViewModels
{
    public class SneakersListViewModel
    {
        public IEnumerable<Sneaker> Sneakers { get; set; }

        public string CurrentCategory { get; set; }

    }
}

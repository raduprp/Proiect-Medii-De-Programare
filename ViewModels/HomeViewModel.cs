using SneakerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sneaker> SneakerOfTheWeek { get; set; } 
    }
}

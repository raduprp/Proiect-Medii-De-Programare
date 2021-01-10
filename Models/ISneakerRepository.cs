using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.Models
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> AllSneakers { get; }
        IEnumerable<Sneaker> SneakerOfTheWeek { get; }
        Sneaker GetSneakerById(int sneakerId);

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.Models
{
    public class SneakerRepository : ISneakerRepository 
    {
        private readonly AppDbContext _appDbContext;

        public SneakerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Sneaker> AllSneakers
        {
            get
            {
                return _appDbContext.Sneakers.Include(c => c.Category);
            }
        }

        public IEnumerable<Sneaker> SneakerOfTheWeek
        {
            get
            {
                return _appDbContext.Sneakers.Include(c => c.Category).Where(p => p.IsSneakerOfTheWeek);
            }
        }

        public Sneaker GetSneakerById(int sneakerId)
        {
            return _appDbContext.Sneakers.FirstOrDefault(p => p.SneakerId == sneakerId);
        }
    }
}

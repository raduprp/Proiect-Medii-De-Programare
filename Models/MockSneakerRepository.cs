using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.Models
{
    public class MockSneakerRepository: ISneakerRepository

    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Sneaker> AllSneakers =>
            new List<Sneaker>
            {
                new Sneaker {SneakerId = 1, Name="Nike Air Force 1", Price=110M, Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/1ec29293-ed66-446b-8980-7204dc629e1c/air-force-1-07-lx-shoe-bhqSGN.jpg", InStock=true, IsSneakerOfTheWeek=false, ImageThumbnailUrl="https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/1ec29293-ed66-446b-8980-7204dc629e1c/air-force-1-07-lx-shoe-bhqSGN.jpg"},
                new Sneaker {SneakerId = 2, Name="Air Jordan 1 Retro", Price=200M, Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/84fc4e69-30b8-4a06-9837-26ad18c2da9f/air-jordan-1-volt-gold-release-date-.jpg", InStock=true, IsSneakerOfTheWeek=false, ImageThumbnailUrl="https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/84fc4e69-30b8-4a06-9837-26ad18c2da9f/air-jordan-1-volt-gold-release-date-.jpg"},
                new Sneaker {SneakerId = 3, Name="Adidas Superstars", Price=90M, Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg", InStock=true, IsSneakerOfTheWeek=true, ImageThumbnailUrl="https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg"},
                new Sneaker {SneakerId = 4, Name="Adidas NMD_R1", Price=100M,Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/0b49803254284e418fccaaf00111954c_9366/NMD_R1_Shoes_Black_FV9015_01_standard.jpg", InStock=true, IsSneakerOfTheWeek=true, ImageThumbnailUrl="https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/0b49803254284e418fccaaf00111954c_9366/NMD_R1_Shoes_Black_FV9015_01_standard.jpg"}
            };

        public IEnumerable<Sneaker> SneakerOfTheWeek { get; }

        public Sneaker GetSneakerById(int SneakerId)
        {
            return AllSneakers.FirstOrDefault(p => p.SneakerId == SneakerId);
        }
    }
}

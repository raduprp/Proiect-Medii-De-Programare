using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakerShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Sneaker> Sneakers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order>Orders { get; set; }

        public DbSet<OrderDetail>OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Nike" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Jordan" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Adidas" });

            

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 1,
                Name = "Nike Air Force 1",
                Price = 110M,


                CategoryId = 1,
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/1ec29293-ed66-446b-8980-7204dc629e1c/air-force-1-07-lx-shoe-bhqSGN.jpg",
                InStock = true,
                IsSneakerOfTheWeek = true,
                ImageThumbnailUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/1ec29293-ed66-446b-8980-7204dc629e1c/air-force-1-07-lx-shoe-bhqSGN.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 2,
                Name = "Air Jordan 1 Retro",
                Price = 200M,


                CategoryId = 2,
                ImageUrl = "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/84fc4e69-30b8-4a06-9837-26ad18c2da9f/air-jordan-1-volt-gold-release-date-.jpg",
                InStock = true,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/84fc4e69-30b8-4a06-9837-26ad18c2da9f/air-jordan-1-volt-gold-release-date-.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 3,
                Name = "Jordan One Take",
                Price = 110M,


                CategoryId = 2,
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/0f751bbf-e4ce-45aa-8454-21de81d27342/jordan-one-take-ii-basketball-shoe-k4Ql69.jpg",
                InStock = true,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/0f751bbf-e4ce-45aa-8454-21de81d27342/jordan-one-take-ii-basketball-shoe-k4Ql69.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 4,
                Name = "Nike Air Max 97",
                Price = 170M,


                CategoryId = 1,
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/a47b2ef9-8239-4e82-99fd-e6159c0df489/air-max-97-shoe-z3TlrlVN.jpg",
                InStock = true,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/a47b2ef9-8239-4e82-99fd-e6159c0df489/air-max-97-shoe-z3TlrlVN.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 5,
                Name = "Adidas Superstars",
                Price = 90M,


                CategoryId = 3,
                ImageUrl = "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg",
                InStock = true,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 6,
                Name = "Adidas NMD_R1",
                Price = 120M,


                CategoryId = 3,
                ImageUrl = "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/0b49803254284e418fccaaf00111954c_9366/NMD_R1_Shoes_Black_FV9015_01_standard.jpg",
                InStock = true,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl = "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/0b49803254284e418fccaaf00111954c_9366/NMD_R1_Shoes_Black_FV9015_01_standard.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 7,
                Name = "Nike Blazer Mid",
                Price = 120M,


                CategoryId = 1,
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/kxmb3lab5dmy00qpoyul/blazer-mid-77-vintage-shoe-CBDjT0.jpg",
                InStock = false,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/kxmb3lab5dmy00qpoyul/blazer-mid-77-vintage-shoe-CBDjT0.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 8,
                Name = "Adidas Ultra4D",
                Price = 220M,


                CategoryId = 3,
                ImageUrl = "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/8c16db10a94c4883ab48abe5010d3788_9366/Ultra4D_Shoes_Black_FW7089_01_standard.jpg",
                InStock = true,
                IsSneakerOfTheWeek = true,
                ImageThumbnailUrl = "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/8c16db10a94c4883ab48abe5010d3788_9366/Ultra4D_Shoes_Black_FW7089_01_standard.jpg"

            });


            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 9,
                Name = "Nike AirMax 2090",
                Price = 180M,


                CategoryId = 1,
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-shoe-skBBrM.jpg",
                InStock = true,
                IsSneakerOfTheWeek = true,
                ImageThumbnailUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-shoe-skBBrM.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 10,
                Name = "Nike AirMax 270",
                Price = 190M,


                CategoryId = 1,
                ImageUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/awjogtdnqxniqqk0wpgf/air-max-270-shoe-nnTrqDGR.jpg",
                InStock = true,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/awjogtdnqxniqqk0wpgf/air-max-270-shoe-nnTrqDGR.jpg"

            });

            modelBuilder.Entity<Sneaker>().HasData(new Sneaker
            {
                SneakerId = 11,
                Name = "Air Jordan High Zoom",
                Price = 200M,
                CategoryId = 2,
                ImageUrl = "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/d682f149-f0da-462e-b729-6cf6f02c672b/air-jordan-1-zoom-crater-release-date.jpg",
                InStock = false,
                IsSneakerOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/d682f149-f0da-462e-b729-6cf6f02c672b/air-jordan-1-zoom-crater-release-date.jpg"

            });
        }
    }
}

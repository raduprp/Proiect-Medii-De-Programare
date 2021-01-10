using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerShop.Migrations
{
    public partial class SeedDataAddedAdv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Nike", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Jordan", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Adidas", null });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "SneakerId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsSneakerOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/1ec29293-ed66-446b-8980-7204dc629e1c/air-force-1-07-lx-shoe-bhqSGN.jpg", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/1ec29293-ed66-446b-8980-7204dc629e1c/air-force-1-07-lx-shoe-bhqSGN.jpg", true, true, null, "Nike Air Force 1", 110m, null },
                    { 4, 1, "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/a47b2ef9-8239-4e82-99fd-e6159c0df489/air-max-97-shoe-z3TlrlVN.jpg", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/a47b2ef9-8239-4e82-99fd-e6159c0df489/air-max-97-shoe-z3TlrlVN.jpg", true, false, null, "Nike Air Max 97", 170m, null },
                    { 7, 1, "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/kxmb3lab5dmy00qpoyul/blazer-mid-77-vintage-shoe-CBDjT0.jpg", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/kxmb3lab5dmy00qpoyul/blazer-mid-77-vintage-shoe-CBDjT0.jpg", false, false, null, "Nike Blazer Mid", 120m, null },
                    { 9, 1, "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-shoe-skBBrM.jpg", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/d136d71a-6821-41c0-b25b-bc2a28bb8ec3/air-max-2090-shoe-skBBrM.jpg", true, true, null, "Nike AirMax 2090", 180m, null },
                    { 10, 1, "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/awjogtdnqxniqqk0wpgf/air-max-270-shoe-nnTrqDGR.jpg", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/awjogtdnqxniqqk0wpgf/air-max-270-shoe-nnTrqDGR.jpg", true, false, null, "Nike AirMax 270", 190m, null },
                    { 2, 2, "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/84fc4e69-30b8-4a06-9837-26ad18c2da9f/air-jordan-1-volt-gold-release-date-.jpg", "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/84fc4e69-30b8-4a06-9837-26ad18c2da9f/air-jordan-1-volt-gold-release-date-.jpg", true, false, null, "Air Jordan 1 Retro", 200m, null },
                    { 3, 2, "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/0f751bbf-e4ce-45aa-8454-21de81d27342/jordan-one-take-ii-basketball-shoe-k4Ql69.jpg", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/0f751bbf-e4ce-45aa-8454-21de81d27342/jordan-one-take-ii-basketball-shoe-k4Ql69.jpg", true, false, null, "Jordan One Take", 110m, null },
                    { 11, 2, "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/d682f149-f0da-462e-b729-6cf6f02c672b/air-jordan-1-zoom-crater-release-date.jpg", "https://static.nike.com/a/images/t_prod_ss/w_640,c_limit,f_auto/d682f149-f0da-462e-b729-6cf6f02c672b/air-jordan-1-zoom-crater-release-date.jpg", false, false, null, "Air Jordan High Zoom", 200m, null },
                    { 5, 3, "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg", "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/7ed0855435194229a525aad6009a0497_9366/Superstar_Shoes_White_EG4958_01_standard.jpg", true, false, null, "Adidas Superstars", 90m, null },
                    { 6, 3, "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/0b49803254284e418fccaaf00111954c_9366/NMD_R1_Shoes_Black_FV9015_01_standard.jpg", "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/0b49803254284e418fccaaf00111954c_9366/NMD_R1_Shoes_Black_FV9015_01_standard.jpg", true, false, null, "Adidas NMD_R1", 120m, null },
                    { 8, 3, "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/8c16db10a94c4883ab48abe5010d3788_9366/Ultra4D_Shoes_Black_FW7089_01_standard.jpg", "https://assets.adidas.com/images/h_2000,f_auto,q_auto:sensitive,fl_lossy/8c16db10a94c4883ab48abe5010d3788_9366/Ultra4D_Shoes_Black_FW7089_01_standard.jpg", true, true, null, "Adidas Ultra4D", 220m, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}

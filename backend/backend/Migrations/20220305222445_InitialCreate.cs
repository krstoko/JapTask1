using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryImgUrl", "CategoryName" },
                values: new object[,]
                {
                    { 1, "https://media.istockphoto.com/photos/grilled-striploin-steak-picture-id535786572?k=20&m=535786572&s=612x612&w=0&h=WAOuIsIUQB7zVW23C6MX9y5QCyl6KLPL2eYcOcc_Qdk=", "Beef" },
                    { 16, "", "Seafood" },
                    { 15, "", "Soup" },
                    { 14, "", "Vegetarian" },
                    { 13, "", "Thai" },
                    { 12, "", "Rice" },
                    { 11, "", "Fruit" },
                    { 10, "", "French" },
                    { 9, "", "Pie" },
                    { 8, "", "Salad" },
                    { 7, "", "Italian" },
                    { 6, "", "Chicken" },
                    { 5, "", "Candy" },
                    { 4, "", "Cake" },
                    { 3, "", "Breakfast" },
                    { 2, "", "Bread" },
                    { 17, "", "Sandwich" },
                    { 18, "", "Lunch" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

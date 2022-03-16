using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class AddingIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeasureUnit = table.Column<int>(type: "int", nullable: false),
                    MeasureQuantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    LowestMeasureUnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "IngredientName", "LowestMeasureUnitPrice", "MeasureQuantity", "MeasureUnit", "Price" },
                values: new object[,]
                {
                    { 1, "Ulje", 0.0015, 1, 3, 1.5 },
                    { 2, "Mlijeko", 0.00080000000000000004, 1, 3, 0.80000000000000004 },
                    { 3, "Voda", 0.001, 1, 3, 1.0 },
                    { 4, "Brasno", 0.002, 1, 0, 2.0 },
                    { 5, "Mljeveno meso", 0.0030000000000000001, 1, 0, 3.0 },
                    { 6, "Tjestenina", 0.0023, 1, 0, 2.2999999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}

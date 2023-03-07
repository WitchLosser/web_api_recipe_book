using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MinToCook = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredient",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredient", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Egg" },
                    { 2, "beef" },
                    { 3, "Fish" },
                    { 4, "Tomato" },
                    { 5, "Cheese" },
                    { 6, "Oil" },
                    { 7, "Sugar" },
                    { 8, "Ketchup" },
                    { 9, "Spageti" },
                    { 10, "Dought" },
                    { 11, "Sour cream" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "MinToCook", "Name" },
                values: new object[,]
                {
                    { 1, 40, "Carbonara" },
                    { 2, 15, "Omlete" },
                    { 3, 45, "Roast beef" },
                    { 4, 60, "Baked fish" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 11, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredient_RecipeId",
                table: "RecipeIngredient",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredient");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}

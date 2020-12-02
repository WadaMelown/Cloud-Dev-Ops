using Microsoft.EntityFrameworkCore.Migrations;

namespace Purchases.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "basket",
                columns: table => new
                {
                    UserBasketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_basket", x => x.UserBasketId);
                });

            migrationBuilder.CreateTable(
                name: "UserBasketItem",
                columns: table => new
                {
                    UserBasketItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    UserBasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBasketItem", x => x.UserBasketItemId);
                    table.ForeignKey(
                        name: "FK_UserBasketItem_basket_UserBasketId",
                        column: x => x.UserBasketId,
                        principalTable: "basket",
                        principalColumn: "UserBasketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserBasketItem_UserBasketId",
                table: "UserBasketItem",
                column: "UserBasketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBasketItem");

            migrationBuilder.DropTable(
                name: "basket");
        }
    }
}

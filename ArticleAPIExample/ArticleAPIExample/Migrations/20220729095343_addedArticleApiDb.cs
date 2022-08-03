using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArticleAPIExample.Migrations
{
    public partial class addedArticleApiDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "saleData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sale = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saleData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "saleData");
        }
    }
}

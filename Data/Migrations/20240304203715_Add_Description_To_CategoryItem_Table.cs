using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebsiteOne.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Description_To_CategoryItem_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "MediaType");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CategoryItem",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CategoryItem");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "MediaType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

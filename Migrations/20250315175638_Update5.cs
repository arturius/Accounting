using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.Migrations
{
    /// <inheritdoc />
    public partial class Update5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstimateValues_Tags_AsscosiatedTagTagId",
                table: "EstimateValues");

            migrationBuilder.DropIndex(
                name: "IX_EstimateValues_AsscosiatedTagTagId",
                table: "EstimateValues");

            migrationBuilder.RenameColumn(
                name: "AsscosiatedTagTagId",
                table: "EstimateValues",
                newName: "AsscosiatedTagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AsscosiatedTagId",
                table: "EstimateValues",
                newName: "AsscosiatedTagTagId");

            migrationBuilder.CreateIndex(
                name: "IX_EstimateValues_AsscosiatedTagTagId",
                table: "EstimateValues",
                column: "AsscosiatedTagTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstimateValues_Tags_AsscosiatedTagTagId",
                table: "EstimateValues",
                column: "AsscosiatedTagTagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

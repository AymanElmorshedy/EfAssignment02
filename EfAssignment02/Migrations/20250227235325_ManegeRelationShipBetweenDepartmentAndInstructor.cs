using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfAssignment02.Migrations
{
    /// <inheritdoc />
    public partial class ManegeRelationShipBetweenDepartmentAndInstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManegerId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManegerId",
                table: "Departments",
                column: "ManegerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManegerId",
                table: "Departments",
                column: "ManegerId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ManegerId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManegerId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ManegerId",
                table: "Departments");
        }
    }
}

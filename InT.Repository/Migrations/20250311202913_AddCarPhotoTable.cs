using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InT.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddCarPhotoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPhoto_Cars_carId",
                table: "CarPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarPhoto",
                table: "CarPhoto");

            migrationBuilder.DropColumn(
                name: "BCode",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CCode",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CPlateNumber",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "CarPhoto",
                newName: "CarPhotos");

            migrationBuilder.RenameIndex(
                name: "IX_CarPhoto_carId",
                table: "CarPhotos",
                newName: "IX_CarPhotos_carId");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlateNumber",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarPhotos",
                table: "CarPhotos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPhotos_Cars_carId",
                table: "CarPhotos",
                column: "carId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarPhotos_Cars_carId",
                table: "CarPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarPhotos",
                table: "CarPhotos");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PlateNumber",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "CarPhotos",
                newName: "CarPhoto");

            migrationBuilder.RenameIndex(
                name: "IX_CarPhotos_carId",
                table: "CarPhoto",
                newName: "IX_CarPhoto_carId");

            migrationBuilder.AddColumn<int>(
                name: "BCode",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CCode",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CPlateNumber",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarPhoto",
                table: "CarPhoto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarPhoto_Cars_carId",
                table: "CarPhoto",
                column: "carId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

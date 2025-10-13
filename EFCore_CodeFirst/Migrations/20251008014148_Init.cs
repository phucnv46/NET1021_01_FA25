using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "sinhvien",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LopMaLop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhvien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sinhvien_Lop_LopMaLop",
                        column: x => x.LopMaLop,
                        principalTable: "Lop",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sinhvien_LopMaLop",
                table: "sinhvien",
                column: "LopMaLop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sinhvien");

            migrationBuilder.DropTable(
                name: "Lop");
        }
    }
}

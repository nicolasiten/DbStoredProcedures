using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbStoredProcedures.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssueStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperatingSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Version = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVersionOs",
                columns: table => new
                {
                    ProductFk = table.Column<int>(nullable: false),
                    VersionFk = table.Column<int>(nullable: false),
                    OperatingSystemFk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVersionOs", x => new { x.ProductFk, x.VersionFk, x.OperatingSystemFk });
                    table.ForeignKey(
                        name: "FK_ProductVersionOs_OperatingSystem_OperatingSystemFk",
                        column: x => x.OperatingSystemFk,
                        principalTable: "OperatingSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVersionOs_Product_ProductFk",
                        column: x => x.ProductFk,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVersionOs_Version_VersionFk",
                        column: x => x.VersionFk,
                        principalTable: "Version",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    StatusFk = table.Column<int>(nullable: false),
                    OperatingSystemFk = table.Column<int>(nullable: false),
                    ProductFk = table.Column<int>(nullable: false),
                    VersionFk = table.Column<int>(nullable: false),
                    Problem = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Resolution = table.Column<string>(nullable: true),
                    ResolutionDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Issue_Status_StatusFk",
                        column: x => x.StatusFk,
                        principalTable: "IssueStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Issue_ProductVersionOs",
                        columns: x => new { x.ProductFk, x.VersionFk, x.OperatingSystemFk },
                        principalTable: "ProductVersionOs",
                        principalColumns: new[] { "ProductFk", "VersionFk", "OperatingSystemFk" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issue_StatusFk",
                table: "Issue",
                column: "StatusFk");

            migrationBuilder.CreateIndex(
                name: "IX_Issue_ProductVersionOs",
                table: "Issue",
                columns: new[] { "ProductFk", "VersionFk", "OperatingSystemFk" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOs_OperatingSystemFk",
                table: "ProductVersionOs",
                column: "OperatingSystemFk");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersionOs_VersionFk",
                table: "ProductVersionOs",
                column: "VersionFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issue");

            migrationBuilder.DropTable(
                name: "IssueStatus");

            migrationBuilder.DropTable(
                name: "ProductVersionOs");

            migrationBuilder.DropTable(
                name: "OperatingSystem");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Version");
        }
    }
}

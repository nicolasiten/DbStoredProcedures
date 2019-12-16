using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace DbStoredProcedures.Data.Migrations
{
    public partial class StoredProcedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string createStoredProcedures = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Migrations\Sql", "CreateStoredProcedures.sql");
            migrationBuilder.Sql(File.ReadAllText(createStoredProcedures));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string createStoredProcedures = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Migrations\Sql", "DropStoredProcedures.sql");
            migrationBuilder.Sql(File.ReadAllText(createStoredProcedures));
        }
    }
}

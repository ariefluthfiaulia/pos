using Microsoft.EntityFrameworkCore.Migrations;

namespace POS.WebApp.Migrations
{
    public partial class GenerateGender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Gender(Name) Values('LAKI-LAKI');");
            migrationBuilder.Sql("insert into Gender(Name) Values('PEREMPUAN');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

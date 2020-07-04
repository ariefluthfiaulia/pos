using Microsoft.EntityFrameworkCore.Migrations;

namespace POS.WebApp.Migrations
{
    public partial class GenerateUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into UserRole(Name,CreatedBy,CreatedAt,UpdatedBy,UpdatedAt) Values('ADMIN','SYSTEM',curdate(),'SYSTEM',curdate());");
            migrationBuilder.Sql("insert into UserRole(Name,CreatedBy,CreatedAt,UpdatedBy,UpdatedAt) Values('STAFF','SYSTEM',curdate(),'SYSTEM',curdate());");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

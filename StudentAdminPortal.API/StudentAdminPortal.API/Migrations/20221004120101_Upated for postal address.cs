using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAdminPortal.API.Migrations
{
    public partial class Upatedforpostaladdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostalAdress",
                table: "Address",
                newName: "PostalAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostalAddress",
                table: "Address",
                newName: "PostalAdress");
        }
    }
}

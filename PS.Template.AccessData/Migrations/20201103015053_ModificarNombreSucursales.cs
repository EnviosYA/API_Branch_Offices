using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class ModificarNombreSucursales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 1,
                column: "Nombre",
                value: "EnvioYa Retiro");

            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 2,
                column: "Nombre",
                value: "EnvioYa Monserrat");

            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 3,
                column: "Nombre",
                value: "EnvioYa Florencio Varela");

            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 4,
                column: "Nombre",
                value: "EnvioYa Quilmes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 1,
                column: "Nombre",
                value: "EnvioYaRetiro");

            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 2,
                column: "Nombre",
                value: "EnvioMonserrat");

            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 3,
                column: "Nombre",
                value: "EnvioYaFlorencioVarela");

            migrationBuilder.UpdateData(
                table: "Sucursal",
                keyColumn: "idSucursal",
                keyValue: 4,
                column: "Nombre",
                value: "EnvioYaQuilmes");
        }
    }
}

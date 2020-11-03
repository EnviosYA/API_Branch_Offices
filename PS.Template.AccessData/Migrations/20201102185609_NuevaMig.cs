using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class NuevaMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 1,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 408, "Av. del Libertador", "-34.5901743", "-58.3796545" });

            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 2,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 1201, "Av. Belgrano", "-34.613230", "-58.383805" });

            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 3,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 1999, "Av. Gral. José de San Martín", "-34.796817", "-58.279027" });

            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 4,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 204, "3 de Febrero", "-34.725701", "-58.262265" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 1,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 1574, "Amancio ALcorta", "21°:32':45'' Norte", "47°:24':51'' Sur" });

            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 2,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 7554, "Alsina", "11°:2':13'' Esta", "7°:4':48'' Sur" });

            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 3,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 2885, "Hipolito Yrigoyen", "31°:17':45'' Norte", "4°:42':18'' Oeste" });

            migrationBuilder.UpdateData(
                table: "Direccion",
                keyColumn: "idDireccion",
                keyValue: 4,
                columns: new[] { "Altura", "Calle", "Latitud", "Longitud" },
                values: new object[] { 578, "Leandro N Alem", "13°:32':15'' Norte", "4°:4':11'' Sur" });
        }
    }
}

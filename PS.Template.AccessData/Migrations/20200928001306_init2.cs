using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Localidad",
                columns: new[] { "idLocalidad", "CP", "idProvincia", "Nombre" },
                values: new object[,]
                {
                    { 1, 1001, 1, "Retiro seccion 1" },
                    { 18, 1018, 1, "Recoleta seccion 3" },
                    { 17, 1017, 1, "San Nicolas seccion seccion 8" },
                    { 16, 1016, 1, "Recoleta seccion 2" },
                    { 15, 1015, 1, "San Nicolas seccion 7" },
                    { 14, 1014, 1, "Recoleta seccion 1" },
                    { 13, 1013, 1, "San Nicolas seccion 6" },
                    { 12, 1012, 1, "Monserrat seccion 3" },
                    { 11, 1011, 1, "Retiro seccion 4" },
                    { 10, 1010, 1, "San Nicolas seccion 5" },
                    { 9, 1009, 1, "San Nicolas seccion 4" },
                    { 8, 1001, 1, "Monserrat seccion 2" },
                    { 7, 1007, 1, "Retiro seccion 3" },
                    { 6, 1006, 1, "Retiro seccion 2" },
                    { 5, 1005, 1, "San Nicolas seccion 3" },
                    { 4, 1004, 1, "San Nicolas seccion 2" },
                    { 3, 1003, 1, "San Nicolas seccion 1" },
                    { 2, 1002, 1, "Monserrat seccion 1" },
                    { 19, 1019, 1, "Recoleta seccion 4" },
                    { 20, 1020, 1, "Recoleta seccion 5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Localidad",
                keyColumn: "idLocalidad",
                keyValue: 20);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace PS.Template.AccessData.Migrations
{
    public partial class CreateSucursalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoSucursal",
                columns: table => new
                {
                    IdEstado = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoSucursal", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    idProvincia = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.idProvincia);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    idLocalidad = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CP = table.Column<int>(nullable: false),
                    idProvincia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.idLocalidad);
                    table.ForeignKey(
                        name: "FK_Localidad_Provincia",
                        column: x => x.idProvincia,
                        principalTable: "Provincia",
                        principalColumn: "idProvincia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    idDireccion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitud = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Longitud = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Calle = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Altura = table.Column<int>(nullable: false),
                    idLocalidad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.idDireccion);
                    table.ForeignKey(
                        name: "FK_Direccion_Localidad",
                        column: x => x.idLocalidad,
                        principalTable: "Localidad",
                        principalColumn: "idLocalidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sucursal",
                columns: table => new
                {
                    idSucursal = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    idDireccion = table.Column<int>(nullable: false),
                    IdEstado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursal", x => x.idSucursal);
                    table.ForeignKey(
                        name: "FK_Sucursal_Direccion",
                        column: x => x.idDireccion,
                        principalTable: "Direccion",
                        principalColumn: "idDireccion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sucursal_EstadoSucursal",
                        column: x => x.IdEstado,
                        principalTable: "EstadoSucursal",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EstadoSucursal",
                columns: new[] { "IdEstado", "Descripcion" },
                values: new object[] { 1, "Habilitada" });

            migrationBuilder.InsertData(
                table: "EstadoSucursal",
                columns: new[] { "IdEstado", "Descripcion" },
                values: new object[] { 2, "Inhabilitada" });

            migrationBuilder.InsertData(
                table: "Provincia",
                columns: new[] { "idProvincia", "Nombre" },
                values: new object[] { 1, "Buenos Aires" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_idLocalidad",
                table: "Direccion",
                column: "idLocalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_idProvincia",
                table: "Localidad",
                column: "idProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_idDireccion",
                table: "Sucursal",
                column: "idDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursal_IdEstado",
                table: "Sucursal",
                column: "IdEstado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sucursal");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "EstadoSucursal");

            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "Provincia");
        }
    }
}

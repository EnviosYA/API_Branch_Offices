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
                    idProvincia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    idLocalidad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Latitud = table.Column<double>(unicode: false, maxLength: 50, nullable: false),
                    Longitud = table.Column<double>(unicode: false, maxLength: 50, nullable: false),
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
                    idSucursal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    { 1, 1001, 1, "Retiro" },
                    { 18, 1018, 1, "Recoleta" },
                    { 17, 1876, 1, "Bernal" },
                    { 16, 1885, 1, "Guillermo Hudson" },
                    { 15, 1931, 1, "Punta Lara" },
                    { 14, 7130, 1, "Chascomus" },
                    { 13, 1875, 1, "Wilde" },
                    { 12, 1923, 1, "Berisso" },
                    { 11, 1846, 1, "San Francisco Solano" },
                    { 10, 1886, 1, "Ranelagh" },
                    { 9, 1900, 1, "La Plata" },
                    { 8, 1828, 1, "Banfield" },
                    { 7, 1824, 1, "Lanus" },
                    { 6, 1884, 1, "Berazategui" },
                    { 5, 1870, 1, "Avellaneda" },
                    { 4, 1878, 1, "Quilmes" },
                    { 3, 1888, 1, "Florencio Varela" },
                    { 2, 1002, 1, "Monserrat" },
                    { 19, 1917, 1, "Punta Indio" },
                    { 20, 1874, 1, "Temperley" }
                });

            migrationBuilder.InsertData(
                table: "Direccion",
                columns: new[] { "idDireccion", "Altura", "Calle", "idLocalidad", "Latitud", "Longitud" },
                values: new object[,]
                {
                    { 1, 408, "Av. del Libertador", 1, -34.590174300000001, -58.379654500000001 },
                    { 2, 1201, "Av. Belgrano", 2, -34.613230000000001, -58.383805000000002 },
                    { 3, 1999, "Av. Gral. José de San Martín", 3, -34.796816999999997, -58.279026999999999 },
                    { 4, 204, "3 de Febrero", 4, -34.725701000000001, -58.262264999999999 }
                });

            migrationBuilder.InsertData(
                table: "Sucursal",
                columns: new[] { "idSucursal", "idDireccion", "IdEstado", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, 1, "EnvioYa Retiro" },
                    { 2, 2, 1, "EnvioYa Monserrat" },
                    { 3, 3, 1, "EnvioYa Florencio Varela" },
                    { 4, 4, 1, "EnvioYa Quilmes" }
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

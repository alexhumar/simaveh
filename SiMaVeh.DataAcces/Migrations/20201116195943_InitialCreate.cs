using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiMaVeh.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasMarca",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasMarca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipamientosAirbags",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Conductor = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Acompanante = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DelanteroIzquierdo = table.Column<int>(type: "int", nullable: false),
                    DelanteroDerecho = table.Column<int>(type: "int", nullable: false),
                    TraseroIzquierdo = table.Column<int>(type: "int", nullable: false),
                    TraseroDerecho = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamientosAirbags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TargetsMantenimiento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Descripcion = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetsMantenimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Descripcion = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposEntidadReparadora",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Descripcion = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEntidadReparadora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposFuenteEnergia",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Descripcion = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposFuenteEnergia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposTelefono",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Descripcion = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTelefono", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UbicacionesPieza",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    Izquierda = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Superior = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UbicacionesPieza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposModelo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MarcaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GruposModelo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GruposModelo_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarcaCategoriaMarca",
                columns: table => new
                {
                    CategoriaMarcaId = table.Column<long>(type: "bigint", nullable: false),
                    MarcaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarcaCategoriaMarca", x => new { x.CategoriaMarcaId, x.MarcaId });
                    table.ForeignKey(
                        name: "FK_MarcaCategoriaMarca_CategoriasMarca_CategoriaMarcaId",
                        column: x => x.CategoriaMarcaId,
                        principalTable: "CategoriasMarca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarcaCategoriaMarca_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Neumaticos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MarcaId = table.Column<long>(type: "bigint", nullable: true),
                    Modelo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    ConstruccionCarcasa = table.Column<int>(type: "int", nullable: false),
                    RelacionAnchoAlto = table.Column<int>(type: "int", nullable: true),
                    DiametroLLanta = table.Column<int>(type: "int", nullable: false),
                    AnchuraSeccionalNominal = table.Column<int>(type: "int", nullable: false),
                    IndiceCarga = table.Column<int>(type: "int", nullable: false),
                    IndiceVelocidad = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neumaticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Neumaticos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recambios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MarcaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recambios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recambios_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TiposCambio",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CoeficienteCambio = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MonedaOrigenId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true),
                    MonedaDestinoId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCambio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TiposCambio_Monedas_MonedaDestinoId",
                        column: x => x.MonedaDestinoId,
                        principalTable: "Monedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TiposCambio_Monedas_MonedaOrigenId",
                        column: x => x.MonedaOrigenId,
                        principalTable: "Monedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PaisId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincias_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aceites",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ViscosidadSAEBajaTemperatura = table.Column<int>(type: "int", nullable: false),
                    ViscosidadSAEAltaTemperatura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aceites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aceites_TargetsMantenimiento_Id",
                        column: x => x.Id,
                        principalTable: "TargetsMantenimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fluidos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fluidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fluidos_TargetsMantenimiento_Id",
                        column: x => x.Id,
                        principalTable: "TargetsMantenimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Apellido = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TipoDocumentoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_TiposDocumento_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TiposDocumento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FuentesEnergia",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MarcaId = table.Column<long>(type: "bigint", nullable: true),
                    TipoFuenteEnergiaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuentesEnergia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuentesEnergia_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FuentesEnergia_TiposFuenteEnergia_TipoFuenteEnergiaId",
                        column: x => x.TipoFuenteEnergiaId,
                        principalTable: "TiposFuenteEnergia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Piezas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UbicacionPiezaId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piezas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piezas_TargetsMantenimiento_Id",
                        column: x => x.Id,
                        principalTable: "TargetsMantenimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Piezas_UbicacionesPieza_UbicacionPiezaId",
                        column: x => x.UbicacionPiezaId,
                        principalTable: "UbicacionesPieza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ModelosVehiculo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GrupoModeloId = table.Column<long>(type: "bigint", nullable: true),
                    Version = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AirbagsId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true),
                    TipoFuenteEnergiaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelosVehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelosVehiculo_EquipamientosAirbags_AirbagsId",
                        column: x => x.AirbagsId,
                        principalTable: "EquipamientosAirbags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModelosVehiculo_GruposModelo_GrupoModeloId",
                        column: x => x.GrupoModeloId,
                        principalTable: "GruposModelo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModelosVehiculo_TiposFuenteEnergia_TipoFuenteEnergiaId",
                        column: x => x.TipoFuenteEnergiaId,
                        principalTable: "TiposFuenteEnergia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresionesNeumaticos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RuedasDelanteras = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    RuedasTraseras = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    VehiculoCargado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NeumaticoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresionesNeumaticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresionesNeumaticos_Neumaticos_NeumaticoId",
                        column: x => x.NeumaticoId,
                        principalTable: "Neumaticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Descripcion = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kits_Recambios_Id",
                        column: x => x.Id,
                        principalTable: "Recambios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoIdentificador = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TargetMantenimientoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repuestos_Recambios_Id",
                        column: x => x.Id,
                        principalTable: "Recambios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Repuestos_TargetsMantenimiento_TargetMantenimientoId",
                        column: x => x.TargetMantenimientoId,
                        principalTable: "TargetsMantenimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ProvinciaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidos_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reparadores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reparadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reparadores_Personas_Id",
                        column: x => x.Id,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    TipoTelefonoId = table.Column<long>(type: "bigint", nullable: true),
                    PersonaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telefonos_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefonos_TiposTelefono_TipoTelefonoId",
                        column: x => x.TipoTelefonoId,
                        principalTable: "TiposTelefono",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Personas_Id",
                        column: x => x.Id,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModeloVehiculoAceite",
                columns: table => new
                {
                    ModeloVehiculoId = table.Column<long>(type: "bigint", nullable: false),
                    AceiteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloVehiculoAceite", x => new { x.AceiteId, x.ModeloVehiculoId });
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoAceite_Aceites_AceiteId",
                        column: x => x.AceiteId,
                        principalTable: "Aceites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoAceite_ModelosVehiculo_ModeloVehiculoId",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModeloVehiculoFuenteEnergia",
                columns: table => new
                {
                    ModeloVehiculoId = table.Column<long>(type: "bigint", nullable: false),
                    FuenteEnergiaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloVehiculoFuenteEnergia", x => new { x.FuenteEnergiaId, x.ModeloVehiculoId });
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoFuenteEnergia_FuentesEnergia_FuenteEnergiaId",
                        column: x => x.FuenteEnergiaId,
                        principalTable: "FuentesEnergia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoFuenteEnergia_ModelosVehiculo_ModeloVehiculoId",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModeloVehiculoPresionNeumatico",
                columns: table => new
                {
                    ModeloVehiculoId = table.Column<long>(type: "bigint", nullable: false),
                    PresionNeumaticoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloVehiculoPresionNeumatico", x => new { x.ModeloVehiculoId, x.PresionNeumaticoId });
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoPresionNeumatico_ModelosVehiculo_ModeloVehicul~",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoPresionNeumatico_PresionesNeumaticos_PresionNe~",
                        column: x => x.PresionNeumaticoId,
                        principalTable: "PresionesNeumaticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitRepuesto",
                columns: table => new
                {
                    KitId = table.Column<long>(type: "bigint", nullable: false),
                    RepuestoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitRepuesto", x => new { x.KitId, x.RepuestoId });
                    table.ForeignKey(
                        name: "FK_KitRepuesto_Kits_KitId",
                        column: x => x.KitId,
                        principalTable: "Kits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitRepuesto_Repuestos_RepuestoId",
                        column: x => x.RepuestoId,
                        principalTable: "Repuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModeloVehiculoRepuesto",
                columns: table => new
                {
                    ModeloVehiculoId = table.Column<long>(type: "bigint", nullable: false),
                    RepuestoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloVehiculoRepuesto", x => new { x.ModeloVehiculoId, x.RepuestoId });
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoRepuesto_ModelosVehiculo_ModeloVehiculoId",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeloVehiculoRepuesto_Repuestos_RepuestoId",
                        column: x => x.RepuestoId,
                        principalTable: "Repuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeriodicidadesMantenimiento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Kilometros = table.Column<long>(type: "bigint", nullable: false),
                    Dias = table.Column<int>(type: "int", nullable: false),
                    Meses = table.Column<int>(type: "int", nullable: false),
                    Anios = table.Column<int>(type: "int", nullable: false),
                    ModeloVehiculoId = table.Column<long>(type: "bigint", nullable: true),
                    RepuestoId = table.Column<long>(type: "bigint", nullable: true),
                    EsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodicidadesMantenimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodicidadesMantenimiento_ModelosVehiculo_ModeloVehiculoId",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PeriodicidadesMantenimiento_Repuestos_RepuestoId",
                        column: x => x.RepuestoId,
                        principalTable: "Repuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CPA = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PartidoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidades_Partidos_PartidoId",
                        column: x => x.PartidoId,
                        principalTable: "Partidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModeloVehiculoId = table.Column<long>(type: "bigint", nullable: true),
                    Kilometraje = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    AnioFabricacion = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_ModelosVehiculo_ModeloVehiculoId",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Calle = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NumeroCalle = table.Column<int>(type: "int", nullable: false),
                    LocalidadId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direcciones_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Automoviles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Patente = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NumeroChasis = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CodigoColorPintura = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automoviles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Automoviles_Vehiculos_Id",
                        column: x => x.Id,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntidadesReparadoras",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TipoEntidadReparadoraId = table.Column<long>(type: "bigint", nullable: true),
                    DireccionId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadesReparadoras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntidadesReparadoras_Direcciones_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "Direcciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntidadesReparadoras_TiposEntidadReparadora_TipoEntidadRepar~",
                        column: x => x.TipoEntidadReparadoraId,
                        principalTable: "TiposEntidadReparadora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReparadorEntidadReparadora",
                columns: table => new
                {
                    ReparadorId = table.Column<long>(type: "bigint", nullable: false),
                    EntidadReparadoraId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReparadorEntidadReparadora", x => new { x.EntidadReparadoraId, x.ReparadorId });
                    table.ForeignKey(
                        name: "FK_ReparadorEntidadReparadora_EntidadesReparadoras_EntidadRepar~",
                        column: x => x.EntidadReparadoraId,
                        principalTable: "EntidadesReparadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReparadorEntidadReparadora_Reparadores_ReparadorId",
                        column: x => x.ReparadorId,
                        principalTable: "Reparadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiciosReparadores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EntidadReparadoraId = table.Column<long>(type: "bigint", nullable: true),
                    VehiculoId = table.Column<long>(type: "bigint", nullable: true),
                    MontoManoObra = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MonedaMontoManoObraId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true),
                    KilometrajeVehiculo = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiciosReparadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiciosReparadores_EntidadesReparadoras_EntidadReparadoraId",
                        column: x => x.EntidadReparadoraId,
                        principalTable: "EntidadesReparadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiciosReparadores_Monedas_MonedaMontoManoObraId",
                        column: x => x.MonedaMontoManoObraId,
                        principalTable: "Monedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiciosReparadores_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mantenimientos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Accion = table.Column<int>(type: "int", nullable: false),
                    RecambioId = table.Column<long>(type: "bigint", nullable: true),
                    MontoRecambio = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MonedaMontoRecambioId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true),
                    ServicioReparadorId = table.Column<long>(type: "bigint", nullable: true),
                    ReparadorId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Monedas_MonedaMontoRecambioId",
                        column: x => x.MonedaMontoRecambioId,
                        principalTable: "Monedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Recambios_RecambioId",
                        column: x => x.RecambioId,
                        principalTable: "Recambios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Reparadores_ReparadorId",
                        column: x => x.ReparadorId,
                        principalTable: "Reparadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_ServiciosReparadores_ServicioReparadorId",
                        column: x => x.ServicioReparadorId,
                        principalTable: "ServiciosReparadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_LocalidadId",
                table: "Direcciones",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_EntidadesReparadoras_DireccionId",
                table: "EntidadesReparadoras",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_EntidadesReparadoras_TipoEntidadReparadoraId",
                table: "EntidadesReparadoras",
                column: "TipoEntidadReparadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_FuentesEnergia_MarcaId",
                table: "FuentesEnergia",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_FuentesEnergia_TipoFuenteEnergiaId",
                table: "FuentesEnergia",
                column: "TipoFuenteEnergiaId");

            migrationBuilder.CreateIndex(
                name: "IX_GruposModelo_MarcaId",
                table: "GruposModelo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_KitRepuesto_RepuestoId",
                table: "KitRepuesto",
                column: "RepuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_PartidoId",
                table: "Localidades",
                column: "PartidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_MonedaMontoRecambioId",
                table: "Mantenimientos",
                column: "MonedaMontoRecambioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_RecambioId",
                table: "Mantenimientos",
                column: "RecambioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_ReparadorId",
                table: "Mantenimientos",
                column: "ReparadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_ServicioReparadorId",
                table: "Mantenimientos",
                column: "ServicioReparadorId");

            migrationBuilder.CreateIndex(
                name: "IX_MarcaCategoriaMarca_MarcaId",
                table: "MarcaCategoriaMarca",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosVehiculo_AirbagsId",
                table: "ModelosVehiculo",
                column: "AirbagsId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosVehiculo_GrupoModeloId",
                table: "ModelosVehiculo",
                column: "GrupoModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosVehiculo_TipoFuenteEnergiaId",
                table: "ModelosVehiculo",
                column: "TipoFuenteEnergiaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloVehiculoAceite_ModeloVehiculoId",
                table: "ModeloVehiculoAceite",
                column: "ModeloVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloVehiculoFuenteEnergia_ModeloVehiculoId",
                table: "ModeloVehiculoFuenteEnergia",
                column: "ModeloVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloVehiculoPresionNeumatico_PresionNeumaticoId",
                table: "ModeloVehiculoPresionNeumatico",
                column: "PresionNeumaticoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloVehiculoRepuesto_RepuestoId",
                table: "ModeloVehiculoRepuesto",
                column: "RepuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Neumaticos_MarcaId",
                table: "Neumaticos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_ProvinciaId",
                table: "Partidos",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicidadesMantenimiento_ModeloVehiculoId",
                table: "PeriodicidadesMantenimiento",
                column: "ModeloVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicidadesMantenimiento_RepuestoId",
                table: "PeriodicidadesMantenimiento",
                column: "RepuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TipoDocumentoId",
                table: "Personas",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Piezas_UbicacionPiezaId",
                table: "Piezas",
                column: "UbicacionPiezaId");

            migrationBuilder.CreateIndex(
                name: "IX_PresionesNeumaticos_NeumaticoId",
                table: "PresionesNeumaticos",
                column: "NeumaticoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincias_PaisId",
                table: "Provincias",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Recambios_MarcaId",
                table: "Recambios",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReparadorEntidadReparadora_ReparadorId",
                table: "ReparadorEntidadReparadora",
                column: "ReparadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Repuestos_TargetMantenimientoId",
                table: "Repuestos",
                column: "TargetMantenimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosReparadores_EntidadReparadoraId",
                table: "ServiciosReparadores",
                column: "EntidadReparadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosReparadores_MonedaMontoManoObraId",
                table: "ServiciosReparadores",
                column: "MonedaMontoManoObraId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosReparadores_VehiculoId",
                table: "ServiciosReparadores",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_PersonaId",
                table: "Telefonos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_TipoTelefonoId",
                table: "Telefonos",
                column: "TipoTelefonoId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposCambio_MonedaDestinoId",
                table: "TiposCambio",
                column: "MonedaDestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_TiposCambio_MonedaOrigenId",
                table: "TiposCambio",
                column: "MonedaOrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ModeloVehiculoId",
                table: "Vehiculos",
                column: "ModeloVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_UsuarioId",
                table: "Vehiculos",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automoviles");

            migrationBuilder.DropTable(
                name: "Fluidos");

            migrationBuilder.DropTable(
                name: "KitRepuesto");

            migrationBuilder.DropTable(
                name: "Mantenimientos");

            migrationBuilder.DropTable(
                name: "MarcaCategoriaMarca");

            migrationBuilder.DropTable(
                name: "ModeloVehiculoAceite");

            migrationBuilder.DropTable(
                name: "ModeloVehiculoFuenteEnergia");

            migrationBuilder.DropTable(
                name: "ModeloVehiculoPresionNeumatico");

            migrationBuilder.DropTable(
                name: "ModeloVehiculoRepuesto");

            migrationBuilder.DropTable(
                name: "PeriodicidadesMantenimiento");

            migrationBuilder.DropTable(
                name: "Piezas");

            migrationBuilder.DropTable(
                name: "ReparadorEntidadReparadora");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "TiposCambio");

            migrationBuilder.DropTable(
                name: "Kits");

            migrationBuilder.DropTable(
                name: "ServiciosReparadores");

            migrationBuilder.DropTable(
                name: "CategoriasMarca");

            migrationBuilder.DropTable(
                name: "Aceites");

            migrationBuilder.DropTable(
                name: "FuentesEnergia");

            migrationBuilder.DropTable(
                name: "PresionesNeumaticos");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropTable(
                name: "UbicacionesPieza");

            migrationBuilder.DropTable(
                name: "Reparadores");

            migrationBuilder.DropTable(
                name: "TiposTelefono");

            migrationBuilder.DropTable(
                name: "EntidadesReparadoras");

            migrationBuilder.DropTable(
                name: "Monedas");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Neumaticos");

            migrationBuilder.DropTable(
                name: "Recambios");

            migrationBuilder.DropTable(
                name: "TargetsMantenimiento");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "TiposEntidadReparadora");

            migrationBuilder.DropTable(
                name: "ModelosVehiculo");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "EquipamientosAirbags");

            migrationBuilder.DropTable(
                name: "GruposModelo");

            migrationBuilder.DropTable(
                name: "TiposFuenteEnergia");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "TiposDocumento");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}

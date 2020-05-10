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
                name: "EquipamientosAirbags",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Volante = table.Column<bool>(nullable: false),
                    Guantera = table.Column<bool>(nullable: false),
                    DelanteroIzquierdo = table.Column<bool>(nullable: false),
                    DelanteroDerecho = table.Column<bool>(nullable: false),
                    TraseroIzquierdo = table.Column<bool>(nullable: false),
                    TraseroDerecho = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamientosAirbags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposDocumento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDocumento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposEntidadReparadora",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEntidadReparadora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposFuenteEnergia",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposFuenteEnergia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposTelefono",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTelefono", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UbicacionesPieza",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Izquierda = table.Column<bool>(nullable: false),
                    Superior = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UbicacionesPieza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GruposModelo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    MarcaId = table.Column<long>(nullable: true)
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
                name: "Neumaticos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MarcaId = table.Column<long>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    ConstruccionCarcasa = table.Column<int>(nullable: false),
                    RelacionAnchoAlto = table.Column<int>(nullable: true),
                    DiametroLLanta = table.Column<int>(nullable: false),
                    AnchuraSeccionalNominal = table.Column<int>(nullable: false),
                    IndiceCarga = table.Column<int>(nullable: false),
                    IndiceVelocidad = table.Column<string>(nullable: true)
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
                name: "TiposCambio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CoeficienteCambio = table.Column<decimal>(nullable: false),
                    MonedaOrigenId = table.Column<long>(nullable: true),
                    MonedaDestinoId = table.Column<long>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false)
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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    PaisId = table.Column<long>(nullable: true)
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
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    NumeroDocumento = table.Column<string>(nullable: true),
                    TipoDocumentoId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false)
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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    MarcaId = table.Column<long>(nullable: true),
                    TipoFuenteEnergiaId = table.Column<long>(nullable: true)
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
                name: "TargetsMantenimiento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    ViscosidadSAEBajaTemperatura = table.Column<int>(nullable: true),
                    ViscosidadSAEAltaTemperatura = table.Column<int>(nullable: true),
                    UbicacionPiezaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetsMantenimiento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TargetsMantenimiento_UbicacionesPieza_UbicacionPiezaId",
                        column: x => x.UbicacionPiezaId,
                        principalTable: "UbicacionesPieza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    ProvinciaId = table.Column<long>(nullable: true)
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
                name: "Telefonos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(nullable: false),
                    TipoTelefonoId = table.Column<long>(nullable: true),
                    PersonaId = table.Column<long>(nullable: true)
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
                name: "ModelosVehiculo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GrupoModeloId = table.Column<long>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    AceiteRecomendadoId = table.Column<long>(nullable: true),
                    AirbagsId = table.Column<long>(nullable: true),
                    TipoFuenteEnergiaId = table.Column<long>(nullable: true),
                    FuenteEnergiaRecomendadaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelosVehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelosVehiculo_TargetsMantenimiento_AceiteRecomendadoId",
                        column: x => x.AceiteRecomendadoId,
                        principalTable: "TargetsMantenimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModelosVehiculo_EquipamientosAirbags_AirbagsId",
                        column: x => x.AirbagsId,
                        principalTable: "EquipamientosAirbags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ModelosVehiculo_FuentesEnergia_FuenteEnergiaRecomendadaId",
                        column: x => x.FuenteEnergiaRecomendadaId,
                        principalTable: "FuentesEnergia",
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
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    CPA = table.Column<string>(nullable: true),
                    PartidoId = table.Column<long>(nullable: true)
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
                name: "PresionesNeumaticos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RuedasDelanteras = table.Column<decimal>(nullable: false),
                    RuedasTraseras = table.Column<decimal>(nullable: false),
                    EsDefault = table.Column<bool>(nullable: false),
                    ModeloVehiculoId = table.Column<long>(nullable: true),
                    NeumaticoId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresionesNeumaticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresionesNeumaticos_ModelosVehiculo_ModeloVehiculoId",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresionesNeumaticos_Neumaticos_NeumaticoId",
                        column: x => x.NeumaticoId,
                        principalTable: "Neumaticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recambios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MarcaId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    CodigoIdentificador = table.Column<string>(nullable: true),
                    TargetMantenimientoId = table.Column<long>(nullable: true),
                    ModeloVehiculoId = table.Column<long>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Recambios_ModelosVehiculo_ModeloVehiculoId",
                        column: x => x.ModeloVehiculoId,
                        principalTable: "ModelosVehiculo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recambios_TargetsMantenimiento_TargetMantenimientoId",
                        column: x => x.TargetMantenimientoId,
                        principalTable: "TargetsMantenimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModeloVehiculoId = table.Column<long>(nullable: true),
                    Kilometraje = table.Column<decimal>(nullable: false),
                    AnioFabricacion = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Patente = table.Column<string>(nullable: true),
                    NumeroChasis = table.Column<string>(nullable: true),
                    CodigoColorPintura = table.Column<string>(nullable: true)
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
                        name: "FK_Vehiculos_Personas_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Calle = table.Column<string>(nullable: true),
                    NumeroCalle = table.Column<int>(nullable: false),
                    LocalidadId = table.Column<long>(nullable: true)
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
                name: "KitRecambio",
                columns: table => new
                {
                    KitId = table.Column<long>(nullable: false),
                    RecambioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitRecambio", x => new { x.KitId, x.RecambioId });
                    table.ForeignKey(
                        name: "FK_KitRecambio_Recambios_KitId",
                        column: x => x.KitId,
                        principalTable: "Recambios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitRecambio_Recambios_RecambioId",
                        column: x => x.RecambioId,
                        principalTable: "Recambios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeriodicidadesMantenimiento",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Kilometros = table.Column<long>(nullable: false),
                    Dias = table.Column<int>(nullable: false),
                    Meses = table.Column<int>(nullable: false),
                    Anios = table.Column<int>(nullable: false),
                    ModeloVehiculoId = table.Column<long>(nullable: true),
                    TargetMantenimientoId = table.Column<long>(nullable: true),
                    EsDefault = table.Column<bool>(nullable: false)
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
                        name: "FK_PeriodicidadesMantenimiento_Recambios_TargetMantenimientoId",
                        column: x => x.TargetMantenimientoId,
                        principalTable: "Recambios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntidadesReparadoras",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    TipoEntidadReparadoraId = table.Column<long>(nullable: true),
                    DireccionId = table.Column<long>(nullable: true)
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
                    ReparadorId = table.Column<long>(nullable: false),
                    EntidadReparadoraId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReparadorEntidadReparadora", x => new { x.ReparadorId, x.EntidadReparadoraId });
                    table.ForeignKey(
                        name: "FK_ReparadorEntidadReparadora_EntidadesReparadoras_EntidadRepar~",
                        column: x => x.EntidadReparadoraId,
                        principalTable: "EntidadesReparadoras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReparadorEntidadReparadora_Personas_ReparadorId",
                        column: x => x.ReparadorId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiciosReparadores",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    EntidadReparadoraId = table.Column<long>(nullable: true),
                    VehiculoId = table.Column<long>(nullable: true),
                    MontoManoObra = table.Column<decimal>(nullable: false),
                    MonedaMontoManoObraId = table.Column<long>(nullable: true),
                    KilometrajeVehiculo = table.Column<decimal>(nullable: false)
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
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Accion = table.Column<int>(nullable: false),
                    RecambioId = table.Column<long>(nullable: true),
                    MontoRecambio = table.Column<decimal>(nullable: false),
                    MonedaMontoRecambioId = table.Column<long>(nullable: true),
                    ServicioReparadorId = table.Column<long>(nullable: true),
                    ReparadorId = table.Column<long>(nullable: true)
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
                        name: "FK_Mantenimientos_Personas_ReparadorId",
                        column: x => x.ReparadorId,
                        principalTable: "Personas",
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
                name: "IX_KitRecambio_RecambioId",
                table: "KitRecambio",
                column: "RecambioId");

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
                name: "IX_ModelosVehiculo_AceiteRecomendadoId",
                table: "ModelosVehiculo",
                column: "AceiteRecomendadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosVehiculo_AirbagsId",
                table: "ModelosVehiculo",
                column: "AirbagsId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosVehiculo_FuenteEnergiaRecomendadaId",
                table: "ModelosVehiculo",
                column: "FuenteEnergiaRecomendadaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosVehiculo_GrupoModeloId",
                table: "ModelosVehiculo",
                column: "GrupoModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelosVehiculo_TipoFuenteEnergiaId",
                table: "ModelosVehiculo",
                column: "TipoFuenteEnergiaId");

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
                name: "IX_PeriodicidadesMantenimiento_TargetMantenimientoId",
                table: "PeriodicidadesMantenimiento",
                column: "TargetMantenimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TipoDocumentoId",
                table: "Personas",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PresionesNeumaticos_ModeloVehiculoId",
                table: "PresionesNeumaticos",
                column: "ModeloVehiculoId");

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
                name: "IX_Recambios_ModeloVehiculoId",
                table: "Recambios",
                column: "ModeloVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recambios_TargetMantenimientoId",
                table: "Recambios",
                column: "TargetMantenimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_ReparadorEntidadReparadora_EntidadReparadoraId",
                table: "ReparadorEntidadReparadora",
                column: "EntidadReparadoraId");

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
                name: "IX_TargetsMantenimiento_UbicacionPiezaId",
                table: "TargetsMantenimiento",
                column: "UbicacionPiezaId");

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
                name: "KitRecambio");

            migrationBuilder.DropTable(
                name: "Mantenimientos");

            migrationBuilder.DropTable(
                name: "PeriodicidadesMantenimiento");

            migrationBuilder.DropTable(
                name: "PresionesNeumaticos");

            migrationBuilder.DropTable(
                name: "ReparadorEntidadReparadora");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "TiposCambio");

            migrationBuilder.DropTable(
                name: "ServiciosReparadores");

            migrationBuilder.DropTable(
                name: "Recambios");

            migrationBuilder.DropTable(
                name: "Neumaticos");

            migrationBuilder.DropTable(
                name: "TiposTelefono");

            migrationBuilder.DropTable(
                name: "EntidadesReparadoras");

            migrationBuilder.DropTable(
                name: "Monedas");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "TiposEntidadReparadora");

            migrationBuilder.DropTable(
                name: "ModelosVehiculo");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "TargetsMantenimiento");

            migrationBuilder.DropTable(
                name: "EquipamientosAirbags");

            migrationBuilder.DropTable(
                name: "FuentesEnergia");

            migrationBuilder.DropTable(
                name: "GruposModelo");

            migrationBuilder.DropTable(
                name: "TiposDocumento");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "UbicacionesPieza");

            migrationBuilder.DropTable(
                name: "TiposFuenteEnergia");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Provincias");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using SiMaVeh.DataAccess.DataSeed.Seeders.Interfaces;
using SiMaVeh.DataAccess.Model.Relations;
using SiMaVeh.Domain.Models;

namespace SiMaVeh.DataAccess.DataSeed
{
    /// <summary>
    /// Data seeder
    /// </summary>
    public class DataSeeder : IDataSeeder
    {
        private readonly IDomainSeeder<Pais, long> paisSeeder;
        private readonly IDomainSeeder<Provincia, long> provinciaSeeder;
        private readonly IDomainSeeder<Partido, long> partidoSeeder;
        private readonly IDomainSeeder<Localidad, long> localidadSeeder;
        private readonly IDomainSeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder;
        private readonly IDomainSeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder;
        private readonly IDomainSeeder<TipoDocumento, long> tipoDocumentoSeeder;
        private readonly IDomainSeeder<TipoTelefono, long> tipoTelefonoSeeder;
        private readonly IDomainSeeder<UbicacionPieza, string> ubicacionPiezaSeeder;
        private readonly IDomainSeeder<EquipamientoAirbags, string> equipamientoAirbagsSeeder;
        private readonly IDomainSeeder<Moneda, string> monedaSeeder;
        private readonly IDomainSeeder<CategoriaMarca, long> categoriaMarcaSeeder;
        private readonly IDomainSeeder<Marca, long> marcaSeeder;
        private readonly ISeeder<MarcaCategoriaMarca> marcaCategoriaMarcaSeeder;
        private readonly IDomainSeeder<FuenteEnergia, long> fuenteEnergiaSeeder;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="paisSeeder"></param>
        /// <param name="provinciaSeeder"></param>
        /// <param name="partidoSeeder"></param>
        /// <param name="localidadSeeder"></param>
        /// <param name="tipoEntidadReparadoraSeeder"></param>
        /// <param name="tipoFuenteEnergiaSeeder"></param>
        /// <param name="tipoDocumentoSeeder"></param>
        /// <param name="tipoTelefonoSeeder"></param>
        /// <param name="ubicacionPiezaSeeder"></param>
        /// <param name="equipamientoAirbagsSeeder"></param>
        /// <param name="monedaSeeder"></param>
        /// <param name="categoriaMarcaSeeder"></param>
        /// <param name="marcaSeeder"></param>
        /// <param name="marcaCategoriaMarcaSeeder"></param>
        /// <param name="fuenteEnergiaSeeder"></param>
        public DataSeeder(IDomainSeeder<Pais, long> paisSeeder,
            IDomainSeeder<Provincia, long> provinciaSeeder,
            IDomainSeeder<Partido, long> partidoSeeder,
            IDomainSeeder<Localidad, long> localidadSeeder,
            IDomainSeeder<TipoEntidadReparadora, long> tipoEntidadReparadoraSeeder,
            IDomainSeeder<TipoFuenteEnergia, long> tipoFuenteEnergiaSeeder,
            IDomainSeeder<TipoDocumento, long> tipoDocumentoSeeder,
            IDomainSeeder<TipoTelefono, long> tipoTelefonoSeeder,
            IDomainSeeder<UbicacionPieza, string> ubicacionPiezaSeeder,
            IDomainSeeder<EquipamientoAirbags, string> equipamientoAirbagsSeeder,
            IDomainSeeder<Moneda, string> monedaSeeder,
            IDomainSeeder<CategoriaMarca, long> categoriaMarcaSeeder,
            IDomainSeeder<Marca, long> marcaSeeder,
            ISeeder<MarcaCategoriaMarca> marcaCategoriaMarcaSeeder,
            IDomainSeeder<FuenteEnergia, long> fuenteEnergiaSeeder)
        {
            this.paisSeeder = paisSeeder;
            this.provinciaSeeder = provinciaSeeder;
            this.partidoSeeder = partidoSeeder;
            this.localidadSeeder = localidadSeeder;
            this.tipoEntidadReparadoraSeeder = tipoEntidadReparadoraSeeder;
            this.tipoFuenteEnergiaSeeder = tipoFuenteEnergiaSeeder;
            this.tipoDocumentoSeeder = tipoDocumentoSeeder;
            this.tipoTelefonoSeeder = tipoTelefonoSeeder;
            this.ubicacionPiezaSeeder = ubicacionPiezaSeeder;
            this.equipamientoAirbagsSeeder = equipamientoAirbagsSeeder;
            this.monedaSeeder = monedaSeeder;
            this.marcaSeeder = marcaSeeder;
            this.categoriaMarcaSeeder = categoriaMarcaSeeder;
            this.marcaCategoriaMarcaSeeder = marcaCategoriaMarcaSeeder;
            this.fuenteEnergiaSeeder = fuenteEnergiaSeeder;
        }

        /// <summary>
        /// Seed data
        /// </summary>
        /// <param name="builder"></param>
        public void SeedData(ModelBuilder builder)
        {
            //Para poder aplicar efectivamente los Seeds, hay que generar migrations.
            builder.Entity<Pais>().HasData(paisSeeder.GetSeeds());
            builder.Entity<Provincia>().HasData(provinciaSeeder.GetSeeds());
            builder.Entity<Partido>().HasData(partidoSeeder.GetSeeds());
            builder.Entity<Localidad>().HasData(localidadSeeder.GetSeeds());
            builder.Entity<TipoEntidadReparadora>().HasData(tipoEntidadReparadoraSeeder.GetSeeds());
            builder.Entity<TipoFuenteEnergia>().HasData(tipoFuenteEnergiaSeeder.GetSeeds());
            builder.Entity<TipoDocumento>().HasData(tipoDocumentoSeeder.GetSeeds());
            builder.Entity<TipoTelefono>().HasData(tipoTelefonoSeeder.GetSeeds());
            builder.Entity<UbicacionPieza>().HasData(ubicacionPiezaSeeder.GetSeeds());
            builder.Entity<EquipamientoAirbags>().HasData(equipamientoAirbagsSeeder.GetSeeds());
            builder.Entity<Moneda>().HasData(monedaSeeder.GetSeeds());
            builder.Entity<CategoriaMarca>().HasData(categoriaMarcaSeeder.GetSeeds());
            builder.Entity<Marca>().HasData(marcaSeeder.GetSeeds());
            builder.Entity<MarcaCategoriaMarca>().HasData(marcaCategoriaMarcaSeeder.GetSeeds());
            builder.Entity<FuenteEnergia>().HasData(fuenteEnergiaSeeder.GetSeeds());
        }
    }
}

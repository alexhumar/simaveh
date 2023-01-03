INSERT INTO GruposModelo (Id, Nombre, MarcaId) VALUES (1, "206", 492);

INSERT INTO ModelosVehiculo (Id, GrupoModeloId, Version, TipoFuenteEnergiaId) VALUES (1, 1, "XT", 6);
INSERT INTO ModelosVehiculo (Id, GrupoModeloId, Version, TipoFuenteEnergiaId) VALUES (2, 1, "XS", 6);

INSERT INTO TargetsMantenimiento (Id, Nombre, Descripcion) VALUES (1, "Parrilla", "Parrilla de suspension");
INSERT INTO TargetsMantenimiento (Id, Nombre, Descripcion) VALUES (2, "Radiador", "Radiador del circuito de refrigeracion");
INSERT INTO TargetsMantenimiento (Id, Nombre, Descripcion) VALUES (3, "Aceite", "Aceite multigrado");

INSERT INTO Piezas (Id) VALUES (1);
INSERT INTO Piezas (Id) VALUES (2);
INSERT INTO Aceites (Id, ViscosidadSAEBajaTemperatura, ViscosidadSAEAltaTemperatura) VALUES (3, 10, 40);

INSERT INTO Recambios (Id, MarcaId) VALUES (1, 357);
INSERT INTO Recambios (Id, MarcaId) VALUES (2, 357);
INSERT INTO Recambios (Id, MarcaId) VALUES (3, 357);

INSERT INTO Repuestos (Id, CodigoIdentificador, TargetMantenimientoId) VALUES (1, "PARRVALEO123", 1);
INSERT INTO Repuestos (Id, CodigoIdentificador, TargetMantenimientoId) VALUES (2, "RADVALEO123", 2);
INSERT INTO Kits (Id, Nombre, Descripcion) VALUES (3, "Kit radiador + parrilla valeo", "Kit radiador + parrilla valeo");

INSERT INTO KitRepuesto (KitId, RepuestoId) VALUES (3, 1);
INSERT INTO KitRepuesto (KitId, RepuestoId) VALUES (3, 2);

INSERT INTO ModeloVehiculoRepuesto (ModeloVehiculoId, RepuestoId) VALUES (1, 1);
INSERT INTO ModeloVehiculoRepuesto (ModeloVehiculoId, RepuestoId) VALUES (1, 2);

INSERT INTO Neumaticos (Id, MarcaId, Modelo, Tipo, ConstruccionCarcasa, RelacionAnchoAlto, DiametroLLanta, AnchuraSeccionalNominal, IndiceCarga, IndiceVelocidad) VALUES (1, 108, "P6", 1, 2, 82, 14, 185, 60, "H");

INSERT INTO PresionesNeumaticos (Id, RuedasDelanteras, RuedasTraseras, VehiculoCargado, NeumaticoId) VALUES (1, 30, 30, 0, 1);

INSERT INTO ModeloVehiculoAceite (ModeloVehiculoId, AceiteId) VALUES (1, 3);

INSERT INTO ModeloVehiculoFuenteEnergia (ModeloVehiculoId, FuenteEnergiaId) VALUES (1, 27);

INSERT INTO ModeloVehiculoPresionNeumatico (ModeloVehiculoId, PresionNeumaticoId) VALUES (1, 1);

INSERT INTO Direcciones (Id, Calle, NumeroCalle, LocalidadId) VALUES (1, "Centenario", 5070, 715);
INSERT INTO Direcciones (Id, Calle, NumeroCalle, LocalidadId) VALUES (2, "Brasil", 436, 715);

INSERT INTO EntidadesReparadoras (Id, Nombre, TipoEntidadReparadoraId, DireccionId) VALUES (1, "Tallersito mecanico de Pepe", 1, 1);
INSERT INTO EntidadesReparadoras (Id, Nombre, TipoEntidadReparadoraId, DireccionId) VALUES (2, "Tallersito mecanico de Juan", 1, 2);

INSERT INTO Personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId) VALUES (1, 'Alex', 'Humar', '35401961', 1);
INSERT INTO Personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId) VALUES (2, 'Pepe', 'Lepeu', '36231256', 1);
INSERT INTO Personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId) VALUES (3, 'Rocio', 'Sanchez', '37256497', 1);

INSERT INTO Reparadores(Id) VALUES (1);
INSERT INTO Reparadores(Id) VALUES (2);

INSERT INTO Usuarios(Id) VALUES (3);

INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (1, 1);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (1, 2);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (2, 1);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (2, 2);

INSERT INTO Vehiculos (Id, ModeloVehiculoId, Kilometraje, AnioFabricacion, UsuarioId) VALUES (1, 1, 0, 2008, 3);
INSERT INTO Automoviles (Id, Patente, NumeroChasis, CodigoColorPintura) VALUES (1, 'HFC396', '32445234324', 'H324CC');

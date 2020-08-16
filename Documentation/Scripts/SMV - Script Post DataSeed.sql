INSERT INTO gruposmodelo (Id, Nombre, MarcaId) VALUES (1, "206", 492);

INSERT INTO modelosvehiculo (Id, GrupoModeloId, Version, TipoFuenteEnergiaId) VALUES (1, 1, "XT", 6);
INSERT INTO modelosvehiculo (Id, GrupoModeloId, Version, TipoFuenteEnergiaId) VALUES (2, 1, "XS", 6);

INSERT INTO targetsmantenimiento (Id, Nombre, Descripcion, Tipo) VALUES (1, "Parrilla", "Parrilla de suspension", "P");
INSERT INTO targetsmantenimiento (Id, Nombre, Descripcion, Tipo) VALUES (2, "Radiador", "Radiador del circuito de refrigeracion", "P");
INSERT INTO targetsmantenimiento (Id, Nombre, Descripcion, Tipo, ViscosidadSAEBajaTemperatura, ViscosidadSAEAltaTemperatura) VALUES (3, "Aceite", "Aceite multigrado", "A", 10, 40);

INSERT INTO recambios (Id, MarcaId, CodigoIdentificador, Tipo, TargetMantenimientoId) VALUES (1, 357, "PARRVALEO123", "R", 1);
INSERT INTO recambios (Id, MarcaId, CodigoIdentificador, Tipo, TargetMantenimientoId) VALUES (2, 357, "RADVALEO123", "R", 2);
INSERT INTO recambios (Id, MarcaId, Tipo, Nombre, Descripcion) VALUES (3, 357, "K", "Kit radiador + parrilla valeo", "Kit radiador + parrilla valeo");

INSERT INTO kitrepuesto (KitId, RepuestoId) VALUES (3, 1);
INSERT INTO kitrepuesto (KitId, RepuestoId) VALUES (3, 2);

INSERT INTO modelovehiculorepuesto (ModeloVehiculoId, RepuestoId) VALUES (1, 1);
INSERT INTO modelovehiculorepuesto (ModeloVehiculoId, RepuestoId) VALUES (1, 2);

INSERT INTO neumaticos (Id, MarcaId, Modelo, Tipo, ConstruccionCarcasa, RelacionAnchoAlto, DiametroLLanta, AnchuraSeccionalNominal, IndiceCarga, IndiceVelocidad) VALUES (1, 108, "P6", 1, 2, 82, 14, 185, 60, "H");

INSERT INTO presionesneumaticos (Id, RuedasDelanteras, RuedasTraseras, VehiculoCargado, NeumaticoId) VALUES (1, 30, 30, 0, 1);

INSERT INTO modelovehiculoaceite (ModeloVehiculoId, AceiteId) VALUES (1, 3);

INSERT INTO modelovehiculofuenteenergia (ModeloVehiculoId, FuenteEnergiaId) VALUES (1, 27);

INSERT INTO modelovehiculopresionneumatico (ModeloVehiculoId, PresionNeumaticoId) VALUES (1, 1);

INSERT INTO direcciones (Id, Calle, NumeroCalle, LocalidadId) VALUES (1, "Centenario", 5070, 715);
INSERT INTO direcciones (Id, Calle, NumeroCalle, LocalidadId) VALUES (2, "Brasil", 436, 715);

INSERT INTO entidadesreparadoras (Id, Nombre, TipoEntidadReparadoraId, DireccionId) VALUES (1, "Tallersito mecanico de Pepe", 1, 1);
INSERT INTO entidadesreparadoras (Id, Nombre, TipoEntidadReparadoraId, DireccionId) VALUES (2, "Tallersito mecanico de Juan", 1, 2);

INSERT INTO personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId, Tipo) VALUES (1, 'Alex', 'Humar', '35401961', 1, 'R');
INSERT INTO personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId, Tipo) VALUES (2, 'Pepe', 'Lepeu', '36231256', 1, 'R');
INSERT INTO personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId, Tipo) VALUES (3, 'Rocio', 'Sanchez', '37256497', 1, 'U');

INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (1, 1);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (1, 2);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (2, 1);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (2, 2);

INSERT INTO vehiculos (Id, ModeloVehiculoId, Kilometraje, AnioFabricacion, UsuarioId, Tipo, Patente, NumeroChasis, CodigoColorPintura) VALUES (1, 1, 0, 2008, 3, 'A', 'HFC396', '32445234324', 'H324CC');
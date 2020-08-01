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
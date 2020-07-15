INSERT INTO gruposmodelo (Id, Nombre, MarcaId) VALUES (1, "206", 492);
INSERT INTO modelosvehiculo (Id, GrupoModeloId, Version, TipoFuenteEnergiaId) VALUES (1, 1, "XT", 6);
INSERT INTO targetsmantenimiento (Id, Nombre, Descripcion, Tipo) VALUES (1, "Parrilla", "Parrilla de suspension", "P");
INSERT INTO targetsmantenimiento (Id, Nombre, Descripcion, Tipo) VALUES (2, "Radiador", "Radiador del circuito de refrigeracion", "P");
INSERT INTO recambios (Id, MarcaId, CodigoIdentificador, Tipo, TargetMantenimientoId, ModeloVehiculoId) VALUES (1, 357, "PARRVALEO123", "R", 1,  1);
INSERT INTO recambios (Id, MarcaId, CodigoIdentificador, Tipo, TargetMantenimientoId, ModeloVehiculoId) VALUES (2, 357, "RADVALEO123", "R", 2,  1);
INSERT INTO recambios (Id, MarcaId, Tipo, Nombre, Descripcion) VALUES (3, 357, "K", "Kit radiador + parrilla valeo", "Kit radiador + parrilla valeo");
INSERT INTO kitrepuesto (KitId, RepuestoId) VALUES (3, 1);
INSERT INTO kitrepuesto (KitId, RepuestoId) VALUES (3, 2);
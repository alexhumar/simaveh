INSERT INTO gruposmodelo (Id, Nombre, MarcaId) VALUES (1, "206", 492);
INSERT INTO modelosvehiculo (Id, GrupoModeloId, Version, TipoFuenteEnergiaId) VALUES (1, 1, "XT", 6);
INSERT INTO targetsmantenimiento (Id, Nombre, Descripcion, Discriminator) VALUES (1, "Parrilla", "Parrilla de suspension", "Pieza");
INSERT INTO targetsmantenimiento (Id, Nombre, Descripcion, Discriminator) VALUES (2, "Radiador", "Radiador del circuito de refrigeracion", "Pieza");
INSERT INTO recambios (Id, MarcaId, CodigoIdentificador, Discriminator, TargetMantenimientoId, ModeloVehiculoId) VALUES (1, 357, "PARRVALEO123", "Repuesto", 1,  1);
INSERT INTO recambios (Id, MarcaId, CodigoIdentificador, Discriminator, TargetMantenimientoId, ModeloVehiculoId) VALUES (2, 357, "RADVALEO123", "Repuesto", 2,  1);
INSERT INTO recambios (Id, MarcaId, Discriminator, Nombre, Descripcion) VALUES (3, 357, "Kit", "Kit radiador + parrilla valeo", "Kit radiador + parrilla valeo");
INSERT INTO kitrecambio (KitId, RecambioId) VALUES (3, 1);
INSERT INTO kitrecambio (KitId, RecambioId) VALUES (3, 2);
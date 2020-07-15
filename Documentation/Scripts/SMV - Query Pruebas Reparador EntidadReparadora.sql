/*Las pruebas basicas de relacion many to many entre Reparadores y EntidadesReparadoras salio OK!*/

INSERT INTO direcciones (Id, Calle, NumeroCalle, LocalidadId) VALUES (1, "Centenario", 5070, 715);
INSERT INTO direcciones (Id, Calle, NumeroCalle, LocalidadId) VALUES (2, "Brasil", 436, 715);

INSERT INTO entidadesreparadoras (Id, Nombre, TipoEntidadReparadoraId, DireccionId) VALUES (1, "Tallersito mecanico de Pepe", 1, 1);
INSERT INTO entidadesreparadoras (Id, Nombre, TipoEntidadReparadoraId, DireccionId) VALUES (2, "Tallersito mecanico de Juan", 1, 2);

INSERT INTO personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId, Tipo) VALUES (1, 'Alex', 'Humar', '35401961', 1, 'R');
INSERT INTO personas (Id, Nombre, Apellido, NumeroDocumento, TipoDocumentoId, Tipo) VALUES (2, 'Pepe', 'Lepeu', '36231256', 1, 'R');

INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (1, 1);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (1, 2);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (2, 1);
INSERT INTO ReparadorEntidadReparadora (ReparadorId, EntidadReparadoraId) VALUES (2, 2);
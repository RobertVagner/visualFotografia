select *
from TipoEvento

select *
from Cliente

select *
from Usuario

select *
from FaseEvento

select *
from Evento

SET IDENTITY_INSERT	TipoEvento ON;
DECLARE @codTipoEvento INT SET @codTipoEvento = IDENT_CURRENT('TipoEvento')
insert into FaseEvento(descricao, codTipoEvento) values ('TESTANDO, testeabd', @codTipoEvento)
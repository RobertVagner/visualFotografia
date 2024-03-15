select *
from Usuario

select *
from TipoEvento

select *
from Cliente
select *
from Evento
select *
from StatusFaseEvento
Delete StatusFaseEvento where codEvento = (select codEvento from Evento where codCliente = 1029)
SELECT e.qualHD, e.dataEntrega, e.dataEvento, e.editor, e.fezBackup, e.envoiDados, e.statusLegenda, 
s.status FROM Evento e inner join StatusFaseEvento s on e.codEvento = s.codEvento where e.codCliente=1018
SELECT status FROM StatusFaseEvento where codEvento=21
select *
from Cliente
Select * from dbo.tabEvento_Mostra where Status != 'Finalizada' order by Data DESC
Delete StatusFaseEvento  where codEvento = (select codEvento from Evento where codCliente = 1017)
Delete Cliente where codCliente = 1016
Delete Evento where codCliente = 1016

delete Cliente where codCliente!= 4;
SELECT Senha, Login from Usuario where codUsuario = 2 
delete Evento
select codEvento from Evento where codCliente =1027
SELECT CodTipoEvento  FROM Evento e inner join StatusFaseEvento s on e.codEvento = s.codEvento where codCliente=1028
SELECT fe.descricao, e.qualHD, e.dataEntrega, e.dataEvento, c.nomeCliente, c.descricao, c.cpfCnpj
FROM Evento e inner join Cliente c on e.codCliente = c.codCliente  inner join TipoEvento te on e.codTipoEvento = te.codTipoEvento
inner join FaseEvento fe on te.codTipoEvento = fe.codTipoEvento WHERE codEvento=11

SELECT e.qualHD, e.dataEntrega, e.dataEvento, c.nomeCliente, c.cpfCnpj
                        FROM Evento e inner join Cliente c on e.codCliente = c.codCliente
                        inner join TipoEvento te on e.codTipoEvento = te.codTipoEvento where e.codCliente=1

select *
from FaseEvento

DECLARE @codTipoEvento INT SET @codTipoEvento = IDENT_CURRENT('TipoEvento')
print @codTipoEvento
DECLARE @codCliente INT SET @codCliente = IDENT_CURRENT('Cliente')
print @codCliente
DECLARE @codUsuario INT SET @codUsuario = IDENT_CURRENT('Usuario')
print @codUsuario

select e.codUsuario as Nome, c.nomeCliente as Cliente, c.descricaoc as Descrição, c.cpfCnpj as CPF_CNPJ, te.descricao as 'Tipo de Evento', e.dataEvento as 'Data', e.envoiDados as Dados, e.statusLegenda as Legenda, e.fezBackup as 'Backup', e.qualHD as HD,e.dataEntrega as 'Prazo de Entrega', e.editor as Editor, sfe.status as Status
from Cliente c inner join Evento e on c.codCliente = e.codCliente
				inner join TipoEvento te on e.codTipoEvento = te.codTipoEvento
				inner join StatusFaseEvento sfe on e.codEvento = sfe.codEvento
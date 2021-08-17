
use master
DROP DATABASE IF EXISTS bdFutbol;
create  database bdFutbol;

go
use bdFutbol;
go

create table ligas(
	codLiga char(5),
	nomLiga varchar(50),
	constraint pkLigas  primary Key (codLiga)
);


create table equipos(
	codEquipo int identity(1,1),
	nomEquipo varchar(40),
	codLiga char(5),
	localidad varchar(60),
	internacional bit default 0 not null,
	constraint pkEquipos primary key (codEquipo),
	constraint fkEquipo_CodLiga foreign key (codLiga) references ligas (codLiga));
	
create table futbolistas(
	coddnionie char(9),
	nombre varchar(50),
	nacionalidad varchar(40),
	constraint pkFutbolistas primary key (coddnionie)
);





create table contratos(
	codcontrato int identity(1,1),
	coddnionie char (9),
	codEquipo int,
	fechaInicio date,
	fechaFin date,
	precioanual int,
	preciorecision int,
	constraint pkContratos primary key(codcontrato),
	constraint fkContratos_futbolistas foreign key (coddnionie) references futbolistas(coddnionie),
	constraint fkContratos_equipos foreign key (codEquipo) references equipos(codEquipo)
);

insert into ligas VALUES('LFP00', 'LIGA DE FÚTBOL PROFESIONAL');
insert into ligas values('PREM0', 'PREMIER LEAGUE');
insert into ligas values('SERIA', 'SERIE A');

insert into equipos VALUES( 'EQUIPO 1', 'LFP00', 'BARCELONA', 1);
insert into equipos VALUES( 'EQUIPO 2', 'LFP00', 'MADRID', 1);
insert into equipos VALUES( 'EQUIPO 3', 'PREM0', 'MANCHESTER', 1);
insert into equipos VALUES( 'EQUIPO 4', 'SERIA', 'MILAN', 1);

insert into futbolistas VALUES( '123456789', 'FUTBOLISTA 1', 'ESPAÑA');
insert into futbolistas VALUES( '123456389', 'FUTBOLISTA 2', 'ALEMANIA');
insert into futbolistas VALUES( '123412789', 'FUTBOLISTA 3', 'ESPAÑA');
insert into futbolistas VALUES( '122412789', 'FUTBOLISTA 4', 'ITALIA');

insert into contratos VALUES( '123456789', 1, '01/01/2018', '01/10/2024', 20000000, 5000000);
insert into contratos VALUES( '123456789', 1, '01/01/2014', '01/01/2018', 2000000, 500000);
insert into contratos VALUES( '123456389', 1, '01/01/2019', '01/08/2021', 320000, 50008);
insert into contratos VALUES( '123412789', 2, '01/01/2004', '01/01/2016', 5130000, 721415);
insert into contratos VALUES( '122412789', 2, '01/01/2004', '01/01/2016', 5130000, 721415);


go

/*
Hacer una función que devuelva los nombres de los equipos que pertenecen a una determinada liga que le pasamos por parámetro de entrada, si la liga no existe deberá aparecer liga no existe.
*/

create function equipos_liga(@codLiga char(5))
	returns  @equipos table (nomEquipo varchar(50))
	as
	begin
		if exists (select * from ligas
						where ligas.codLiga=@codLiga)
			
			insert into @equipos select equipos.nomEquipo from ligas			
									inner join equipos on equipos.codLiga=ligas.codLiga
									where ligas.codLiga=@codLiga	
		else 
			insert into @equipos values('liga no existente')
		return
	end
go

select * from DBO.equipos_liga('LIGA DE FÚTBOL PROFESIONAL')
select * from DBO.equipos_liga('LIGA DE FÚTBOL dsfdsfssf')
go
/*
 Crear un procedimiento almacenado que indicándole un equipo, precio anual y un precio recisión,
devuelva dos parámetros. En un parámetro de salida la cantidad de futbolistas en activo (con contrato
vigente) que hay en dicho equipo. En otro parámetro de salida la cantidad de futbolistas en activo de
dicho equipo con precio anual y de recisión menor de los indicados.
*/

create procedure consulta_contratos @equipo int, @precio_anual int, @precio_recision int, @futbolistas_activos int output, @futbolistas_activos_condiciones int output
	as
	begin
		set @futbolistas_activos= (select COUNT(contratos.codcontrato) from contratos
				where contratos.codEquipo=1 and GETDATE()<contratos.fechaFin
				);
		
		set @futbolistas_activos_condiciones=(select COUNT(contratos.codcontrato) from contratos
				where contratos.codEquipo=1 and GETDATE()<contratos.fechaFin and contratos.precioanual<@precio_anual and contratos.preciorecision=@precio_recision
		);
	end
go
/*
declare  @numero_activos INT , @numero_consultado INT 
	exec consulta_contratos 1,5130000 ,500000, @numero_activos output, @numero_consultado output
	select @numero_activos, @numero_consultado
	*/
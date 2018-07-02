create database LojaOleo
use LojaOleo

create table Usuario
(
	codigo int primary key identity (1,1),
	email varchar (100),
	senha varchar (100)
);

create table Oleo
(
	codigo int primary key identity (1,1),
	nome varchar (100),
	categoria varchar (100),
	tipo varchar (100),
	fabricante varchar (100),
	valor decimal (5,2)
);

create table Cliente
(
	codigo int primary key identity (1,1),
	nome varchar (100),
	veiculo varchar (100),
	placa varchar (100),
	email varchar (100)
);

create table TrocaOleo
(
	codigo int primary key identity (1,1),
	data date,
	codigo_cliente int foreign key references Cliente (codigo),
	codigo_oleo int foreign key references Oleo (codigo),
	qtde_litros decimal (6,2)
);

select * from Usuario;
select * from Oleo;
select * from Cliente;
select * from TrocaOleo;

bulk insert Usuario
from 'E:\Programação de app\LojaOleo\Usuarios.txt'
with
(
	codepage = 'ACP',
	fieldterminator = ';'
);

bulk insert Oleo
from 'E:\Programação de app\LojaOleo\Oleos.txt'
with
(
	codepage = 'ACP',
	fieldterminator = ';'
);

bulk insert Cliente
from 'E:\Programação de app\LojaOleo\Clientes.txt'
with
(
	codepage = 'ACP',
	fieldterminator = ';'
);

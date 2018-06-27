-- criando base de dados
CREATE DATABASE trabalhoLuis

use trabalhoLuis

create table clientes
(
codigo integer primary key,
nome varchar(100),
veiculo varchar(100),
placa varchar(100),
email varchar(100)
)

bulk insert clientes
from 'C:\Users\win10\Downloads\TrabalhoLuis-master\TrabalhoLuis-master\Clientes.txt'
with(
	CODEPAGE='ACP',
	FIELDTERMINATOR = ';',
	firstrow = 2
)

create table oleos
(
codigo integer primary key,
nome varchar(100),
categoria varchar(100),
tipo varchar(100),
fabricante varchar(100),
valor decimal(10,2)
)

bulk insert oleos
from 'C:\Users\win10\Downloads\TrabalhoLuis-master\TrabalhoLuis-master\Oleos.txt'
with(
	CODEPAGE='ACP',
	FIELDTERMINATOR = ';',
	firstrow = 2
)
create table usuario
(
codigo integer primary key identity(1,1),
email varchar(100),
senha varchar(100)
)

bulk insert usuario
from 'C:\Users\win10\Downloads\TrabalhoLuis-master\TrabalhoLuis-master\usuarios.txt'
with(
	CODEPAGE='ACP',
	FIELDTERMINATOR   = ';',
	firstrow = 2
)

select * from clientes;

select * from usuario;

select * from controleTroca;

select * from oleos;


create table controleTroca(
codigo int primary key identity(1,1),
data_troca datetime,
nome_cliente varchar(100),
nome_oleo varchar(100),
categoria_oleo varchar(100),
tipo_oleo varchar(100),
fabricante varchar(100),
valor_oleo decimal(10,3),
qtd_oleo decimal(10,3),
vlr_total decimal(10,2),
email_cliente varchar(100))
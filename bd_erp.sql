drop database mini_erp;
create database mini_erp;
use mini_erp;

create table fornecedor
(
	id integer primary key identity,
	nome varchar(50) not null unique
);

create table produto
(
	id integer primary key identity,
	nome varchar(60) not null,
	quantidade int not null,
	descricao varchar(200),
	preco decimal(6,2) not null,
	fk_fornecedor integer not null,
	foreign key(fk_fornecedor) references fornecedor(id)
);


create table cliente
(
	id integer primary key identity,
	nome varchar(60) not null,
	dataNascimento varchar(10),
	telefone varchar(16),
	sexo varchar(15)
)

create table pedido
(
	id integer primary key identity,
	total decimal(6,2),
	dataCompra datetime,
	fk_cliente integer not null,
	foreign key(fk_cliente) references cliente(id),
);

create table itempedido
(
	id integer primary key identity,
	quantidadeComprada int,
	valorUnitario decimal(6,2),
	valorTotal decimal(6,2),
	fk_produto integer not null,
	foreign key(fk_produto) references produto(id),
	fk_pedido integer not null,
	foreign key(fk_pedido) references pedido(id)
);

create login usuario3 with password='senha1234';
create user usuario3 from login usuario3;
exec sp_addrolemember 'DB_DATAREADER', 'usuario3';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario3';

insert into fornecedor(nome)
values('Fornecedor A'),
('Fornecedor B'),
('Fornecedor C'),
('Fornecedor D'),
('Fornecedor E'),
('Fornecedor F'),
('Fornecedor G'),
('Fornecedor H'),
('Fornecedor I'),
('Fornecedor J'),
('Fornecedor K'),
('Fornecedor L'),
('Fornecedor M'),
('Fornecedor N'),
('Fornecedor O');

insert into produto(nome,quantidade,preco,fk_fornecedor)
values('Leite Integral',64,3.90,6),
('Arroz',100,23.0,9),
('Feijão',88,8.99,1),
('Bolacha recheada',205,4.30,1),
('Bolacha recheada',55,3.90,9),
('Leite Integral',154,3.70,5),
('Caixa de ovos 30un',88,18.90,8),
('Margarina 500g',78,7.90,4),
('Margarina 500g',66,7.50,2),
('Leite Integral',160,4.10,2),
('Arroz',25,19.90,1),
('Feijão',97,8.19,7),
('Caixa de ovos 30un',108,20.90,6),
('Açúcar',100,5.90,10),
('Açúcar',55,3.90,11),
('Leite Integral',64,3.50,12);

insert into cliente(nome)
values('Beatriz'),
('Alice'),
('Helena'),
('Isabela'),
('Júlia'),
('Artur'),
('Bernardo'),
('Davi'),
('Gabriel'),
('Lucas'),
('Antônio'),
('Breno'),
('Cauã'),
('João'),
('Luan');
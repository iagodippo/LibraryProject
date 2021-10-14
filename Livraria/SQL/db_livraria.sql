-- criando banco de dados db_livraria
create database db_livraria

-- informando qual banco de dados desejo trabalhar
use db_livraria

create table tbl_atendente
( 
	cd_Atendente int primary key identity,
	ds_Login varchar(20) not null,
	ds_Senha varchar(8) not null,
	nm_Atendente varchar(60) not null
)

-- insira na tabela atendente
insert into tbl_atendente
(ds_Login, ds_Senha, nm_Atendente)
values('iago', 'dippo96', 'Iago D''Ippolito')

select * from tbl_atendente

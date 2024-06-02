create database webasp2024
go
use webasp2024
go
create table categorie (idcat int primary key,
nomcat varchar(60) not null)
go
create table article (codeArt varchar(10) primary key , nomArt varchar(60) not null ,
prix money,qt int ,idcat int,constraint fk_art_cat foreign key (idcat)
references categorie(idcat))
go
create table photo (codeArt varchar (10),
nomphoto varchar (60) default 'photopardefault.jpg'
primary key (codeArt,nomphoto),constraint fk_photo_art foreign key(codeArt)
references article (codeArt))
go
select * from categorie
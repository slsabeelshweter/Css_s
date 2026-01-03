

create database librarybb;


create table books(
id int primary key identity,
title varchar(20) not null,
author varchar(20),
price decimal,
isavailable bit,
);

insert into books 
values('arabic', 'slsabeel shweter',20,0),('english','noor mahmoud',70,1),('life','ahmad',30,0);

select* from books
where price>50

update books
set price=15
where id=3

delete from books where id=1

select* from books



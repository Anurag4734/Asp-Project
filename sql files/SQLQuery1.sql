create database my;
use my;

create table myDetails(
eid int primary key,
ename varchar (20) not null,
eaddress varchar(30),
contact bigint
);

create table student(
sid int primary key identity(100,1),
sname varchar (20) not null,
saddress varchar(30),
contact bigint
);

drop table student;

insert into myDetails values(1,'Anurag','Baneshwor',9999999999);
insert into myDetails values(2,'Rohan','NayaBasti',8888888888);
insert into myDetails values(3,'Prashansa','Gothatar',7777777777);
insert into myDetails values(4,'Kushal','Jyatha',6666666666);

insert into student(sname,saddress,contact) values('Anurag','Baneshwor',9999999999);
insert into student values(2,'Rohan','NayaBasti',8888888888);
insert into student values(3,'Prashansa','Gothatar',7777777777);
insert into student values(4,'Kushal','Jyatha',6666666666);
select * from student;

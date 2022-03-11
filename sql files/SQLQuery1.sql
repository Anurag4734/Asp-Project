create database my;
use my;

create table myDetails(
eid int primary key,
ename varchar (20) not null,
eaddress varchar(30),
contact bigint
);

drop table myDetails;

insert into mydetails values(1,'Anurag','baneshwor',9999999999);
insert into mydetails values(2,'Rohan','NayaBasti',8888888888);
insert into mydetails values(3,'Prashansa','Gothatar',7777777777);
insert into mydetails values(4,'Kushal','Jyatha',6666666666);
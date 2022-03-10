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
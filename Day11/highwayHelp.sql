create database highwayHelp;
use HighwayHelp;
create table adminLoginCradentials(
Id int primary key auto_increment,
UserName varchar(25) not null,
Password varchar(25) not null
);

insert into adminLoginCradentials values(101,"chaitanya","Chaitanya@123");
insert into adminLoginCradentials(UserName,Password) values("prashant","Prashant@123");
insert into adminLoginCradentials(UserName,Password) values("mauli","Mauli@123");




create table hospitalDetails(
hospId int primary key auto_increment,
hospName varchar(25) not null,
hospEmail varchar(25) not null,
hospPin varchar(25) not null
);


insert into hospitalDetails values(11,"Vedanta Hospitala", "vedanta@gmail.com","414450");
insert into hospitalDetails(hospName,hospEmail,hospPin) values("CityCare Hospitala", "citycare@gmail.com","414450");
insert into hospitalDetails(hospName,hospEmail,hospPin) values("Rubby Hospitala", "rubby@gmail.com","414450");
insert into hospitalDetails(hospName,hospEmail,hospPin) values("Vighnaharta Hospitala", "vighnharta@gmail.com","414450");
insert into hospitalDetails(hospName,hospEmail,hospPin) values("Lifeline Hospitala", "lifeline@gmail.com","414450");
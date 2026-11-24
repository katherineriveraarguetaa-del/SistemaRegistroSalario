create database registroSalario
use registroSalario

create table registroSalrios 
(
id_Registro Int primary key identity (1,1),
nombreEmpleado varchar (100) not null,
salarioBruto decimal (10,2) not null,
porcentajeAFP decimal (5,4) not null,
AFP decimal (10,2) not null,
salarioNeto decimal (10,2) not null
)


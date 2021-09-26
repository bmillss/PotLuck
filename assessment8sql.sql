create schema potluck;
use potluck;
create table TeamMember(Id integer auto_increment,
FirstName varchar(50)not null, 
LastName varchar(50) not null, 
EmailAddress varchar(50) not null, 
AttendanceDate varchar(50) not null,
GuestName varchar(50),
primary key(Id));

create table Dish(Id integer not null auto_increment, 
TMName varchar(50) not null, 
PhoneNumber varchar(25) not null,
DishName varchar(50) not null,
DishDescription varchar(100)not null, 
Category varchar(25) not null,
primary key(Id));

insert into dish values (1,"Brandon Miller", "704-995-1920",
"Fishdish", "Fishy dish", "Main");
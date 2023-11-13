create database Parking

use Parking 

create table UserAccount (
userId integer IDENTITY(1,1) primary key,
userName varchar (50) not null,
userPassword varchar (50) not null,
roleId int,
userStatus varchar (10) not NULL default 'ACTIVE',
);

CREATE TABLE UserInformation (
userPlatenum varchar(50) primary key,
userTypeCar varchar (50) not null,
userTimeOut integer not null,
userTimeArrive varchar not null,
userId integer,
FOREIGN KEY (userId) REFERENCES UserAccount(userId),
parkSlot int not null
);



CREATE TABLE [dbo].[Role](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE Parking
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (1, N'User', N'User ')
INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Admin', N'Admin')
UPDATE [dbo].[Role] set roleName = 'User', roleDescription = 'User' where roleId = 1;
update [dbo].[Role] set roleName = 'Admin', roleDescription = 'Admin' where roleId = 2;
delete from [dbo].[Role] where roleId = 3;
--INSERT [dbo].[Role] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF

create table ParkSlot (
	parkSlot int primary key
);

SELECT UserInformation.userPlatenum, UserInformation.userTimeArrive, UserInformation.userTypeCar, UserInformation.userTimeOut,
ParkSlot.parkSlot From UserInformation JOIN ParkSlot ON UserInformation.parkSlot = ParkSlot.parkSlot


select * from [dbo].[Role]
select * from UserAccount
select * from UserInformation
select * from ParkSlot

insert into ParkSlot (parkSlot) values (1)
insert into ParkSlot (parkSlot) values (2)
insert into ParkSlot (parkSlot) values (3)
insert into ParkSlot (parkSlot) values (4)
insert into ParkSlot (parkSlot) values (5)
insert into ParkSlot (parkSlot) values (6)
insert into ParkSlot (parkSlot) values (7)
insert into ParkSlot (parkSlot) values (8)
insert into ParkSlot (parkSlot) values (9)
insert into ParkSlot (parkSlot) values (10)
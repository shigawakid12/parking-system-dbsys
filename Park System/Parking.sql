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
userInfo int identity(1,1) primary key, 
AuserPlatenum varchar(50),
userTypeCar varchar (50) NULL,
userTimeOut Varchar (50) NULL,
userTimeArrive varchar (50)NULL,
slotId int
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
	slotId int IDENTITY(1,1) primary key,
	parkSlot int NULL,
	parkName varchar(20),
	AuserPlatenum varchar (50),
	AuserTypeCar varchar (50) NULL,
	AuserTimeOut Varchar (50) NULL,
	AuserTimeArrive varchar (50)NULL,

);

insert ParkSlot (parkSlot,parkName) values(1,N'Slot 1');
insert ParkSlot (parkSlot,parkName) values(2,N'Slot 2');
insert ParkSlot (parkSlot,parkName) values(3,N'Slot 3');
insert ParkSlot (parkSlot,parkName) values(4,N'Slot 4');
insert ParkSlot (parkSlot,parkName) values(5,N'Slot 5');
insert ParkSlot (parkSlot,parkName) values(6,N'Slot 6');
insert ParkSlot (parkSlot,parkName) values(7,N'Slot 7');
insert ParkSlot (parkSlot,parkName) values(8,N'Slot 8');
insert ParkSlot (parkSlot,parkName) values(9,N'Slot 9');
insert ParkSlot (parkSlot,parkName) values(10,N'Slot 10');

SELECT UserInformation.userPlatenum, UserInformation.userTimeArrive, UserInformation.userTypeCar, UserInformation.userTimeOut,
ParkSlot.parkSlot From UserInformation JOIN ParkSlot ON UserInformation.parkSlot = ParkSlot.parkSlot


drop table ParkSlot

select * from [dbo].[Role]
select * from UserAccount
select * from UserInformation
select * from ParkSlot
SELECT parkSlot from UserInformation


INSERT UserInformation (parkSlot)


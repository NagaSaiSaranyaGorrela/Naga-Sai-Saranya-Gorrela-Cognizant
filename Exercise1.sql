create database AllianceFeedbackSystemDb
use AllianceFeedbackSystemDb
create table Trainer_Info(Trainer_Id varchar(20) primary key,
Salutation varchar(7),
Trainer_Name varchar(30),
Trainer_Location varchar(30),
Trainer_Track varchar(15),
Trainer_Qualification varchar(100),
Trainer_Experience int,
Trainer_Email varchar(100),
Trainer_Password varchar(20))

select * from Trainer_Info

--create table Batch_Info
create table Batch_Info(Batch_Id varchar(20) primary key,
Batch_Owner varchar(30),
Batch_BU_Name varchar(30))

select * from Batch_Info

--create table Module_Info
create table Module_Info(Module_Id varchar(20) primary key,
Module_Name varchar(40),
Module_Duration int)

select * from Module_Info

--create table Associate_Info
create table Associate_Info(Associate_Id varchar(20) primary key,
Salutation varchar(7),
Associate_Name varchar(30),
Associate_Location varchar(30),
Associate_Track varchar(15),
Associate_Qualification varchar(200),
Associate_Email varchar(100),
Associate_Password varchar(20))

select * from Associate_Info

--create table Questions
create table Questions(Questions_Id varchar(20) primary key,
Module_Id varchar(20) foreign key references Module_Info(Module_Id),
Question_Text varchar(900))

select * from Questions

--create table Associate_Status
create table Associate_Status(
Associate_Id varchar(20) foreign key references Associate_Info(associate_Id),
Module_Id varchar(20) foreign key references Module_Info(Module_Id),
Start_Date varchar(20),
End_Date varchar(20),
AFeedbackGiven varchar(20),
TFeedbackGiven varchar(20))

select * from Associate_Status

--create table Trainer_Feedback
create table Trainer_Feedback(Trainer_Id varchar(20) foreign key references Trainer_Info(Trainer_Id),
Question_Id varchar(20) foreign key references Questions(Questions_Id),
Batch_Id varchar(20) foreign key references Batch_Info(Batch_Id),
Module_Id varchar(20) foreign key references Module_Info(Module_Id),
Trainer_Rating int )

select * from Trainer_Feedback

--create table associate_Feedback
create table Associate_Feedback(Associate_Id varchar(20) foreign key references Associate_Info(Associate_Id),
Questions_Id varchar(20) foreign key references Questions(Questions_Id),
Module_Id varchar(20) foreign key references Module_Info(Module_Id),
Associate_Rating int)

select * from Associate_Feedback

--create table login_Details
create table Login_Details(User_Id varchar(20),
User_Password varchar(20))

select * from Login_Details

--exercise 2.2
--add 2 columns to Associate_Status
alter table Associate_Status add Batch_Id varchar(20) foreign key references Batch_Info(Batch_Id),
Trainer_Id varchar(20) foreign key references Trainer_Info(Trainer_Id)

--modify 2 columns datatypes
alter table Associate_Status alter column Start_Date date
alter table Associate_Status alter column End_Date date

--exercise 2.3
--insert values into Trainer_Info table
insert into Trainer_Info values('F001','Mr.','PANKAJ GHOSH','Pune','Java','Bachelor of Technology',12,'Pankaj.Ghosh@alliance.com','fac1@123'),
('F002','Mr.','SANJAY RADHAKRISHNAN','Bangalore','DotNet','Bachelor of Technology',12,'Sanjay.Radhakrishnan@alliance.com','fac2@123'),
('F003','Mr.','VIJAY MATHUR','Chennai','Mainframe','Bachelor of Technology',10,'Vijay.Mathur@alliance.com','fac3@123'),
('F004','Mrs.','NANDINI NAIR','Kolkata','Java','Master of Computer Applications',9,'Nandini.Nair@alliance.com','fac4@123'),
('F005','Miss.','ANITHA PAREKH','Hyderabad','Testing','Master of Computer Applications',6,'Anitha.Parekh@alliance.com','fac5@123'),
('F006','Mr.','MANOJ AGRAWAL','Mumbai','Mainframe','Bachelor of Technology',9,'Manoj.Agrawal@alliance.com','fac6@123'),
('F007','Ms.','MEENA KULKARNI','Coimbatore','Testing','Bachelor of Technology',5,'Meena.Kulkarni@alliance.com','fac7@123'),
('F009','Mr.','SAGAR MENON','Mumbai','Java','Master of Science In Information Technology',12,'Sagar.Menon@alliance.com','fac8@123')

--insert values into Batch_Info table
insert into Batch_Info values('B001','MRS.SWATI ROY','MSP'),
('B002','MRS.ARURNA K','HEALTHCARE'),
('B003','MR.RAJESH KRISHNAN','LIFE SCIENCES'),
('B004','MR.SACHIN SHETTY','BFS'),
('B005','MR.RAMESH PATEL','COMMUNICATIONS'),
('B006','MRS.SUSAN CHERIAN','RETAIL & HOSPITALITY'),
('B007','MRS.SAMPADA JAIN','MSP'),
('B008','MRS.KAVITA REGE','BPO'),
('B009','MR.RAVI SEJPAL','MSP')

--insert values into Module_Info table
insert into Module_Info values('O10SQL','Oracle 10g SQL',16),
('O10PLSQL','Oracle 10g PL/ SQL',16),
('J2SE','Core Java SE 1.6',288),
('J2EE','Advanced Java EE 1.6',80),
('JAVAFX','JavaFX 2.1',80),
('DOTNT4','.Net Framework 4.0',50),
('SQL2008','MS SQl Server 2008',120),
('MSBI08','MS BI Studio 2008',158),
('SHRPNT','MS Share Point',80),
('ANDRD4','Android 4.0',200),
('EM001','Instructor',0),
('EM002','Course Material',0),
('EM003','Learning Effectiveness',0),
('EM004','Environment',0),
('EM005','Job Impact',0),
('TM001','Attendees',0),
('TM002','Course Material',0),
('TM003','Environment',0)

--insert values into Associate_Info table
insert into Associate_Info values('A001','Miss.','GAYATHRI NARAYANAN','Gurgaon','Java','Bachelor of Technology','Gayathri.Narayanan@hp.com','tne1@123'),
('A002','Mrs.','RADHIKA MOHAN','Kerala','Java','Bachelor of Engineering In Information Technology','Radhika.Mohan@cognizant.com','tne2@123'),
('A003','Mr.','KISHORE SRINIVAS','Chennai','Java','Bachelor of Engineering In Computers','Kishore.Srinivas@ibm.com','tne3@123'),
('A004','Mr.','ANAND RANGANATHAN','Mumbai','DotNet','Master of Computer Applications','Anand.Ranganathan@finolex.com','tne4@123'),
('A005','Miss.','LEELA MENON','Kerala','Mainframe','Bachelor of Engineering In Information Technology','Leela.Menon@microsoft.com','tne5@123'),
('A006','Mrs.','ARTI KRISHNAN','Pune','Testing','Master of Computer Applications','Arti.Krishnan@cognizant.com','tne6@123'),
('A007','Mr.','PRABHAKAR SHUNMUGHAM','Mumbai','Java','Bachelor of Technology','Prabhakar.Shunmugham@honda.com','tne7@123')

--insert values into Questions table
insert into Questions values('Q001','EM001','Instructor knowledgeable and able to handle all your queries'),
('Q002','EM001','All the topics in a particular course handled by the trainer without any gaps or slippages'),
('Q003','EM002','The course materials presentation, handson,  etc. refered during the training are relevant and useful.'),
('Q004','EM002','The Hands on session adequate enough to grasp the understanding of the topic.'),
('Q005','EM002','The reference materials suggested for each module are adequate.'),
('Q006','EM003','Knowledge and skills presented in this training are applicatible at your work'),
('Q007','EM003','This training increases my proficiency level'),
('Q008','EM004','The physical environment e.g. classroom space, air-conditioning was conducive to learning.'),
('Q009','EM004','The software/hardware environment provided was sufficient for the purpose of the training.'),
('Q010','EM005','This training will improve your job performance.'),
('Q011','EM005','This training align with the business priorities and goals.'),
('Q012','TM001','Participants were receptive and had attitude towards learning.'),
('Q013','TM001','All participats gained the knowledge and the practical skills after this training.'),
('Q014','TM002','The course materials presentation, handson,  etc. available for the session covers the entire objectives of the course.'),
('Q015','TM002','Complexity of the course is adequate for the particpate level.'),
('Q016','TM002','Case study and practical demos helpful in understanding of the topic'),
('Q017','TM003','The physical environment e.g. classroom space, air-conditioning was conducive to learning.'),
('Q018','TM003','The software/hardware environment provided was adequate  for the purpose of the training.')

--insert values into Associate_Status table
insert into Associate_Status (Associate_Id,Module_Id,Start_Date,End_Date,Batch_Id,Trainer_Id) values('A001','O10SQL','2000-12-15','2000-12-25','B001','F001'),
('A002','O10SQL','2000-12-15','2000-12-25','B001','F001'),
('A003','O10SQL','2000-12-15','2000-12-25','B001','F001'),
('A001','O10PLSQL','2001-2-1','2001-2-12','B002','F002'),
('A002','O10PLSQL','2001-2-1','2001-2-12','B002','F002'),
('A003','O10PLSQL','2001-2-1','2001-2-12','B002','F002'),
('A001','J2SE','2002-8-20','2002-10-25','B003','F003'),
('A002','J2SE','2002-8-20','2002-10-25','B003','F003'),
('A001','J2EE','2005-12-1','2005-12-25','B004','F004'),
('A002','J2EE','2005-12-1','2005-12-25','B004','F004'),
('A003','J2EE','2005-12-1','2005-12-25','B004','F004'),
('A004','J2EE','2005-12-1','2005-12-25','B004','F004'),
('A005','JAVAFX','2005-12-4','2005-12-20','B005','F006'),
('A006','JAVAFX','2005-12-4','2005-12-20','B005','F006'),
('A006','SQL2008','2007-6-21','2007-6-28','B006','F007'),
('A007','SQL2008','2007-6-21','2007-6-28','B006','F007'),
('A002','MSBI08','2009-6-26','2009-6-29','B007','F006'),
('A003','MSBI08','2009-6-26','2009-6-29','B007','F006'),
('A004','MSBI08','2009-6-26','2009-6-29','B007','F006'),
('A002','ANDRD4','2010-6-5','2010-6-28','B008','F005'),
('A005','ANDRD4','2010-6-5','2010-6-28','B008','F005'),
('A003','ANDRD4','2011-8-1','2011-8-20','B009','F005'),
('A006','ANDRD4','2011-8-1','2011-8-20','B009','F005')


--exercise 2.4

update Trainer_Info set Trainer_Password='nn4@123' where Trainer_Password='fac4@123'

--exercise 2.5
delete from Associate_Status where Associate_Id='A003'
delete from Associate_Status where Module_Id='J2EE'

delete from Associate_Status where Batch_Id='B004'

delete from Associate_Status where Trainer_Id='F004'

delete from Associate_Status where Start_Date='2005-12-1'

delete from Associate_Status where End_Date='2005-12-25'

select * from Associate_Status

--Exercise 2.6
select top 5 * from Trainer_Info order by Trainer_Experience desc

--exercise 2.8
create login Mylogin with password='123'
create user user1 for login Mylogin
grant create table to user1
grant select ,insert,update,alter to user1
revoke create table,select to user1

--exercise 2.9
drop table Login_Details



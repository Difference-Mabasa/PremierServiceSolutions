USE master
GO

CREATE DATABASE PremierServiceSolutionsDB
ON PRIMARY
(
	NAME = PSSData,
	FILENAME ='c/users/PSSData.mdf' ,
	SIZE =20MB,
	MAXSIZE = Unlimited,
	FILEGROWTH = 10MB
)

LOG ON

(
	NAME = PSSLog,
	FILENAME ='c/users/PSSLog.ldf'  ,
	SIZE = 1GB,
	MAXSIZE = Unlimited,
	FILEGROWTH = 10MB
)

GO

CREATE TABLE Addresses
(
	AddressID VARCHAR(5) PRIMARY KEY,
	StreetName VARCHAR(20) NOT NULL,
	StreetNum INT NOT NULL,
	Suburb VARCHAR(30) NOT NULL,
	City VARCHAR(30) NOT NULL,
	PostalCode CHAR(4) NOT NULL,
)
GO

CREATE TABLE Contracts
(
	ContractID VARCHAR(5) PRIMARY KEY,
	ContractType VARCHAR(15) NOT NULL,
	ContractDescription VARCHAR(50),
	IndividualPrice MONEY NOT NULL,
	BusinessPrice MONEY NOT NULL
)
GO

CREATE TABLE Employees
(
	EmployeeID VARCHAR(10) PRIMARY KEY ,
	EmployeeName VARCHAR(25) NOT NULL,
	EmployeeSurname VARCHAR(25) NOT NULL,
	Department VARCHAR(25) NOT NULL,
	JobTitle VARCHAR(25) NOT NULL,
	Phone CHAR(10) NOT NULL,
	Email VARCHAR(30) ,
	Password VARCHAR(10) NOT NULL,
	AddressID VARCHAR(5) FOREIGN KEY REFERENCES Addresses(AddressID)
)
GO

CREATE TABLE IndividualClients
(
	ClientID VARCHAR(10) PRIMARY KEY ,
	ClientName VARCHAR(25) NOT NULL,
	ClientSurname VARCHAR(25) NOT NULL,
	Phone CHAR(10) NOT NULL,
	Email VARCHAR(30) ,
	AddressID VARCHAR(5) FOREIGN KEY REFERENCES Addresses(AddressID),
	ContractID VARCHAR(5) FOREIGN KEY REFERENCES Contracts(ContractID)
)
GO
CREATE TABLE BusinessClients
(
	ClientID VARCHAR(10) PRIMARY KEY ,
	CompanyName VARCHAR(25) NOT NULL,
	Phone CHAR(10) NOT NULL,
	Email VARCHAR(30) ,
	AddressID VARCHAR(5) FOREIGN KEY REFERENCES Addresses(AddressID),
	ContractID VARCHAR(5) FOREIGN KEY REFERENCES Contracts(ContractID)
)
GO
CREATE TABLE IndividualClientJobs
(
	JobID VARCHAR(10) PRIMARY KEY ,
	JobDescription VARCHAR(30),
	JobStatus BIT NOT NULL,
	JobDuration INT NOT NULL,
	ClientID VARCHAR(10) FOREIGN KEY REFERENCES IndividualClients(ClientID),
	EmployeeID VARCHAR(10) FOREIGN KEY REFERENCES Employees(EmployeeID)
)

CREATE TABLE BusinessClientJobs
(
	JobID VARCHAR(10) PRIMARY KEY ,
	JobDescription VARCHAR(30),
	JobStatus BIT NOT NULL,
	JobDuration INT NOT NULL,
	CompanyID VARCHAR(10) FOREIGN KEY REFERENCES BusinessClients(ClientID),
	EmployeeID VARCHAR(10) FOREIGN KEY REFERENCES Employees(EmployeeID)
)

GO

CREATE TABLE IndividualClientCallReports
(
	CallID VARCHAR(5) PRIMARY KEY,
	CallDuration INT NOT NULL,
	CallStartTime CHAR(4) NOT NULL,
	CallDateDate CHAR(8) NOT NULL,
	ClientID VARCHAR(10) FOREIGN KEY REFERENCES IndividualClients(ClientID),
	EmployeeID VARCHAR(10) FOREIGN KEY REFERENCES Employees(EmployeeID)
)

GO

CREATE TABLE BusinessClientCallReports
(
	CallID VARCHAR(5) PRIMARY KEY,
	CallDuration INT NOT NULL,
	CallDate CHAR(8) NOT NULL,
	CallStartTime CHAR(4) NOT NULL,
	CompanyID VARCHAR(10) FOREIGN KEY REFERENCES BusinessClients(ClientID),
	EmployeeID VARCHAR(10) FOREIGN KEY REFERENCES Employees(EmployeeID)
)

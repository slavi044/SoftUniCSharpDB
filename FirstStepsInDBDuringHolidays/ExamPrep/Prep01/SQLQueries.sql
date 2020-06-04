CREATE DATABASE [ExamPreparation01]

USE [ExamPreparation01]

--Problem01
CREATE TABLE Planes(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[Name] VARCHAR(30) NOT NULL,
	Seats INT NOT NULL,
	[Range] INT NOT NULL
)

CREATE TABLE Flights(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	DepartureTime DATETIME2,
	ArrivalTime DATETIME2,
	Origin VARCHAR(50) NOT NULL,
	Destination VARCHAR(50) NOT NULL,
	PlaneId INT FOREIGN KEY REFERENCES Planes(Id)
)

CREATE TABLE Passengers(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	FirstName VARCHAR(30) NOT NULL,
	LastName VARCHAR(30) NOT NULL,
	Age INT NOT NULL,
	[Address] VARCHAR(30) NOT NULL,
	PassportId VARCHAR(11) NOT NULL, -- ???
)

CREATE TABLE LuggageTypes(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[Type] VARCHAR(30) NOT NULL
)

CREATE TABLE Luggages(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	LuggageTypeId INT FOREIGN KEY REFERENCES LuggageTypes(Id) NOT NULL,
	PassengerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL
)

CREATE TABLE Tickets(
	Id INT PRIMARY KEY IDENTITY(1, 1),
	PassengerId INT FOREIGN KEY REFERENCES Passengers(Id),
	FlightId INT FOREIGN KEY REFERENCES Flights(Id),
	LuggageId INT FOREIGN KEY REFERENCES Luggages(Id),
	Price DECIMAL(15, 2) NOT NULL
)


CREATE TABLE Persons (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Email nvarchar(50) NULL,
	BirthDate date NOT NULL,
	Age tinyint NOT NULL,
	Gender nvarchar(1) NOT NULL,
	);

CREATE TABLE Countries (
	CountryID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CountryName nvarchar(10) NOT NULL,
	CountryCode nvarchar(3) NOT NULL,
	PhoneCode VARCHAR(3) NOT NULL,
	);

CREATE TABLE Phones (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	PhoneNumber bigint NOT NULL,
	PersonID INT REFERENCES Persons(ID) NOT NULL,
	CountryID INT REFERENCES Countries(CountryID) NOT NULL,
	);

CREATE TABLE Users (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	PersonID int REFERENCES Persons(ID) NOT NULL,
	Username nvarchar(10) NOT NULL,
	Password nvarchar(8) NOT NULL,
	Permssions int NOT NULL,
	);

CREATE TABLE Accounts (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Balance smallmoney NOT NULL,
	PINCode CHAR(4) CHECK (PINCode BETWEEN 1000 AND 9999) NOT NULL,
	ClientID int REFERENCES Clients(ID) NOT NULL,
	);

CREATE TABLE Clients (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	PersonID int REFERENCES Persons(ID) NOT NULL,
	);

CREATE TABLE TransferRegister (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	SenderID int REFERENCES Clients(ID) NOT NULL,
	ReceiverID int REFERENCES Clients(ID) NOT NULL,
	TransferAmount smallmoney NOT NULL,
	UserID int REFERENCES Users(ID) NOT NULL,
	TransferDate date NOT NULL,
	);

CREATE TABLE LoginRegister (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	UserID int REFERENCES Users(ID) NOT NULL,
	LoginDate Date NOT NULL,
	);

CREATE TABLE Currencies (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CountryID int REFERENCES Countries(CountryID) NOT NULL,
	Name nvarchar(50) NOT NULL,
	Rate SmallMoney Not NULL,
	);


BACKUP DATABASE BankSystemDB
TO DISK = 'D:\repos\BankSystemADO.Net\DataAccess\BankSystemDB.bak';


SELECT * FROM Clients;

SELECT Accounts.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.BirthDate, Persons.Age, Persons.Gender, Accounts.ID AS AccountNumber, Accounts.Balance, Accounts.PINCode
FROM   Persons INNER JOIN
             Accounts ON Persons.ID = Accounts.ID INNER JOIN
             Clients ON Persons.ID = Clients.PersonID AND Accounts.ClientID = Clients.ID

SELECT Users.ID AS UserID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.BirthDate, Persons.Age, Persons.Gender, Users.Username, Users.Password, Users.Permissions
FROM   Users INNER JOIN
             Persons ON Users.PersonID = Persons.ID

SELECT LoginRegister.LoginDate, LoginRegister.UserID, Users.Username, Users.Permissions
FROM   LoginRegister INNER JOIN
             Users ON LoginRegister.UserID = Users.ID

SELECT Phones.ID, Countries.PhoneCode, Persons.FirstName, Persons.LastName, Phones.PhoneNumber, Persons.Gender
FROM   Phones INNER JOIN
             Countries ON Phones.CountryID = Countries.CountryID INNER JOIN
             Persons ON Phones.PersonID = Persons.ID

SELECT TransferRegister.ID, TransferRegister.TransferDate, TransferRegister.SenderID, TransferRegister.ReceiverID, TransferRegister.TransferAmount, TransferRegister.UserID, Users.Username, Users.Permissions
FROM   TransferRegister INNER JOIN
             Accounts ON TransferRegister.ID = Accounts.ID INNER JOIN
             Users ON TransferRegister.UserID = Users.ID

SELECT Currencies.ID, Countries.CountryName, Countries.CountryCode AS Code, Currencies.Name, Currencies.Rate
FROM   Currencies INNER JOIN
             Countries ON Currencies.CountryID = Countries.CountryID

SELECT Countries.CountryCode
FROM   Countries INNER JOIN
             Currencies ON Countries.CountryID = Currencies.CountryID

SELECT Currencies.*
FROM   Countries INNER JOIN
             Currencies ON Countries.CountryID = Currencies.CountryID

SELECT Accounts.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.Age, Persons.Gender, Accounts.PINCode, Accounts.Balance
FROM   Clients INNER JOIN
             Accounts ON Clients.ID = Accounts.ClientID INNER JOIN
             Persons ON Clients.PersonID = Persons.ID


DELETE FROM Accounts;
DELETE FROM Clients;
DELETE FROM Persons;
DELETE FROM LoginRegister;
DELETE FROM TransferRegister;
DELETE FROM Users;
DELETE FROM Currencies;
DELETE FROM Countries;
DELETE FROM Phones;
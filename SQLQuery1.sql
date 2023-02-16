CREATE DATABASE PetShop
COLLATE Polish_CI_AS;
GO
USE PetShop;
GO
INSERT INTO Users(Username, Password, Firstname, Lastname, Email, RoleID)
VALUES ('admin', 'admin', 'Mateusz', 'Dynur', 'admin@domain.com', 1)
CREATE TABLE Roles (
    RolesID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL,
);
CREATE TABLE Users (
    UsersID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(255) NOT NULL,
    Password VARCHAR(255) NOT NULL,
    Firstname VARCHAR(255) NOT NULL,
    Lastname VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
	Roles INT FOREIGN KEY REFERENCES Roles(RolesID)
);

CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL,
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL,
    Category INT FOREIGN KEY REFERENCES Category(CategoryID),
    Description VARCHAR(MAX) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Availability VARCHAR(255) NOT NULL
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    PhoneNumber VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    OrderDate DATETIME NOT NULL,
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL,
    TotalPrice DECIMAL(10,2) NOT NULL
);

CREATE TABLE Deliveries (
    DeliveryID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    DeliveryDate DATETIME NOT NULL,
    Quantity INT NOT NULL
);

INSERT INTO Roles (Name)
VALUES ('ADMIN'),
('USER'),
('CUSTOMER')


/*CREATE TABLE ProductRatings (
    RatingID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    Rating INT NOT NULL,
    Comment VARCHAR(MAX) NOT NULL
);
CREATE TABLE Complaints (
    ComplaintID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    ComplaintDate DATETIME NOT NULL,
    Description VARCHAR(MAX) NOT NULL,
    Status VARCHAR(255) NOT NULL
);*/




create table CustomerDB([CustomerId] INT IDENTITY (1, 1) NOT NULL,
    [Customer_Name] VARCHAR (30) NULL,
    [PhoneNumber]   BIGINT       NOT NULL,
    [Address]       VARCHAR (30) NULL,
    [Country]       VARCHAR (30) NULL,
    [Salary]        INT          NULL,
    [Pincode]       INT          NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC))

    select * from CustomerDB;
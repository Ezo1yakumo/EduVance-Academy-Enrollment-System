USE dblogin;
GO

-- Create the table if it does not exist.
IF OBJECT_ID('dbo.Users', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Users
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Username NVARCHAR(50) NOT NULL UNIQUE,
        PasswordSalt VARBINARY(16) NOT NULL,
        PasswordHash VARBINARY(32) NOT NULL,
        Role NVARCHAR(20) NOT NULL,
        IsActive BIT NOT NULL DEFAULT 1
    );
END;
GO

-- Administrator test account
IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Username = 'admin_test')
BEGIN
    INSERT INTO dbo.Users
        (Username, PasswordSalt, PasswordHash, Role, IsActive)
    VALUES
        ('admin_test',
         0xCA51F7FB24CD45113EE39A5688A9611E,
         0xF307226969EE04AC6014BD7409B8468ED56E755A1BD6C7D7543D96CBFEA5476D,
         'Administrator',
         1);
END;

-- Cashier test account
IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Username = 'cashier_test')
BEGIN
    INSERT INTO dbo.Users
        (Username, PasswordSalt, PasswordHash, Role, IsActive)
    VALUES
        ('cashier_test',
         0x355893B77F37BC1A8E43CF69B3F27E92,
         0x9329FAB95876E2BBDD31524D272164C20F6B8C69631898738D267E767950AD00,
         'Cashier',
         1);
END;
GO

-- Show the accounts that were added.
SELECT Username, Role, IsActive FROM dbo.Users;
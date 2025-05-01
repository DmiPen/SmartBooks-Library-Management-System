-- 1. Drop existing tables (in right order to avoid FK errors)
IF OBJECT_ID('dbo.Books', 'U') IS NOT NULL
    DROP TABLE dbo.Books;
GO

IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
    DROP TABLE dbo.Users;
GO


-- 2. Create Users table
CREATE TABLE dbo.Users (
    UserID       INT           IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    Password     NVARCHAR(100) NOT NULL,
    FullName     NVARCHAR(100) NULL,
    AccessLevel  NVARCHAR(20)  NOT NULL,  -- 'Admin','Manager','Standard'
    IsActive     BIT           NOT NULL DEFAULT(0)
);
GO

-- 3. Create Books table
CREATE TABLE dbo.Books (
    BookID         INT     IDENTITY(1,1) PRIMARY KEY,
    Title          NVARCHAR(100) NOT NULL,
    Author         NVARCHAR(100) NULL,
    ISBN           NVARCHAR(50)  NULL,
    PublishedDate  DATE          NULL,
    Category       NVARCHAR(50)  NULL,
    Quantity       INT           NOT NULL DEFAULT(1),
    AddedByUserID  INT           NOT NULL
        CONSTRAINT FK_Books_Users REFERENCES dbo.Users(UserID)
);
GO


-- 4. Insert sample Users
INSERT INTO dbo.Users (Username, Password, FullName, AccessLevel, IsActive)
VALUES
  ('admin',   'admin123',   'Angel Madrid',       'Admin',    1),
  ('manager', 'manager123', 'Jason Coc',          'Manager',  1),
  ('user1',   'user123',    'Alekzander Calderon','Standard', 1),
  ('user2',   'user456',    'Dmitri Wu',          'Standard', 1);
GO


-- 5. Insert sample Books
-- If you care about specific BookID values (e.g. ID = 7 for Steve), turn on IDENTITY_INSERT.
SET IDENTITY_INSERT dbo.Books ON;
INSERT INTO dbo.Books (BookID, Title, Author, ISBN, PublishedDate, Category, Quantity, AddedByUserID)
VALUES
  (1, 'The Great Gatsby',   'F. Scott Fitzgerald', '9780743273565', '1925-04-10', 'Classic',     3, 1),
  (2, '1984',               'George Orwell',      '9780451524935', '1949-06-08', 'Dystopian',   5, 2),
  (3, 'VB.NET Programming', 'John Doe',           '9781234567897', '2020-01-01', 'Programming', 2, 1),
  (4, 'Database Systems',   'Jane Smith',         '9789876543210', '2018-09-15', 'Technology',  4, 2),
  (7, 'steve The book',     'Steve',               '7556755858',    '2025-04-04', 'adventure',   3, 1);
SET IDENTITY_INSERT dbo.Books OFF;
GO

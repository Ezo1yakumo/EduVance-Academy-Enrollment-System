
USE [EduVance];
GO

-- Add default Section A only if it doesn't exist
IF NOT EXISTS
(
    SELECT 1
    FROM dbo.Sections
    WHERE SectionName = N'Section A'
)
BEGIN
    INSERT INTO dbo.Sections
    (
        SectionName,
        IsActive
    )
    VALUES
    (
        N'Section A',
        1
    );
END;
GO

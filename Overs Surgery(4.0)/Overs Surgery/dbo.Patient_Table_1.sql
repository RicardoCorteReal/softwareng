CREATE TABLE [dbo].[Patient_Table] (
    [Patient_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [First Name]     NVARCHAR (50) NOT NULL,
    [Surname]        NVARCHAR (50) NOT NULL,
    [Email]          NVARCHAR (50) NOT NULL,
    [Address]        NVARCHAR (50) NOT NULL,
    [Date Of Birth ] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Patient_ID] ASC)
);


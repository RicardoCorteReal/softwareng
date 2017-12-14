CREATE TABLE [dbo].[Availability_Table ] (
    [Availabity_ID] INT           NOT NULL IDENTITY,
    [Staff_ID]      INT           NOT NULL,
    [Status]        NCHAR (10)    NOT NULL,
    [Date]          DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([Availabity_ID] ASC), 
    CONSTRAINT [FK_Availability_Table _ToTable] FOREIGN KEY ([Staff_ID]) REFERENCES [Staff_Table]([Staff_ID])
);


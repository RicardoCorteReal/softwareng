CREATE TABLE [dbo].[Availability ] (
    [Availabity_ID] INT           NOT NULL,
    [Staff_ID]      INT           NOT NULL,
    [Status]        NCHAR (10)    NOT NULL,
    [Date]          SMALLDATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Availabity_ID] ASC)
);


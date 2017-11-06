CREATE TABLE [dbo].[Appointment Table] (
    [Appointment ID]      INT        IDENTITY (1, 1) NOT NULL,
    [Appointment Date]    DATE       NOT NULL,
    [Appointment Time]    TIME NOT NULL,
    [Appointment Status ] NCHAR (20) NOT NULL,
    [Patient_ID]          INT        NOT NULL,
    [Staff_ID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Appointment ID] ASC),
    CONSTRAINT [FK_Appointment Table_ToTable] FOREIGN KEY ([Patient_ID]) REFERENCES [dbo].[Patient Table] ([Patient_ID]),
	CONSTRAINT [FK_Appointment Table2_ToTable] FOREIGN KEY ([Staff_ID]) REFERENCES [dbo].[Staff Table] ([Staff_ID])
);


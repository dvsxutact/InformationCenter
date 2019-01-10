CREATE TABLE [dbo].[InformationCenter] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (255) NULL,
    [Year]          NVARCHAR (255) NULL,
    [Make]          NVARCHAR (255) NULL,
    [Model]         NVARCHAR (255) NULL,
    [Engine]        NVARCHAR (255) NULL,
    [Mileage]       NVARCHAR (255) NULL,
    [Purchase_Date] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


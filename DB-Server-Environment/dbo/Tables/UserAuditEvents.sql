CREATE TABLE [dbo].[UserAuditEvents] (
    [UserAuditId] INT                IDENTITY (1, 1) NOT NULL,
    [AuditEvent]  INT                NOT NULL,
    [IpAddress]   NVARCHAR (MAX)     NULL,
    [Timestamp]   DATETIMEOFFSET (7) NOT NULL,
    [UserId]      NVARCHAR (MAX)     NOT NULL,
    CONSTRAINT [PK_UserAuditEvents] PRIMARY KEY CLUSTERED ([UserAuditId] ASC)
);


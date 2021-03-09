IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE TABLE [RegistrationTypes] (
        [RegistrationTypeId] bigint NOT NULL IDENTITY,
        [TypeName] nvarchar(150) NULL,
        [TypeCode] nvarchar(150) NULL,
        [Url] nvarchar(300) NULL,
        [UpdatedDate] datetime2 NOT NULL,
        [Status] bit NOT NULL DEFAULT CAST(1 AS bit),
        CONSTRAINT [PK_RegistrationTypes] PRIMARY KEY ([RegistrationTypeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE TABLE [Users] (
        [UserId] bigint NOT NULL IDENTITY,
        [Firstname] nvarchar(150) NOT NULL,
        [Lastname] nvarchar(150) NULL,
        [Email] nvarchar(350) NULL,
        [Designation] nvarchar(max) NOT NULL,
        [PasswordHash] varbinary(max) NULL,
        [PasswordSalt] varbinary(max) NULL,
        [CreatedDate] datetime2 NOT NULL DEFAULT (GETDATE()),
        [UpdatedDate] datetime2 NOT NULL,
        [Status] bit NOT NULL DEFAULT CAST(1 AS bit),
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE TABLE [DocumentReferences] (
        [DocumentReferenceId] bigint NOT NULL IDENTITY,
        [ReferenceName] nvarchar(150) NULL,
        [ReferenceCode] nvarchar(150) NULL,
        [CreatedDate] datetime2 NOT NULL DEFAULT (GETDATE()),
        [UpdatedDate] datetime2 NOT NULL,
        [Email] nvarchar(350) NULL,
        [Notes] nvarchar(max) NULL,
        [Status] bit NOT NULL DEFAULT CAST(1 AS bit),
        [UserId] bigint NOT NULL,
        [RegistrationTypeId] bigint NOT NULL,
        CONSTRAINT [PK_DocumentReferences] PRIMARY KEY ([DocumentReferenceId]),
        CONSTRAINT [FK_DocumentReferences_RegistrationTypes_RegistrationTypeId] FOREIGN KEY ([RegistrationTypeId]) REFERENCES [RegistrationTypes] ([RegistrationTypeId]) ON DELETE CASCADE,
        CONSTRAINT [FK_DocumentReferences_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE TABLE [TitleNumbers] (
        [TitleNumberId] bigint NOT NULL IDENTITY,
        [TitleNumberCode] nvarchar(150) NULL,
        [PropertyName] nvarchar(500) NULL,
        [CreatedDate] datetime2 NOT NULL DEFAULT (GETDATE()),
        [UpdatedDate] datetime2 NOT NULL,
        [Status] bit NOT NULL DEFAULT CAST(1 AS bit),
        [DocumentReferenceId] bigint NOT NULL,
        CONSTRAINT [PK_TitleNumbers] PRIMARY KEY ([TitleNumberId]),
        CONSTRAINT [FK_TitleNumbers_DocumentReferences_DocumentReferenceId] FOREIGN KEY ([DocumentReferenceId]) REFERENCES [DocumentReferences] ([DocumentReferenceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE TABLE [ApplicationForms] (
        [ApplicationFormId] bigint NOT NULL IDENTITY,
        [Type] nvarchar(300) NULL,
        [Reference] nvarchar(300) NULL,
        [ChargeDate] datetime2 NOT NULL,
        [IsAgreed] bit NOT NULL,
        [FileLocation] nvarchar(max) NULL,
        [CertificationType] nvarchar(max) NULL,
        [Fee] decimal(18,2) NOT NULL,
        [CreatedDate] datetime2 NOT NULL DEFAULT (GETDATE()),
        [UpdatedDate] datetime2 NOT NULL,
        [Status] bit NOT NULL DEFAULT CAST(1 AS bit),
        [TitleNumberId] bigint NOT NULL,
        CONSTRAINT [PK_ApplicationForms] PRIMARY KEY ([ApplicationFormId]),
        CONSTRAINT [FK_ApplicationForms_TitleNumbers_TitleNumberId] FOREIGN KEY ([TitleNumberId]) REFERENCES [TitleNumbers] ([TitleNumberId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RegistrationTypeId', N'Status', N'TypeCode', N'TypeName', N'UpdatedDate', N'Url') AND [object_id] = OBJECT_ID(N'[RegistrationTypes]'))
        SET IDENTITY_INSERT [RegistrationTypes] ON;
    INSERT INTO [RegistrationTypes] ([RegistrationTypeId], [Status], [TypeCode], [TypeName], [UpdatedDate], [Url])
    VALUES (CAST(1 AS bigint), CAST(1 AS bit), N'doc_reg', N'Document Registration', '2021-01-21T10:06:04.2671005+05:30', N'document-registration'),
    (CAST(2 AS bigint), CAST(1 AS bit), N'lease_ext', N'Lease Extension', '2021-01-21T10:06:04.2679142+05:30', N'lease-extension'),
    (CAST(3 AS bigint), CAST(1 AS bit), N'new_lease', N'New Lease', '2021-01-21T10:06:04.2679169+05:30', N'new-lease'),
    (CAST(4 AS bigint), CAST(1 AS bit), N'transfer', N'Transfer of Part', '2021-01-21T10:06:04.2679171+05:30', N'transfer'),
    (CAST(5 AS bigint), CAST(1 AS bit), N'rem_frm', N'Removal of default form A restriction (JP1)', '2021-01-21T10:06:04.2679173+05:30', N'removal-form');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RegistrationTypeId', N'Status', N'TypeCode', N'TypeName', N'UpdatedDate', N'Url') AND [object_id] = OBJECT_ID(N'[RegistrationTypes]'))
        SET IDENTITY_INSERT [RegistrationTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Designation', N'Email', N'Firstname', N'Lastname', N'PasswordHash', N'PasswordSalt', N'Status', N'UpdatedDate') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] ON;
    INSERT INTO [Users] ([UserId], [Designation], [Email], [Firstname], [Lastname], [PasswordHash], [PasswordSalt], [Status], [UpdatedDate])
    VALUES (CAST(1 AS bigint), N'admin', N'dushyanthaccura@gmail.com', N'Admin', NULL, 0x61990A9E3BC4CC829386E75E09BBA6C7CFC05E4B3101472402226FB64F383D72679DB9512E9AD4F46CC3DEE256D153B14CFDAE1125B656296AE503001D9611AB, 0x0B954465215E1B3A03CAC2C233C8EC265CD71E8E0F83DB57F503F50321058056A458535B2294504E68A4B50099B5345D241F9892AEDC0177688F5B20C5A20EDBB5864F3DA4AD40EDA0F38524ED79A894632EA29F8798ADD5E138267E7CD81994387A17D048261E876D2FB1E90C359AED64A57BCCC63B114BDE98D911456A4FEC, CAST(1 AS bit), '0001-01-01T00:00:00.0000000');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UserId', N'Designation', N'Email', N'Firstname', N'Lastname', N'PasswordHash', N'PasswordSalt', N'Status', N'UpdatedDate') AND [object_id] = OBJECT_ID(N'[Users]'))
        SET IDENTITY_INSERT [Users] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE INDEX [IX_ApplicationForms_TitleNumberId] ON [ApplicationForms] ([TitleNumberId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE INDEX [IX_DocumentReferences_RegistrationTypeId] ON [DocumentReferences] ([RegistrationTypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE INDEX [IX_DocumentReferences_UserId] ON [DocumentReferences] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE INDEX [IX_TitleNumbers_DocumentReferenceId] ON [TitleNumbers] ([DocumentReferenceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    CREATE UNIQUE INDEX [IX_Users_Email] ON [Users] ([Email]) WHERE [Email] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210121043604_init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210121043604_init', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    CREATE TABLE [ErrorLogs] (
        [ErrorLogId] bigint NOT NULL IDENTITY,
        [ClassName] nvarchar(500) NULL,
        [Message] nvarchar(max) NULL,
        [Source] nvarchar(max) NULL,
        [StackTraceString] nvarchar(max) NULL,
        [CreatedDate] Datetime NOT NULL DEFAULT (GETDATE()),
        CONSTRAINT [PK_ErrorLogs] PRIMARY KEY ([ErrorLogId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-22T10:15:21.1773138+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-22T10:15:21.1781186+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-22T10:15:21.1781208+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-22T10:15:21.1781254+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-22T10:15:21.1781256+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x011E3699E73C47B88FAFAE84B50F386FE1074ADBA12A7D723D3702B69540D0146734C49997A3839F1076D0FCD8174769E1EF406B175C4CC342B750D194F65551, [PasswordSalt] = 0x484A4BA624E31B127B4C8949BC5E231BB96D0D137AF943E4740BCE4991607A28767198F0E9FCFE701EEDEAE9FCD7B93598830CB9B5DA8B13D01DE3715CAD31AE023A50DAC25FA2E323BF870FAC0DED397C735336228C1853A4B9D224492A5AD9E56E7EDCC074E051A48B868E23A05692357E60240166C01C3EEA36FB6839BCF1
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210122044521_ErrorLogs')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210122044521_ErrorLogs', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127081142_ignorefield')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-27T13:41:42.2502833+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127081142_ignorefield')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-27T13:41:42.2514708+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127081142_ignorefield')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-27T13:41:42.2514739+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127081142_ignorefield')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-27T13:41:42.2514743+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127081142_ignorefield')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-27T13:41:42.2514745+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127081142_ignorefield')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xADFBD506B2A8FE66EE98B66381086C1FC56C2693309A5D41FC367FF391A2CE56B242B4A47DCC9334D357E0E6B2ABA43E8CA2B0585BC76F3CFAB1B47F1D4471C4, [PasswordSalt] = 0xB5A5E30F66A13D53E1E5985934818F9FC83D8FF9BEB9C5B6242C6D7BE5354F5C4E69FA967FDE009784D8C97733A3BCA479E04F3CFD4BD687F04B3AD9CF6DDCBED97F73B61B84D3026EA2E8014A601387E57613062022B0966EF3BBC061149AAC59B1C5F80296954F4402BE61145F9EA22FAADBAF30F75E548D7381B9A5A0E612
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210127081142_ignorefield')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210127081142_ignorefield', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [FileName] nvarchar(1000) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-31T21:21:38.9753823+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-31T21:21:38.9764600+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-31T21:21:38.9764624+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-31T21:21:38.9764627+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-01-31T21:21:38.9764628+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x97C4F72EF4C8BD8668848AD4BC8434614914EF8288056276F62ACD9FCCB8650D62552D3BF0AB691EA42EC573B39B9010A65D613955AB9415401B6B21BDE09A12, [PasswordSalt] = 0x67C544F89A6CBB6180F3798896D4156B5B141468813BB4C9D31FD1B0B70FA5D095927816B378D1CA83C537B5B86E163A0345CB4F72395E812279CE0A3EA3B17E459DC1042E92A302FA779E68A882212AC624DBAEB57862EC1CD5858DB7A35B89FB21A099FE27DD3C9B12B65BD47CEBC1380BDE658887CF16B3930184471E3DFC
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210131155139_fileName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210131155139_fileName', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    ALTER TABLE [TitleNumbers] ADD [TitleType] nvarchar(50) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-02T10:45:45.6017380+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-02T10:45:45.6028065+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-02T10:45:45.6028087+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-02T10:45:45.6028089+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-02T10:45:45.6028091+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x0AA34B19EC2CC1E635CA485EE5D17C19E95453FC59F7C666F2B469862C71AD71908015D9F8658A8A39183B55451381484E794026A0623BB568E4F97DC4CA5792, [PasswordSalt] = 0x965AD523EF56DFCD8E71346CC33AF50D75C462B7C9A1A82A670CEF2FA5AA7FFDE7624746FDA749016DBD30BB6E57495794D827F6423E7B970F95532E116612D98E1E868DA905F90CC97A2523C25C1869CA17B26E7A3DA2233E7CBECA862EA84CE09F9477949DAC61FC0F37924F4AAE48D9EB21D9F8763ECA50A9FE7BAD4F445E
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210202051546_titleType')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210202051546_titleType', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] DROP CONSTRAINT [FK_ApplicationForms_TitleNumbers_TitleNumberId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] DROP CONSTRAINT [FK_DocumentReferences_RegistrationTypes_RegistrationTypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] DROP CONSTRAINT [FK_DocumentReferences_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DROP INDEX [IX_DocumentReferences_RegistrationTypeId] ON [DocumentReferences];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TitleNumbers]') AND [c].[name] = N'PropertyName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [TitleNumbers] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [TitleNumbers] DROP COLUMN [PropertyName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TitleNumbers]') AND [c].[name] = N'TitleType');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [TitleNumbers] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [TitleNumbers] DROP COLUMN [TitleType];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'CreatedDate');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [DocumentReferences] DROP COLUMN [CreatedDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'ReferenceCode');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [DocumentReferences] DROP COLUMN [ReferenceCode];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'ReferenceName');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [DocumentReferences] DROP COLUMN [ReferenceName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'RegistrationTypeId');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [DocumentReferences] DROP COLUMN [RegistrationTypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'UpdatedDate');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [DocumentReferences] DROP COLUMN [UpdatedDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'CertificationType');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [CertificationType];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'ChargeDate');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [ChargeDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'CreatedDate');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [CreatedDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'Fee');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [Fee];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'FileLocation');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [FileLocation];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'FileName');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [FileName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'IsAgreed');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [IsAgreed];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'Reference');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [Reference];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'Status');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [Status];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'UpdatedDate');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [UpdatedDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var17 sysname;
    SELECT @var17 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'UserId');
    IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var17 + '];');
    ALTER TABLE [DocumentReferences] ALTER COLUMN [UserId] bigint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var18 sysname;
    SELECT @var18 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'Email');
    IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var18 + '];');
    ALTER TABLE [DocumentReferences] ALTER COLUMN [Email] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [AP1WarningUnderstood] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [ApplicationAffects] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [ApplicationDate] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [DisclosableOveridingInterests] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [LocalAuthority] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [PostcodeOfProperty] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [Reference] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [TelephoneNumber] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [TotalFeeInPence] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var19 sysname;
    SELECT @var19 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'Type');
    IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var19 + '];');
    ALTER TABLE [ApplicationForms] ALTER COLUMN [Type] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    DECLARE @var20 sysname;
    SELECT @var20 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'TitleNumberId');
    IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var20 + '];');
    ALTER TABLE [ApplicationForms] ALTER COLUMN [TitleNumberId] bigint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [ApplicationFormId1] bigint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [DocumentReferenceId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [FeeInPence] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [PartyId] bigint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [Priority] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [SupportingDocumentsSupportingDocumentId] bigint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [Value] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE TABLE [Documents] (
        [DocumentId] bigint NOT NULL IDENTITY,
        [CertifiedCopy] nvarchar(max) NULL,
        [FileName] nvarchar(max) NULL,
        [FileExtension] nvarchar(max) NULL,
        [ApplicationFormId] bigint NOT NULL,
        CONSTRAINT [PK_Documents] PRIMARY KEY ([DocumentId]),
        CONSTRAINT [FK_Documents_ApplicationForms_ApplicationFormId] FOREIGN KEY ([ApplicationFormId]) REFERENCES [ApplicationForms] ([ApplicationFormId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE TABLE [Parties] (
        [PartyId] bigint NOT NULL IDENTITY,
        [IsApplicant] bit NOT NULL,
        [CompanyOrForeName] nvarchar(max) NULL,
        [Surname] nvarchar(max) NULL,
        [Roles] nvarchar(max) NULL,
        [PartyType] nvarchar(max) NULL,
        [DocumentReferenceId] bigint NOT NULL,
        CONSTRAINT [PK_Parties] PRIMARY KEY ([PartyId]),
        CONSTRAINT [FK_Parties_DocumentReferences_DocumentReferenceId] FOREIGN KEY ([DocumentReferenceId]) REFERENCES [DocumentReferences] ([DocumentReferenceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE TABLE [SupportingDocuments] (
        [SupportingDocumentId] bigint NOT NULL IDENTITY,
        [CertifiedCopy] nvarchar(max) NULL,
        [DocumentId] nvarchar(max) NULL,
        [DocumentName] nvarchar(max) NULL,
        [DocumentReferenceId] bigint NOT NULL,
        CONSTRAINT [PK_SupportingDocuments] PRIMARY KEY ([SupportingDocumentId]),
        CONSTRAINT [FK_SupportingDocuments_DocumentReferences_DocumentReferenceId] FOREIGN KEY ([DocumentReferenceId]) REFERENCES [DocumentReferences] ([DocumentReferenceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T15:53:48.8015723+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T15:53:48.8023716+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T15:53:48.8023739+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T15:53:48.8023741+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T15:53:48.8023743+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x49958ABE077E4498625C7BD6149F74DBFF295691C24E1DCFB5824402ABB9AE09E1D2DC3086C0581119C30D9BD7259D4E401C4A1E94518BAECE2CB2BAEB2E9F42, [PasswordSalt] = 0x40F84935DA918C43918A3795222E3571953007FE427EBB964E151B97BB13D6332B1C4EDE2AA48CCFA9D22AF6D2B680AAAA4AD94ECEDB8500967F92D21A9CDD3832078C8C87FFF5E7F27BEF88E9D8534542EF1EBA7FE5CE39DBAE0EC7525B5F26CDDA119198580C270AD7ADE183A1A6DA46A434A713184B6B9B6B2904491B6223
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE INDEX [IX_ApplicationForms_ApplicationFormId1] ON [ApplicationForms] ([ApplicationFormId1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE INDEX [IX_ApplicationForms_DocumentReferenceId] ON [ApplicationForms] ([DocumentReferenceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE INDEX [IX_ApplicationForms_PartyId] ON [ApplicationForms] ([PartyId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE INDEX [IX_ApplicationForms_SupportingDocumentsSupportingDocumentId] ON [ApplicationForms] ([SupportingDocumentsSupportingDocumentId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE INDEX [IX_Documents_ApplicationFormId] ON [Documents] ([ApplicationFormId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE INDEX [IX_Parties_DocumentReferenceId] ON [Parties] ([DocumentReferenceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    CREATE INDEX [IX_SupportingDocuments_DocumentReferenceId] ON [SupportingDocuments] ([DocumentReferenceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD CONSTRAINT [FK_ApplicationForms_ApplicationForms_ApplicationFormId1] FOREIGN KEY ([ApplicationFormId1]) REFERENCES [ApplicationForms] ([ApplicationFormId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD CONSTRAINT [FK_ApplicationForms_DocumentReferences_DocumentReferenceId] FOREIGN KEY ([DocumentReferenceId]) REFERENCES [DocumentReferences] ([DocumentReferenceId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD CONSTRAINT [FK_ApplicationForms_Parties_PartyId] FOREIGN KEY ([PartyId]) REFERENCES [Parties] ([PartyId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD CONSTRAINT [FK_ApplicationForms_SupportingDocuments_SupportingDocumentsSupportingDocumentId] FOREIGN KEY ([SupportingDocumentsSupportingDocumentId]) REFERENCES [SupportingDocuments] ([SupportingDocumentId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [ApplicationForms] ADD CONSTRAINT [FK_ApplicationForms_TitleNumbers_TitleNumberId] FOREIGN KEY ([TitleNumberId]) REFERENCES [TitleNumbers] ([TitleNumberId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    ALTER TABLE [DocumentReferences] ADD CONSTRAINT [FK_DocumentReferences_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216102349_newDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210216102349_newDb', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    DECLARE @var21 sysname;
    SELECT @var21 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'Value');
    IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var21 + '];');
    ALTER TABLE [ApplicationForms] ALTER COLUMN [Value] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T18:18:14.7759958+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T18:18:14.7768200+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T18:18:14.7768228+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T18:18:14.7768231+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T18:18:14.7768233+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x6A8DE702A3359DF214E747D6FCDD2F8E027D83DF45233B3D8ABAF2A242F69CF8075F492A201FCA7F9D02621B3869814EDCBEE5BE5AE9147DE52C84D7934BDB79, [PasswordSalt] = 0x737B00B2608AFDC002FF9ACB04F9723EFADE5DE96EFA5D8358CEF81909CC013B3C34B10B6F31E68E6B2E870E72F047BC97D4E9F2B957B524A6456A8A44337BDC68E157C11FA0D717DDF869532AACC1D40CE621506657D429A2D41249038427ECCAF31D4484E4B366A9E16DDC7C398F421C6B808493DFC50230BC421E78FBB028
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216124815_priority')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210216124815_priority', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    ALTER TABLE [ApplicationForms] DROP CONSTRAINT [FK_ApplicationForms_ApplicationForms_ApplicationFormId1];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    DROP INDEX [IX_ApplicationForms_ApplicationFormId1] ON [ApplicationForms];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    DECLARE @var22 sysname;
    SELECT @var22 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'ApplicationFormId1');
    IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var22 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [ApplicationFormId1];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    ALTER TABLE [Documents] ADD [Base64] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T19:33:39.5931043+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T19:33:39.5942559+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T19:33:39.5942581+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T19:33:39.5942583+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T19:33:39.5942584+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xA8699A5609B42615199B50E5318289E2165DC99ACAB6D116741F4DD8FA0FA97DECEF559EE2815F6E5ABC4C5D99CA761E9CBA0ED83FF6F4C844BE0445D9FE253D, [PasswordSalt] = 0xCD4056D0737B1B9EF741C61AA2EC501351FA696ECB4FD6DDADAF88D4DDDBFBD687726EFDCFB6649F100D0979AD970C9B4D865800952B0287F7BED75D53E53946958CF8F189B17EB22CCA7A862A5996DA0F88595E9A5CCC7700176C66687A7E97ACAC14E7A263F363E1A425FE32EE8A69FBF4B842EFF5EB03B4182123E22CA235
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216140340_base64add')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210216140340_base64add', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [RegistrationTypeId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T21:29:30.5071410+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T21:29:30.5082246+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T21:29:30.5082269+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T21:29:30.5082271+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-16T21:29:30.5082273+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xD5103E5AD87204B759A929C002638D35FC53383297253846492DB92B5A7165C5C733815F39F66D20A67DB39F3DADACD81951CD98484E40B5E14227A369BAE9C3, [PasswordSalt] = 0xA719E503B492FD360473EF4EFCC76F95852F313C82FDD000D775B3BF807E6E097163424C6F9B6B8E3FF0A3A98E7680D1EE7211DD07813B3102136C5C09C1C85DAFBACC56BFB2C010191D1A9C22ECD8062C080B51A161E8A76DF68804F5ECA54E34BB05383D125D354BFC90A2A01E6EE73E614C422C8B195EA45AFFAB7DF6230B
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    CREATE INDEX [IX_DocumentReferences_RegistrationTypeId] ON [DocumentReferences] ([RegistrationTypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    ALTER TABLE [DocumentReferences] ADD CONSTRAINT [FK_DocumentReferences_RegistrationTypes_RegistrationTypeId] FOREIGN KEY ([RegistrationTypeId]) REFERENCES [RegistrationTypes] ([RegistrationTypeId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210216155930_regType')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210216155930_regType', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    ALTER TABLE [ApplicationForms] DROP CONSTRAINT [FK_ApplicationForms_TitleNumbers_TitleNumberId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    DROP INDEX [IX_ApplicationForms_TitleNumberId] ON [ApplicationForms];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    DECLARE @var23 sysname;
    SELECT @var23 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'TitleNumberId');
    IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var23 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [TitleNumberId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [MessageID] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:03:57.8929539+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:03:57.8945029+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:03:57.8945088+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:03:57.8945093+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:03:57.8945095+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x9EA8DC9FC698D6933DA2C5D26487DA6C1A21A850E7E36EC9B2A339B69F1029A2F42E0E2F0AA3478898D0D9CF024EF5B8498FBF9A8A72260B48FDEF021B65A4D6, [PasswordSalt] = 0x4A2F8689BF246DB5604340A14CAF185775A4A4A09C7456CCB69E57D8B9CDCE585FCD1DF49D2A1A61C404DE5144FA7FC55F58D99C7FFF0EC0BA89089A8B26A1BFC77EF542CF181A3B530B65AE9909E60B8FB46E22949C9088619136EE479EA67FCEF7E965B40F9F242C965EA4FB1990D78DAB70AA3B598D1D201AF3E25A61355D
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217033358_msgId')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217033358_msgId', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [AdditionalProviderFilter] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [ExternalReference] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:14:13.0791944+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:14:13.0800895+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:14:13.0800917+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:14:13.0800920+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:14:13.0800921+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xAAD67BCD536EE03EEB0FC76DE6095D1A6EF723628CC00D998ABBCD3B3B7A3BDE5EF1BD317F0511CE6E6685A0341FC021C1751B4C1D5FA7DD12A2DBE8EF14115E, [PasswordSalt] = 0x34736711811C9D423B18D0D2482E111ACBDE8B7C0875505BF4D8A7451457320FB392F9807AF8258255BD28E282C89AF3749A263EDB3327A155B2B4419A88FB6E1B32ED015331C29C5D546DC43A9A05AF294B721BDEAB1708166DBFB76693FAA7F28528E2D5F9D21E530E7288CDAAC4F7CC794DA2B1264808BDDD7228AECE3D81
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217034413_filter')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217034413_filter', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    ALTER TABLE [DocumentReferences] ADD [Password] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:37:21.5235846+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:37:21.5244829+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:37:21.5244857+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:37:21.5244860+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T09:37:21.5244862+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x4FE9F82AD29991837793C6E8B8CB2AE109356299CC8D4AB181AB65BAF83B383EE4B150365B3DD529A1E97E2B7CF3833B6746F5AA52FD8CB438F7AD8653C98449, [PasswordSalt] = 0xD4A51485ED052638D3518FC4575C36328DFF7761319E3E37277D07F081785C90D7D5EB48342B51319E61681B20FC99F23458DF514930B1755497D0F7797BFA9968748C73E8386335A36100365645AF5565A596271318D6B7E7E964E5EAB8AB30BA36FD8C00D0CBF141B45E26250F66AB1FB588E3FA2620EA15CCE30150BDCC22
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217040721_pass')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217040721_pass', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    ALTER TABLE [ApplicationForms] DROP CONSTRAINT [FK_ApplicationForms_Parties_PartyId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    ALTER TABLE [ApplicationForms] DROP CONSTRAINT [FK_ApplicationForms_SupportingDocuments_SupportingDocumentsSupportingDocumentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    DROP INDEX [IX_ApplicationForms_PartyId] ON [ApplicationForms];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    DROP INDEX [IX_ApplicationForms_SupportingDocumentsSupportingDocumentId] ON [ApplicationForms];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    DECLARE @var24 sysname;
    SELECT @var24 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'PartyId');
    IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var24 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [PartyId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    DECLARE @var25 sysname;
    SELECT @var25 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'SupportingDocumentsSupportingDocumentId');
    IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var25 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [SupportingDocumentsSupportingDocumentId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [CertifiedCopy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [ExternalReference] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:39:40.3296719+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:39:40.3307928+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:39:40.3307984+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:39:40.3307988+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:39:40.3307992+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xF284D12370CA313DEC9CBDE0039CA5C4D1A25A127CF74C25D7DB36ECCBEC496B54E36804FB5311ECD2DDF827CE7D168756D817881C1BA71E8C89C41DA5AFC5E8, [PasswordSalt] = 0x099CB2F8F3FB09820FF9AB7658A487CF5C2DED710FCD3CD0A2208073F52CA7061B2CE3F40D1D1C995EF635B3E64B3F4EE5931F4364FDDA0A581390CA3F1670AA0EAE46AA6823AEACB4CD51315FA8E1DB4C16B59B16C75D0C157D0CC55B88219E4BF80DD059EB27BE4A32BF551182D01C82B0248BE90B7BC18DAB4685B8479B85
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217050940_extRef')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217050940_extRef', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    DECLARE @var26 sysname;
    SELECT @var26 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationForms]') AND [c].[name] = N'CertifiedCopy');
    IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationForms] DROP CONSTRAINT [' + @var26 + '];');
    ALTER TABLE [ApplicationForms] DROP COLUMN [CertifiedCopy];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:40:53.6378455+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:40:53.6386698+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:40:53.6386720+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:40:53.6386722+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T10:40:53.6386723+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x0B3D461B4CB74253CA0AE50EAD4027CF6E1FD21B0103E1CB24A41C688C35FD28E9FF3DB28237BF5195DABE2BF3B09BC480A01F5F848AB41C232FB6D922203E17, [PasswordSalt] = 0x0E031C39C3127198673408B2AD86457E834BB33309509DC25551FB4DE566257AC17EFC2A3C610788A948DB8380B9B081D00DD762203CBE54489D46E8BB6DF0F60ED984AD8C87E97ABB46B0F0A08896960BB69FCB3146F06BC92FEB4D93555727A4B815043E793C84F9F4C0A6CE7FA54CA6157FC110F0E3AEC42FE2BDC83706F8
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217051054_removeCertCpy')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217051054_removeCertCpy', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    DROP INDEX [IX_Documents_ApplicationFormId] ON [Documents];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    DECLARE @var27 sysname;
    SELECT @var27 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Documents]') AND [c].[name] = N'CertifiedCopy');
    IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [Documents] DROP CONSTRAINT [' + @var27 + '];');
    ALTER TABLE [Documents] DROP COLUMN [CertifiedCopy];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [CertifiedCopy] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:41:42.0877703+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:41:42.0889654+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:41:42.0889684+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:41:42.0889686+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:41:42.0889688+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x2523EB277B61DC9B1ED4CE77EF873BF6A80B3720B2FF230DE88D61FE60A61118BBEEE9DAC47132E3BF39A62E446B86F21E366DC5AA027460524AD62481B717D3, [PasswordSalt] = 0xF54F1BA28DE38F6B29F0E6EF8377A52834E8DE286CF2F332593B9AF6942AB08990A9471F74EBDA32DB40885F5BFF7360596C4E25EFBFD7D55C246AEC92B62FB6065578439488FF753FAC6558C49472B1D1B98EBFCB72B3C491892FD7EB28A16B50FBF08C676A58D2A648111A467A17453238F9BDBB4DCC3454EBC6B37927C3B5
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    CREATE UNIQUE INDEX [IX_Documents_ApplicationFormId] ON [Documents] ([ApplicationFormId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061142_addcertcpy')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217061142_addcertcpy', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    DECLARE @var28 sysname;
    SELECT @var28 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DocumentReferences]') AND [c].[name] = N'TelephoneNumber');
    IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [DocumentReferences] DROP CONSTRAINT [' + @var28 + '];');
    ALTER TABLE [DocumentReferences] ALTER COLUMN [TelephoneNumber] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:47:08.3442867+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:47:08.3454807+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:47:08.3454835+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:47:08.3454838+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-17T11:47:08.3454839+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x5DABA61C0E4A85668828E0CD3E0E1AADE5E0B19B79F02CF83B90DA3CE19D56807C5E65998FC06A81C43105550A69A36C7216F15E32EC8B4DA4CBA3235A071539, [PasswordSalt] = 0xE2739D6DD418C9BDCCADC91F293D74E43AC7595A0074207A3A6BA01F544324B7743D531069CFD72E1A9939C5DC5DA698E1445E5CC2823D49A327DC09ABE039E4069E21101392132995EF3ED7CE35F1FE4ED85A904E3D08646E9B9328740F4A3C141E831BE500C8E0AA2DFABE63881006D7E70ECB992272E7ACA4843B5D7AA575
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217061708_TPtoStr')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217061708_TPtoStr', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeName] = N'Transfer and charge', [UpdatedDate] = '2021-02-17T16:56:37.5285103+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeName] = N'Remortgage', [UpdatedDate] = '2021-02-17T16:56:37.5293102+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeName] = N'Transfer of equity', [UpdatedDate] = '2021-02-17T16:56:37.5293126+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'rem_frm', [TypeName] = N'Restriction, hostile takeover', [UpdatedDate] = '2021-02-17T16:56:37.5293129+05:30', [Url] = N'removal-form'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'transfer', [TypeName] = N'Change of name', [UpdatedDate] = '2021-02-17T16:56:37.5293131+05:30', [Url] = N'transfer'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RegistrationTypeId', N'Status', N'TypeCode', N'TypeName', N'UpdatedDate', N'Url') AND [object_id] = OBJECT_ID(N'[RegistrationTypes]'))
        SET IDENTITY_INSERT [RegistrationTypes] ON;
    INSERT INTO [RegistrationTypes] ([RegistrationTypeId], [Status], [TypeCode], [TypeName], [UpdatedDate], [Url])
    VALUES (CAST(6 AS bigint), CAST(1 AS bit), N'transfer', N'Dispositionary first lease', '2021-02-17T16:56:37.5293132+05:30', N'transfer'),
    (CAST(7 AS bigint), CAST(1 AS bit), N'transfer', N'Transfer of part', '2021-02-17T16:56:37.5293133+05:30', N'transfer'),
    (CAST(8 AS bigint), CAST(1 AS bit), N'transfer', N'Lease extension', '2021-02-17T16:56:37.5293135+05:30', N'transfer');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RegistrationTypeId', N'Status', N'TypeCode', N'TypeName', N'UpdatedDate', N'Url') AND [object_id] = OBJECT_ID(N'[RegistrationTypes]'))
        SET IDENTITY_INSERT [RegistrationTypes] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x6B1905D81F73E8ACF08D49AFB88969899DA8D413877AA3095D0BC816712751B8EAA7ADD77819CE9CEB353A026F9B70C60D83F39890EDD5BCD9AFDF3583A5F5F2, [PasswordSalt] = 0x460222E7AFF51F99922C8EF41D965DF52A9550B0B84B34CC27D3F64C0D3B03CEC7AD2972D99777C4AEA68274669E88647D206337753207141E1CB335962193FF2F79AA900B698A0BEBA3478629DB00B067832F50515F4B3E2D5213625E055ED87F2C2C19D2DBFE310B52D65DC4856CD283F1B37C065E80FAD9E7A692744FD382
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210217112637_newRegTypes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210217112637_newRegTypes', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    CREATE TABLE [RequestLogs] (
        [RequestLogId] bigint NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [TypeCode] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CreatedDate] datetime2 NOT NULL DEFAULT (GETDATE()),
        [File] nvarchar(max) NULL,
        CONSTRAINT [PK_RequestLogs] PRIMARY KEY ([RequestLogId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9047451+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9056119+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9056147+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9056149+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9056151+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9056153+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9056155+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:04:47.9056156+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xDFD259980FF351C9C52C6DD388BC72AB394682738AF0D8964299D113003BA0E219631F7A4814EBDB425A988AC9956EA7CA603C47A6B7F99FBD0F3DB5F01E1F1B, [PasswordSalt] = 0xAAFFA764C84DF757DF0436F2A3E748A2BB7EAEE0EEC182B006D8D4892A97162F72E083046E118064D45BB38D9B9B12291BCD0FCC00DE745BAB6780A2EAC1AD142D1B57B11419DD7F29056E2614C6024F993D3E88651FEE3B2BC60E500111A600F62C9D7FFA0AA366FBE6ED3D156854789FAC6A78DB96241C2664C3071E407A37
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043448_logs')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210219043448_logs', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    DECLARE @var29 sysname;
    SELECT @var29 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RequestLogs]') AND [c].[name] = N'TypeCode');
    IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [RequestLogs] DROP CONSTRAINT [' + @var29 + '];');
    ALTER TABLE [RequestLogs] ALTER COLUMN [TypeCode] int NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2066429+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2076213+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2076252+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2076255+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2076257+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2076259+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2076261+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:09:19.2076262+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x627F0F7A2D2E22CA8089BAD1E6C43B275C20D894E5EDC132A78CDCEEB1517744FA1C330B3777E1C9990C32121FC0DED3290FCB4EAD6B3BD2C994A9A077D1D09A, [PasswordSalt] = 0x92E40DCFE195151BA6E86AAF1474820FA6AB76E75DFE3812D1E495945F4F046CD72EDC9FC26B6A6708A95BFA14CF0B51205AFAADA97F1B425DE255DE6BAB2F2CE04A0908400985B2AD959A208FA7E29FE1D22B67ED973B3C8C39D6B36261F0ECF7D16B3081B103D0E1E10F63E5829D3547BE3BF7A9FD576F22302778E2929686
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219043919_typeCode')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210219043919_typeCode', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    ALTER TABLE [RequestLogs] ADD [DocumentReferenceId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7352866+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7361017+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7361040+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7361042+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7361044+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7361046+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7361047+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T10:11:07.7361049+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x1D70DC031AB2675910E36BCEC6ECB59DE44F5F4C203792992E81A62ABD32A3D4B0EEB1B908EA856BE35138CF70C8DBD4E9020715A41C23F7968DF3215FE947A8, [PasswordSalt] = 0x7A152FAACF208ECF293544963DC532F7B0376603842497DBDBD629762761EDBD939184DC542AD294293CA44798E798DDCC454288EF05F698A0DC758312C2D67D3532961A81FAFAFF5EE5CDFBC89F4C8241B5428F76E768928BF5FE58C9B92FC7038920BB221D562EAE893DE21523F9995874677F30CAB9C47AC9C2F50DAA5947
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    CREATE INDEX [IX_RequestLogs_DocumentReferenceId] ON [RequestLogs] ([DocumentReferenceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    ALTER TABLE [RequestLogs] ADD CONSTRAINT [FK_RequestLogs_DocumentReferences_DocumentReferenceId] FOREIGN KEY ([DocumentReferenceId]) REFERENCES [DocumentReferences] ([DocumentReferenceId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219044108_refId')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210219044108_refId', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    ALTER TABLE [TitleNumbers] ADD [LesseeTitleNumber] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    CREATE TABLE [AttachmentNotes] (
        [AttachmentNotesId] bigint NOT NULL IDENTITY,
        [AdditionalProviderFilter] nvarchar(max) NULL,
        [MessageId] bigint NOT NULL,
        [ExternalReference] nvarchar(max) NULL,
        [ApplicationMessageId] nvarchar(max) NULL,
        [ApplicationService] nvarchar(max) NULL,
        [Notes] nvarchar(max) NULL,
        [DocumentReferenceId] bigint NOT NULL,
        CONSTRAINT [PK_AttachmentNotes] PRIMARY KEY ([AttachmentNotesId]),
        CONSTRAINT [FK_AttachmentNotes_DocumentReferences_DocumentReferenceId] FOREIGN KEY ([DocumentReferenceId]) REFERENCES [DocumentReferences] ([DocumentReferenceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4559544+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4576457+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4576488+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4576491+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4576493+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4576495+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4576496+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:12:49.4576498+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x04EFA6D4ECB723C6C5C5A05932A67C98C529924D2682549DCA7B1CC8DC2BE911F7AD99FAC71933152F744D0CC68B891E2BBA8DCBE6789F4FD52C0A6CEB38A47E, [PasswordSalt] = 0xCA4F753819899C46934D1FABD9BDDB46CC9C683DBEDA19290762AD631A9A54C8D36ABF728FF070A29A32A7191D19918DFBCAF3E42BCEF6FFB99C6C4A280CCD3795EFBDA6984BD829EFE9D933313A98DD1B31EF418BE77A91C8D12C2E3816C10AFFB2CDD3AA2698D4636983EC649221F7E1D9B1E5E09AF0EDD0ED2D43061D5F19
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    CREATE INDEX [IX_AttachmentNotes_DocumentReferenceId] ON [AttachmentNotes] ([DocumentReferenceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219064250_lessetitle')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210219064250_lessetitle', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:38:46.2659277+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:38:46.2668045+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:38:46.2668070+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:38:46.2668072+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:38:46.2668074+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:38:46.2668076+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-19T12:38:46.2668077+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'lease_ext', [UpdatedDate] = '2021-02-19T12:38:46.2668079+05:30', [Url] = N'lease-extension'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x6110FF2B277923071EFDCC39BDF0DF59D3833B48225D6E64ADA0688FD8506982998C20E11CEBB57400B1063F207C348B584B33BC355BBC24B3F63651816596CB, [PasswordSalt] = 0xF42B8526EE8E5F7201213BF1815871CA63C453D8C055CD8B29AF839F8E434349FCD366D66199DFE81087BCF839A48BA9C7073325DD4470763CD61A9BF49396EE67015B3F4F87DE52D57E7D00180D2077AB80CD43ABABB8E96B42BFB48F2EC45862F21817A432C5482CF30DE788F912C66E060478EAFA88E8287B3A6827FB7EE2
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210219070846_editLeaseExtUrl')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210219070846_editLeaseExtUrl', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [ChargeDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [MDRef] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    ALTER TABLE [ApplicationForms] ADD [Variety] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'trns_chrge', [UpdatedDate] = '2021-02-22T08:43:40.3139895+05:30', [Url] = N'transfer-and-charge'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T08:43:40.3148437+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T08:43:40.3148461+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T08:43:40.3148463+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T08:43:40.3148465+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T08:43:40.3148466+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T08:43:40.3148468+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T08:43:40.3148469+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x99F12B9AD98C23075D72708EE25FA874CC6A6F2A2C0A82EC9381C4F94FE0AAA638FDAE1E922C4377D5174D4B8EEC28D7F0110229102398E89D63D78CAD5C9085, [PasswordSalt] = 0xB3041D9BC0D6BD20387BAA61FB679EC480CC67FA645146BB307BC6457FD5AE7CB8EA998ED613F5BD113F511956FFE987817D3FF24FA5C5ED0F8A2F6E7E199B9612ABC1DCCD9B676449C7B86A8EE1643E572738D3796224F50259A7A35294014FB50D53491EA167F98FF7808590DC571BCF4117FD6338469A4FF997DE7FF076D3
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222031340_newTit')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210222031340_newTit', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    CREATE TABLE [Representations] (
        [RepresentationId] bigint NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [RepresentativeId] bigint NOT NULL,
        [Name] nvarchar(max) NULL,
        [Reference] nvarchar(max) NULL,
        [DxNumber] bigint NOT NULL,
        [DxExchange] nvarchar(max) NULL,
        [DocumentReferenceId] bigint NOT NULL,
        CONSTRAINT [PK_Representations] PRIMARY KEY ([RepresentationId]),
        CONSTRAINT [FK_Representations_DocumentReferences_DocumentReferenceId] FOREIGN KEY ([DocumentReferenceId]) REFERENCES [DocumentReferences] ([DocumentReferenceId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4630619+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4641967+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4641999+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4642002+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4642004+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4642006+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4642009+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T11:47:27.4642011+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xCF0C614B533BB6DCDC96CE80714E95A53D2B4223A683B4CB1652CA841EB7F7BC4FC9318EA3D11E5970E8F0E1DEEB34D32FABBD25F051EEF7AF935CEC7B00892C, [PasswordSalt] = 0xC9B9B8DB9EF51765BB0DB17974A7F1280432D785B2FD06756B4BA6587136BDDC1B2AB347D75066576824A98DBF15527E36D6D1AEB823F2C9482FD349301159578A21719AB3877D5928D401EACEDFD3E34B888F622E69A71720C07B801193BE6A1A30C676E6C92217896F1B42105612892820FE37860029266FE80443070AD305
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    CREATE INDEX [IX_Representations_DocumentReferenceId] ON [Representations] ([DocumentReferenceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222061728_representation')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210222061728_representation', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:36:13.6713160+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'rem_gage', [UpdatedDate] = '2021-02-22T16:36:13.6727475+05:30', [Url] = N'remortgage'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:36:13.6727510+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:36:13.6727513+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:36:13.6727515+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:36:13.6727517+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:36:13.6727519+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:36:13.6727521+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x1C69C0DE5299E9A8417D13E720E72895A39670AAABC9464181A432CB2AF8421426BE1DFD95CC5CF1D6674F78B2BB3E9AA8123B988FA04DF4E6636371EB5AAFB7, [PasswordSalt] = 0x1D90F4D5CCA03BAD7EFEF8AD7B34307671767655AB13600340B0177D5C6623F331A96452A1C915AB2969319308A76A868C1F7A5BA15FE0A62CF3B64094027EE39F082302EC285F16230D9D1A8FA53FE9BE2656948251626E41C246942275448348C4AF56684B20ED1691805BCB1CD199707D1E55CAF9C1AFA7A2ACFEEB0F5B32
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222110614_remgage')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210222110614_remgage', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    ALTER TABLE [Parties] ADD [AddressForService] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8736957+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8751795+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8751834+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8751838+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8751841+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8751844+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8751846+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-22T16:57:48.8751848+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x91D923F9A08A8213240AF28732CD69333DA10E00A1A977756A45CD5B6037B3343FBA969C057F6005F86373073106B912A17B6C9326752D8586E3A249F478677B, [PasswordSalt] = 0x3777B196119BA75035BF4CE82863940C8635B659EA139571F14E90D968C80E7315FED8A4C8C7CA3AE6455AD0B4C40105E39E65E82D91EEF7AF92A41035F5E05E9118192F2947CAF97C7B401A56078906EB5F12E7E9CDB8EFA0241ECFE4257F83871C66C75004F612AA149DF6B6513933C835215A7A170655808DAC7951C6F1FD
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210222112749_addForSer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210222112749_addForSer', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-23T10:59:35.4355116+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-23T10:59:35.4366048+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'trns_eqty', [UpdatedDate] = '2021-02-23T10:59:35.4366070+05:30', [Url] = N'transfer-equity'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-23T10:59:35.4366073+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-23T10:59:35.4366074+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-23T10:59:35.4366075+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-23T10:59:35.4366077+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-23T10:59:35.4366078+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x93894162E8509FAB0C41D6A8A441A365C87F4BA1D06F04D44CEC7ACD0A3324C6B0BEAF3F96A509208F5655873E3C2EE40AC915EA846727A72DF0EECE89F46C42, [PasswordSalt] = 0xE8FE8FA18306679D2B31545B2C564E38492331F3E3C81B7530C5031ABE3F60292874E7282D1BA9C6562508FCF0EB8F7013D2FEC138D11679A118786E73CB8FC5C61E3B624A3098399AF7DCF7568A3CA2FB78C1BD4A6C61BF81004528146D0779357C750FD27478C0E6FA63F6B8831D9E063830E8F5A908C09CA4DAC8FEAF08A5
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210223052935_trnsf-equty')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210223052935_trnsf-equty', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-24T09:55:03.8709452+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-24T09:55:03.8720528+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-24T09:55:03.8720550+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-24T09:55:03.8720553+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'chngName', [UpdatedDate] = '2021-02-24T09:55:03.8720554+05:30', [Url] = N'change-name'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-24T09:55:03.8720556+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-24T09:55:03.8720558+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-24T09:55:03.8720559+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xD569F7BA2DC5854C02732DC84256D83B9635474CDC990CE6CB2152C806FA7726C8E296DF0E98BCC404993E9A0DDA7905B068D7698A60C6CEDD33DA3AF1569658, [PasswordSalt] = 0xCD2723F1E3BF75EDEC11740BB5E3DEBB198BC2731310E4708BF82D33F38B1F1539E5B1F94F9D2D11DABF1786AB3101A64A7A9044D3BFDFC2C6F5976E3D6338AC0D756C602BF33A8CFC325B6DE57EB1F9862837787A59489E9DC1E6B6E49C6BFD969180A323363BC230329ED6C27FEB8D1F6E7960FFF5C6B06851C0755477274B
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210224042504_changeOfName')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210224042504_changeOfName', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T13:21:47.2419949+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T13:21:47.2432252+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T13:21:47.2432285+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T13:21:47.2432288+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T13:21:47.2432290+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [TypeCode] = N'dispositionary', [UpdatedDate] = '2021-02-25T13:21:47.2432291+05:30', [Url] = N'dispositionary'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T13:21:47.2432293+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T13:21:47.2432294+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x58B55E9CAA5C748B5360713FE612036722EDF5D6776C9BD9BB32FCC51ADDDA58E6E60120C2E033072D72E70D405DD0B6C122353369961CEFA229E61BF3A6BD5B, [PasswordSalt] = 0x54E2D045D0683CFD087FA84B6E7113BCC969B7CC08A92D2B6AB063B9A5F3FC0A44D7D381364FB6F50FE6A17CA7D4981C39B8517D252BA12DE23656E191C148BCFADF7A8427A531E23A6863D6FB9360D8E545F126A277E482ED59D875F2D703E046CE04F12FE21CF5AACA56F8B6A99EA6484C8BF16FA8B2CA21B6C7D91D592CB2
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225075147_dispositionary')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210225075147_dispositionary', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    DECLARE @var30 sysname;
    SELECT @var30 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Representations]') AND [c].[name] = N'DxExchange');
    IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [Representations] DROP CONSTRAINT [' + @var30 + '];');
    ALTER TABLE [Representations] DROP COLUMN [DxExchange];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    DECLARE @var31 sysname;
    SELECT @var31 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Representations]') AND [c].[name] = N'DxNumber');
    IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [Representations] DROP CONSTRAINT [' + @var31 + '];');
    ALTER TABLE [Representations] DROP COLUMN [DxNumber];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    ALTER TABLE [Representations] ADD [AddressType] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    ALTER TABLE [Representations] ADD [DxAddressId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    ALTER TABLE [Representations] ADD [PostalAddressId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    CREATE TABLE [DxAddress] (
        [DxAddressId] bigint NOT NULL IDENTITY,
        [DxNumber] bigint NOT NULL,
        [DxExchange] nvarchar(max) NULL,
        CONSTRAINT [PK_DxAddress] PRIMARY KEY ([DxAddressId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    CREATE TABLE [PostalAddress] (
        [PostalAddressId] bigint NOT NULL IDENTITY,
        [AddressLine1] nvarchar(max) NULL,
        [AddressLine2] nvarchar(max) NULL,
        [AddressLine3] nvarchar(max) NULL,
        [AddressLine4] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [County] nvarchar(max) NULL,
        [Country] nvarchar(max) NULL,
        [PostCode] nvarchar(max) NULL,
        CONSTRAINT [PK_PostalAddress] PRIMARY KEY ([PostalAddressId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8809328+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8819409+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8819439+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8819442+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8819444+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8819445+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8819447+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T17:59:08.8819449+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x0DE1D5B947BFEFEDDC486BA7BE8E82A4F982B09BA2AFA619DD80FC25E0325C2D4AF06323B1A14D105E43A03B7B001E628D8F3EEFE0F805086F78C351EC3890B1, [PasswordSalt] = 0xD149BDF060C753F2531BF164012BDD0C6F53FCE0DB26B520B2AD5755A7EE2FD1D8A0362D930D466140695A7F757CA517C1524C59FE330BE83FC45205D8CDA28F9CC644E402170AE6AFFAD9C499357ACC8A0664F4486EB36D12F147B7B2E46DD8F595C618B511649AEF25D4618E2F4D566CCAC4EE2A40EFB99504E210091A2BA9
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    CREATE INDEX [IX_Representations_DxAddressId] ON [Representations] ([DxAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    CREATE INDEX [IX_Representations_PostalAddressId] ON [Representations] ([PostalAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    ALTER TABLE [Representations] ADD CONSTRAINT [FK_Representations_DxAddress_DxAddressId] FOREIGN KEY ([DxAddressId]) REFERENCES [DxAddress] ([DxAddressId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    ALTER TABLE [Representations] ADD CONSTRAINT [FK_Representations_PostalAddress_PostalAddressId] FOREIGN KEY ([PostalAddressId]) REFERENCES [PostalAddress] ([PostalAddressId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225122909_addressTypes')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210225122909_addressTypes', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [Representations] DROP CONSTRAINT [FK_Representations_DxAddress_DxAddressId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [Representations] DROP CONSTRAINT [FK_Representations_PostalAddress_PostalAddressId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [PostalAddress] DROP CONSTRAINT [PK_PostalAddress];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [DxAddress] DROP CONSTRAINT [PK_DxAddress];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    EXEC sp_rename N'[PostalAddress]', N'PostalAddresses';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    EXEC sp_rename N'[DxAddress]', N'DxAddresses';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [PostalAddresses] ADD CONSTRAINT [PK_PostalAddresses] PRIMARY KEY ([PostalAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [DxAddresses] ADD CONSTRAINT [PK_DxAddresses] PRIMARY KEY ([DxAddressId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3839146+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3853739+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3853779+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3853783+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3853785+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3853786+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3853788+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:00:10.3853790+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x33ED458C7E7B27BE03B0DF598AE0E6FD181E307C6973A1C33173D44E61DFA3B428FDC92DBA302D28B94F1D04DBA725C38E8912E0B7035FE6F899CE15CF1C3B3C, [PasswordSalt] = 0x9BC3F1A86CC3C0F0D66399504B25627F0412BE9D2B91F4D85C925A5764730FA082BD95E92F7A59C37C178D6AB355E6E13DBD2E004FD96B208CAE9F8E0D6ED02965D9B86CDED5A67E4446353B2DA719B1BD8D2FA7F16FA667CB18315F6B26244E2C51269DD855FAFF25A68B213470C8329BE312B2E8D6FE5ED8133E94B5C0CC78
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [Representations] ADD CONSTRAINT [FK_Representations_DxAddresses_DxAddressId] FOREIGN KEY ([DxAddressId]) REFERENCES [DxAddresses] ([DxAddressId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    ALTER TABLE [Representations] ADD CONSTRAINT [FK_Representations_PostalAddresses_PostalAddressId] FOREIGN KEY ([PostalAddressId]) REFERENCES [PostalAddresses] ([PostalAddressId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123011_addressTypesv2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210225123011_addressTypesv2', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] DROP CONSTRAINT [FK_Representations_DxAddresses_DxAddressId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] DROP CONSTRAINT [FK_Representations_PostalAddresses_PostalAddressId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    DROP TABLE [DxAddresses];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    DROP TABLE [PostalAddresses];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    DROP INDEX [IX_Representations_DxAddressId] ON [Representations];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    DROP INDEX [IX_Representations_PostalAddressId] ON [Representations];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    DECLARE @var32 sysname;
    SELECT @var32 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Representations]') AND [c].[name] = N'DxAddressId');
    IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [Representations] DROP CONSTRAINT [' + @var32 + '];');
    ALTER TABLE [Representations] DROP COLUMN [DxAddressId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    DECLARE @var33 sysname;
    SELECT @var33 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Representations]') AND [c].[name] = N'PostalAddressId');
    IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [Representations] DROP CONSTRAINT [' + @var33 + '];');
    ALTER TABLE [Representations] DROP COLUMN [PostalAddressId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [AddressLine1] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [AddressLine2] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [AddressLine3] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [AddressLine4] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [City] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [Country] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [County] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [DxExchange] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [DxNumber] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    ALTER TABLE [Representations] ADD [PostCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2098067+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2110334+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2110360+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2110364+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2110366+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2110368+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2110369+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T18:01:27.2110370+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0xA8E65A762B0861403FC01825CEE03C0107EC96FDF99360832BB9FC214F548CBA27E4CDE399F7A9CDEBB1D62FD21279E8583D75AE2FE97C9CC578D11C61DFB960, [PasswordSalt] = 0x9DFFBE176BECCD0827EA75FCE258AD74824A84F16869206342073EA44520DB3E41D62A41CE19B89DD3EFA14719DA64F67EEEE5076A10E16E3A6781CAED1886D5CEB8FCCE9CC15DD670932A7CEA18BD931D9827F0E94FC4C0C428F64230DCD0B876DD8BF08A6D21B4618F0F1BD0569C64E110E51BC9F498C0475F5118F710355F
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225123127_addressTypesv3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210225123127_addressTypesv3', N'3.1.11');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    ALTER TABLE [Representations] ADD [CareOfName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    ALTER TABLE [Representations] ADD [CareOfReference] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2318915+05:30'
    WHERE [RegistrationTypeId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2332233+05:30'
    WHERE [RegistrationTypeId] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2332272+05:30'
    WHERE [RegistrationTypeId] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2332274+05:30'
    WHERE [RegistrationTypeId] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2332275+05:30'
    WHERE [RegistrationTypeId] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2332277+05:30'
    WHERE [RegistrationTypeId] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2332278+05:30'
    WHERE [RegistrationTypeId] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [RegistrationTypes] SET [UpdatedDate] = '2021-02-25T19:00:14.2332280+05:30'
    WHERE [RegistrationTypeId] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    UPDATE [Users] SET [PasswordHash] = 0x9B4A9E9CDF9BDD9FD1A9809B761FE084B05D8EB909D4A1EFB50742B2E0B1BADC767185A1E08B957F8D7294FD2846DE7F6CFF07D1C9EC90CF67028267C122A892, [PasswordSalt] = 0xF0A4B91EF10B953A3E8656609F5CAC5D47DB1037F2DA602DD7A8900CD084D1B50561D75BA4804BD761EAC62D04821C5038CD59C801D96C7B110023E8BC2441546A408D3BBACBEAEBDE072AE176F9686F9F41B4ADB85ED225DF416F4A741047141715CF73D620E411AC908BD8B2A7300039AACAECDF5282D7DE52F664A5E2D325
    WHERE [UserId] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225133014_careofaddress')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210225133014_careofaddress', N'3.1.11');
END;

GO


-- Создание таблицы Оплаты
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Оплаты]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Оплаты](
        [Код_оплаты] [int] IDENTITY(1,1) NOT NULL,
        [Код_заказа] [int] NOT NULL,
        [Дата_оплаты] [datetime] NOT NULL,
        [Сумма] [decimal](18, 2) NOT NULL,
        [Способ_оплаты] [nvarchar](100) NOT NULL,
        [Код_клиента] [int] NOT NULL,
        CONSTRAINT [PK_Оплаты] PRIMARY KEY CLUSTERED ([Код_оплаты] ASC),
        CONSTRAINT [FK_Оплаты_Заказы] FOREIGN KEY([Код_заказа])
            REFERENCES [dbo].[Заказы] ([Код_заказа])
            ON DELETE CASCADE,
        CONSTRAINT [FK_Оплаты_Клиенты] FOREIGN KEY([Код_клиента])
            REFERENCES [dbo].[Клиенты] ([Код_клиента])
            ON DELETE CASCADE
    ) ON [PRIMARY]
    
    PRINT 'Таблица Оплаты успешно создана!'
END
ELSE
BEGIN
    PRINT 'Таблица Оплаты уже существует.'
END
GO


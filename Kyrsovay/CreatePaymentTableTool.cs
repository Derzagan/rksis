using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public static class CreatePaymentTableTool
    {
        public static void CreatePaymentTable()
        {
            string connectionString = Properties.Settings.Default.service_centerIsaConnectionString;

            string sqlScript = @"
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
    
    SELECT 'Таблица Оплаты успешно создана!' AS Result
END
ELSE
BEGIN
    SELECT 'Таблица Оплаты уже существует.' AS Result
END";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlScript, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        string message = result?.ToString() ?? "Таблица Оплаты проверена.";
                        MessageBox.Show(message, "Создание таблицы", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании таблицы:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


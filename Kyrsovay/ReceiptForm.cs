using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Kyrsovay
{
    public partial class ReceiptForm : Form
    {
        private int _orderId;
        private string _connectionString;

        public ReceiptForm(int orderId, string connectionString)
        {
            _orderId = orderId;
            _connectionString = connectionString;
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            LoadReceiptData();
            reportViewer1.RefreshReport();
        }

        private void LoadReceiptData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            c.ФИО AS ClientName,
                            ISNULL(s.ФИО, 'Не назначен') AS MasterName,
                            z.Серийный_номер AS Device,
                            z.Описание AS Issue,
                            z.Цена AS Price,
                            o.Дата_оплаты AS PaymentDate,
                            z.Код_заказа AS OrderNumber,
                            o.Код_оплаты AS PaymentNumber,
                            o.Способ_оплаты AS PaymentMethod
                        FROM Оплаты o
                        JOIN Заказы z ON o.Код_заказа = z.Код_заказа
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        LEFT JOIN Сотрудники s ON z.Код_сотрудника = s.Код_сотрудника
                        WHERE o.Код_заказа = @orderId";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@orderId", _orderId);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource dataSource = new ReportDataSource("ReceiptDataSet", table);
                        reportViewer1.LocalReport.DataSources.Add(dataSource);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных чека: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class ManagerMainForm : MetroForm
    {
        private readonly int _employeeId;

        public ManagerMainForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;

            // Оформление Metro
            this.Style = MetroColorStyle.Blue;
            this.Theme = MetroThemeStyle.Dark;
            this.Text = "Журнал заказов (приёмщик)";
        }

        private void ManagerMainForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            string connectionString = Properties.Settings.Default.service_centerIsaConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            z.Код_заказа,
                            z.Дата_заказа,
                            z.Дата_возврата,
                            z.ФИО_заказчика,
                            z.Серийный_номер,
                            z.Код_вида,
                            z.Код_магазина,
                            z.Отметка_о_гарантии,
                            z.Срок_гарантии,
                            z.Цена,
                            z.Код_сотрудника
                        FROM Заказы z
                        ORDER BY z.Дата_заказа DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable table = new DataTable();
                        da.Fill(table);

                        metroGridOrders.DataSource = table;
                    }
                }

                metroGridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                metroGridOrders.ReadOnly = true;
                metroGridOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                metroGridOrders.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(
                    this,
                    "Ошибка загрузки заказов: " + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

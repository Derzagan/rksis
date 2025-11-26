using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class MasterMainForm : Form
    {
        private int _employeeId;

        public MasterMainForm()
        {
            InitializeComponent();
        }

        public MasterMainForm(int employeeId) : this()
        {
            _employeeId = employeeId;
        }

        private void MasterMainForm_Load(object sender, EventArgs e)
        {
            LoadMyOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMyOrders();
        }

        private void LoadMyOrders()
        {
            string connectionString = Properties.Settings.Default.service_centerIsaConnectionString;

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
                        z.Цена
                    FROM Заказы z
                    WHERE z.Код_сотрудника = @empId
                    ORDER BY z.Дата_заказа DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@empId", _employeeId);

                    DataTable table = new DataTable();
                    da.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class MasterMainForm : Form
    {
        private int _employeeId;
        private string _connectionString = Properties.Settings.Default.service_centerIsaConnectionString;

        private int _selectedOrderId = -1;

        public MasterMainForm(int employeeId)
        {
            InitializeComponent();

            _employeeId = employeeId;

            // --- Привязка событий ---
            btnMyOrders.Click += BtnMyOrders_Click;
            btnInProgress.Click += BtnInProgress_Click;
            btnLogout.Click += BtnLogout_Click;
            btnLogout2.Click += BtnLogout2_Click;

            btnOpenOrder.Click += BtnOpenOrder_Click;
            btnStartWork.Click += BtnStartWork_Click;
            btnNeedParts.Click += BtnNeedParts_Click;
            btnFinishRepair.Click += BtnFinishRepair_Click;

            // Центрирование
            this.Resize += MasterMainForm_Resize;

            LoadMyOrders();
            ShowPanel(panelOrders);
        }

        // ======================================================
        // Центрирование панелей
        // ======================================================
        private void MasterMainForm_Resize(object sender, EventArgs e)
        {
            Center(panelOrdersCenter);
            Center(panelDetailCenter);
        }

        private void Center(Control c)
        {
            if (c == null) return;

            c.Left = (panelContent.Width - c.Width) / 2;
            c.Top = (panelContent.Height - c.Height) / 2;
        }

        private void ShowPanel(Panel p)
        {
            panelOrders.Visible = false;
            panelOrderDetails.Visible = false;

            p.Visible = true;

            Center(panelOrdersCenter);
            Center(panelDetailCenter);
        }

        // ======================================================
        // Загрузка заявок мастера
        // ======================================================
        private void LoadMyOrders()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        Код_заказа,
                        Дата_заказа,
                        Серийный_номер,
                        Описание,
                        Цена,
                        Статус
                    FROM Заказы
                    WHERE Код_сотрудника = @id
                    ORDER BY Дата_заказа DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", _employeeId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridOrders.DataSource = dt;
            }
        }

        // ======================================================
        // Загрузка заявок "в работе"
        // ======================================================
        private void LoadOrdersInProgress()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        Код_заказа,
                        Дата_заказа,
                        Серийный_номер,
                        Описание,
                        Цена,
                        Статус
                    FROM Заказы
                    WHERE Код_сотрудника = @id
                    AND Статус = N'В работе'
                    ORDER BY Дата_заказа DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@id", _employeeId);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridOrders.DataSource = dt;
            }
        }

        // ======================================================
        // Обработчики кнопок меню
        // ======================================================
        private void BtnMyOrders_Click(object sender, EventArgs e)
        {
            LoadMyOrders();
            ShowPanel(panelOrders);
        }

        private void BtnInProgress_Click(object sender, EventArgs e)
        {
            LoadOrdersInProgress();
            ShowPanel(panelOrders);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void BtnLogout2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        // ======================================================
        // Открыть заявку
        // ======================================================
        private void BtnOpenOrder_Click(object sender, EventArgs e)
        {
            if (gridOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заявку!");
                return;
            }

            _selectedOrderId = Convert.ToInt32(
                gridOrders.SelectedRows[0].Cells["Код_заказа"].Value
            );

            LoadOrderDetails(_selectedOrderId);
            ShowPanel(panelOrderDetails);
        }

        // ======================================================
        // Детали заявки
        // ======================================================
        private void LoadOrderDetails(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        z.Описание,
                        z.Цена,
                        z.Статус,
                        z.Серийный_номер,
                        c.ФИО AS Клиент
                    FROM Заказы z
                    JOIN Клиенты c
                        ON z.Код_клиента = c.Код_клиента
                    WHERE Код_заказа = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", orderId);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    lblClientName.Text = "Клиент: " + rd["Клиент"].ToString();
                    lblDeviceInfo.Text = "Устройство: " + rd["Серийный_номер"].ToString();
                    lblStatus.Text = "Статус: " + rd["Статус"].ToString();

                    txtWorkComment.Text = rd["Описание"].ToString();
                    txtRepairPrice.Text = rd["Цена"].ToString();
                }
            }
        }

        // ======================================================
        // Изменение статусов
        // ======================================================
        private void BtnStartWork_Click(object sender, EventArgs e)
        {
            UpdateStatus("В работе");
        }

        private void BtnNeedParts_Click(object sender, EventArgs e)
        {
            UpdateStatus("Ожидание запчастей");
        }

        private void BtnFinishRepair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRepairPrice.Text))
            {
                MessageBox.Show("Введите итоговую цену!");
                return;
            }

            UpdateStatus("Готово", txtRepairPrice.Text);
        }

        private void UpdateStatus(string newStatus, string price = null)
        {
            if (_selectedOrderId == -1)
                return;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql;

                if (price == null)
                {
                    sql = @"UPDATE Заказы 
                            SET Статус=@s 
                            WHERE Код_заказа=@id";
                }
                else
                {
                    sql = @"UPDATE Заказы 
                            SET Статус=@s, Цена=@p 
                            WHERE Код_заказа=@id";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@s", newStatus);
                cmd.Parameters.AddWithValue("@id", _selectedOrderId);

                if (price != null)
                    cmd.Parameters.AddWithValue("@p", price);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Статус обновлён!");

            LoadOrderDetails(_selectedOrderId);
            LoadMyOrders();
        }
    }
}

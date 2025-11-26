using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class ManagerMainForm : Form
    {
        private int _employeeId;
        private string _connectionString = Properties.Settings.Default.service_centerIsaConnectionString;

        private int _selectedOrderId = -1;   // выбранная заявка

        public ManagerMainForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;

            // Подключаем события
            btnAllOrders.Click += BtnAllOrders_Click;
            btnPending.Click += BtnPending_Click;
            btnAssignMaster.Click += BtnAssignMaster_Click;
            //btnLogout.Click += BtnLogout_Click;
            btnLogout2.Click += BtnLogout2_Click;

            btnOpenOrder.Click += BtnOpenOrder_Click;
            btnAssignMasterConfirm.Click += BtnAssignMasterConfirm_Click;

            btnDetailAccept.Click += BtnDetailAccept_Click;
            btnDetailSendToMaster.Click += BtnDetailSendToMaster_Click;
            btnDetailFinish.Click += BtnDetailFinish_Click;

            // Центрирование панелей при изменении размера
            this.Resize += ManagerMainForm_Resize;

            LoadAllOrders();
            ShowPanel(panelOrders);
        }

        // ============================================================
        // ЦЕНТР И ПАНЕЛИ
        // ============================================================

        private void ManagerMainForm_Resize(object sender, EventArgs e)
        {
            CenterPanel(panelOrdersCenter);
            CenterPanel(panelAssignCenter);
            CenterPanel(panelDetailCenter);
        }

        private void CenterPanel(Control panel)
        {
            if (panel == null) return;

            panel.Left = (panelContent.Width - panel.Width) / 2;
            panel.Top = (panelContent.Height - panel.Height) / 2;
        }

        private void ShowPanel(Panel panel)
        {
            panelOrders.Visible = false;
            panelAssignMaster.Visible = false;
            panelOrderDetails.Visible = false;

            panel.Visible = true;
            CenterPanel(panelOrdersCenter);
            CenterPanel(panelAssignCenter);
            CenterPanel(panelDetailCenter);
        }

        // ============================================================
        // ЗАГРУЗКА ЗАЯВОК
        // ============================================================

        private void LoadAllOrders()
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
                    ORDER BY Дата_заказа DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                da.Fill(table);

                gridOrders.DataSource = table;
            }
        }

        private void LoadPendingOrders()
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
                    WHERE Статус = N'Отправлено'
                    ORDER BY Дата_заказа DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                da.Fill(table);

                gridOrders.DataSource = table;
            }
        }

        // ============================================================
        // КНОПКИ МЕНЮ
        // ============================================================

        private void BtnAllOrders_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
            ShowPanel(panelOrders);
        }

        private void BtnPending_Click(object sender, EventArgs e)
        {
            LoadPendingOrders();
            ShowPanel(panelOrders);
        }

        private void BtnAssignMaster_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId == -1)
            {
                MessageBox.Show("Выберите заявку!");
                return;
            }

            LoadMastersList();
            lblOrderInfo.Text = $"Заявка №{_selectedOrderId}";

            ShowPanel(panelAssignMaster);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void BtnLogout2_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        // ============================================================
        // ОТКРЫТИЕ ДЕТАЛЕЙ ЗАЯВКИ
        // ============================================================

        private void BtnOpenOrder_Click(object sender, EventArgs e)
        {
            if (gridOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заявку!");
                return;
            }

            _selectedOrderId = Convert.ToInt32(gridOrders.SelectedRows[0].Cells["Код_заказа"].Value);

            LoadOrderDetails(_selectedOrderId);
            ShowPanel(panelOrderDetails);
        }

        private void LoadOrderDetails(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        z.Код_заказа,
                        z.Описание,
                        z.Цена,
                        z.Статус,
                        z.Серийный_номер,
                        c.ФИО AS Клиент
                    FROM Заказы z
                    JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                    WHERE Код_заказа = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", orderId);

                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    lblDetailClient.Text = "Клиент: " + rd["Клиент"].ToString();
                    lblDetailDevice.Text = "Устройство: " + rd["Серийный_номер"].ToString();
                    lblDetailStatus.Text = "Статус: " + rd["Статус"].ToString();

                    txtDetailComment.Text = rd["Описание"].ToString();
                }
            }
        }

        // ============================================================
        // НАЗНАЧЕНИЕ МАСТЕРА
        // ============================================================

        private void LoadMastersList()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"
                    SELECT Код_сотрудника, ФИО
                    FROM Сотрудники
                    WHERE Код_должности = 1 AND Активен = 1";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                da.Fill(table);

                cmbMasters.DataSource = table;
                cmbMasters.DisplayMember = "ФИО";
                cmbMasters.ValueMember = "Код_сотрудника";
            }
        }

        private void BtnAssignMasterConfirm_Click(object sender, EventArgs e)
        {
            if (cmbMasters.SelectedValue == null)
            {
                MessageBox.Show("Выберите мастера!");
                return;
            }

            int masterId = (int)cmbMasters.SelectedValue;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"
                    UPDATE Заказы
                    SET Код_сотрудника = @m, Статус = N'У мастера'
                    WHERE Код_заказа = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@m", masterId);
                cmd.Parameters.AddWithValue("@id", _selectedOrderId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Мастер назначен!");
            LoadAllOrders();
            ShowPanel(panelOrders);
        }

        // ============================================================
        // ИЗМЕНЕНИЕ СТАТУСОВ
        // ============================================================

        private void BtnDetailAccept_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Принято");
        }

        private void BtnDetailSendToMaster_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("У мастера");
        }

        private void BtnDetailFinish_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Готово");
        }

        private void UpdateOrderStatus(string status)
        {
            if (_selectedOrderId == -1) return;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                string sql = @"
                    UPDATE Заказы
                    SET Статус = @status
                    WHERE Код_заказа = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", _selectedOrderId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Статус обновлён!");

            LoadOrderDetails(_selectedOrderId);
            LoadAllOrders();
        }
    }
}

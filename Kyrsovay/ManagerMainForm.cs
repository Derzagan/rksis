using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class ManagerMainForm : Form
    {
        private int _employeeId;
        private string _connectionString = Properties.Settings.Default.service_centerIsaConnectionString;
        private int _selectedOrderId = -1;

        public ManagerMainForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;

            // Подключение событий меню
            btnAllOrders.Click += BtnAllOrders_Click;
            btnPending.Click += BtnPending_Click;
            btnAssignMaster.Click += BtnAssignMaster_Click;
            btnLogout2.Click += BtnLogout2_Click;

            // События фильтра
            btnApplyFilter.Click += BtnApplyFilter_Click;
            btnResetFilter.Click += BtnResetFilter_Click;

            // События работы с заявками
            gridOrders.CellDoubleClick += GridOrders_CellDoubleClick;
            btnBackToOrders.Click += BtnBackToOrders_Click;
            btnBackFromDetails.Click += BtnBackFromDetails_Click;

            // События назначения мастера
            btnAssignMasterConfirm.Click += BtnAssignMasterConfirm_Click;

            // События изменения статусов
            btnDetailAccept.Click += BtnDetailAccept_Click;
            btnDetailSendToMaster.Click += BtnDetailSendToMaster_Click;
            btnDetailFinish.Click += BtnDetailFinish_Click;

            // Форматирование DataGridView
            gridOrders.DataBindingComplete += GridOrders_DataBindingComplete;

            // Инициализация фильтров
            InitializeFilterStatus();
            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTo.Value = DateTime.Now;

            // Стилизация
            StyleDataGridView();

            // Показываем все заявки
            LoadAllOrders();
            ShowPanel(panelOrders);
        }

        // ========== ИНИЦИАЛИЗАЦИЯ ФИЛЬТРА ==========
        private void InitializeFilterStatus()
        {
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.Add("Все статусы");
            cmbFilterStatus.Items.Add("Отправлено");
            cmbFilterStatus.Items.Add("Принято");
            cmbFilterStatus.Items.Add("У мастера");
            cmbFilterStatus.Items.Add("В работе");
            cmbFilterStatus.Items.Add("Ожидание запчастей");
            cmbFilterStatus.Items.Add("Готово");
            cmbFilterStatus.SelectedIndex = 0;
        }

        // ========== СТИЛИЗАЦИЯ DATAGRIDVIEW ==========
        private void StyleDataGridView()
        {
            gridOrders.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            gridOrders.DefaultCellStyle.Padding = new Padding(5);
            gridOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            gridOrders.DefaultCellStyle.SelectionForeColor = Color.White;

            gridOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            gridOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridOrders.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            gridOrders.ColumnHeadersHeight = 40;

            gridOrders.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            gridOrders.RowTemplate.Height = 35;
        }

        // ========== ФОРМАТИРОВАНИЕ КОЛОНОК ==========
        private void GridOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                if (gridOrders.Columns == null || gridOrders.Columns.Count == 0)
                    return;

                for (int i = 0; i < gridOrders.Columns.Count; i++)
                {
                    DataGridViewColumn col = gridOrders.Columns[i];
                    if (col == null) continue;

                    string header = col.HeaderText ?? "";

                    if (header == "№")
                    {
                        col.Width = 50;
                    }
                    else if (header == "Дата")
                    {
                        col.Width = 110;
                        col.DefaultCellStyle.Format = "dd.MM.yyyy";
                    }
                    else if (header == "Клиент")
                    {
                        col.Width = 150;
                    }
                    else if (header == "Устройство")
                    {
                        col.Width = 120;
                    }
                    else if (header == "Цена")
                    {
                        col.Width = 90;
                        col.DefaultCellStyle.Format = "N0";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    else if (header == "Статус")
                    {
                        col.Width = 140;
                    }
                }
            }
            catch
            {
                // Игнорируем ошибки форматирования
            }
        }

        // ========== УПРАВЛЕНИЕ ПАНЕЛЯМИ ==========
        private void ShowPanel(Panel panel)
        {
            panelOrders.Visible = false;
            panelAssignMaster.Visible = false;
            panelOrderDetails.Visible = false;

            // Сброс стиля кнопок меню
            btnAllOrders.BackColor = Color.FromArgb(55, 55, 55);
            btnAllOrders.Font = new Font("Segoe UI", 10F);
            btnPending.BackColor = Color.FromArgb(55, 55, 55);
            btnPending.Font = new Font("Segoe UI", 10F);
            btnAssignMaster.BackColor = Color.FromArgb(55, 55, 55);
            btnAssignMaster.Font = new Font("Segoe UI", 10F);

            panel.Visible = true;

            // Подсветка активной кнопки
            if (panel == panelOrders)
            {
                btnAllOrders.BackColor = Color.FromArgb(0, 122, 204);
                btnAllOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else if (panel == panelAssignMaster)
            {
                btnAssignMaster.BackColor = Color.FromArgb(0, 122, 204);
                btnAssignMaster.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        // ========== ЗАГРУЗКА ВСЕХ ЗАЯВОК ==========
        private void LoadAllOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            z.Код_заказа AS [№],
                            z.Дата_заказа AS [Дата],
                            c.ФИО AS [Клиент],
                            z.Серийный_номер AS [Устройство],
                            z.Описание AS [Описание],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус]
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        ORDER BY z.Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    gridOrders.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки заявок: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ЗАГРУЗКА НОВЫХ ЗАЯВОК ==========
        private void LoadPendingOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            z.Код_заказа AS [№],
                            z.Дата_заказа AS [Дата],
                            c.ФИО AS [Клиент],
                            z.Серийный_номер AS [Устройство],
                            z.Описание AS [Описание],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус]
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        WHERE z.Статус = N'Отправлено'
                        ORDER BY z.Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    gridOrders.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки заявок: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ЗАГРУЗКА С ФИЛЬТРОМ ==========
        private void LoadOrdersFiltered(string status, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            z.Код_заказа AS [№],
                            z.Дата_заказа AS [Дата],
                            c.ФИО AS [Клиент],
                            z.Серийный_номер AS [Устройство],
                            z.Описание AS [Описание],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус]
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        WHERE z.Дата_заказа >= @dateFrom
                        AND z.Дата_заказа <= @dateTo";

                    if (!string.IsNullOrEmpty(status) && status != "Все статусы")
                    {
                        sql += " AND z.Статус = @status";
                    }

                    sql += " ORDER BY z.Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@dateFrom", dateFrom.Date);
                    da.SelectCommand.Parameters.AddWithValue("@dateTo", dateTo.Date.AddDays(1));

                    if (!string.IsNullOrEmpty(status) && status != "Все статусы")
                    {
                        da.SelectCommand.Parameters.AddWithValue("@status", status);
                    }

                    DataTable table = new DataTable();
                    da.Fill(table);

                    gridOrders.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка фильтрации: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== КНОПКИ МЕНЮ ==========
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
                MessageBox.Show("Сначала выберите заявку из таблицы!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadMastersList();
            lblOrderInfo.Text = $"Заявка №{_selectedOrderId}";
            ShowPanel(panelAssignMaster);
        }

        private void BtnLogout2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // ========== ФИЛЬТРЫ ==========
        private void BtnApplyFilter_Click(object sender, EventArgs e)
        {
            string status = cmbFilterStatus.SelectedItem?.ToString() ?? "Все статусы";
            DateTime dateFrom = dtpDateFrom.Value;
            DateTime dateTo = dtpDateTo.Value;

            if (dateFrom > dateTo)
            {
                MessageBox.Show("Дата 'от' не может быть больше даты 'до'!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadOrdersFiltered(status, dateFrom, dateTo);
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = 0;
            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTo.Value = DateTime.Now;
            LoadAllOrders();
        }

        // ========== ОТКРЫТИЕ ДЕТАЛЕЙ ПО ДВОЙНОМУ КЛИКУ ==========
        private void GridOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _selectedOrderId = Convert.ToInt32(gridOrders.Rows[e.RowIndex].Cells["№"].Value);
            LoadOrderDetails(_selectedOrderId);
            ShowPanel(panelOrderDetails);
        }

        // ========== ЗАГРУЗКА ДЕТАЛЕЙ ЗАЯВКИ ==========
        private void LoadOrderDetails(int orderId)
        {
            try
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
                        WHERE z.Код_заказа = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", orderId);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        lblDetailClient.Text = "👤 Клиент: " + rd["Клиент"].ToString();
                        lblDetailDevice.Text = "📱 Устройство: " + rd["Серийный_номер"].ToString();
                        lblDetailStatus.Text = "📊 Статус: " + rd["Статус"].ToString();
                        lblDetailPrice.Text = "💰 Стоимость: " + Convert.ToInt32(rd["Цена"]).ToString("N0") + " ₸";
                        txtDetailComment.Text = rd["Описание"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки деталей: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== НАЗНАЧЕНИЕ МАСТЕРА ==========
        private void LoadMastersList()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки мастеров: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAssignMasterConfirm_Click(object sender, EventArgs e)
        {
            if (cmbMasters.SelectedValue == null)
            {
                MessageBox.Show("Выберите мастера!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
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

                MessageBox.Show("✓ Мастер успешно назначен!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllOrders();
                ShowPanel(panelOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка назначения мастера: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ИЗМЕНЕНИЕ СТАТУСОВ ==========
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

            try
            {
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

                MessageBox.Show("✓ Статус успешно обновлён!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrderDetails(_selectedOrderId);
                LoadAllOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления статуса: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== НАВИГАЦИЯ НАЗАД ==========
        private void BtnBackToOrders_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
            ShowPanel(panelOrders);
        }

        private void BtnBackFromDetails_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
            ShowPanel(panelOrders);
        }
    }
}
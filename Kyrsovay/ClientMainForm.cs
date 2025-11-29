using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class ClientMainForm : Form
    {
        private int _clientId;
        private string _connectionString = Properties.Settings.Default.service_centerIsaConnectionString;
        private string _clientName;
        private int _currentPrice = 0;  // Текущая цена для заявки

        public ClientMainForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;

            // Загружаем имя клиента
            _clientName = LoadClientName();
            lblWelcome.Text = $"Добро пожаловать, {_clientName}!";

            // Навешиваем обработчики меню
            btnMyOrders.Click += btnMyOrders_Click;
            btnNewOrder.Click += btnNewOrder_Click;
            btnProfile.Click += btnProfile_Click;
            btnLogout2.Click += btnLogout2_Click;
            btnSendOrder.Click += btnSendOrder_Click;
            btnSaveProfile.Click += btnSaveProfile_Click;

            // Обработчики фильтрации
            btnApplyFilter.Click += btnApplyFilter_Click;
            btnResetFilter.Click += btnResetFilter_Click;

            // Обработчики для создания заявки
            cmbDeviceType.SelectedIndexChanged += cmbDeviceType_SelectedIndexChanged;
            cmbIssue.SelectedIndexChanged += cmbIssue_SelectedIndexChanged;

            // Инициализация фильтра статусов
            InitializeFilterStatus();

            // Типы устройств
            cmbDeviceType.Items.AddRange(new string[]
            {
                "Смартфон", "Ноутбук", "Планшет", "Телевизор", "Другое"
            });

            // Возможные поломки
            cmbIssue.Items.AddRange(new string[]
            {
                "Разбит экран",
                "Не включается",
                "Не заряжается",
                "Залит водой",
                "Быстро разряжается",
                "Не работает звук",
                "Другое"
            });

            // Настройка дат по умолчанию
            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTo.Value = DateTime.Now;

            // Стилизация DataGridView
            StyleDataGridView();

            // Форматирование колонок после загрузки данных
            gridOrders.DataBindingComplete += GridOrders_DataBindingComplete;

            // Показываем заявки
            ShowOrdersPanel();
        }

        // ========== ИНИЦИАЛИЗАЦИЯ ФИЛЬТРА СТАТУСОВ ==========
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

        // ========== ЗАГРУЗКА ИМЕНИ ==========
        private string LoadClientName()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT ФИО FROM Клиенты WHERE Код_клиента=@id", conn);
                    cmd.Parameters.AddWithValue("@id", _clientId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return result.ToString();
                }
            }
            catch
            {
                return "Клиент";
            }

            return "Клиент";
        }

        // ========== УПРАВЛЕНИЕ ПАНЕЛЯМИ ==========
        private void HideAll()
        {
            panelOrders.Visible = false;
            panelCreate.Visible = false;
            panelProfile.Visible = false;

            // Сброс стиля кнопок меню
            btnMyOrders.BackColor = Color.FromArgb(55, 55, 55);
            btnMyOrders.Font = new Font("Segoe UI", 10F);
            btnNewOrder.BackColor = Color.FromArgb(55, 55, 55);
            btnNewOrder.Font = new Font("Segoe UI", 10F);
            btnProfile.BackColor = Color.FromArgb(55, 55, 55);
            btnProfile.Font = new Font("Segoe UI", 10F);
        }

        private void ShowOrdersPanel()
        {
            HideAll();
            panelOrders.Visible = true;
            btnMyOrders.BackColor = Color.FromArgb(0, 122, 204);
            btnMyOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LoadOrders();
        }

        private void ShowCreatePanel()
        {
            HideAll();
            panelCreate.Visible = true;
            btnNewOrder.BackColor = Color.FromArgb(0, 122, 204);
            btnNewOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Сброс всех полей
            _currentPrice = 0;
            lblPrice.Text = "0 ₸";
            cmbDeviceType.SelectedIndex = -1;
            cmbModel.Items.Clear();
            cmbIssue.SelectedIndex = -1;
            txtDescription.Text = "";
        }

        private void ShowProfilePanel()
        {
            HideAll();
            panelProfile.Visible = true;
            btnProfile.BackColor = Color.FromArgb(0, 122, 204);
            btnProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LoadProfile();
        }

        // ========== КНОПКИ МЕНЮ ==========
        private void btnMyOrders_Click(object sender, EventArgs e) => ShowOrdersPanel();
        private void btnNewOrder_Click(object sender, EventArgs e) => ShowCreatePanel();
        private void btnProfile_Click(object sender, EventArgs e) => ShowProfilePanel();

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // ========== ЗАГРУЗКА ЗАЯВОК (БЕЗ ФИЛЬТРА) ==========
        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            Код_заказа AS [№],
                            Дата_заказа AS [Дата],
                            Серийный_номер AS [Устройство],
                            Описание AS [Описание],
                            Цена AS [Цена],
                            Статус AS [Статус]
                        FROM Заказы
                        WHERE Код_клиента = @id
                        ORDER BY Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@id", _clientId);

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

        // ========== ЗАГРУЗКА ЗАЯВОК С ФИЛЬТРОМ ==========
        private void LoadOrdersFiltered(string status, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            Код_заказа AS [№],
                            Дата_заказа AS [Дата],
                            Серийный_номер AS [Устройство],
                            Описание AS [Описание],
                            Цена AS [Цена],
                            Статус AS [Статус]
                        FROM Заказы
                        WHERE Код_клиента = @id
                        AND Дата_заказа >= @dateFrom
                        AND Дата_заказа <= @dateTo";

                    // Добавляем фильтр по статусу, если выбран
                    if (!string.IsNullOrEmpty(status) && status != "Все статусы")
                    {
                        sql += " AND Статус = @status";
                    }

                    sql += " ORDER BY Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@id", _clientId);
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

        // ========== ФОРМАТИРОВАНИЕ КОЛОНОК (через событие) ==========
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

        // ========== ОБРАБОТЧИКИ ФИЛЬТРА ==========
        private void btnApplyFilter_Click(object sender, EventArgs e)
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

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = 0;
            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTo.Value = DateTime.Now;
            LoadOrders();
        }

        // ========== ПОДГРУЗКА МОДЕЛЕЙ ==========
        private void cmbDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            switch (cmbDeviceType.SelectedItem?.ToString())
            {
                case "Смартфон":
                    cmbModel.Items.AddRange(new[] { "iPhone 13", "iPhone 14", "iPhone 15", "Samsung S23", "Samsung S24", "Xiaomi Redmi 12", "Xiaomi 14" });
                    break;
                case "Ноутбук":
                    cmbModel.Items.AddRange(new[] { "MacBook Air", "MacBook Pro", "Asus VivoBook", "Lenovo ThinkPad", "HP Pavilion", "Dell XPS" });
                    break;
                case "Планшет":
                    cmbModel.Items.AddRange(new[] { "iPad", "iPad Pro", "iPad Air", "Samsung Tab S9", "Xiaomi Pad 6" });
                    break;
                case "Телевизор":
                    cmbModel.Items.AddRange(new[] { "Samsung Smart TV", "LG OLED", "Sony Bravia", "Xiaomi Mi TV" });
                    break;
                default:
                    cmbModel.Items.Add("Указать вручную");
                    break;
            }
        }

        // ========== РАСЧЁТ ЦЕНЫ ==========
        private void cmbIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string issue = cmbIssue.SelectedItem?.ToString();

            switch (issue)
            {
                case "Разбит экран": _currentPrice = 25000; break;
                case "Не включается": _currentPrice = 15000; break;
                case "Не заряжается": _currentPrice = 8000; break;
                case "Залит водой": _currentPrice = 12000; break;
                case "Быстро разряжается": _currentPrice = 6000; break;
                case "Не работает звук": _currentPrice = 7000; break;
                default: _currentPrice = 5000; break;
            }

            lblPrice.Text = $"{_currentPrice:N0} ₸";
        }

        // ========== СОЗДАНИЕ ЗАЯВКИ ==========
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            if (cmbDeviceType.SelectedIndex == -1 ||
                cmbModel.SelectedIndex == -1 ||
                cmbIssue.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_currentPrice <= 0)
            {
                MessageBox.Show("Выберите тип проблемы!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO Заказы
                            (Код_клиента, Дата_заказа, Серийный_номер, Описание, Статус, Цена)
                        VALUES
                            (@id, GETDATE(), @model, @descr, N'Отправлено', @price)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _clientId);
                    cmd.Parameters.AddWithValue("@model", cmbModel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@descr", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@price", _currentPrice);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Заявка успешно отправлена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowOrdersPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка отправки заявки: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ЗАГРУЗКА ПРОФИЛЯ ==========
        private void LoadProfile()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "SELECT ФИО, Телефон, Email FROM Клиенты WHERE Код_клиента=@id", conn);

                    cmd.Parameters.AddWithValue("@id", _clientId);

                    SqlDataReader r = cmd.ExecuteReader();

                    if (r.Read())
                    {
                        txtProfileName.Text = r["ФИО"].ToString();
                        txtProfilePhone.Text = r["Телефон"].ToString();
                        txtProfileEmail.Text = r["Email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки профиля: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== СОХРАНЕНИЕ ПРОФИЛЯ ==========
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProfileName.Text))
            {
                MessageBox.Show("ФИО не может быть пустым!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"UPDATE Клиенты 
                          SET ФИО=@n, Телефон=@p, Email=@e
                          WHERE Код_клиента=@id", conn);

                    cmd.Parameters.AddWithValue("@n", txtProfileName.Text);
                    cmd.Parameters.AddWithValue("@p", txtProfilePhone.Text);
                    cmd.Parameters.AddWithValue("@e", txtProfileEmail.Text);
                    cmd.Parameters.AddWithValue("@id", _clientId);

                    cmd.ExecuteNonQuery();
                }

                // Обновляем имя в хедере
                _clientName = txtProfileName.Text;
                lblWelcome.Text = $"Добро пожаловать, {_clientName}!";

                MessageBox.Show("✓ Профиль успешно обновлён!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

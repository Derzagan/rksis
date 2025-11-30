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
        private int _currentPrice = 0;

        public ClientMainForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;

            _clientName = LoadClientName();
            lblWelcome.Text = $"Добро пожаловать, {_clientName}!";

            // События меню
            btnMyOrders.Click += btnMyOrders_Click;
            btnNewOrder.Click += btnNewOrder_Click;
            btnPriceList.Click += btnPriceList_Click;
            btnProfile.Click += btnProfile_Click;
            btnLogout2.Click += btnLogout2_Click;
            btnSendOrder.Click += btnSendOrder_Click;
            btnSaveProfile.Click += btnSaveProfile_Click;
            btnClosePriceList.Click += btnClosePriceList_Click;

            // Фильтры
            btnApplyFilter.Click += btnApplyFilter_Click;
            btnResetFilter.Click += btnResetFilter_Click;
            btnFilterByPrice.Click += btnFilterByPrice_Click;

            // Создание заказа
            cmbDeviceType.SelectedIndexChanged += cmbDeviceType_SelectedIndexChanged;
            cmbIssue.SelectedIndexChanged += cmbIssue_SelectedIndexChanged;
            chkCustomDevice.CheckedChanged += chkCustomDevice_CheckedChanged;

            InitializeFilterStatus();

            cmbDeviceType.Items.AddRange(new string[]
            {
                "Смартфон", "Ноутбук", "Планшет", "Телевизор", "Другое"
            });

            // Не добавляем сразу - заполним в зависимости от типа устройства

            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTo.Value = DateTime.Now;

            StyleDataGridView();
            gridOrders.DataBindingComplete += GridOrders_DataBindingComplete;

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
                        col.Width = 50;
                    else if (header == "Дата")
                    {
                        col.Width = 110;
                        col.DefaultCellStyle.Format = "dd.MM.yyyy";
                    }
                    else if (header == "Устройство")
                        col.Width = 120;
                    else if (header == "Описание")
                        col.Width = 200;
                    else if (header == "Цена")
                    {
                        col.Width = 90;
                        col.DefaultCellStyle.Format = "N0";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    else if (header == "Статус")
                        col.Width = 120;
                }
            }
            catch { }
        }

        // ========== ЗАГРУЗКА ИМЕНИ КЛИЕНТА ==========
        private string LoadClientName()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ФИО FROM Клиенты WHERE Код_клиента = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _clientId);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Пользователь";
                }
            }
            catch
            {
                return "Пользователь";
            }
        }

        // ========== ПАНЕЛИ ==========
        private void ShowOrdersPanel()
        {
            panelOrders.Visible = true;
            panelCreate.Visible = false;
            panelProfile.Visible = false;
            panelPriceList.Visible = false;

            btnMyOrders.BackColor = Color.FromArgb(0, 122, 204);
            btnMyOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewOrder.BackColor = Color.FromArgb(55, 55, 55);
            btnNewOrder.Font = new Font("Segoe UI", 10F);
            btnPriceList.BackColor = Color.FromArgb(55, 55, 55);
            btnPriceList.Font = new Font("Segoe UI", 10F);
            btnProfile.BackColor = Color.FromArgb(55, 55, 55);
            btnProfile.Font = new Font("Segoe UI", 10F);

            LoadMyOrders();
        }

        private void ShowCreatePanel()
        {
            panelOrders.Visible = false;
            panelCreate.Visible = true;
            panelProfile.Visible = false;
            panelPriceList.Visible = false;

            btnMyOrders.BackColor = Color.FromArgb(55, 55, 55);
            btnMyOrders.Font = new Font("Segoe UI", 10F);
            btnNewOrder.BackColor = Color.FromArgb(0, 122, 204);
            btnNewOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPriceList.BackColor = Color.FromArgb(55, 55, 55);
            btnPriceList.Font = new Font("Segoe UI", 10F);
            btnProfile.BackColor = Color.FromArgb(55, 55, 55);
            btnProfile.Font = new Font("Segoe UI", 10F);
        }

        private void ShowProfilePanel()
        {
            panelOrders.Visible = false;
            panelCreate.Visible = false;
            panelProfile.Visible = true;
            panelPriceList.Visible = false;

            btnMyOrders.BackColor = Color.FromArgb(55, 55, 55);
            btnMyOrders.Font = new Font("Segoe UI", 10F);
            btnNewOrder.BackColor = Color.FromArgb(55, 55, 55);
            btnNewOrder.Font = new Font("Segoe UI", 10F);
            btnPriceList.BackColor = Color.FromArgb(55, 55, 55);
            btnPriceList.Font = new Font("Segoe UI", 10F);
            btnProfile.BackColor = Color.FromArgb(0, 122, 204);
            btnProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            LoadProfileData();
        }

        private void ShowPriceListPanel()
        {
            panelOrders.Visible = false;
            panelCreate.Visible = false;
            panelProfile.Visible = false;
            panelPriceList.Visible = true;

            btnMyOrders.BackColor = Color.FromArgb(55, 55, 55);
            btnMyOrders.Font = new Font("Segoe UI", 10F);
            btnNewOrder.BackColor = Color.FromArgb(55, 55, 55);
            btnNewOrder.Font = new Font("Segoe UI", 10F);
            btnPriceList.BackColor = Color.FromArgb(0, 122, 204);
            btnPriceList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProfile.BackColor = Color.FromArgb(55, 55, 55);
            btnProfile.Font = new Font("Segoe UI", 10F);

            LoadPriceList();
        }

        // ========== ЗАГРУЗКА ПРАЙС-ЛИСТА ==========
        private void LoadPriceList()
        {
            treePriceList.Nodes.Clear();
            treePriceList.Font = new Font("Segoe UI", 10F);

            // Смартфоны
            TreeNode smartphones = new TreeNode("📱 Смартфон");
            smartphones.Nodes.Add("Замена стекла → 25 000 ₸");
            smartphones.Nodes.Add("Замена дисплея → 35 000 ₸");
            smartphones.Nodes.Add("Замена аккумулятора → 15 000 ₸");
            smartphones.Nodes.Add("Не включается → 15 000 ₸");
            smartphones.Nodes.Add("Не заряжается → 12 000 ₸");
            smartphones.Nodes.Add("Залит водой → 20 000 ₸");
            smartphones.Nodes.Add("Быстро разряжается → 10 000 ₸");
            smartphones.Nodes.Add("Не работает звук → 8 000 ₸");
            treePriceList.Nodes.Add(smartphones);

            // Ноутбуки
            TreeNode laptops = new TreeNode("💻 Ноутбук");
            laptops.Nodes.Add("Чистка от пыли → 8 000 ₸");
            laptops.Nodes.Add("Замена термопасты → 5 000 ₸");
            laptops.Nodes.Add("Замена клавиатуры → 18 000 ₸");
            laptops.Nodes.Add("Не включается → 15 000 ₸");
            laptops.Nodes.Add("Не заряжается → 12 000 ₸");
            laptops.Nodes.Add("Залит водой → 20 000 ₸");
            laptops.Nodes.Add("Быстро разряжается → 10 000 ₸");
            treePriceList.Nodes.Add(laptops);

            // Планшеты
            TreeNode tablets = new TreeNode("📲 Планшет");
            tablets.Nodes.Add("Замена стекла → 18 000 ₸");
            tablets.Nodes.Add("Замена дисплея → 28 000 ₸");
            tablets.Nodes.Add("Замена аккумулятора → 10 000 ₸");
            tablets.Nodes.Add("Не включается → 15 000 ₸");
            tablets.Nodes.Add("Не заряжается → 12 000 ₸");
            tablets.Nodes.Add("Залит водой → 20 000 ₸");
            tablets.Nodes.Add("Быстро разряжается → 10 000 ₸");
            tablets.Nodes.Add("Не работает звук → 8 000 ₸");
            treePriceList.Nodes.Add(tablets);

            // Телевизоры
            TreeNode tvs = new TreeNode("📺 Телевизор");
            tvs.Nodes.Add("Диагностика → 5 000 ₸");
            tvs.Nodes.Add("Не включается → 15 000 ₸");
            tvs.Nodes.Add("Не работает звук → 8 000 ₸");
            tvs.Nodes.Add("Замена матрицы → 50 000 ₸");
            treePriceList.Nodes.Add(tvs);

            // Другое
            TreeNode other = new TreeNode("🔧 Другое");
            other.Nodes.Add("Диагностика → 5 000 ₸");
            other.Nodes.Add("Не включается → 15 000 ₸");
            other.Nodes.Add("Не заряжается → 12 000 ₸");
            other.Nodes.Add("Залит водой → 20 000 ₸");
            other.Nodes.Add("Быстро разряжается → 10 000 ₸");
            other.Nodes.Add("Не работает звук → 8 000 ₸");
            treePriceList.Nodes.Add(other);

            treePriceList.ExpandAll();
        }

        // ========== ЗАГРУЗКА ЗАЯВОК ==========
        private void LoadMyOrders(string orderBy = "z.Дата_заказа DESC")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = $@"
                        SELECT 
                            z.Код_заказа AS [№],
                            z.Дата_заказа AS [Дата],
                            z.Серийный_номер AS [Устройство],
                            z.Описание AS [Описание],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус]
                        FROM Заказы z
                        WHERE z.Код_клиента = @clientId
                        ORDER BY {orderBy}";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@clientId", _clientId);

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

        // ========== ФИЛЬТР ПО ЦЕНЕ ==========
        private void btnFilterByPrice_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemAsc = new ToolStripMenuItem("Самые дешёвые (по возрастанию)");
            itemAsc.Click += (s, ev) => LoadMyOrders("z.Цена ASC");
            menu.Items.Add(itemAsc);

            ToolStripMenuItem itemDesc = new ToolStripMenuItem("Самые дорогие (по убыванию)");
            itemDesc.Click += (s, ev) => LoadMyOrders("z.Цена DESC");
            menu.Items.Add(itemDesc);

            menu.Show(btnFilterByPrice, new Point(0, btnFilterByPrice.Height));
        }

        // ========== ФИЛЬТР ПО СТАТУСУ И ДАТЕ ==========
        private void btnApplyFilter_Click(object sender, EventArgs e)
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
                            z.Серийный_номер AS [Устройство],
                            z.Описание AS [Описание],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус]
                        FROM Заказы z
                        WHERE z.Код_клиента = @clientId
                        AND z.Дата_заказа >= @dateFrom
                        AND z.Дата_заказа <= @dateTo";

                    string status = cmbFilterStatus.SelectedItem?.ToString();
                    if (!string.IsNullOrEmpty(status) && status != "Все статусы")
                    {
                        sql += " AND z.Статус = @status";
                    }

                    sql += " ORDER BY z.Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@clientId", _clientId);
                    da.SelectCommand.Parameters.AddWithValue("@dateFrom", dtpDateFrom.Value.Date);
                    da.SelectCommand.Parameters.AddWithValue("@dateTo", dtpDateTo.Value.Date.AddDays(1));

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

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = 0;
            dtpDateFrom.Value = DateTime.Now.AddMonths(-1);
            dtpDateTo.Value = DateTime.Now;
            LoadMyOrders();
        }

        // ========== ЧЕКБОКС СВОЁ УСТРОЙСТВО ==========
        private void chkCustomDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomDevice.Checked)
            {
                cmbDeviceType.Enabled = false;
                cmbModel.Enabled = false;
                txtCustomDevice.Enabled = true;
                txtCustomDevice.Clear();
                txtCustomDevice.Focus();
            }
            else
            {
                cmbDeviceType.Enabled = true;
                cmbModel.Enabled = true;
                txtCustomDevice.Enabled = false;
                txtCustomDevice.Text = "Введите название устройства";
            }
        }

        // ========== ИЗМЕНЕНИЕ ТИПА УСТРОЙСТВА ==========
        private void cmbDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            cmbIssue.Items.Clear();
            string deviceType = cmbDeviceType.SelectedItem?.ToString();

            if (deviceType == "Смартфон")
            {
                cmbModel.Items.AddRange(new string[] { "iPhone", "Samsung", "Xiaomi", "Huawei", "Другой" });
                
                // Услуги как в прайс-листе для смартфонов
                cmbIssue.Items.AddRange(new string[] 
                { 
                    "Замена стекла",
                    "Замена дисплея",
                    "Замена аккумулятора",
                    "Не включается",
                    "Не заряжается",
                    "Залит водой",
                    "Быстро разряжается",
                    "Не работает звук",
                    "Другое"
                });
            }
            else if (deviceType == "Ноутбук")
            {
                cmbModel.Items.AddRange(new string[] { "HP", "Dell", "Lenovo", "Asus", "Acer", "Другой" });
                
                // Услуги как в прайс-листе для ноутбуков
                cmbIssue.Items.AddRange(new string[] 
                { 
                    "Чистка от пыли",
                    "Замена термопасты",
                    "Замена клавиатуры",
                    "Ремонт системы охлаждения",
                    "Замена жесткого диска",
                    "Не включается",
                    "Не заряжается",
                    "Залит водой",
                    "Быстро разряжается",
                    "Другое"
                });
            }
            else if (deviceType == "Планшет")
            {
                cmbModel.Items.AddRange(new string[] { "iPad", "Samsung", "Xiaomi", "Другой" });
                
                // Услуги как в прайс-листе для планшетов
                cmbIssue.Items.AddRange(new string[] 
                { 
                    "Замена стекла",
                    "Замена дисплея",
                    "Замена аккумулятора",
                    "Не включается",
                    "Не заряжается",
                    "Залит водой",
                    "Быстро разряжается",
                    "Не работает звук",
                    "Другое"
                });
            }
            else if (deviceType == "Телевизор")
            {
                cmbModel.Items.AddRange(new string[] { "Samsung", "LG", "Sony", "Xiaomi", "Другой" });
                
                // Услуги как в прайс-листе для телевизоров
                cmbIssue.Items.AddRange(new string[] 
                { 
                    "Диагностика",
                    "Не включается",
                    "Не работает звук",
                    "Замена матрицы",
                    "Другое"
                });
            }
            else // Другое
            {
                cmbModel.Items.Add("Не указано");
                
                // Общие услуги
                cmbIssue.Items.AddRange(new string[] 
                { 
                    "Диагностика",
                    "Не включается",
                    "Не заряжается",
                    "Залит водой",
                    "Быстро разряжается",
                    "Не работает звук",
                    "Другое"
                });
            }

            if (cmbModel.Items.Count > 0)
                cmbModel.SelectedIndex = 0;
            if (cmbIssue.Items.Count > 0)
                cmbIssue.SelectedIndex = 0;

            UpdatePrice();
        }

        // ========== ИЗМЕНЕНИЕ ПРОБЛЕМЫ ==========
        private void cmbIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        // ========== РАСЧЁТ ЦЕНЫ ==========
        private void UpdatePrice()
        {
            string deviceType = cmbDeviceType.SelectedItem?.ToString();
            string issue = cmbIssue.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(deviceType) || string.IsNullOrEmpty(issue))
            {
                _currentPrice = 0;
                lblPrice.Text = "0 ₸ (бесплатно)";
                return;
            }

            // ЕДИНЫЕ ЦЕНЫ согласно прайс-листу
            int price = 10000; // базовая цена по умолчанию

            // Универсальные цены для большинства устройств
            if (issue == "Замена стекла")
            {
                if (deviceType == "Смартфон")
                    price = 25000;
                else if (deviceType == "Планшет")
                    price = 18000;
                else
                    price = 20000;
            }
            else if (issue == "Замена дисплея")
            {
                if (deviceType == "Смартфон")
                    price = 35000;
                else if (deviceType == "Планшет")
                    price = 28000;
                else
                    price = 30000;
            }
            else if (issue == "Замена аккумулятора")
            {
                if (deviceType == "Смартфон")
                    price = 15000;
                else if (deviceType == "Планшет")
                    price = 10000;
                else
                    price = 12000;
            }
            else if (issue == "Не включается")
                price = 15000;
            else if (issue == "Не заряжается")
                price = 12000;
            else if (issue == "Залит водой")
                price = 20000;
            else if (issue == "Быстро разряжается")
                price = 10000;
            else if (issue == "Не работает звук")
                price = 8000;
            else if (issue == "Диагностика")
                price = 5000;
            else if (issue == "Замена матрицы")
                price = 50000;
            else if (issue == "Чистка от пыли")
                price = 8000;
            else if (issue == "Замена термопасты")
                price = 5000;
            else if (issue == "Замена клавиатуры")
                price = 18000;
            else if (issue == "Ремонт системы охлаждения")
                price = 15000;
            else if (issue == "Замена жесткого диска")
                price = 10000;
            else if (issue == "Другое")
                price = 10000;

            _currentPrice = price;
            lblPrice.Text = $"{price:N0} ₸";
        }

        // ========== ОТПРАВКА ЗАЯВКИ ==========
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            string device = "";
            
            if (chkCustomDevice.Checked)
            {
                device = txtCustomDevice.Text.Trim();
                if (string.IsNullOrWhiteSpace(device) || device == "Введите название устройства")
                {
                    MessageBox.Show("Введите название устройства!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (cmbDeviceType.SelectedItem == null || cmbModel.SelectedItem == null || cmbIssue.SelectedItem == null)
                {
                    MessageBox.Show("Заполните все поля!", "Внимание",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                device = $"{cmbDeviceType.SelectedItem} {cmbModel.SelectedItem}";
            }

            string issue = cmbIssue.SelectedItem?.ToString() ?? "";
            string description = txtDescription.Text.Trim();
            if (string.IsNullOrEmpty(description))
                description = issue;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO Заказы (Код_клиента, Серийный_номер, Описание, Дата_заказа, Цена, Статус)
                        VALUES (@clientId, @device, @description, @date, @price, N'Отправлено')";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@clientId", _clientId);
                    cmd.Parameters.AddWithValue("@device", device);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@price", _currentPrice);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Заявка успешно отправлена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ShowOrdersPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания заявки: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ЗАГРУЗКА ПРОФИЛЯ ==========
        private void LoadProfileData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = "SELECT ФИО, Телефон, Email FROM Клиенты WHERE Код_клиента = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _clientId);

                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        txtProfileName.Text = rd["ФИО"].ToString();
                        txtProfilePhone.Text = rd["Телефон"].ToString();
                        txtProfileEmail.Text = rd["Email"].ToString();
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
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        UPDATE Клиенты
                        SET ФИО = @name, Телефон = @phone, Email = @email
                        WHERE Код_клиента = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", txtProfileName.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtProfilePhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtProfileEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", _clientId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Профиль успешно обновлён!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _clientName = txtProfileName.Text.Trim();
                lblWelcome.Text = $"Добро пожаловать, {_clientName}!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения профиля: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== КНОПКИ МЕНЮ ==========
        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            ShowOrdersPanel();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            ShowCreatePanel();
        }

        private void btnPriceList_Click(object sender, EventArgs e)
        {
            ShowPriceListPanel();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowProfilePanel();
        }

        private void btnClosePriceList_Click(object sender, EventArgs e)
        {
            ShowOrdersPanel();
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}

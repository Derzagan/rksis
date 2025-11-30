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
            btnLogout2.Click += BtnLogout2_Click;

            // События фильтров
            btnFilterByName.Click += BtnFilterByName_Click;
            btnFilterByPrice.Click += BtnFilterByPrice_Click;
            btnFilterByMaster.Click += BtnFilterByMaster_Click;
            btnFilterByStatus.Click += BtnFilterByStatus_Click;
            btnResetFilters.Click += BtnResetFilters_Click;

            // События работы с заявками
            gridOrders.CellDoubleClick += GridOrders_CellDoubleClick;
            gridOrders.SelectionChanged += GridOrders_SelectionChanged;
            btnBackFromDetails.Click += BtnBackFromDetails_Click;

            // События назначения мастера из деталей
            btnAssignMasterDetail.Click += BtnAssignMasterDetail_Click;
            btnConfirmMaster.Click += BtnConfirmMaster_Click;
            btnCancelMaster.Click += BtnCancelMaster_Click;

            // События изменения статусов
            btnDetailAccept.Click += BtnDetailAccept_Click;
            btnDetailSendToMaster.Click += BtnDetailSendToMaster_Click;
            btnDetailFinish.Click += BtnDetailFinish_Click;
            btnDeleteOrder.Click += BtnDeleteOrder_Click;

            // Форматирование DataGridView
            gridOrders.DataBindingComplete += GridOrders_DataBindingComplete;

            // Стилизация
            StyleDataGridView(gridOrders);

            // Показываем все заявки
            LoadAllOrders();
            ShowPanel(panelOrders);
        }

        // ========== СТИЛИЗАЦИЯ DATAGRIDVIEW ==========
        private void StyleDataGridView(DataGridView grid)
        {
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            grid.DefaultCellStyle.Padding = new Padding(5);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 122, 204);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;

            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            grid.ColumnHeadersHeight = 40;

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
            grid.RowTemplate.Height = 35;
        }

        // ========== ФОРМАТИРОВАНИЕ КОЛОНОК ==========
        private void GridOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FormatGrid(gridOrders);
        }

        private void FormatGrid(DataGridView grid)
        {
            try
            {
                if (grid.Columns == null || grid.Columns.Count == 0)
                    return;

                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    DataGridViewColumn col = grid.Columns[i];
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
                        col.Width = 120;
                    }
                    else if (header == "Мастер")
                    {
                        col.Width = 150;
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
            panelOrderDetails.Visible = false;

            // Сброс стиля кнопок меню
            btnAllOrders.BackColor = Color.FromArgb(55, 55, 55);
            btnAllOrders.Font = new Font("Segoe UI", 10F);

            panel.Visible = true;

            // Подсветка активной кнопки
            if (panel == panelOrders)
            {
                btnAllOrders.BackColor = Color.FromArgb(0, 122, 204);
                btnAllOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        // ========== ЗАГРУЗКА ВСЕХ ЗАЯВОК ==========
        private void LoadAllOrders(string orderBy = "z.Дата_заказа DESC")
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
                            c.ФИО AS [Клиент],
                            z.Серийный_номер AS [Устройство],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус],
                            ISNULL(s.ФИО, N'Не назначен') AS [Мастер]
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        LEFT JOIN Сотрудники s ON z.Код_сотрудника = s.Код_сотрудника
                        ORDER BY {orderBy}";

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

        // ========== ЗАГРУЗКА С ФИЛЬТРОМ ПО МАСТЕРУ ==========
        private void LoadOrdersByMaster(int? masterId = null, bool showWithoutMaster = false)
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
                            z.Цена AS [Цена],
                            z.Статус AS [Статус],
                            ISNULL(s.ФИО, N'Не назначен') AS [Мастер]
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        LEFT JOIN Сотрудники s ON z.Код_сотрудника = s.Код_сотрудника
                        WHERE ";

                    if (showWithoutMaster)
                    {
                        sql += "z.Код_сотрудника IS NULL";
                    }
                    else if (masterId.HasValue)
                    {
                        sql += "z.Код_сотрудника = @masterId";
                    }

                    sql += " ORDER BY z.Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    if (masterId.HasValue)
                        da.SelectCommand.Parameters.AddWithValue("@masterId", masterId.Value);

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

        // ========== КНОПКИ ФИЛЬТРОВ ==========
        private void BtnFilterByName_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            
            ToolStripMenuItem itemAZ = new ToolStripMenuItem("А → Я (по возрастанию)");
            itemAZ.Click += (s, ev) => LoadAllOrders("c.ФИО ASC");
            menu.Items.Add(itemAZ);
            
            ToolStripMenuItem itemZA = new ToolStripMenuItem("Я → А (по убыванию)");
            itemZA.Click += (s, ev) => LoadAllOrders("c.ФИО DESC");
            menu.Items.Add(itemZA);
            
            menu.Show(btnFilterByName, new Point(0, btnFilterByName.Height));
        }

        private void BtnFilterByPrice_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            
            ToolStripMenuItem itemDesc = new ToolStripMenuItem("Самые дорогие (по убыванию)");
            itemDesc.Click += (s, ev) => LoadAllOrders("z.Цена DESC");
            menu.Items.Add(itemDesc);
            
            ToolStripMenuItem itemAsc = new ToolStripMenuItem("Самые дешёвые (по возрастанию)");
            itemAsc.Click += (s, ev) => LoadAllOrders("z.Цена ASC");
            menu.Items.Add(itemAsc);
            
            menu.Show(btnFilterByPrice, new Point(0, btnFilterByPrice.Height));
        }

        private void BtnFilterByMaster_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT Код_сотрудника, ФИО
                        FROM Сотрудники
                        WHERE Код_должности = 1 AND Активен = 1
                        ORDER BY ФИО";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    ContextMenuStrip menu = new ContextMenuStrip();
                    
                    ToolStripMenuItem itemAll = new ToolStripMenuItem("Все мастера");
                    itemAll.Click += (s, ev) => LoadAllOrders();
                    menu.Items.Add(itemAll);
                    
                    ToolStripMenuItem itemNone = new ToolStripMenuItem("Без мастера");
                    itemNone.Click += (s, ev) => LoadOrdersByMaster(null, true);
                    menu.Items.Add(itemNone);
                    
                    menu.Items.Add(new ToolStripSeparator());

                    foreach (DataRow row in table.Rows)
                    {
                        int masterId = (int)row["Код_сотрудника"];
                        string masterName = row["ФИО"].ToString();
                        
                        ToolStripMenuItem item = new ToolStripMenuItem(masterName);
                        int localMasterId = masterId;
                        item.Click += (s, ev) => LoadOrdersByMaster(localMasterId);
                        menu.Items.Add(item);
                    }

                    menu.Show(btnFilterByMaster, new Point(0, btnFilterByMaster.Height));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки мастеров: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFilterByStatus_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            // Список всех возможных статусов
            string[] statuses = new string[] 
            {
                "Отправлено",
                "У мастера",
                "В работе",
                "Ожидание запчастей",
                "Готово",
                "Выдано"
            };

            foreach (string status in statuses)
            {
                string localStatus = status; // Для корректной работы замыкания
                ToolStripMenuItem item = new ToolStripMenuItem($"📌 {status}");
                item.Click += (s, ev) => LoadOrdersByStatus(localStatus);
                menu.Items.Add(item);
            }

            menu.Show(btnFilterByStatus, new Point(0, btnFilterByStatus.Height));
        }

        private void LoadOrdersByStatus(string status)
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
                            z.Описание AS [Проблема],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус],
                            ISNULL(s.ФИО, 'Не назначен') AS [Мастер]
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        LEFT JOIN Сотрудники s ON z.Код_сотрудника = s.Код_сотрудника
                        WHERE z.Статус = @status
                        ORDER BY z.Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@status", status);

                    DataTable table = new DataTable();
                    da.Fill(table);

                    gridOrders.DataSource = table;

                    // Обновляем заголовок
                    btnAllOrders.Text = $"📋 Фильтр: {status} ({table.Rows.Count})";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка фильтрации по статусу: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            btnAllOrders.Text = "📋 Все заявки";
            LoadAllOrders();
        }

        // ========== КНОПКИ МЕНЮ ==========
        private void BtnAllOrders_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
            ShowPanel(panelOrders);
        }

        private void BtnLogout2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // ========== ВЫБОР ЗАКАЗА ==========
        private void GridOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (gridOrders.SelectedRows.Count > 0)
            {
                _selectedOrderId = Convert.ToInt32(gridOrders.SelectedRows[0].Cells["№"].Value);
            }
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
                            z.Код_сотрудника,
                            c.ФИО AS Клиент,
                            ISNULL(s.ФИО, N'Не назначен') AS Мастер
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        LEFT JOIN Сотрудники s ON z.Код_сотрудника = s.Код_сотрудника
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
                        lblDetailMaster.Text = "👨‍🔧 Мастер: " + rd["Мастер"].ToString();
                        txtDetailComment.Text = rd["Описание"].ToString();
                    }
                }

                // Скрываем панель выбора мастера
                panelMastersList.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки деталей: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== КНОПКА "МАСТЕРА" В ДЕТАЛЯХ ==========
        private void BtnAssignMasterDetail_Click(object sender, EventArgs e)
        {
            if (panelMastersList.Visible)
            {
                panelMastersList.Visible = false;
                return;
            }

            LoadMastersForDetail();
            panelMastersList.Visible = true;
            panelMastersList.BringToFront();
        }

        // ========== ЗАГРУЗКА МАСТЕРОВ ДЛЯ LISTBOX ==========
        private void LoadMastersForDetail()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT Код_сотрудника, ФИО
                        FROM Сотрудники
                        WHERE Код_должности = 1 AND Активен = 1
                        ORDER BY ФИО";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    listMasters.Items.Clear();
                    listMasters.DisplayMember = "ФИО";
                    listMasters.ValueMember = "Код_сотрудника";
                    listMasters.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки мастеров: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ПОДТВЕРЖДЕНИЕ ВЫБОРА МАСТЕРА ==========
        private void BtnConfirmMaster_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId == -1) return;

            if (listMasters.SelectedValue == null)
            {
                MessageBox.Show("Выберите мастера из списка!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int masterId = Convert.ToInt32(listMasters.SelectedValue);

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

                MessageBox.Show("✓ Мастер успешно назначен! Статус изменён на 'У мастера'", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                panelMastersList.Visible = false;
                LoadOrderDetails(_selectedOrderId);
                LoadAllOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка назначения мастера: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ОТМЕНА ВЫБОРА МАСТЕРА ==========
        private void BtnCancelMaster_Click(object sender, EventArgs e)
        {
            panelMastersList.Visible = false;
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

        // ========== УДАЛЕНИЕ ЗАКАЗА ==========
        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId == -1) return;

            DialogResult result = MessageBox.Show(
                $"Вы действительно хотите удалить заказ №{_selectedOrderId}?\n\nЭто действие нельзя отменить!",
                "⚠ Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = @"
                        DELETE FROM Заказы
                        WHERE Код_заказа = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _selectedOrderId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("✓ Заказ успешно удалён!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _selectedOrderId = -1;
                        LoadAllOrders();
                        ShowPanel(panelOrders);
                    }
                    else
                    {
                        MessageBox.Show("Заказ не найден или уже удалён.", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления заказа: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== НАВИГАЦИЯ НАЗАД ==========
        private void BtnBackFromDetails_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
            ShowPanel(panelOrders);
        }
    }
}

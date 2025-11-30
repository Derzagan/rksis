using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class MasterMainForm : Form
    {
        private int _employeeId;
        private string _connectionString = Properties.Settings.Default.service_centerIsaConnectionString;
        private int _selectedOrderId = -1;
        private string _masterName = "";

        public MasterMainForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;

            // Загрузка имени мастера
            LoadMasterName();
            lblWelcome.Text = $"Панель мастера — {_masterName}";

            // События меню
            btnMyOrders.Click += BtnMyOrders_Click;
            btnLogout2.Click += BtnLogout2_Click;

            // События фильтров
            btnFilterByName.Click += BtnFilterByName_Click;
            btnFilterByPrice.Click += BtnFilterByPrice_Click;
            btnResetFilters.Click += BtnResetFilters_Click;

            // События работы с заявками
            gridOrders.CellDoubleClick += GridOrders_CellDoubleClick;
            btnBackFromDetails.Click += BtnBackFromDetails_Click;

            // События работы с ремонтом
            btnStartWork.Click += BtnStartWork_Click;
            btnNeedParts.Click += BtnNeedParts_Click;
            btnFinishRepair.Click += BtnFinishRepair_Click;

            // Форматирование DataGridView
            gridOrders.DataBindingComplete += GridOrders_DataBindingComplete;

            // Стилизация
            StyleDataGridView();

            // Показываем заявки
            LoadMyOrders();
            ShowPanel(panelOrders);
        }

        // ========== ЗАГРУЗКА ИМЕНИ МАСТЕРА ==========
        private void LoadMasterName()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT ФИО FROM Сотрудники WHERE Код_сотрудника = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _employeeId);
                    object result = cmd.ExecuteScalar();
                    _masterName = result?.ToString() ?? "Мастер";
                }
            }
            catch
            {
                _masterName = "Мастер";
            }
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
                    else if (header == "Клиент")
                        col.Width = 150;
                    else if (header == "Устройство")
                        col.Width = 120;
                    else if (header == "Цена")
                    {
                        col.Width = 90;
                        col.DefaultCellStyle.Format = "N0";
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                    else if (header == "Статус")
                        col.Width = 140;
                }
            }
            catch { }
        }

        // ========== УПРАВЛЕНИЕ ПАНЕЛЯМИ ==========
        private void ShowPanel(Panel panel)
        {
            panelOrders.Visible = false;
            panelOrderDetails.Visible = false;

            panel.Visible = true;

            btnMyOrders.BackColor = Color.FromArgb(0, 122, 204);
            btnMyOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        // ========== ЗАГРУЗКА СВОИХ ЗАЯВОК ==========
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
                            c.ФИО AS [Клиент],
                            z.Серийный_номер AS [Устройство],
                            z.Цена AS [Цена],
                            z.Статус AS [Статус]
                        FROM Заказы z
                        JOIN Клиенты c ON z.Код_клиента = c.Код_клиента
                        WHERE z.Код_сотрудника = @employeeId
                        ORDER BY {orderBy}";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@employeeId", _employeeId);

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

            ToolStripMenuItem itemAZ = new ToolStripMenuItem("А → Я (клиенты по возрастанию)");
            itemAZ.Click += (s, ev) => LoadMyOrders("c.ФИО ASC");
            menu.Items.Add(itemAZ);

            ToolStripMenuItem itemZA = new ToolStripMenuItem("Я → А (клиенты по убыванию)");
            itemZA.Click += (s, ev) => LoadMyOrders("c.ФИО DESC");
            menu.Items.Add(itemZA);

            menu.Show(btnFilterByName, new Point(0, btnFilterByName.Height));
        }

        private void BtnFilterByPrice_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemDesc = new ToolStripMenuItem("Самые дорогие (по убыванию)");
            itemDesc.Click += (s, ev) => LoadMyOrders("z.Цена DESC");
            menu.Items.Add(itemDesc);

            ToolStripMenuItem itemAsc = new ToolStripMenuItem("Самые дешёвые (по возрастанию)");
            itemAsc.Click += (s, ev) => LoadMyOrders("z.Цена ASC");
            menu.Items.Add(itemAsc);

            menu.Show(btnFilterByPrice, new Point(0, btnFilterByPrice.Height));
        }

        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            LoadMyOrders();
        }

        // ========== КНОПКИ МЕНЮ ==========
        private void BtnMyOrders_Click(object sender, EventArgs e)
        {
            LoadMyOrders();
            ShowPanel(panelOrders);
        }

        private void BtnLogout2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
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
                        txtFinalPrice.Text = rd["Цена"].ToString();
                        txtWorkComment.Clear(); // Очищаем для нового комментария
                    }
                    rd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки деталей: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== НАЧАТЬ РАБОТУ ==========
        private void BtnStartWork_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("В работе");
        }

        // ========== ОЖИДАНИЕ ЗАПЧАСТЕЙ ==========
        private void BtnNeedParts_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Ожидание запчастей");
        }

        // ========== ЗАВЕРШИТЬ РЕМОНТ ==========
        private void BtnFinishRepair_Click(object sender, EventArgs e)
        {
            if (_selectedOrderId == -1) return;

            // Проверка итоговой цены
            if (string.IsNullOrWhiteSpace(txtFinalPrice.Text))
            {
                MessageBox.Show("Введите итоговую стоимость ремонта!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFinalPrice.Focus();
                return;
            }

            decimal finalPrice;
            if (!decimal.TryParse(txtFinalPrice.Text, out finalPrice) || finalPrice < 0)
            {
                MessageBox.Show("Введите корректную цену!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFinalPrice.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    // Обновляем описание - добавляем комментарий мастера
                    string workComment = txtWorkComment.Text.Trim();
                    string updatedDescription = "";
                    
                    if (!string.IsNullOrWhiteSpace(workComment))
                    {
                        // Получаем старое описание
                        string sqlGet = "SELECT Описание FROM Заказы WHERE Код_заказа = @id";
                        SqlCommand cmdGet = new SqlCommand(sqlGet, conn);
                        cmdGet.Parameters.AddWithValue("@id", _selectedOrderId);
                        object oldDesc = cmdGet.ExecuteScalar();
                        
                        updatedDescription = oldDesc?.ToString() ?? "";
                        updatedDescription += "\n\n--- Комментарий мастера ---\n" + workComment;
                    }

                    string sql = @"
                        UPDATE Заказы
                        SET Статус = N'Готово', 
                            Цена = @price" +
                            (string.IsNullOrWhiteSpace(workComment) ? "" : ", Описание = @description") +
                        " WHERE Код_заказа = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@price", finalPrice);
                    cmd.Parameters.AddWithValue("@id", _selectedOrderId);
                    
                    if (!string.IsNullOrWhiteSpace(workComment))
                        cmd.Parameters.AddWithValue("@description", updatedDescription);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Ремонт завершён! Заказ готов к выдаче.", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrderDetails(_selectedOrderId);
                LoadMyOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка завершения ремонта: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== ОБНОВЛЕНИЕ СТАТУСА ==========
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

                MessageBox.Show($"✓ Статус изменён на '{status}'", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrderDetails(_selectedOrderId);
                LoadMyOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления статуса: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== НАВИГАЦИЯ НАЗАД ==========
        private void BtnBackFromDetails_Click(object sender, EventArgs e)
        {
            LoadMyOrders();
            ShowPanel(panelOrders);
        }
    }
}

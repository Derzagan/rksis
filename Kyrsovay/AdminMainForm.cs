using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class AdminMainForm : Form
    {
        private int _employeeId;
        private string _connectionString = Properties.Settings.Default.service_centerIsaConnectionString;

        public AdminMainForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;

            // События меню
            btnEmployees.Click += BtnEmployees_Click;
            btnPositions.Click += BtnPositions_Click;
            btnOrders.Click += BtnOrders_Click;
            btnLogout.Click += BtnLogout_Click;

            // События управления сотрудниками
            btnAddEmployee.Click += BtnAddEmployee_Click;
            btnEditEmployee.Click += BtnEditEmployee_Click;
            btnDeleteEmployee.Click += BtnDeleteEmployee_Click;
            btnToggleActive.Click += BtnToggleActive_Click;

            // События управления должностями
            btnAddPosition.Click += BtnAddPosition_Click;
            btnDeletePosition.Click += BtnDeletePosition_Click;

            // События управления заказами
            btnDeleteOrder.Click += BtnDeleteOrder_Click;

            // События фильтров сотрудников
            btnFilterEmployeeByName.Click += BtnFilterEmployeeByName_Click;
            btnResetEmployeeFilter.Click += BtnResetEmployeeFilter_Click;

            // События фильтров должностей
            btnFilterPositionByName.Click += BtnFilterPositionByName_Click;
            btnResetPositionFilter.Click += BtnResetPositionFilter_Click;

            // События фильтров заказов
            btnFilterOrderByName.Click += BtnFilterOrderByName_Click;
            btnFilterOrderByPrice.Click += BtnFilterOrderByPrice_Click;
            btnFilterOrderByDate.Click += BtnFilterOrderByDate_Click;
            btnResetOrderFilter.Click += BtnResetOrderFilter_Click;

            // Стилизация DataGridView
            StyleDataGridView(gridEmployees);
            StyleDataGridView(gridPositions);
            StyleDataGridView(gridOrders);

            // Загружаем сотрудников по умолчанию
            LoadEmployees();
            ShowPanel(panelEmployees);
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

        // ========== УПРАВЛЕНИЕ ПАНЕЛЯМИ ==========
        private void ShowPanel(Panel panel)
        {
            panelEmployees.Visible = false;
            panelPositions.Visible = false;
            panelOrders.Visible = false;

            panel.Visible = true;

            // Обновляем цвета кнопок меню
            btnEmployees.BackColor = Color.FromArgb(60, 60, 60);
            btnEmployees.Font = new Font("Segoe UI", 10F);
            btnPositions.BackColor = Color.FromArgb(60, 60, 60);
            btnPositions.Font = new Font("Segoe UI", 10F);
            btnOrders.BackColor = Color.FromArgb(60, 60, 60);
            btnOrders.Font = new Font("Segoe UI", 10F);

            if (panel == panelEmployees)
            {
                btnEmployees.BackColor = Color.FromArgb(0, 122, 204);
                btnEmployees.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else if (panel == panelPositions)
            {
                btnPositions.BackColor = Color.FromArgb(0, 122, 204);
                btnPositions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else if (panel == panelOrders)
            {
                btnOrders.BackColor = Color.FromArgb(0, 122, 204);
                btnOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        // ========== КНОПКИ МЕНЮ ==========
        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            ShowPanel(panelEmployees);
        }

        private void BtnPositions_Click(object sender, EventArgs e)
        {
            LoadPositions();
            ShowPanel(panelPositions);
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            LoadOrders();
            ShowPanel(panelOrders);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // ========== ЗАГРУЗКА ДАННЫХ ==========
        private void LoadEmployees(string orderBy = "s.ФИО ASC")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql = $@"
                        SELECT 
                            s.Код_сотрудника AS [№],
                            s.ФИО AS [ФИО],
                            s.Телефон AS [Телефон],
                            s.Логин AS [Логин],
                            d.Наименование AS [Должность],
                            CASE WHEN s.Активен = 1 THEN 'Да' ELSE 'Нет' END AS [Активен]
                        FROM Сотрудники s
                        JOIN Должности d ON s.Код_должности = d.Код_должности
                        WHERE s.Код_должности != 3
                        ORDER BY {orderBy}";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    gridEmployees.DataSource = table;

                    // Скрываем столбец с паролем
                    if (gridEmployees.Columns.Contains("Пароль"))
                        gridEmployees.Columns["Пароль"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки сотрудников: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPositions(string orderBy = "Код_должности ASC")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    string sql;
                    
                    // Если сортировка по имени, сначала нумеруем по Код_должности, потом сортируем по имени
                    if (orderBy.Contains("Наименование"))
                    {
                        sql = $@"
                            SELECT [№], [Название должности]
                            FROM (
                                SELECT 
                                    ROW_NUMBER() OVER (ORDER BY Код_должности) AS [№],
                                    Наименование AS [Название должности]
                                FROM Должности
                                WHERE Код_должности != 3
                            ) AS numbered
                            ORDER BY [Название должности] {(orderBy.Contains("DESC") ? "DESC" : "ASC")}";
                    }
                    else
                    {
                        sql = $@"
                            SELECT 
                                ROW_NUMBER() OVER (ORDER BY Код_должности) AS [№],
                                Наименование AS [Название должности]
                            FROM Должности
                            WHERE Код_должности != 3
                            ORDER BY Код_должности ASC";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    gridPositions.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки должностей: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrders(string orderBy = "z.Дата_заказа DESC")
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
                            ISNULL(s.ФИО, 'Не назначен') AS [Мастер]
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
                MessageBox.Show("Ошибка загрузки заказов: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== УПРАВЛЕНИЕ СОТРУДНИКАМИ ==========
        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            using (EmployeeEditDialog dialog = new EmployeeEditDialog(_connectionString))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                }
            }
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            if (gridEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для редактирования!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employeeId = Convert.ToInt32(gridEmployees.SelectedRows[0].Cells["№"].Value);

            using (EmployeeEditDialog dialog = new EmployeeEditDialog(_connectionString, employeeId))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployees();
                }
            }
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (gridEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employeeId = Convert.ToInt32(gridEmployees.SelectedRows[0].Cells["№"].Value);
            string employeeName = gridEmployees.SelectedRows[0].Cells["ФИО"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Вы действительно хотите удалить сотрудника '{employeeName}'?\n\nЭто действие нельзя отменить!",
                "⚠ Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Сотрудники WHERE Код_сотрудника = @id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✓ Сотрудник успешно удалён!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления сотрудника: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnToggleActive_Click(object sender, EventArgs e)
        {
            if (gridEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int employeeId = Convert.ToInt32(gridEmployees.SelectedRows[0].Cells["№"].Value);
            string employeeName = gridEmployees.SelectedRows[0].Cells["ФИО"].Value.ToString();
            string isActive = gridEmployees.SelectedRows[0].Cells["Активен"].Value.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Сотрудники SET Активен = @active WHERE Код_сотрудника = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@active", isActive == "Да" ? 0 : 1);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.ExecuteNonQuery();
                }

                string newStatus = isActive == "Да" ? "неактивным" : "активным";
                MessageBox.Show($"✓ Сотрудник '{employeeName}' теперь {newStatus}!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка изменения статуса: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== УПРАВЛЕНИЕ ДОЛЖНОСТЯМИ ==========
        private void BtnAddPosition_Click(object sender, EventArgs e)
        {
            string positionName = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название новой должности:",
                "Добавление должности",
                "",
                -1, -1);

            if (string.IsNullOrWhiteSpace(positionName))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Должности (Наименование) VALUES (@name)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", positionName.Trim());
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Должность успешно добавлена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPositions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления должности: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeletePosition_Click(object sender, EventArgs e)
        {
            if (gridPositions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите должность для удаления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int positionId = Convert.ToInt32(gridPositions.SelectedRows[0].Cells["№"].Value);
            string positionName = gridPositions.SelectedRows[0].Cells["Название должности"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Вы действительно хотите удалить должность '{positionName}'?\n\nЭто действие нельзя отменить!",
                "⚠ Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM Должности WHERE Код_должности = @id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", positionId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("✓ Должность успешно удалена!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPositions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления должности: " + ex.Message + "\n\nВозможно, эта должность используется сотрудниками.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========== УПРАВЛЕНИЕ ЗАКАЗАМИ ==========
        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (gridOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для удаления!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId = Convert.ToInt32(gridOrders.SelectedRows[0].Cells["№"].Value);
            string clientName = gridOrders.SelectedRows[0].Cells["Клиент"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Вы действительно хотите удалить заказ №{orderId} от клиента '{clientName}'?\n\nЭто действие нельзя отменить!",
                "⚠ Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();

                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // Сначала удаляем все связанные оплаты
                                string deletePaymentsSql = @"
                                    DELETE FROM Оплаты 
                                    WHERE Код_заказа = @id";

                                SqlCommand deletePaymentsCmd = new SqlCommand(deletePaymentsSql, conn, transaction);
                                deletePaymentsCmd.Parameters.AddWithValue("@id", orderId);
                                deletePaymentsCmd.ExecuteNonQuery();

                                // Затем удаляем сам заказ
                                string deleteOrderSql = "DELETE FROM Заказы WHERE Код_заказа = @id";
                                SqlCommand deleteOrderCmd = new SqlCommand(deleteOrderSql, conn, transaction);
                                deleteOrderCmd.Parameters.AddWithValue("@id", orderId);
                                deleteOrderCmd.ExecuteNonQuery();

                                transaction.Commit();
                                MessageBox.Show("✓ Заказ успешно удалён!", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadOrders();
                            }
                            catch
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления заказа: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========== ФИЛЬТРЫ СОТРУДНИКОВ ==========
        private void BtnFilterEmployeeByName_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemAZ = new ToolStripMenuItem("А → Я (по возрастанию)");
            itemAZ.Click += (s, ev) => LoadEmployees("s.ФИО ASC");
            menu.Items.Add(itemAZ);

            ToolStripMenuItem itemZA = new ToolStripMenuItem("Я → А (по убыванию)");
            itemZA.Click += (s, ev) => LoadEmployees("s.ФИО DESC");
            menu.Items.Add(itemZA);

            menu.Show(btnFilterEmployeeByName, new Point(0, btnFilterEmployeeByName.Height));
        }

        private void BtnResetEmployeeFilter_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        // ========== ФИЛЬТРЫ ДОЛЖНОСТЕЙ ==========
        private void BtnFilterPositionByName_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemAZ = new ToolStripMenuItem("А → Я (по возрастанию)");
            itemAZ.Click += (s, ev) => LoadPositions("Наименование ASC");
            menu.Items.Add(itemAZ);

            ToolStripMenuItem itemZA = new ToolStripMenuItem("Я → А (по убыванию)");
            itemZA.Click += (s, ev) => LoadPositions("Наименование DESC");
            menu.Items.Add(itemZA);

            ToolStripMenuItem itemNum = new ToolStripMenuItem("По номеру (1, 2, 3...)");
            itemNum.Click += (s, ev) => LoadPositions("Код_должности ASC");
            menu.Items.Add(itemNum);

            menu.Show(btnFilterPositionByName, new Point(0, btnFilterPositionByName.Height));
        }

        private void BtnResetPositionFilter_Click(object sender, EventArgs e)
        {
            LoadPositions();
        }

        // ========== ФИЛЬТРЫ ЗАКАЗОВ ==========
        private void BtnFilterOrderByName_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemAZ = new ToolStripMenuItem("А → Я (клиенты по возрастанию)");
            itemAZ.Click += (s, ev) => LoadOrders("c.ФИО ASC");
            menu.Items.Add(itemAZ);

            ToolStripMenuItem itemZA = new ToolStripMenuItem("Я → А (клиенты по убыванию)");
            itemZA.Click += (s, ev) => LoadOrders("c.ФИО DESC");
            menu.Items.Add(itemZA);

            menu.Show(btnFilterOrderByName, new Point(0, btnFilterOrderByName.Height));
        }

        private void BtnFilterOrderByPrice_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemDesc = new ToolStripMenuItem("Самые дорогие (по убыванию)");
            itemDesc.Click += (s, ev) => LoadOrders("z.Цена DESC");
            menu.Items.Add(itemDesc);

            ToolStripMenuItem itemAsc = new ToolStripMenuItem("Самые дешёвые (по возрастанию)");
            itemAsc.Click += (s, ev) => LoadOrders("z.Цена ASC");
            menu.Items.Add(itemAsc);

            menu.Show(btnFilterOrderByPrice, new Point(0, btnFilterOrderByPrice.Height));
        }

        private void BtnFilterOrderByDate_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem itemNew = new ToolStripMenuItem("Сначала новые (по убыванию)");
            itemNew.Click += (s, ev) => LoadOrders("z.Дата_заказа DESC");
            menu.Items.Add(itemNew);

            ToolStripMenuItem itemOld = new ToolStripMenuItem("Сначала старые (по возрастанию)");
            itemOld.Click += (s, ev) => LoadOrders("z.Дата_заказа ASC");
            menu.Items.Add(itemOld);

            menu.Show(btnFilterOrderByDate, new Point(0, btnFilterOrderByDate.Height));
        }

        private void BtnResetOrderFilter_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }

    // ========== ДИАЛОГ РЕДАКТИРОВАНИЯ СОТРУДНИКА ==========
    public class EmployeeEditDialog : Form
    {
        private TextBox txtFIO;
        private TextBox txtPhone;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private ComboBox cmbPosition;
        private CheckBox chkActive;
        private Button btnSave;
        private Button btnCancel;

        private string _connectionString;
        private int? _employeeId;

        public EmployeeEditDialog(string connectionString, int? employeeId = null)
        {
            _connectionString = connectionString;
            _employeeId = employeeId;

            InitializeDialog();
            LoadPositions();

            if (_employeeId.HasValue)
            {
                this.Text = "Редактирование сотрудника";
                LoadEmployeeData();
            }
            else
            {
                this.Text = "Добавление сотрудника";
                chkActive.Checked = true;
            }
        }

        private void InitializeDialog()
        {
            this.Size = new Size(450, 380);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            int y = 20;
            int labelX = 20;
            int controlX = 140;
            int controlWidth = 270;
            int rowHeight = 35;

            // ФИО
            Label lblFIO = new Label { Text = "ФИО:", Left = labelX, Top = y, Width = 100 };
            txtFIO = new TextBox { Left = controlX, Top = y, Width = controlWidth };
            this.Controls.Add(lblFIO);
            this.Controls.Add(txtFIO);
            y += rowHeight;

            // Телефон
            Label lblPhone = new Label { Text = "Телефон:", Left = labelX, Top = y, Width = 100 };
            txtPhone = new TextBox { Left = controlX, Top = y, Width = controlWidth };
            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);
            y += rowHeight;

            // Логин
            Label lblLogin = new Label { Text = "Логин:", Left = labelX, Top = y, Width = 100 };
            txtLogin = new TextBox { Left = controlX, Top = y, Width = controlWidth };
            this.Controls.Add(lblLogin);
            this.Controls.Add(txtLogin);
            y += rowHeight;

            // Пароль
            Label lblPassword = new Label { Text = "Пароль:", Left = labelX, Top = y, Width = 100 };
            txtPassword = new TextBox { Left = controlX, Top = y, Width = controlWidth, UseSystemPasswordChar = false };
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            y += rowHeight;

            // Должность
            Label lblPosition = new Label { Text = "Должность:", Left = labelX, Top = y, Width = 100 };
            cmbPosition = new ComboBox { Left = controlX, Top = y, Width = controlWidth, DropDownStyle = ComboBoxStyle.DropDownList };
            this.Controls.Add(lblPosition);
            this.Controls.Add(cmbPosition);
            y += rowHeight;

            // Активен
            chkActive = new CheckBox { Text = "Активен", Left = controlX, Top = y, Width = controlWidth };
            this.Controls.Add(chkActive);
            y += rowHeight + 20;

            // Кнопки
            btnSave = new Button { Text = "💾 Сохранить", Left = 140, Top = y, Width = 130, Height = 35 };
            btnSave.Click += BtnSave_Click;
            btnSave.DialogResult = DialogResult.None;
            this.Controls.Add(btnSave);

            btnCancel = new Button { Text = "✕ Отмена", Left = 280, Top = y, Width = 130, Height = 35 };
            btnCancel.DialogResult = DialogResult.Cancel;
            this.Controls.Add(btnCancel);

            this.CancelButton = btnCancel;
        }

        private void LoadPositions()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT Код_должности, Наименование FROM Должности WHERE Код_должности != 3 ORDER BY Наименование";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    cmbPosition.DisplayMember = "Наименование";
                    cmbPosition.ValueMember = "Код_должности";
                    cmbPosition.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки должностей: " + ex.Message);
            }
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Сотрудники WHERE Код_сотрудника = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", _employeeId.Value);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtFIO.Text = reader["ФИО"].ToString();
                        txtPhone.Text = reader["Телефон"].ToString();
                        txtLogin.Text = reader["Логин"].ToString();
                        txtPassword.Text = reader["Пароль"].ToString();
                        cmbPosition.SelectedValue = reader["Код_должности"];
                        chkActive.Checked = Convert.ToBoolean(reader["Активен"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных сотрудника: " + ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Валидация
            if (string.IsNullOrWhiteSpace(txtFIO.Text))
            {
                MessageBox.Show("Введите ФИО!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFIO.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Введите логин!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (cmbPosition.SelectedValue == null)
            {
                MessageBox.Show("Выберите должность!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPosition.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string sql;

                    if (_employeeId.HasValue)
                    {
                        sql = @"UPDATE Сотрудники 
                                SET ФИО = @fio, Телефон = @phone, Логин = @login, 
                                    Пароль = @password, Код_должности = @position, Активен = @active
                                WHERE Код_сотрудника = @id";
                    }
                    else
                    {
                        sql = @"INSERT INTO Сотрудники (ФИО, Телефон, Логин, Пароль, Код_должности, Активен)
                                VALUES (@fio, @phone, @login, @password, @position, @active)";
                    }

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@fio", txtFIO.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@position", cmbPosition.SelectedValue);
                    cmd.Parameters.AddWithValue("@active", chkActive.Checked);

                    if (_employeeId.HasValue)
                        cmd.Parameters.AddWithValue("@id", _employeeId.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✓ Сотрудник успешно сохранён!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

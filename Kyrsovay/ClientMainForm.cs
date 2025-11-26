using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class ClientMainForm : Form
    {
        private int _clientId;
        private string _connectionString = Properties.Settings.Default.service_centerIsaConnectionString;

        private string _clientName; // ← имя клиента

        public ClientMainForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;

            // Загружаем имя клиента
            _clientName = LoadClientName();
            lblWelcome.Text = $"Добро пожаловать, {_clientName}!";

            // навешиваем обработчики
            btnMyOrders.Click += btnMyOrders_Click;
            btnNewOrder.Click += btnNewOrder_Click;
            btnProfile.Click += btnProfile_Click;
            //btnLogout.Click += btnLogout_Click;
            btnLogout2.Click += btnLogout2_Click;
            btnSendOrder.Click += btnSendOrder_Click;
            btnSaveProfile.Click += btnSaveProfile_Click;

            cmbDeviceType.SelectedIndexChanged += cmbDeviceType_SelectedIndexChanged;
            cmbIssue.SelectedIndexChanged += cmbIssue_SelectedIndexChanged;

            // типы устройств
            cmbDeviceType.Items.AddRange(new string[]
            {
                "Смартфон", "Ноутбук", "Планшет", "Телевизор", "Другое"
            });

            // возможные поломки
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

            ShowOrdersPanel();
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

        // скрыть все панели
        private void HideAll()
        {
            panelOrders.Visible = false;
            panelCreate.Visible = false;
            panelProfile.Visible = false;
        }

        // показать «Мои заявки»
        private void ShowOrdersPanel()
        {
            HideAll();
            panelOrders.Visible = true;
            LoadOrders();
        }

        // показать «Создать заявку»
        private void ShowCreatePanel()
        {
            HideAll();
            panelCreate.Visible = true;

            lblPrice.Text = "0 ₸";
            cmbDeviceType.SelectedIndex = -1;
            cmbModel.Items.Clear();
            cmbIssue.SelectedIndex = -1;
            txtDescription.Text = "";
        }

        // показать профиль
        private void ShowProfilePanel()
        {
            HideAll();
            panelProfile.Visible = true;
            LoadProfile();
        }

        // кнопки меню
        private void btnMyOrders_Click(object sender, EventArgs e) => ShowOrdersPanel();
        private void btnNewOrder_Click(object sender, EventArgs e) => ShowCreatePanel();
        private void btnProfile_Click(object sender, EventArgs e) => ShowProfilePanel();

        // кнопка выход (верхняя)
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // кнопка выход снизу
        private void btnLogout2_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // ================== ЗАГРУЗКА ЗАЯВОК ==================
        private void LoadOrders()
        {
            try
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
                        WHERE Код_клиента = @id
                        ORDER BY Дата_заказа DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@id", _clientId);

                    DataTable table = new DataTable();
                    da.Fill(table);

                    gridOrders.DataSource = table;
                    gridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки заявок: " + ex.Message);
            }
        }

        // ================== ПОДГРУЗКА МОДЕЛЕЙ ==================
        private void cmbDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            switch (cmbDeviceType.SelectedItem?.ToString())
            {
                case "Смартфон":
                    cmbModel.Items.AddRange(new[] { "iPhone 13", "iPhone 14", "Samsung S23", "Xiaomi Redmi 12" });
                    break;
                case "Ноутбук":
                    cmbModel.Items.AddRange(new[] { "MacBook Air", "MacBook Pro", "Asus VivoBook", "Lenovo ThinkPad" });
                    break;
                case "Планшет":
                    cmbModel.Items.AddRange(new[] { "iPad", "iPad Pro", "Samsung Tab S7" });
                    break;
                default:
                    cmbModel.Items.Add("Указать вручную");
                    break;
            }
        }

        // ================== РАСЧЁТ ЦЕНЫ ==================
        private void cmbIssue_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = 0;
            string issue = cmbIssue.SelectedItem?.ToString();

            if (issue == "Разбит экран")
                price = 25000;
            else if (issue == "Не включается")
                price = 15000;
            else if (issue == "Не заряжается")
                price = 8000;
            else if (issue == "Залит водой")
                price = 12000;
            else if (issue == "Быстро разряжается")
                price = 6000;
            else if (issue == "Не работает звук")
                price = 7000;
            else
                price = 5000;

            lblPrice.Text = price + " ₸";


            lblPrice.Text = $"{price} ₸";
        }

        // ================== СОЗДАНИЕ ЗАЯВКИ ==================
        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            if (cmbDeviceType.SelectedIndex == -1 ||
                cmbModel.SelectedIndex == -1 ||
                cmbIssue.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            int price = int.Parse(lblPrice.Text.Split(' ')[0]);

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
                    cmd.Parameters.AddWithValue("@price", price);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Заявка успешно отправлена!");
                ShowOrdersPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка отправки заявки: " + ex.Message);
            }
        }

        // ================== ЗАГРУЗКА ПРОФИЛЯ ==================
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
                MessageBox.Show("Ошибка загрузки профиля: " + ex.Message);
            }
        }

        // ================== СОХРАНЕНИЕ ПРОФИЛЯ ==================
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
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

                MessageBox.Show("Профиль обновлён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
    }
}

using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();

            // Metro стиль
            this.Style = MetroColorStyle.Blue;
            this.Theme = MetroThemeStyle.Dark;
            this.Text = "Авторизация";

            // Центрируем панель сразу
            CenterPanel();

            // Центрируем каждый раз при изменении размера окна
            this.Resize += (s, e) => CenterPanel();
        }

        private void CenterPanel()
        {
            if (panelCenter == null) return;

            panelCenter.Left = (this.ClientSize.Width - panelCenter.Width) / 2;
            panelCenter.Top = (this.ClientSize.Height - panelCenter.Height) / 2;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MetroMessageBox.Show(this, "Введите логин и пароль!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = Properties.Settings.Default.service_centerIsaConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Проверка клиента
                string sqlClient = @"
                    SELECT Код_клиента, ФИО 
                    FROM Клиенты 
                    WHERE Логин = @l AND Пароль = @p";

                using (SqlCommand cmd = new SqlCommand(sqlClient, conn))
                {
                    cmd.Parameters.AddWithValue("@l", login);
                    cmd.Parameters.AddWithValue("@p", password);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        int clientId = (int)rd["Код_клиента"];
                        string fio = rd["ФИО"].ToString();
                        rd.Close();

                        MetroMessageBox.Show(this, $"Добро пожаловать, {fio}!",
                            "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClientMainForm clientForm = new ClientMainForm(clientId);
                        clientForm.Show();
                        this.Hide();
                        return;
                    }

                    rd.Close();
                }

                // Проверка сотрудника
                string sqlEmp = @"
                    SELECT Код_сотрудника, Код_должности, ФИО
                    FROM Сотрудники 
                    WHERE Логин = @l AND Пароль = @p AND Активен = 1";

                using (SqlCommand cmd = new SqlCommand(sqlEmp, conn))
                {
                    cmd.Parameters.AddWithValue("@l", login);
                    cmd.Parameters.AddWithValue("@p", password);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (!rd.Read())
                    {
                        MetroMessageBox.Show(this,
                            "Неверный логин или пароль!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    int empId = (int)rd["Код_сотрудника"];
                    int posId = (int)rd["Код_должности"];
                    string fio = rd["ФИО"].ToString();
                    rd.Close();

                    MetroMessageBox.Show(this, $"Добро пожаловать, {fio}!",
                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OpenMainFormByRole(empId, posId);
                }
            }
        }

        private void OpenMainFormByRole(int employeeId, int positionId)
        {
            Form nextForm = null;

            switch (positionId)
            {
                case 1: nextForm = new MasterMainForm(employeeId); break;
                case 2: nextForm = new ManagerMainForm(employeeId); break;
                case 3: nextForm = new SupplyMainForm(employeeId); break;
                case 4: nextForm = new AdminMainForm(employeeId); break;
                default:
                    MetroMessageBox.Show(this, "Неизвестная роль!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            nextForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            string password2 = txtPasswordRepeat.Text.Trim();

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните обязательные поля!");
                return;
            }

            if (password != password2)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            string connStr = Properties.Settings.Default.service_centerIsaConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string sql = @"
                        INSERT INTO Клиенты (ФИО, Телефон, Email, Логин, Пароль)
                        VALUES (@name, @phone, @email, @login, @pass)
                    ";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pass", password);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Регистрация выполнена!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}

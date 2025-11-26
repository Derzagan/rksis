using System;
using System.Windows.Forms;
using System.Drawing;

namespace Kyrsovay
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Центровочная панель
        private Panel panelCenter;

        // Лейблы
        private Label lblTitle;
        private Label lblName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblLogin;
        private Label lblPassword;
        private Label lblPasswordRepeat;

        // Поля ввода
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtPasswordRepeat;

        // Кнопка
        private Button btnRegister;

        /// <summary>
        /// Очистка ресурсов
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.panelCenter = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordRepeat = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordRepeat = new System.Windows.Forms.TextBox();

            this.btnRegister = new System.Windows.Forms.Button();

            this.panelCenter.SuspendLayout();
            this.SuspendLayout();

            // ==========================
            // panelCenter (контейнер)
            // ==========================
            this.panelCenter.BackColor = System.Drawing.Color.White;
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelCenter.Size = new System.Drawing.Size(400, 460);
            this.panelCenter.Name = "panelCenter";

            // (координаты поставим в коде — через CenterPanel)

            // ==========================
            // Заголовок
            // ==========================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Регистрация клиента";

            // ==========================
            // ФИО
            // ==========================
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 75);
            this.lblName.Name = "lblName";
            this.lblName.Text = "ФИО:";

            this.txtName.Location = new System.Drawing.Point(30, 95);
            this.txtName.Size = new System.Drawing.Size(340, 23);
            this.txtName.Name = "txtName";

            // ==========================
            // Телефон
            // ==========================
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(30, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Телефон:";

            this.txtPhone.Location = new System.Drawing.Point(30, 150);
            this.txtPhone.Size = new System.Drawing.Size(340, 23);
            this.txtPhone.Name = "txtPhone";

            // ==========================
            // Email
            // ==========================
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email:";

            this.txtEmail.Location = new System.Drawing.Point(30, 205);
            this.txtEmail.Size = new System.Drawing.Size(340, 23);
            this.txtEmail.Name = "txtEmail";

            // ==========================
            // Логин
            // ==========================
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 240);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Text = "Логин:";

            this.txtLogin.Location = new System.Drawing.Point(30, 260);
            this.txtLogin.Size = new System.Drawing.Size(340, 23);
            this.txtLogin.Name = "txtLogin";

            // ==========================
            // Пароль
            // ==========================
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 295);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Пароль:";

            this.txtPassword.Location = new System.Drawing.Point(30, 315);
            this.txtPassword.Size = new System.Drawing.Size(340, 23);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Name = "txtPassword";

            // ==========================
            // Повтор пароля
            // ==========================
            this.lblPasswordRepeat.AutoSize = true;
            this.lblPasswordRepeat.Location = new System.Drawing.Point(30, 350);
            this.lblPasswordRepeat.Name = "lblPasswordRepeat";
            this.lblPasswordRepeat.Text = "Повтор пароля:";

            this.txtPasswordRepeat.Location = new System.Drawing.Point(30, 370);
            this.txtPasswordRepeat.Size = new System.Drawing.Size(340, 23);
            this.txtPasswordRepeat.PasswordChar = '•';
            this.txtPasswordRepeat.Name = "txtPasswordRepeat";

            // ==========================
            // Кнопка регистрации
            // ==========================
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Size = new System.Drawing.Size(340, 35);
            this.btnRegister.Location = new System.Drawing.Point(30, 410);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // ==========================
            // Добавляем контролы в panelCenter
            // ==========================
            this.panelCenter.Controls.Add(this.lblTitle);
            this.panelCenter.Controls.Add(this.lblName);
            this.panelCenter.Controls.Add(this.txtName);
            this.panelCenter.Controls.Add(this.lblPhone);
            this.panelCenter.Controls.Add(this.txtPhone);
            this.panelCenter.Controls.Add(this.lblEmail);
            this.panelCenter.Controls.Add(this.txtEmail);
            this.panelCenter.Controls.Add(this.lblLogin);
            this.panelCenter.Controls.Add(this.txtLogin);
            this.panelCenter.Controls.Add(this.lblPassword);
            this.panelCenter.Controls.Add(this.txtPassword);
            this.panelCenter.Controls.Add(this.lblPasswordRepeat);
            this.panelCenter.Controls.Add(this.txtPasswordRepeat);
            this.panelCenter.Controls.Add(this.btnRegister);

            // ==========================
            // Настройки формы
            // ==========================
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация клиента";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // кладём панель на форму
            this.Controls.Add(this.panelCenter);

            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

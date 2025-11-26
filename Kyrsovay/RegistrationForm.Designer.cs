namespace Kyrsovay
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordRepeat;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordRepeat;

        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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

            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Регистрация клиента";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTitle.Location = new System.Drawing.Point(70, 15);
            this.lblTitle.AutoSize = true;

            // ФИО
            this.lblName.Text = "ФИО:";
            this.lblName.Location = new System.Drawing.Point(40, 70);
            this.lblName.AutoSize = true;

            this.txtName.Location = new System.Drawing.Point(40, 95);
            this.txtName.Size = new System.Drawing.Size(330, 28);
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;

            // Телефон
            this.lblPhone.Text = "Телефон:";
            this.lblPhone.Location = new System.Drawing.Point(40, 135);
            this.lblPhone.AutoSize = true;

            this.txtPhone.Location = new System.Drawing.Point(40, 160);
            this.txtPhone.Size = new System.Drawing.Size(330, 28);
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;

            // Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(40, 200);
            this.lblEmail.AutoSize = true;

            this.txtEmail.Location = new System.Drawing.Point(40, 225);
            this.txtEmail.Size = new System.Drawing.Size(330, 28);
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;

            // Логин
            this.lblLogin.Text = "Логин:";
            this.lblLogin.Location = new System.Drawing.Point(40, 265);
            this.lblLogin.AutoSize = true;

            this.txtLogin.Location = new System.Drawing.Point(40, 290);
            this.txtLogin.Size = new System.Drawing.Size(330, 28);
            this.txtLogin.BackColor = System.Drawing.Color.WhiteSmoke;

            // Пароль
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.Location = new System.Drawing.Point(40, 330);
            this.lblPassword.AutoSize = true;

            this.txtPassword.Location = new System.Drawing.Point(40, 355);
            this.txtPassword.Size = new System.Drawing.Size(330, 28);
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;

            // Повтор пароля
            this.lblPasswordRepeat.Text = "Повтор пароля:";
            this.lblPasswordRepeat.Location = new System.Drawing.Point(40, 395);
            this.lblPasswordRepeat.AutoSize = true;

            this.txtPasswordRepeat.Location = new System.Drawing.Point(40, 420);
            this.txtPasswordRepeat.Size = new System.Drawing.Size(330, 28);
            this.txtPasswordRepeat.PasswordChar = '•';
            this.txtPasswordRepeat.BackColor = System.Drawing.Color.WhiteSmoke;

            // Кнопка
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Location = new System.Drawing.Point(40, 460);
            this.btnRegister.Size = new System.Drawing.Size(330, 40);
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPasswordRepeat);
            this.Controls.Add(this.txtPasswordRepeat);
            this.Controls.Add(this.btnRegister);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

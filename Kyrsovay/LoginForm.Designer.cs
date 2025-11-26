namespace Kyrsovay
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel lblLogin;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelCenter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelCenter = new System.Windows.Forms.Panel();
            this.lblLogin = new MetroFramework.Controls.MetroLabel();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.btnRegister = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // panelCenter
            // 
            this.panelCenter.Size = new System.Drawing.Size(350, 250);
            this.panelCenter.BackColor = System.Drawing.Color.Transparent;

            // 
            // lblLogin
            // 
            this.lblLogin.Text = "Логин:";
            this.lblLogin.Location = new System.Drawing.Point(20, 15);

            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(20, 40);
            this.txtLogin.Size = new System.Drawing.Size(250, 23);

            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.Location = new System.Drawing.Point(20, 80);

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(20, 105);
            this.txtPassword.Size = new System.Drawing.Size(250, 23);
            this.txtPassword.PasswordChar = '*';

            // 
            // btnLogin
            // 
            this.btnLogin.Text = "Войти";
            this.btnLogin.Location = new System.Drawing.Point(90, 150);
            this.btnLogin.Size = new System.Drawing.Size(150, 35);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // 
            // btnRegister
            // 
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Location = new System.Drawing.Point(90, 195);
            this.btnRegister.Size = new System.Drawing.Size(150, 35);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // Добавляем элементы в панель
            this.panelCenter.Controls.Add(this.lblLogin);
            this.panelCenter.Controls.Add(this.txtLogin);
            this.panelCenter.Controls.Add(this.lblPassword);
            this.panelCenter.Controls.Add(this.txtPassword);
            this.panelCenter.Controls.Add(this.btnLogin);
            this.panelCenter.Controls.Add(this.btnRegister);

            // Добавляем панель на форму
            this.Controls.Add(this.panelCenter);

            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
        }
    }
}

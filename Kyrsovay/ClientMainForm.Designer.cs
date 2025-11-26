namespace Kyrsovay
{
    partial class ClientMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblProfilePhone = new System.Windows.Forms.Label();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.cmbDeviceType = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPriceCaption = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 50);
            this.panelHeader.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(107, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать!";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnLogout2);
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.btnNewOrder);
            this.panelMenu.Controls.Add(this.btnMyOrders);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 550);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogout2
            // 
            this.btnLogout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout2.FlatAppearance.BorderSize = 0;
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.ForeColor = System.Drawing.Color.White;
            this.btnLogout2.Location = new System.Drawing.Point(0, 500);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(180, 50);
            this.btnLogout2.TabIndex = 0;
            this.btnLogout2.Text = "Выход";
            this.btnLogout2.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 110);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(180, 55);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Профиль";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(0, 55);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(180, 55);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "Создать заявку";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.ForeColor = System.Drawing.Color.White;
            this.btnMyOrders.Location = new System.Drawing.Point(0, 0);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(180, 55);
            this.btnMyOrders.TabIndex = 3;
            this.btnMyOrders.Text = "Мои заявки";
            this.btnMyOrders.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelProfile);
            this.panelContent.Controls.Add(this.panelCreate);
            this.panelContent.Controls.Add(this.panelOrders);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(180, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(620, 550);
            this.panelContent.TabIndex = 0;
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.lblProfileName);
            this.panelProfile.Controls.Add(this.txtProfileName);
            this.panelProfile.Controls.Add(this.lblProfilePhone);
            this.panelProfile.Controls.Add(this.txtProfilePhone);
            this.panelProfile.Controls.Add(this.lblProfileEmail);
            this.panelProfile.Controls.Add(this.txtProfileEmail);
            this.panelProfile.Controls.Add(this.btnSaveProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(620, 550);
            this.panelProfile.TabIndex = 0;
            this.panelProfile.Visible = false;
            // 
            // lblProfileName
            // 
            this.lblProfileName.Location = new System.Drawing.Point(40, 40);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(100, 23);
            this.lblProfileName.TabIndex = 0;
            this.lblProfileName.Text = "ФИО:";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(40, 65);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(300, 20);
            this.txtProfileName.TabIndex = 1;
            // 
            // lblProfilePhone
            // 
            this.lblProfilePhone.Location = new System.Drawing.Point(40, 115);
            this.lblProfilePhone.Name = "lblProfilePhone";
            this.lblProfilePhone.Size = new System.Drawing.Size(100, 23);
            this.lblProfilePhone.TabIndex = 2;
            this.lblProfilePhone.Text = "Телефон:";
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Location = new System.Drawing.Point(40, 140);
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.Size = new System.Drawing.Size(300, 20);
            this.txtProfilePhone.TabIndex = 3;
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.Location = new System.Drawing.Point(40, 190);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(100, 23);
            this.lblProfileEmail.TabIndex = 4;
            this.lblProfileEmail.Text = "Email:";
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Location = new System.Drawing.Point(40, 215);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(300, 20);
            this.txtProfileEmail.TabIndex = 5;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(40, 260);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(150, 40);
            this.btnSaveProfile.TabIndex = 6;
            this.btnSaveProfile.Text = "Сохранить";
            // 
            // panelCreate
            // 
            this.panelCreate.Controls.Add(this.lblDeviceType);
            this.panelCreate.Controls.Add(this.cmbDeviceType);
            this.panelCreate.Controls.Add(this.lblModel);
            this.panelCreate.Controls.Add(this.cmbModel);
            this.panelCreate.Controls.Add(this.lblIssue);
            this.panelCreate.Controls.Add(this.cmbIssue);
            this.panelCreate.Controls.Add(this.lblDescription);
            this.panelCreate.Controls.Add(this.txtDescription);
            this.panelCreate.Controls.Add(this.lblPriceCaption);
            this.panelCreate.Controls.Add(this.lblPrice);
            this.panelCreate.Controls.Add(this.btnSendOrder);
            this.panelCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreate.Location = new System.Drawing.Point(0, 0);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(620, 550);
            this.panelCreate.TabIndex = 1;
            this.panelCreate.Visible = false;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.Location = new System.Drawing.Point(40, 40);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(100, 23);
            this.lblDeviceType.TabIndex = 0;
            this.lblDeviceType.Text = "Тип устройства:";
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.Location = new System.Drawing.Point(40, 65);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(300, 21);
            this.cmbDeviceType.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(40, 115);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(100, 23);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Модель:";
            // 
            // cmbModel
            // 
            this.cmbModel.Location = new System.Drawing.Point(40, 140);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(300, 21);
            this.cmbModel.TabIndex = 3;
            // 
            // lblIssue
            // 
            this.lblIssue.Location = new System.Drawing.Point(40, 190);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(100, 23);
            this.lblIssue.TabIndex = 4;
            this.lblIssue.Text = "Проблема:";
            // 
            // cmbIssue
            // 
            this.cmbIssue.Location = new System.Drawing.Point(40, 215);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(300, 21);
            this.cmbIssue.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(40, 265);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Комментарий:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(40, 290);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 80);
            this.txtDescription.TabIndex = 7;
            // 
            // lblPriceCaption
            // 
            this.lblPriceCaption.Location = new System.Drawing.Point(40, 380);
            this.lblPriceCaption.Name = "lblPriceCaption";
            this.lblPriceCaption.Size = new System.Drawing.Size(100, 23);
            this.lblPriceCaption.TabIndex = 8;
            this.lblPriceCaption.Text = "Стоимость:";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(150, 380);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "0 ₸";
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.Location = new System.Drawing.Point(40, 420);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(180, 40);
            this.btnSendOrder.TabIndex = 10;
            this.btnSendOrder.Text = "Отправить заявку";
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.gridOrders);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(620, 550);
            this.panelOrders.TabIndex = 2;
            this.panelOrders.Visible = false;
            // 
            // gridOrders
            // 
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrders.Location = new System.Drawing.Point(0, 0);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(620, 550);
            this.gridOrders.TabIndex = 0;
            // 
            // ClientMainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "ClientMainForm";
            this.Text = "Личный кабинет клиента";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout2;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.DataGridView gridOrders;

        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.ComboBox cmbIssue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPriceCaption;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSendOrder;

        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfilePhone;
        private System.Windows.Forms.TextBox txtProfilePhone;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Button btnSaveProfile;
    }
}

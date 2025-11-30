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
            this.btnPriceList = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelOrderActions = new System.Windows.Forms.Panel();
            this.btnGetReceipt = new System.Windows.Forms.Button();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.btnFilterByPrice = new System.Windows.Forms.Button();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.cmbDeviceType = new System.Windows.Forms.ComboBox();
            this.chkCustomDevice = new System.Windows.Forms.CheckBox();
            this.txtCustomDevice = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.cmbIssue = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPriceCaption = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSendOrder = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblProfilePhone = new System.Windows.Forms.Label();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.panelPriceList = new System.Windows.Forms.Panel();
            this.lblPriceListTitle = new System.Windows.Forms.Label();
            this.treePriceList = new System.Windows.Forms.TreeView();
            this.btnClosePriceList = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelOrderActions.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelPriceList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 50);
            this.panelHeader.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(170, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать!";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnLogout2);
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.btnPriceList);
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
            this.btnLogout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogout2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout2.FlatAppearance.BorderSize = 0;
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout2.ForeColor = System.Drawing.Color.White;
            this.btnLogout2.Location = new System.Drawing.Point(0, 500);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(180, 50);
            this.btnLogout2.TabIndex = 0;
            this.btnLogout2.Text = "⬅ Выход";
            this.btnLogout2.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 165);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(180, 55);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "👤 Профиль";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnPriceList
            // 
            this.btnPriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnPriceList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPriceList.FlatAppearance.BorderSize = 0;
            this.btnPriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPriceList.ForeColor = System.Drawing.Color.White;
            this.btnPriceList.Location = new System.Drawing.Point(0, 110);
            this.btnPriceList.Name = "btnPriceList";
            this.btnPriceList.Size = new System.Drawing.Size(180, 55);
            this.btnPriceList.TabIndex = 4;
            this.btnPriceList.Text = "💰 Прайс-лист";
            this.btnPriceList.UseVisualStyleBackColor = false;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(0, 55);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(180, 55);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "➕ Новый заказ";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMyOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMyOrders.ForeColor = System.Drawing.Color.White;
            this.btnMyOrders.Location = new System.Drawing.Point(0, 0);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(180, 55);
            this.btnMyOrders.TabIndex = 3;
            this.btnMyOrders.Text = "📋 Мои заявки";
            this.btnMyOrders.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelContent.Controls.Add(this.panelOrders);
            this.panelContent.Controls.Add(this.panelCreate);
            this.panelContent.Controls.Add(this.panelProfile);
            this.panelContent.Controls.Add(this.panelPriceList);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(180, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(720, 550);
            this.panelContent.TabIndex = 0;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.gridOrders);
            this.panelOrders.Controls.Add(this.panelOrderActions);
            this.panelOrders.Controls.Add(this.panelFilter);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(720, 550);
            this.panelOrders.TabIndex = 0;
            // 
            // gridOrders
            // 
            this.gridOrders.AllowUserToAddRows = false;
            this.gridOrders.AllowUserToDeleteRows = false;
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrders.BackgroundColor = System.Drawing.Color.White;
            this.gridOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrders.EnableHeadersVisualStyles = false;
            this.gridOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // panelOrderActions
            // 
            this.panelOrderActions.BackColor = System.Drawing.Color.White;
            this.panelOrderActions.Controls.Add(this.btnGetReceipt);
            this.panelOrderActions.Controls.Add(this.btnPayOrder);
            this.panelOrderActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderActions.Location = new System.Drawing.Point(0, 450);
            this.panelOrderActions.Name = "panelOrderActions";
            this.panelOrderActions.Padding = new System.Windows.Forms.Padding(15);
            this.panelOrderActions.Size = new System.Drawing.Size(720, 100);
            this.panelOrderActions.TabIndex = 2;
            this.panelOrderActions.Visible = false;
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPayOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayOrder.FlatAppearance.BorderSize = 0;
            this.btnPayOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPayOrder.ForeColor = System.Drawing.Color.White;
            this.btnPayOrder.Location = new System.Drawing.Point(15, 15);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(180, 40);
            this.btnPayOrder.TabIndex = 0;
            this.btnPayOrder.Text = "💳 Оплатить";
            this.btnPayOrder.UseVisualStyleBackColor = false;
            // 
            // btnGetReceipt
            // 
            this.btnGetReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGetReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetReceipt.FlatAppearance.BorderSize = 0;
            this.btnGetReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetReceipt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGetReceipt.ForeColor = System.Drawing.Color.White;
            this.btnGetReceipt.Location = new System.Drawing.Point(205, 15);
            this.btnGetReceipt.Name = "btnGetReceipt";
            this.btnGetReceipt.Size = new System.Drawing.Size(180, 40);
            this.btnGetReceipt.TabIndex = 1;
            this.btnGetReceipt.Text = "🧾 Получить чек";
            this.btnGetReceipt.UseVisualStyleBackColor = false;
            // 
            // gridOrders
            // 
            this.gridOrders.AllowUserToAddRows = false;
            this.gridOrders.AllowUserToDeleteRows = false;
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrders.BackgroundColor = System.Drawing.Color.White;
            this.gridOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrders.EnableHeadersVisualStyles = false;
            this.gridOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridOrders.Location = new System.Drawing.Point(0, 140);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.gridOrders.RowHeadersVisible = false;
            this.gridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.Size = new System.Drawing.Size(720, 310);
            this.gridOrders.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.lblFilterTitle);
            this.panelFilter.Controls.Add(this.btnFilterByPrice);
            this.panelFilter.Controls.Add(this.lblFilterStatus);
            this.panelFilter.Controls.Add(this.cmbFilterStatus);
            this.panelFilter.Controls.Add(this.lblFilterDateFrom);
            this.panelFilter.Controls.Add(this.dtpDateFrom);
            this.panelFilter.Controls.Add(this.lblFilterDateTo);
            this.panelFilter.Controls.Add(this.dtpDateTo);
            this.panelFilter.Controls.Add(this.btnApplyFilter);
            this.panelFilter.Controls.Add(this.btnResetFilter);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(15);
            this.panelFilter.Size = new System.Drawing.Size(720, 140);
            this.panelFilter.TabIndex = 1;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 10);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(104, 20);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "🔍 Фильтры:";
            // 
            // btnFilterByPrice
            // 
            this.btnFilterByPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterByPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterByPrice.FlatAppearance.BorderSize = 0;
            this.btnFilterByPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterByPrice.ForeColor = System.Drawing.Color.White;
            this.btnFilterByPrice.Location = new System.Drawing.Point(15, 95);
            this.btnFilterByPrice.Name = "btnFilterByPrice";
            this.btnFilterByPrice.Size = new System.Drawing.Size(150, 32);
            this.btnFilterByPrice.TabIndex = 10;
            this.btnFilterByPrice.Text = "💰 Фильтр по цене ▼";
            this.btnFilterByPrice.UseVisualStyleBackColor = false;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterStatus.Location = new System.Drawing.Point(15, 42);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(46, 15);
            this.lblFilterStatus.TabIndex = 1;
            this.lblFilterStatus.Text = "Статус:";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFilterStatus.Location = new System.Drawing.Point(15, 60);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(160, 25);
            this.cmbFilterStatus.TabIndex = 2;
            // 
            // lblFilterDateFrom
            // 
            this.lblFilterDateFrom.AutoSize = true;
            this.lblFilterDateFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterDateFrom.Location = new System.Drawing.Point(190, 42);
            this.lblFilterDateFrom.Name = "lblFilterDateFrom";
            this.lblFilterDateFrom.Size = new System.Drawing.Size(54, 15);
            this.lblFilterDateFrom.TabIndex = 3;
            this.lblFilterDateFrom.Text = "Дата от:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(190, 60);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(120, 23);
            this.dtpDateFrom.TabIndex = 4;
            // 
            // lblFilterDateTo
            // 
            this.lblFilterDateTo.AutoSize = true;
            this.lblFilterDateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterDateTo.Location = new System.Drawing.Point(325, 42);
            this.lblFilterDateTo.Name = "lblFilterDateTo";
            this.lblFilterDateTo.Size = new System.Drawing.Size(55, 15);
            this.lblFilterDateTo.TabIndex = 5;
            this.lblFilterDateTo.Text = "Дата до:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(325, 60);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(120, 23);
            this.dtpDateTo.TabIndex = 6;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(470, 55);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(100, 32);
            this.btnApplyFilter.TabIndex = 7;
            this.btnApplyFilter.Text = "✓ Применить";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnResetFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilter.FlatAppearance.BorderSize = 0;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(580, 55);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(100, 32);
            this.btnResetFilter.TabIndex = 8;
            this.btnResetFilter.Text = "✕ Сбросить";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            // 
            // panelCreate
            // 
            this.panelCreate.BackColor = System.Drawing.Color.White;
            this.panelCreate.Controls.Add(this.lblDeviceType);
            this.panelCreate.Controls.Add(this.cmbDeviceType);
            this.panelCreate.Controls.Add(this.chkCustomDevice);
            this.panelCreate.Controls.Add(this.txtCustomDevice);
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
            this.panelCreate.Padding = new System.Windows.Forms.Padding(40);
            this.panelCreate.Size = new System.Drawing.Size(720, 550);
            this.panelCreate.TabIndex = 1;
            this.panelCreate.Visible = false;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeviceType.Location = new System.Drawing.Point(40, 40);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(117, 19);
            this.lblDeviceType.TabIndex = 0;
            this.lblDeviceType.Text = "Тип устройства:";
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDeviceType.Location = new System.Drawing.Point(40, 65);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(350, 25);
            this.cmbDeviceType.TabIndex = 1;
            // 
            // chkCustomDevice
            // 
            this.chkCustomDevice.AutoSize = true;
            this.chkCustomDevice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCustomDevice.Location = new System.Drawing.Point(40, 100);
            this.chkCustomDevice.Name = "chkCustomDevice";
            this.chkCustomDevice.Size = new System.Drawing.Size(239, 19);
            this.chkCustomDevice.TabIndex = 2;
            this.chkCustomDevice.Text = "Моего устройства нет в списке (ввести вручную)";
            this.chkCustomDevice.UseVisualStyleBackColor = true;
            // 
            // txtCustomDevice
            // 
            this.txtCustomDevice.Enabled = false;
            this.txtCustomDevice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomDevice.Location = new System.Drawing.Point(40, 125);
            this.txtCustomDevice.Name = "txtCustomDevice";
            this.txtCustomDevice.Size = new System.Drawing.Size(350, 25);
            this.txtCustomDevice.TabIndex = 3;
            this.txtCustomDevice.Text = "Введите название устройства";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModel.Location = new System.Drawing.Point(40, 160);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(69, 19);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Модель:";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbModel.Location = new System.Drawing.Point(40, 185);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(350, 25);
            this.cmbModel.TabIndex = 5;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIssue.Location = new System.Drawing.Point(40, 220);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(79, 19);
            this.lblIssue.TabIndex = 6;
            this.lblIssue.Text = "Проблема:";
            // 
            // cmbIssue
            // 
            this.cmbIssue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIssue.Location = new System.Drawing.Point(40, 245);
            this.cmbIssue.Name = "cmbIssue";
            this.cmbIssue.Size = new System.Drawing.Size(350, 25);
            this.cmbIssue.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.Location = new System.Drawing.Point(40, 280);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(188, 19);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Описание (опционально):";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(40, 305);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(500, 80);
            this.txtDescription.TabIndex = 9;
            // 
            // lblPriceCaption
            // 
            this.lblPriceCaption.AutoSize = true;
            this.lblPriceCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPriceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblPriceCaption.Location = new System.Drawing.Point(40, 400);
            this.lblPriceCaption.Name = "lblPriceCaption";
            this.lblPriceCaption.Size = new System.Drawing.Size(58, 20);
            this.lblPriceCaption.TabIndex = 10;
            this.lblPriceCaption.Text = "Цена:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblPrice.Location = new System.Drawing.Point(40, 425);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(130, 25);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "0 ₸ (бесплатно)";
            // 
            // btnSendOrder
            // 
            this.btnSendOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSendOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendOrder.FlatAppearance.BorderSize = 0;
            this.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSendOrder.ForeColor = System.Drawing.Color.White;
            this.btnSendOrder.Location = new System.Drawing.Point(40, 470);
            this.btnSendOrder.Name = "btnSendOrder";
            this.btnSendOrder.Size = new System.Drawing.Size(200, 45);
            this.btnSendOrder.TabIndex = 12;
            this.btnSendOrder.Text = "✓ Отправить заявку";
            this.btnSendOrder.UseVisualStyleBackColor = false;
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.White;
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
            this.panelProfile.Padding = new System.Windows.Forms.Padding(40);
            this.panelProfile.Size = new System.Drawing.Size(720, 550);
            this.panelProfile.TabIndex = 2;
            this.panelProfile.Visible = false;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfileName.Location = new System.Drawing.Point(40, 40);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(46, 19);
            this.lblProfileName.TabIndex = 0;
            this.lblProfileName.Text = "ФИО:";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfileName.Location = new System.Drawing.Point(40, 65);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(400, 25);
            this.txtProfileName.TabIndex = 1;
            // 
            // lblProfilePhone
            // 
            this.lblProfilePhone.AutoSize = true;
            this.lblProfilePhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfilePhone.Location = new System.Drawing.Point(40, 110);
            this.lblProfilePhone.Name = "lblProfilePhone";
            this.lblProfilePhone.Size = new System.Drawing.Size(72, 19);
            this.lblProfilePhone.TabIndex = 2;
            this.lblProfilePhone.Text = "Телефон:";
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfilePhone.Location = new System.Drawing.Point(40, 135);
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.Size = new System.Drawing.Size(400, 25);
            this.txtProfilePhone.TabIndex = 3;
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProfileEmail.Location = new System.Drawing.Point(40, 180);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(49, 19);
            this.lblProfileEmail.TabIndex = 4;
            this.lblProfileEmail.Text = "Email:";
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfileEmail.Location = new System.Drawing.Point(40, 205);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(400, 25);
            this.txtProfileEmail.TabIndex = 5;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSaveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(40, 250);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(150, 40);
            this.btnSaveProfile.TabIndex = 6;
            this.btnSaveProfile.Text = "💾 Сохранить";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            // 
            // panelPriceList
            // 
            this.panelPriceList.BackColor = System.Drawing.Color.White;
            this.panelPriceList.Controls.Add(this.lblPriceListTitle);
            this.panelPriceList.Controls.Add(this.treePriceList);
            this.panelPriceList.Controls.Add(this.btnClosePriceList);
            this.panelPriceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPriceList.Location = new System.Drawing.Point(0, 0);
            this.panelPriceList.Name = "panelPriceList";
            this.panelPriceList.Padding = new System.Windows.Forms.Padding(20);
            this.panelPriceList.Size = new System.Drawing.Size(720, 550);
            this.panelPriceList.TabIndex = 3;
            this.panelPriceList.Visible = false;
            // 
            // lblPriceListTitle
            // 
            this.lblPriceListTitle.AutoSize = true;
            this.lblPriceListTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPriceListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblPriceListTitle.Location = new System.Drawing.Point(20, 20);
            this.lblPriceListTitle.Name = "lblPriceListTitle";
            this.lblPriceListTitle.Size = new System.Drawing.Size(236, 25);
            this.lblPriceListTitle.TabIndex = 0;
            this.lblPriceListTitle.Text = "💰 Прайс-лист на услуги";
            // 
            // treePriceList
            // 
            this.treePriceList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.treePriceList.Location = new System.Drawing.Point(20, 60);
            this.treePriceList.Name = "treePriceList";
            this.treePriceList.Size = new System.Drawing.Size(680, 420);
            this.treePriceList.TabIndex = 1;
            // 
            // btnClosePriceList
            // 
            this.btnClosePriceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClosePriceList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePriceList.FlatAppearance.BorderSize = 0;
            this.btnClosePriceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePriceList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClosePriceList.ForeColor = System.Drawing.Color.White;
            this.btnClosePriceList.Location = new System.Drawing.Point(20, 490);
            this.btnClosePriceList.Name = "btnClosePriceList";
            this.btnClosePriceList.Size = new System.Drawing.Size(150, 40);
            this.btnClosePriceList.TabIndex = 2;
            this.btnClosePriceList.Text = "← Назад";
            this.btnClosePriceList.UseVisualStyleBackColor = false;
            // 
            // ClientMainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ClientMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервисный центр — Личный кабинет";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.panelOrderActions.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelPriceList.ResumeLayout(false);
            this.panelPriceList.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnPriceList;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout2;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Panel panelOrderActions;
        private System.Windows.Forms.Button btnPayOrder;
        private System.Windows.Forms.Button btnGetReceipt;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Button btnFilterByPrice;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblFilterDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblFilterDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnResetFilter;

        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.ComboBox cmbDeviceType;
        private System.Windows.Forms.CheckBox chkCustomDevice;
        private System.Windows.Forms.TextBox txtCustomDevice;
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

        private System.Windows.Forms.Panel panelPriceList;
        private System.Windows.Forms.Label lblPriceListTitle;
        private System.Windows.Forms.TreeView treePriceList;
        private System.Windows.Forms.Button btnClosePriceList;
    }
}

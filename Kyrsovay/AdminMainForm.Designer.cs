namespace Kyrsovay
{
    partial class AdminMainForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnPositions = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.panelEmployeeButtons = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnToggleActive = new System.Windows.Forms.Button();
            this.panelEmployeeFilter = new System.Windows.Forms.Panel();
            this.btnFilterEmployeeByName = new System.Windows.Forms.Button();
            this.btnResetEmployeeFilter = new System.Windows.Forms.Button();
            this.panelPositions = new System.Windows.Forms.Panel();
            this.gridPositions = new System.Windows.Forms.DataGridView();
            this.panelPositionButtons = new System.Windows.Forms.Panel();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.panelPositionFilter = new System.Windows.Forms.Panel();
            this.btnFilterPositionByName = new System.Windows.Forms.Button();
            this.btnResetPositionFilter = new System.Windows.Forms.Button();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelOrdersTop = new System.Windows.Forms.Panel();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.panelOrdersButtons = new System.Windows.Forms.Panel();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.panelOrderFilter = new System.Windows.Forms.Panel();
            this.btnFilterOrderByName = new System.Windows.Forms.Button();
            this.btnFilterOrderByPrice = new System.Windows.Forms.Button();
            this.btnFilterOrderByDate = new System.Windows.Forms.Button();
            this.btnResetOrderFilter = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.panelEmployeeButtons.SuspendLayout();
            this.panelEmployeeFilter.SuspendLayout();
            this.panelPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPositions)).BeginInit();
            this.panelPositionButtons.SuspendLayout();
            this.panelPositionFilter.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelOrdersTop.SuspendLayout();
            this.panelOrdersButtons.SuspendLayout();
            this.panelOrderFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "👑 Панель администратора";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnPositions);
            this.panelMenu.Controls.Add(this.btnEmployees);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 550);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 500);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "⬅ Выход";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(0, 110);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 55);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "📋 Заказы";
            this.btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnPositions
            // 
            this.btnPositions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPositions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPositions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPositions.FlatAppearance.BorderSize = 0;
            this.btnPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPositions.ForeColor = System.Drawing.Color.White;
            this.btnPositions.Location = new System.Drawing.Point(0, 55);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(200, 55);
            this.btnPositions.TabIndex = 2;
            this.btnPositions.Text = "💼 Должности";
            this.btnPositions.UseVisualStyleBackColor = false;
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Location = new System.Drawing.Point(0, 0);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(200, 55);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "👥 Сотрудники";
            this.btnEmployees.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelContent.Controls.Add(this.panelEmployees);
            this.panelContent.Controls.Add(this.panelPositions);
            this.panelContent.Controls.Add(this.panelOrders);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 550);
            this.panelContent.TabIndex = 2;
            // 
            // panelEmployees
            // 
            this.panelEmployees.Controls.Add(this.gridEmployees);
            this.panelEmployees.Controls.Add(this.panelEmployeeButtons);
            this.panelEmployees.Controls.Add(this.panelEmployeeFilter);
            this.panelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployees.Location = new System.Drawing.Point(0, 0);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Padding = new System.Windows.Forms.Padding(20);
            this.panelEmployees.Size = new System.Drawing.Size(800, 550);
            this.panelEmployees.TabIndex = 0;
            // 
            // panelEmployeeFilter
            // 
            this.panelEmployeeFilter.BackColor = System.Drawing.Color.White;
            this.panelEmployeeFilter.Controls.Add(this.btnFilterEmployeeByName);
            this.panelEmployeeFilter.Controls.Add(this.btnResetEmployeeFilter);
            this.panelEmployeeFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeeFilter.Location = new System.Drawing.Point(20, 20);
            this.panelEmployeeFilter.Name = "panelEmployeeFilter";
            this.panelEmployeeFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelEmployeeFilter.Size = new System.Drawing.Size(760, 60);
            this.panelEmployeeFilter.TabIndex = 2;
            // 
            // btnFilterEmployeeByName
            // 
            this.btnFilterEmployeeByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterEmployeeByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterEmployeeByName.FlatAppearance.BorderSize = 0;
            this.btnFilterEmployeeByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterEmployeeByName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterEmployeeByName.ForeColor = System.Drawing.Color.White;
            this.btnFilterEmployeeByName.Location = new System.Drawing.Point(15, 15);
            this.btnFilterEmployeeByName.Name = "btnFilterEmployeeByName";
            this.btnFilterEmployeeByName.Size = new System.Drawing.Size(160, 32);
            this.btnFilterEmployeeByName.TabIndex = 0;
            this.btnFilterEmployeeByName.Text = "📝 Фильтр по имени ▼";
            this.btnFilterEmployeeByName.UseVisualStyleBackColor = false;
            // 
            // btnResetEmployeeFilter
            // 
            this.btnResetEmployeeFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnResetEmployeeFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetEmployeeFilter.FlatAppearance.BorderSize = 0;
            this.btnResetEmployeeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEmployeeFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetEmployeeFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetEmployeeFilter.Location = new System.Drawing.Point(185, 15);
            this.btnResetEmployeeFilter.Name = "btnResetEmployeeFilter";
            this.btnResetEmployeeFilter.Size = new System.Drawing.Size(120, 32);
            this.btnResetEmployeeFilter.TabIndex = 1;
            this.btnResetEmployeeFilter.Text = "✕ Сбросить";
            this.btnResetEmployeeFilter.UseVisualStyleBackColor = false;
            // 
            // gridEmployees
            // 
            this.gridEmployees.AllowUserToAddRows = false;
            this.gridEmployees.AllowUserToDeleteRows = false;
            this.gridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployees.BackgroundColor = System.Drawing.Color.White;
            this.gridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployees.EnableHeadersVisualStyles = false;
            this.gridEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridEmployees.Location = new System.Drawing.Point(20, 80);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.ReadOnly = true;
            this.gridEmployees.RowHeadersVisible = false;
            this.gridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployees.Size = new System.Drawing.Size(760, 390);
            this.gridEmployees.TabIndex = 0;
            // 
            // panelEmployeeButtons
            // 
            this.panelEmployeeButtons.BackColor = System.Drawing.Color.White;
            this.panelEmployeeButtons.Controls.Add(this.btnToggleActive);
            this.panelEmployeeButtons.Controls.Add(this.btnDeleteEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnEditEmployee);
            this.panelEmployeeButtons.Controls.Add(this.btnAddEmployee);
            this.panelEmployeeButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmployeeButtons.Location = new System.Drawing.Point(20, 470);
            this.panelEmployeeButtons.Name = "panelEmployeeButtons";
            this.panelEmployeeButtons.Padding = new System.Windows.Forms.Padding(10);
            this.panelEmployeeButtons.Size = new System.Drawing.Size(760, 60);
            this.panelEmployeeButtons.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(15, 15);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(160, 32);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "➕ Добавить";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmployee.FlatAppearance.BorderSize = 0;
            this.btnEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEditEmployee.Location = new System.Drawing.Point(185, 15);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(160, 32);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "✏ Редактировать";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(355, 15);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(160, 32);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "🗑 Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            // 
            // btnToggleActive
            // 
            this.btnToggleActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnToggleActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleActive.FlatAppearance.BorderSize = 0;
            this.btnToggleActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToggleActive.ForeColor = System.Drawing.Color.White;
            this.btnToggleActive.Location = new System.Drawing.Point(525, 15);
            this.btnToggleActive.Name = "btnToggleActive";
            this.btnToggleActive.Size = new System.Drawing.Size(180, 32);
            this.btnToggleActive.TabIndex = 3;
            this.btnToggleActive.Text = "🔄 Активен/Неактивен";
            this.btnToggleActive.UseVisualStyleBackColor = false;
            // 
            // panelPositions
            // 
            this.panelPositions.Controls.Add(this.gridPositions);
            this.panelPositions.Controls.Add(this.panelPositionButtons);
            this.panelPositions.Controls.Add(this.panelPositionFilter);
            this.panelPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPositions.Location = new System.Drawing.Point(0, 0);
            this.panelPositions.Name = "panelPositions";
            this.panelPositions.Padding = new System.Windows.Forms.Padding(20);
            this.panelPositions.Size = new System.Drawing.Size(800, 550);
            this.panelPositions.TabIndex = 1;
            this.panelPositions.Visible = false;
            // 
            // panelPositionFilter
            // 
            this.panelPositionFilter.BackColor = System.Drawing.Color.White;
            this.panelPositionFilter.Controls.Add(this.btnFilterPositionByName);
            this.panelPositionFilter.Controls.Add(this.btnResetPositionFilter);
            this.panelPositionFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPositionFilter.Location = new System.Drawing.Point(20, 20);
            this.panelPositionFilter.Name = "panelPositionFilter";
            this.panelPositionFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelPositionFilter.Size = new System.Drawing.Size(760, 60);
            this.panelPositionFilter.TabIndex = 2;
            // 
            // btnFilterPositionByName
            // 
            this.btnFilterPositionByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterPositionByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterPositionByName.FlatAppearance.BorderSize = 0;
            this.btnFilterPositionByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPositionByName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterPositionByName.ForeColor = System.Drawing.Color.White;
            this.btnFilterPositionByName.Location = new System.Drawing.Point(15, 15);
            this.btnFilterPositionByName.Name = "btnFilterPositionByName";
            this.btnFilterPositionByName.Size = new System.Drawing.Size(160, 32);
            this.btnFilterPositionByName.TabIndex = 0;
            this.btnFilterPositionByName.Text = "📝 Фильтр по имени ▼";
            this.btnFilterPositionByName.UseVisualStyleBackColor = false;
            // 
            // btnResetPositionFilter
            // 
            this.btnResetPositionFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnResetPositionFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPositionFilter.FlatAppearance.BorderSize = 0;
            this.btnResetPositionFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPositionFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPositionFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetPositionFilter.Location = new System.Drawing.Point(185, 15);
            this.btnResetPositionFilter.Name = "btnResetPositionFilter";
            this.btnResetPositionFilter.Size = new System.Drawing.Size(120, 32);
            this.btnResetPositionFilter.TabIndex = 1;
            this.btnResetPositionFilter.Text = "✕ Сбросить";
            this.btnResetPositionFilter.UseVisualStyleBackColor = false;
            // 
            // gridPositions
            // 
            this.gridPositions.AllowUserToAddRows = false;
            this.gridPositions.AllowUserToDeleteRows = false;
            this.gridPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPositions.BackgroundColor = System.Drawing.Color.White;
            this.gridPositions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPositions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPositions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPositions.EnableHeadersVisualStyles = false;
            this.gridPositions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.gridPositions.Location = new System.Drawing.Point(20, 80);
            this.gridPositions.Name = "gridPositions";
            this.gridPositions.ReadOnly = true;
            this.gridPositions.RowHeadersVisible = false;
            this.gridPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPositions.Size = new System.Drawing.Size(760, 390);
            this.gridPositions.TabIndex = 0;
            // 
            // panelPositionButtons
            // 
            this.panelPositionButtons.BackColor = System.Drawing.Color.White;
            this.panelPositionButtons.Controls.Add(this.btnDeletePosition);
            this.panelPositionButtons.Controls.Add(this.btnAddPosition);
            this.panelPositionButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPositionButtons.Location = new System.Drawing.Point(20, 470);
            this.panelPositionButtons.Name = "panelPositionButtons";
            this.panelPositionButtons.Padding = new System.Windows.Forms.Padding(10);
            this.panelPositionButtons.Size = new System.Drawing.Size(760, 60);
            this.panelPositionButtons.TabIndex = 1;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPosition.FlatAppearance.BorderSize = 0;
            this.btnAddPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddPosition.ForeColor = System.Drawing.Color.White;
            this.btnAddPosition.Location = new System.Drawing.Point(15, 15);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(160, 32);
            this.btnAddPosition.TabIndex = 0;
            this.btnAddPosition.Text = "➕ Добавить должность";
            this.btnAddPosition.UseVisualStyleBackColor = false;
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeletePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePosition.FlatAppearance.BorderSize = 0;
            this.btnDeletePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeletePosition.ForeColor = System.Drawing.Color.White;
            this.btnDeletePosition.Location = new System.Drawing.Point(185, 15);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(160, 32);
            this.btnDeletePosition.TabIndex = 1;
            this.btnDeletePosition.Text = "🗑 Удалить должность";
            this.btnDeletePosition.UseVisualStyleBackColor = false;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.gridOrders);
            this.panelOrders.Controls.Add(this.panelOrdersButtons);
            this.panelOrders.Controls.Add(this.panelOrderFilter);
            this.panelOrders.Controls.Add(this.panelOrdersTop);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Padding = new System.Windows.Forms.Padding(20);
            this.panelOrders.Size = new System.Drawing.Size(800, 550);
            this.panelOrders.TabIndex = 2;
            this.panelOrders.Visible = false;
            // 
            // panelOrderFilter
            // 
            this.panelOrderFilter.BackColor = System.Drawing.Color.White;
            this.panelOrderFilter.Controls.Add(this.btnFilterOrderByDate);
            this.panelOrderFilter.Controls.Add(this.btnFilterOrderByPrice);
            this.panelOrderFilter.Controls.Add(this.btnFilterOrderByName);
            this.panelOrderFilter.Controls.Add(this.btnResetOrderFilter);
            this.panelOrderFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderFilter.Location = new System.Drawing.Point(20, 70);
            this.panelOrderFilter.Name = "panelOrderFilter";
            this.panelOrderFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelOrderFilter.Size = new System.Drawing.Size(760, 60);
            this.panelOrderFilter.TabIndex = 3;
            // 
            // btnFilterOrderByName
            // 
            this.btnFilterOrderByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterOrderByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterOrderByName.FlatAppearance.BorderSize = 0;
            this.btnFilterOrderByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterOrderByName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterOrderByName.ForeColor = System.Drawing.Color.White;
            this.btnFilterOrderByName.Location = new System.Drawing.Point(15, 15);
            this.btnFilterOrderByName.Name = "btnFilterOrderByName";
            this.btnFilterOrderByName.Size = new System.Drawing.Size(160, 32);
            this.btnFilterOrderByName.TabIndex = 0;
            this.btnFilterOrderByName.Text = "📝 Фильтр по имени ▼";
            this.btnFilterOrderByName.UseVisualStyleBackColor = false;
            // 
            // btnFilterOrderByPrice
            // 
            this.btnFilterOrderByPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterOrderByPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterOrderByPrice.FlatAppearance.BorderSize = 0;
            this.btnFilterOrderByPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterOrderByPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterOrderByPrice.ForeColor = System.Drawing.Color.White;
            this.btnFilterOrderByPrice.Location = new System.Drawing.Point(185, 15);
            this.btnFilterOrderByPrice.Name = "btnFilterOrderByPrice";
            this.btnFilterOrderByPrice.Size = new System.Drawing.Size(160, 32);
            this.btnFilterOrderByPrice.TabIndex = 1;
            this.btnFilterOrderByPrice.Text = "💰 Фильтр по цене ▼";
            this.btnFilterOrderByPrice.UseVisualStyleBackColor = false;
            // 
            // btnFilterOrderByDate
            // 
            this.btnFilterOrderByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterOrderByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterOrderByDate.FlatAppearance.BorderSize = 0;
            this.btnFilterOrderByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterOrderByDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterOrderByDate.ForeColor = System.Drawing.Color.White;
            this.btnFilterOrderByDate.Location = new System.Drawing.Point(355, 15);
            this.btnFilterOrderByDate.Name = "btnFilterOrderByDate";
            this.btnFilterOrderByDate.Size = new System.Drawing.Size(160, 32);
            this.btnFilterOrderByDate.TabIndex = 3;
            this.btnFilterOrderByDate.Text = "📅 Фильтр по дате ▼";
            this.btnFilterOrderByDate.UseVisualStyleBackColor = false;
            // 
            // btnResetOrderFilter
            // 
            this.btnResetOrderFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnResetOrderFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetOrderFilter.FlatAppearance.BorderSize = 0;
            this.btnResetOrderFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrderFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetOrderFilter.ForeColor = System.Drawing.Color.White;
            this.btnResetOrderFilter.Location = new System.Drawing.Point(525, 15);
            this.btnResetOrderFilter.Name = "btnResetOrderFilter";
            this.btnResetOrderFilter.Size = new System.Drawing.Size(120, 32);
            this.btnResetOrderFilter.TabIndex = 2;
            this.btnResetOrderFilter.Text = "✕ Сбросить";
            this.btnResetOrderFilter.UseVisualStyleBackColor = false;
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
            this.gridOrders.Location = new System.Drawing.Point(20, 130);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.gridOrders.RowHeadersVisible = false;
            this.gridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.Size = new System.Drawing.Size(760, 340);
            this.gridOrders.TabIndex = 0;
            // 
            // panelOrdersTop
            // 
            this.panelOrdersTop.BackColor = System.Drawing.Color.White;
            this.panelOrdersTop.Controls.Add(this.lblOrdersTitle);
            this.panelOrdersTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrdersTop.Location = new System.Drawing.Point(20, 20);
            this.panelOrdersTop.Name = "panelOrdersTop";
            this.panelOrdersTop.Size = new System.Drawing.Size(760, 50);
            this.panelOrdersTop.TabIndex = 1;
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblOrdersTitle.Location = new System.Drawing.Point(15, 13);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(267, 21);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "📋 Все заказы";
            // 
            // panelOrdersButtons
            // 
            this.panelOrdersButtons.BackColor = System.Drawing.Color.White;
            this.panelOrdersButtons.Controls.Add(this.btnDeleteOrder);
            this.panelOrdersButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrdersButtons.Location = new System.Drawing.Point(20, 470);
            this.panelOrdersButtons.Name = "panelOrdersButtons";
            this.panelOrdersButtons.Padding = new System.Windows.Forms.Padding(10);
            this.panelOrdersButtons.Size = new System.Drawing.Size(760, 60);
            this.panelOrdersButtons.TabIndex = 2;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Location = new System.Drawing.Point(15, 15);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(160, 32);
            this.btnDeleteOrder.TabIndex = 0;
            this.btnDeleteOrder.Text = "🗑 Удалить заказ";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // AdminMainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервисный центр — Панель администратора";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.panelEmployeeButtons.ResumeLayout(false);
            this.panelEmployeeFilter.ResumeLayout(false);
            this.panelPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPositions)).EndInit();
            this.panelPositionButtons.ResumeLayout(false);
            this.panelPositionFilter.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.panelOrdersTop.ResumeLayout(false);
            this.panelOrdersTop.PerformLayout();
            this.panelOrdersButtons.ResumeLayout(false);
            this.panelOrderFilter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelEmployees;
        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.Panel panelEmployeeButtons;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnToggleActive;
        private System.Windows.Forms.Panel panelEmployeeFilter;
        private System.Windows.Forms.Button btnFilterEmployeeByName;
        private System.Windows.Forms.Button btnResetEmployeeFilter;

        private System.Windows.Forms.Panel panelPositions;
        private System.Windows.Forms.DataGridView gridPositions;
        private System.Windows.Forms.Panel panelPositionButtons;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Panel panelPositionFilter;
        private System.Windows.Forms.Button btnFilterPositionByName;
        private System.Windows.Forms.Button btnResetPositionFilter;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Panel panelOrdersTop;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Panel panelOrdersButtons;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Panel panelOrderFilter;
        private System.Windows.Forms.Button btnFilterOrderByName;
        private System.Windows.Forms.Button btnFilterOrderByPrice;
        private System.Windows.Forms.Button btnFilterOrderByDate;
        private System.Windows.Forms.Button btnResetOrderFilter;
    }
}

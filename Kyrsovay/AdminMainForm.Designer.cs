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
            this.panelPositions = new System.Windows.Forms.Panel();
            this.gridPositions = new System.Windows.Forms.DataGridView();
            this.panelPositionButtons = new System.Windows.Forms.Panel();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelOrdersTop = new System.Windows.Forms.Panel();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.panelEmployeeButtons.SuspendLayout();
            this.panelPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPositions)).BeginInit();
            this.panelPositionButtons.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelOrdersTop.SuspendLayout();
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
            this.panelEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmployees.Location = new System.Drawing.Point(0, 0);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Padding = new System.Windows.Forms.Padding(20);
            this.panelEmployees.Size = new System.Drawing.Size(800, 550);
            this.panelEmployees.TabIndex = 0;
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
            this.gridEmployees.Location = new System.Drawing.Point(20, 20);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.ReadOnly = true;
            this.gridEmployees.RowHeadersVisible = false;
            this.gridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployees.Size = new System.Drawing.Size(760, 450);
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
            this.panelPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPositions.Location = new System.Drawing.Point(0, 0);
            this.panelPositions.Name = "panelPositions";
            this.panelPositions.Padding = new System.Windows.Forms.Padding(20);
            this.panelPositions.Size = new System.Drawing.Size(800, 550);
            this.panelPositions.TabIndex = 1;
            this.panelPositions.Visible = false;
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
            this.gridPositions.Location = new System.Drawing.Point(20, 20);
            this.gridPositions.Name = "gridPositions";
            this.gridPositions.ReadOnly = true;
            this.gridPositions.RowHeadersVisible = false;
            this.gridPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPositions.Size = new System.Drawing.Size(760, 450);
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
            this.panelOrders.Controls.Add(this.panelOrdersTop);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Padding = new System.Windows.Forms.Padding(20);
            this.panelOrders.Size = new System.Drawing.Size(800, 550);
            this.panelOrders.TabIndex = 2;
            this.panelOrders.Visible = false;
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
            this.gridOrders.Location = new System.Drawing.Point(20, 70);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.gridOrders.RowHeadersVisible = false;
            this.gridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.Size = new System.Drawing.Size(760, 460);
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
            this.lblOrdersTitle.Text = "📋 Все заказы (только просмотр)";
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
            this.panelPositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPositions)).EndInit();
            this.panelPositionButtons.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.panelOrdersTop.ResumeLayout(false);
            this.panelOrdersTop.PerformLayout();
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

        private System.Windows.Forms.Panel panelPositions;
        private System.Windows.Forms.DataGridView gridPositions;
        private System.Windows.Forms.Panel panelPositionButtons;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Button btnDeletePosition;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Panel panelOrdersTop;
        private System.Windows.Forms.Label lblOrdersTitle;
    }
}

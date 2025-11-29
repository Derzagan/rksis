namespace Kyrsovay
{
    partial class ManagerMainForm
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
            this.btnAssignMaster = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.lblFilterDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.panelAssignMaster = new System.Windows.Forms.Panel();
            this.panelAssignCenter = new System.Windows.Forms.Panel();
            this.lblAssignTitle = new System.Windows.Forms.Label();
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.lblMasterSelect = new System.Windows.Forms.Label();
            this.cmbMasters = new System.Windows.Forms.ComboBox();
            this.btnAssignMasterConfirm = new System.Windows.Forms.Button();
            this.btnBackToOrders = new System.Windows.Forms.Button();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.panelDetailCenter = new System.Windows.Forms.Panel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.lblDetailClient = new System.Windows.Forms.Label();
            this.lblDetailDevice = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.lblDetailPrice = new System.Windows.Forms.Label();
            this.lblCommentTitle = new System.Windows.Forms.Label();
            this.txtDetailComment = new System.Windows.Forms.TextBox();
            this.btnDetailAccept = new System.Windows.Forms.Button();
            this.btnDetailSendToMaster = new System.Windows.Forms.Button();
            this.btnDetailFinish = new System.Windows.Forms.Button();
            this.btnBackFromDetails = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelAssignMaster.SuspendLayout();
            this.panelAssignCenter.SuspendLayout();
            this.panelOrderDetails.SuspendLayout();
            this.panelDetailCenter.SuspendLayout();
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
            this.lblWelcome.Size = new System.Drawing.Size(222, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Панель управления — Менеджер";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnLogout2);
            this.panelMenu.Controls.Add(this.btnAssignMaster);
            this.panelMenu.Controls.Add(this.btnPending);
            this.panelMenu.Controls.Add(this.btnAllOrders);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 550);
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
            this.btnLogout2.Size = new System.Drawing.Size(200, 50);
            this.btnLogout2.TabIndex = 0;
            this.btnLogout2.Text = "⬅ Выход";
            this.btnLogout2.UseVisualStyleBackColor = false;
            // 
            // btnAssignMaster
            // 
            this.btnAssignMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAssignMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignMaster.FlatAppearance.BorderSize = 0;
            this.btnAssignMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignMaster.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAssignMaster.ForeColor = System.Drawing.Color.White;
            this.btnAssignMaster.Location = new System.Drawing.Point(0, 110);
            this.btnAssignMaster.Name = "btnAssignMaster";
            this.btnAssignMaster.Size = new System.Drawing.Size(200, 55);
            this.btnAssignMaster.TabIndex = 1;
            this.btnAssignMaster.Text = "👨‍🔧 Назначить мастера";
            this.btnAssignMaster.UseVisualStyleBackColor = false;
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPending.FlatAppearance.BorderSize = 0;
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPending.ForeColor = System.Drawing.Color.White;
            this.btnPending.Location = new System.Drawing.Point(0, 55);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(200, 55);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "🆕 Новые заявки";
            this.btnPending.UseVisualStyleBackColor = false;
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAllOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllOrders.FlatAppearance.BorderSize = 0;
            this.btnAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAllOrders.ForeColor = System.Drawing.Color.White;
            this.btnAllOrders.Location = new System.Drawing.Point(0, 0);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(200, 55);
            this.btnAllOrders.TabIndex = 3;
            this.btnAllOrders.Text = "📋 Все заявки";
            this.btnAllOrders.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelContent.Controls.Add(this.panelOrders);
            this.panelContent.Controls.Add(this.panelAssignMaster);
            this.panelContent.Controls.Add(this.panelOrderDetails);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(700, 550);
            this.panelContent.TabIndex = 0;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.gridOrders);
            this.panelOrders.Controls.Add(this.panelFilter);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(700, 550);
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
            this.gridOrders.Location = new System.Drawing.Point(0, 120);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.gridOrders.RowHeadersVisible = false;
            this.gridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.Size = new System.Drawing.Size(700, 430);
            this.gridOrders.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.lblFilterTitle);
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
            this.panelFilter.Size = new System.Drawing.Size(700, 120);
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
            // panelAssignMaster
            // 
            this.panelAssignMaster.BackColor = System.Drawing.Color.White;
            this.panelAssignMaster.Controls.Add(this.panelAssignCenter);
            this.panelAssignMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignMaster.Location = new System.Drawing.Point(0, 0);
            this.panelAssignMaster.Name = "panelAssignMaster";
            this.panelAssignMaster.Padding = new System.Windows.Forms.Padding(40);
            this.panelAssignMaster.Size = new System.Drawing.Size(700, 550);
            this.panelAssignMaster.TabIndex = 1;
            this.panelAssignMaster.Visible = false;
            // 
            // panelAssignCenter
            // 
            this.panelAssignCenter.Controls.Add(this.lblAssignTitle);
            this.panelAssignCenter.Controls.Add(this.lblOrderInfo);
            this.panelAssignCenter.Controls.Add(this.lblMasterSelect);
            this.panelAssignCenter.Controls.Add(this.cmbMasters);
            this.panelAssignCenter.Controls.Add(this.btnAssignMasterConfirm);
            this.panelAssignCenter.Controls.Add(this.btnBackToOrders);
            this.panelAssignCenter.Location = new System.Drawing.Point(40, 40);
            this.panelAssignCenter.Name = "panelAssignCenter";
            this.panelAssignCenter.Size = new System.Drawing.Size(500, 350);
            this.panelAssignCenter.TabIndex = 0;
            // 
            // lblAssignTitle
            // 
            this.lblAssignTitle.AutoSize = true;
            this.lblAssignTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAssignTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblAssignTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAssignTitle.Name = "lblAssignTitle";
            this.lblAssignTitle.Size = new System.Drawing.Size(232, 25);
            this.lblAssignTitle.TabIndex = 0;
            this.lblAssignTitle.Text = "👨‍🔧 Назначить мастера";
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.AutoSize = true;
            this.lblOrderInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOrderInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblOrderInfo.Location = new System.Drawing.Point(0, 50);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(134, 20);
            this.lblOrderInfo.TabIndex = 1;
            this.lblOrderInfo.Text = "Выберите заявку";
            // 
            // lblMasterSelect
            // 
            this.lblMasterSelect.AutoSize = true;
            this.lblMasterSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMasterSelect.Location = new System.Drawing.Point(0, 100);
            this.lblMasterSelect.Name = "lblMasterSelect";
            this.lblMasterSelect.Size = new System.Drawing.Size(122, 19);
            this.lblMasterSelect.TabIndex = 2;
            this.lblMasterSelect.Text = "Выберите мастера:";
            // 
            // cmbMasters
            // 
            this.cmbMasters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMasters.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMasters.Location = new System.Drawing.Point(0, 125);
            this.cmbMasters.Name = "cmbMasters";
            this.cmbMasters.Size = new System.Drawing.Size(350, 28);
            this.cmbMasters.TabIndex = 3;
            // 
            // btnAssignMasterConfirm
            // 
            this.btnAssignMasterConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAssignMasterConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignMasterConfirm.FlatAppearance.BorderSize = 0;
            this.btnAssignMasterConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignMasterConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssignMasterConfirm.ForeColor = System.Drawing.Color.White;
            this.btnAssignMasterConfirm.Location = new System.Drawing.Point(0, 180);
            this.btnAssignMasterConfirm.Name = "btnAssignMasterConfirm";
            this.btnAssignMasterConfirm.Size = new System.Drawing.Size(170, 45);
            this.btnAssignMasterConfirm.TabIndex = 4;
            this.btnAssignMasterConfirm.Text = "✓ Назначить";
            this.btnAssignMasterConfirm.UseVisualStyleBackColor = false;
            // 
            // btnBackToOrders
            // 
            this.btnBackToOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBackToOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToOrders.FlatAppearance.BorderSize = 0;
            this.btnBackToOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOrders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackToOrders.ForeColor = System.Drawing.Color.White;
            this.btnBackToOrders.Location = new System.Drawing.Point(180, 180);
            this.btnBackToOrders.Name = "btnBackToOrders";
            this.btnBackToOrders.Size = new System.Drawing.Size(120, 45);
            this.btnBackToOrders.TabIndex = 5;
            this.btnBackToOrders.Text = "← Назад";
            this.btnBackToOrders.UseVisualStyleBackColor = false;
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.BackColor = System.Drawing.Color.White;
            this.panelOrderDetails.Controls.Add(this.panelDetailCenter);
            this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Padding = new System.Windows.Forms.Padding(40);
            this.panelOrderDetails.Size = new System.Drawing.Size(700, 550);
            this.panelOrderDetails.TabIndex = 2;
            this.panelOrderDetails.Visible = false;
            // 
            // panelDetailCenter
            // 
            this.panelDetailCenter.Controls.Add(this.lblDetailTitle);
            this.panelDetailCenter.Controls.Add(this.lblDetailClient);
            this.panelDetailCenter.Controls.Add(this.lblDetailDevice);
            this.panelDetailCenter.Controls.Add(this.lblDetailStatus);
            this.panelDetailCenter.Controls.Add(this.lblDetailPrice);
            this.panelDetailCenter.Controls.Add(this.lblCommentTitle);
            this.panelDetailCenter.Controls.Add(this.txtDetailComment);
            this.panelDetailCenter.Controls.Add(this.btnDetailAccept);
            this.panelDetailCenter.Controls.Add(this.btnDetailSendToMaster);
            this.panelDetailCenter.Controls.Add(this.btnDetailFinish);
            this.panelDetailCenter.Controls.Add(this.btnBackFromDetails);
            this.panelDetailCenter.Location = new System.Drawing.Point(40, 40);
            this.panelDetailCenter.Name = "panelDetailCenter";
            this.panelDetailCenter.Size = new System.Drawing.Size(550, 470);
            this.panelDetailCenter.TabIndex = 0;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDetailTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(158, 25);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "📋 Детали заявки";
            // 
            // lblDetailClient
            // 
            this.lblDetailClient.AutoSize = true;
            this.lblDetailClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailClient.Location = new System.Drawing.Point(0, 50);
            this.lblDetailClient.Name = "lblDetailClient";
            this.lblDetailClient.Size = new System.Drawing.Size(57, 19);
            this.lblDetailClient.TabIndex = 1;
            this.lblDetailClient.Text = "Клиент:";
            // 
            // lblDetailDevice
            // 
            this.lblDetailDevice.AutoSize = true;
            this.lblDetailDevice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailDevice.Location = new System.Drawing.Point(0, 80);
            this.lblDetailDevice.Name = "lblDetailDevice";
            this.lblDetailDevice.Size = new System.Drawing.Size(87, 19);
            this.lblDetailDevice.TabIndex = 2;
            this.lblDetailDevice.Text = "Устройство:";
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.AutoSize = true;
            this.lblDetailStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailStatus.Location = new System.Drawing.Point(0, 110);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(54, 19);
            this.lblDetailStatus.TabIndex = 3;
            this.lblDetailStatus.Text = "Статус:";
            // 
            // lblDetailPrice
            // 
            this.lblDetailPrice.AutoSize = true;
            this.lblDetailPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailPrice.Location = new System.Drawing.Point(0, 140);
            this.lblDetailPrice.Name = "lblDetailPrice";
            this.lblDetailPrice.Size = new System.Drawing.Size(83, 19);
            this.lblDetailPrice.TabIndex = 4;
            this.lblDetailPrice.Text = "Стоимость:";
            // 
            // lblCommentTitle
            // 
            this.lblCommentTitle.AutoSize = true;
            this.lblCommentTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCommentTitle.Location = new System.Drawing.Point(0, 180);
            this.lblCommentTitle.Name = "lblCommentTitle";
            this.lblCommentTitle.Size = new System.Drawing.Size(101, 19);
            this.lblCommentTitle.TabIndex = 5;
            this.lblCommentTitle.Text = "Комментарий:";
            // 
            // txtDetailComment
            // 
            this.txtDetailComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDetailComment.Location = new System.Drawing.Point(0, 205);
            this.txtDetailComment.Multiline = true;
            this.txtDetailComment.Name = "txtDetailComment";
            this.txtDetailComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetailComment.Size = new System.Drawing.Size(400, 100);
            this.txtDetailComment.TabIndex = 6;
            // 
            // btnDetailAccept
            // 
            this.btnDetailAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDetailAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailAccept.FlatAppearance.BorderSize = 0;
            this.btnDetailAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailAccept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetailAccept.ForeColor = System.Drawing.Color.White;
            this.btnDetailAccept.Location = new System.Drawing.Point(0, 330);
            this.btnDetailAccept.Name = "btnDetailAccept";
            this.btnDetailAccept.Size = new System.Drawing.Size(180, 45);
            this.btnDetailAccept.TabIndex = 7;
            this.btnDetailAccept.Text = "✓ Принять";
            this.btnDetailAccept.UseVisualStyleBackColor = false;
            // 
            // btnDetailSendToMaster
            // 
            this.btnDetailSendToMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDetailSendToMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailSendToMaster.FlatAppearance.BorderSize = 0;
            this.btnDetailSendToMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailSendToMaster.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetailSendToMaster.ForeColor = System.Drawing.Color.White;
            this.btnDetailSendToMaster.Location = new System.Drawing.Point(200, 330);
            this.btnDetailSendToMaster.Name = "btnDetailSendToMaster";
            this.btnDetailSendToMaster.Size = new System.Drawing.Size(180, 45);
            this.btnDetailSendToMaster.TabIndex = 8;
            this.btnDetailSendToMaster.Text = "👨‍🔧 К мастеру";
            this.btnDetailSendToMaster.UseVisualStyleBackColor = false;
            // 
            // btnDetailFinish
            // 
            this.btnDetailFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnDetailFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailFinish.FlatAppearance.BorderSize = 0;
            this.btnDetailFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailFinish.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetailFinish.ForeColor = System.Drawing.Color.White;
            this.btnDetailFinish.Location = new System.Drawing.Point(0, 390);
            this.btnDetailFinish.Name = "btnDetailFinish";
            this.btnDetailFinish.Size = new System.Drawing.Size(180, 45);
            this.btnDetailFinish.TabIndex = 9;
            this.btnDetailFinish.Text = "✔ Завершить";
            this.btnDetailFinish.UseVisualStyleBackColor = false;
            // 
            // btnBackFromDetails
            // 
            this.btnBackFromDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBackFromDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackFromDetails.FlatAppearance.BorderSize = 0;
            this.btnBackFromDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackFromDetails.ForeColor = System.Drawing.Color.White;
            this.btnBackFromDetails.Location = new System.Drawing.Point(200, 390);
            this.btnBackFromDetails.Name = "btnBackFromDetails";
            this.btnBackFromDetails.Size = new System.Drawing.Size(120, 45);
            this.btnBackFromDetails.TabIndex = 10;
            this.btnBackFromDetails.Text = "← Назад";
            this.btnBackFromDetails.UseVisualStyleBackColor = false;
            // 
            // ManagerMainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ManagerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервисный центр — Панель менеджера";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelAssignMaster.ResumeLayout(false);
            this.panelAssignCenter.ResumeLayout(false);
            this.panelAssignCenter.PerformLayout();
            this.panelOrderDetails.ResumeLayout(false);
            this.panelDetailCenter.ResumeLayout(false);
            this.panelDetailCenter.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnAssignMaster;
        private System.Windows.Forms.Button btnLogout2;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblFilterDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblFilterDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnResetFilter;

        private System.Windows.Forms.Panel panelAssignMaster;
        private System.Windows.Forms.Panel panelAssignCenter;
        private System.Windows.Forms.Label lblAssignTitle;
        private System.Windows.Forms.Label lblOrderInfo;
        private System.Windows.Forms.Label lblMasterSelect;
        private System.Windows.Forms.ComboBox cmbMasters;
        private System.Windows.Forms.Button btnAssignMasterConfirm;
        private System.Windows.Forms.Button btnBackToOrders;

        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Panel panelDetailCenter;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblDetailClient;
        private System.Windows.Forms.Label lblDetailDevice;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label lblDetailPrice;
        private System.Windows.Forms.Label lblCommentTitle;
        private System.Windows.Forms.TextBox txtDetailComment;
        private System.Windows.Forms.Button btnDetailAccept;
        private System.Windows.Forms.Button btnDetailSendToMaster;
        private System.Windows.Forms.Button btnDetailFinish;
        private System.Windows.Forms.Button btnBackFromDetails;
    }
}
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
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnFilterByDate = new System.Windows.Forms.Button();
            this.btnFilterByStatus = new System.Windows.Forms.Button();
            this.btnFilterByMaster = new System.Windows.Forms.Button();
            this.btnFilterByPrice = new System.Windows.Forms.Button();
            this.btnFilterByName = new System.Windows.Forms.Button();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.panelDetailCenter = new System.Windows.Forms.Panel();
            this.panelMastersList = new System.Windows.Forms.Panel();
            this.lblMastersTitle = new System.Windows.Forms.Label();
            this.listMasters = new System.Windows.Forms.ListBox();
            this.btnConfirmMaster = new System.Windows.Forms.Button();
            this.btnCancelMaster = new System.Windows.Forms.Button();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.lblDetailClient = new System.Windows.Forms.Label();
            this.lblDetailDevice = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.lblDetailPrice = new System.Windows.Forms.Label();
            this.lblDetailMaster = new System.Windows.Forms.Label();
            this.lblCommentTitle = new System.Windows.Forms.Label();
            this.txtDetailComment = new System.Windows.Forms.TextBox();
            this.btnAssignMasterDetail = new System.Windows.Forms.Button();
            this.btnDetailAccept = new System.Windows.Forms.Button();
            this.btnDetailSendToMaster = new System.Windows.Forms.Button();
            this.btnDetailFinish = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnBackFromDetails = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelOrderDetails.SuspendLayout();
            this.panelDetailCenter.SuspendLayout();
            this.panelMastersList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1240, 50);
            this.panelHeader.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(278, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Панель управления — Менеджер";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnLogout2);
            this.panelMenu.Controls.Add(this.btnAllOrders);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 573);
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
            this.btnLogout2.Location = new System.Drawing.Point(0, 523);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(200, 50);
            this.btnLogout2.TabIndex = 0;
            this.btnLogout2.Text = "⬅ Выход";
            this.btnLogout2.UseVisualStyleBackColor = false;
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
            this.panelContent.Controls.Add(this.panelOrderDetails);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1040, 573);
            this.panelContent.TabIndex = 0;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.gridOrders);
            this.panelOrders.Controls.Add(this.panelFilter);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(1040, 573);
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
            this.gridOrders.Location = new System.Drawing.Point(0, 60);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.gridOrders.RowHeadersVisible = false;
            this.gridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.Size = new System.Drawing.Size(1040, 513);
            this.gridOrders.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnResetFilters);
            this.panelFilter.Controls.Add(this.btnFilterByDate);
            this.panelFilter.Controls.Add(this.btnFilterByStatus);
            this.panelFilter.Controls.Add(this.btnFilterByMaster);
            this.panelFilter.Controls.Add(this.btnFilterByPrice);
            this.panelFilter.Controls.Add(this.btnFilterByName);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelFilter.Size = new System.Drawing.Size(1040, 60);
            this.panelFilter.TabIndex = 1;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatAppearance.BorderSize = 0;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(877, 15);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(120, 32);
            this.btnResetFilters.TabIndex = 4;
            this.btnResetFilters.Text = "✕ Сбросить";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // btnFilterByDate
            // 
            this.btnFilterByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterByDate.FlatAppearance.BorderSize = 0;
            this.btnFilterByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterByDate.ForeColor = System.Drawing.Color.White;
            this.btnFilterByDate.Location = new System.Drawing.Point(355, 15);
            this.btnFilterByDate.Name = "btnFilterByDate";
            this.btnFilterByDate.Size = new System.Drawing.Size(160, 32);
            this.btnFilterByDate.TabIndex = 4;
            this.btnFilterByDate.Text = "📅 Фильтр по дате ▼";
            this.btnFilterByDate.UseVisualStyleBackColor = false;
            // 
            // btnFilterByStatus
            // 
            this.btnFilterByStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterByStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterByStatus.FlatAppearance.BorderSize = 0;
            this.btnFilterByStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterByStatus.ForeColor = System.Drawing.Color.White;
            this.btnFilterByStatus.Location = new System.Drawing.Point(711, 15);
            this.btnFilterByStatus.Name = "btnFilterByStatus";
            this.btnFilterByStatus.Size = new System.Drawing.Size(160, 32);
            this.btnFilterByStatus.TabIndex = 3;
            this.btnFilterByStatus.Text = "📊 Фильтр по статусу ▼";
            this.btnFilterByStatus.UseVisualStyleBackColor = false;
            // 
            // btnFilterByMaster
            // 
            this.btnFilterByMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterByMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterByMaster.FlatAppearance.BorderSize = 0;
            this.btnFilterByMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByMaster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterByMaster.ForeColor = System.Drawing.Color.White;
            this.btnFilterByMaster.Location = new System.Drawing.Point(525, 15);
            this.btnFilterByMaster.Name = "btnFilterByMaster";
            this.btnFilterByMaster.Size = new System.Drawing.Size(180, 32);
            this.btnFilterByMaster.TabIndex = 2;
            this.btnFilterByMaster.Text = "👨‍🔧 Фильтр по мастерам ▼";
            this.btnFilterByMaster.UseVisualStyleBackColor = false;
            // 
            // btnFilterByPrice
            // 
            this.btnFilterByPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterByPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterByPrice.FlatAppearance.BorderSize = 0;
            this.btnFilterByPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterByPrice.ForeColor = System.Drawing.Color.White;
            this.btnFilterByPrice.Location = new System.Drawing.Point(185, 15);
            this.btnFilterByPrice.Name = "btnFilterByPrice";
            this.btnFilterByPrice.Size = new System.Drawing.Size(160, 32);
            this.btnFilterByPrice.TabIndex = 1;
            this.btnFilterByPrice.Text = "💰 Фильтр по цене ▼";
            this.btnFilterByPrice.UseVisualStyleBackColor = false;
            // 
            // btnFilterByName
            // 
            this.btnFilterByName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFilterByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterByName.FlatAppearance.BorderSize = 0;
            this.btnFilterByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilterByName.ForeColor = System.Drawing.Color.White;
            this.btnFilterByName.Location = new System.Drawing.Point(15, 15);
            this.btnFilterByName.Name = "btnFilterByName";
            this.btnFilterByName.Size = new System.Drawing.Size(160, 32);
            this.btnFilterByName.TabIndex = 0;
            this.btnFilterByName.Text = "📝 Фильтр по имени ▼";
            this.btnFilterByName.UseVisualStyleBackColor = false;
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.BackColor = System.Drawing.Color.White;
            this.panelOrderDetails.Controls.Add(this.panelDetailCenter);
            this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Padding = new System.Windows.Forms.Padding(40);
            this.panelOrderDetails.Size = new System.Drawing.Size(1040, 573);
            this.panelOrderDetails.TabIndex = 2;
            this.panelOrderDetails.Visible = false;
            // 
            // panelDetailCenter
            // 
            this.panelDetailCenter.Controls.Add(this.panelMastersList);
            this.panelDetailCenter.Controls.Add(this.lblDetailTitle);
            this.panelDetailCenter.Controls.Add(this.lblDetailClient);
            this.panelDetailCenter.Controls.Add(this.lblDetailDevice);
            this.panelDetailCenter.Controls.Add(this.lblDetailStatus);
            this.panelDetailCenter.Controls.Add(this.lblDetailPrice);
            this.panelDetailCenter.Controls.Add(this.lblDetailMaster);
            this.panelDetailCenter.Controls.Add(this.lblCommentTitle);
            this.panelDetailCenter.Controls.Add(this.txtDetailComment);
            this.panelDetailCenter.Controls.Add(this.btnAssignMasterDetail);
            this.panelDetailCenter.Controls.Add(this.btnDetailAccept);
            this.panelDetailCenter.Controls.Add(this.btnDetailSendToMaster);
            this.panelDetailCenter.Controls.Add(this.btnDetailFinish);
            this.panelDetailCenter.Controls.Add(this.btnDeleteOrder);
            this.panelDetailCenter.Controls.Add(this.btnBackFromDetails);
            this.panelDetailCenter.Location = new System.Drawing.Point(40, 40);
            this.panelDetailCenter.Name = "panelDetailCenter";
            this.panelDetailCenter.Size = new System.Drawing.Size(700, 470);
            this.panelDetailCenter.TabIndex = 0;
            // 
            // panelMastersList
            // 
            this.panelMastersList.BackColor = System.Drawing.Color.White;
            this.panelMastersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMastersList.Controls.Add(this.lblMastersTitle);
            this.panelMastersList.Controls.Add(this.listMasters);
            this.panelMastersList.Controls.Add(this.btnConfirmMaster);
            this.panelMastersList.Controls.Add(this.btnCancelMaster);
            this.panelMastersList.Location = new System.Drawing.Point(190, 240);
            this.panelMastersList.Name = "panelMastersList";
            this.panelMastersList.Size = new System.Drawing.Size(300, 220);
            this.panelMastersList.TabIndex = 9;
            this.panelMastersList.Visible = false;
            // 
            // lblMastersTitle
            // 
            this.lblMastersTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblMastersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMastersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMastersTitle.ForeColor = System.Drawing.Color.White;
            this.lblMastersTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMastersTitle.Name = "lblMastersTitle";
            this.lblMastersTitle.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblMastersTitle.Size = new System.Drawing.Size(298, 35);
            this.lblMastersTitle.TabIndex = 0;
            this.lblMastersTitle.Text = "Выберите мастера:";
            // 
            // listMasters
            // 
            this.listMasters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listMasters.FormattingEnabled = true;
            this.listMasters.ItemHeight = 15;
            this.listMasters.Location = new System.Drawing.Point(10, 45);
            this.listMasters.Name = "listMasters";
            this.listMasters.Size = new System.Drawing.Size(278, 124);
            this.listMasters.TabIndex = 1;
            // 
            // btnConfirmMaster
            // 
            this.btnConfirmMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmMaster.FlatAppearance.BorderSize = 0;
            this.btnConfirmMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmMaster.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirmMaster.ForeColor = System.Drawing.Color.White;
            this.btnConfirmMaster.Location = new System.Drawing.Point(10, 178);
            this.btnConfirmMaster.Name = "btnConfirmMaster";
            this.btnConfirmMaster.Size = new System.Drawing.Size(135, 30);
            this.btnConfirmMaster.TabIndex = 2;
            this.btnConfirmMaster.Text = "✓ Назначить";
            this.btnConfirmMaster.UseVisualStyleBackColor = false;
            // 
            // btnCancelMaster
            // 
            this.btnCancelMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnCancelMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelMaster.FlatAppearance.BorderSize = 0;
            this.btnCancelMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMaster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelMaster.ForeColor = System.Drawing.Color.White;
            this.btnCancelMaster.Location = new System.Drawing.Point(153, 178);
            this.btnCancelMaster.Name = "btnCancelMaster";
            this.btnCancelMaster.Size = new System.Drawing.Size(135, 30);
            this.btnCancelMaster.TabIndex = 3;
            this.btnCancelMaster.Text = "✕ Отмена";
            this.btnCancelMaster.UseVisualStyleBackColor = false;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDetailTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(171, 25);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "📋 Детали заявки";
            // 
            // lblDetailClient
            // 
            this.lblDetailClient.AutoSize = true;
            this.lblDetailClient.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailClient.Location = new System.Drawing.Point(0, 50);
            this.lblDetailClient.Name = "lblDetailClient";
            this.lblDetailClient.Size = new System.Drawing.Size(56, 19);
            this.lblDetailClient.TabIndex = 1;
            this.lblDetailClient.Text = "Клиент:";
            // 
            // lblDetailDevice
            // 
            this.lblDetailDevice.AutoSize = true;
            this.lblDetailDevice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailDevice.Location = new System.Drawing.Point(0, 75);
            this.lblDetailDevice.Name = "lblDetailDevice";
            this.lblDetailDevice.Size = new System.Drawing.Size(83, 19);
            this.lblDetailDevice.TabIndex = 2;
            this.lblDetailDevice.Text = "Устройство:";
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.AutoSize = true;
            this.lblDetailStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailStatus.Location = new System.Drawing.Point(0, 100);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(53, 19);
            this.lblDetailStatus.TabIndex = 3;
            this.lblDetailStatus.Text = "Статус:";
            // 
            // lblDetailPrice
            // 
            this.lblDetailPrice.AutoSize = true;
            this.lblDetailPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailPrice.Location = new System.Drawing.Point(0, 125);
            this.lblDetailPrice.Name = "lblDetailPrice";
            this.lblDetailPrice.Size = new System.Drawing.Size(80, 19);
            this.lblDetailPrice.TabIndex = 4;
            this.lblDetailPrice.Text = "Стоимость:";
            // 
            // lblDetailMaster
            // 
            this.lblDetailMaster.AutoSize = true;
            this.lblDetailMaster.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailMaster.Location = new System.Drawing.Point(0, 150);
            this.lblDetailMaster.Name = "lblDetailMaster";
            this.lblDetailMaster.Size = new System.Drawing.Size(59, 19);
            this.lblDetailMaster.TabIndex = 5;
            this.lblDetailMaster.Text = "Мастер:";
            // 
            // lblCommentTitle
            // 
            this.lblCommentTitle.AutoSize = true;
            this.lblCommentTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCommentTitle.Location = new System.Drawing.Point(0, 185);
            this.lblCommentTitle.Name = "lblCommentTitle";
            this.lblCommentTitle.Size = new System.Drawing.Size(100, 19);
            this.lblCommentTitle.TabIndex = 6;
            this.lblCommentTitle.Text = "Комментарий:";
            // 
            // txtDetailComment
            // 
            this.txtDetailComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDetailComment.Location = new System.Drawing.Point(0, 210);
            this.txtDetailComment.Multiline = true;
            this.txtDetailComment.Name = "txtDetailComment";
            this.txtDetailComment.ReadOnly = true;
            this.txtDetailComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetailComment.Size = new System.Drawing.Size(450, 70);
            this.txtDetailComment.TabIndex = 7;
            // 
            // btnAssignMasterDetail
            // 
            this.btnAssignMasterDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAssignMasterDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignMasterDetail.FlatAppearance.BorderSize = 0;
            this.btnAssignMasterDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignMasterDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssignMasterDetail.ForeColor = System.Drawing.Color.White;
            this.btnAssignMasterDetail.Location = new System.Drawing.Point(0, 295);
            this.btnAssignMasterDetail.Name = "btnAssignMasterDetail";
            this.btnAssignMasterDetail.Size = new System.Drawing.Size(180, 40);
            this.btnAssignMasterDetail.TabIndex = 8;
            this.btnAssignMasterDetail.Text = "👨‍🔧 Мастера";
            this.btnAssignMasterDetail.UseVisualStyleBackColor = false;
            // 
            // btnDetailAccept
            // 
            this.btnDetailAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDetailAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailAccept.FlatAppearance.BorderSize = 0;
            this.btnDetailAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailAccept.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetailAccept.ForeColor = System.Drawing.Color.White;
            this.btnDetailAccept.Location = new System.Drawing.Point(0, 350);
            this.btnDetailAccept.Name = "btnDetailAccept";
            this.btnDetailAccept.Size = new System.Drawing.Size(150, 40);
            this.btnDetailAccept.TabIndex = 10;
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
            this.btnDetailSendToMaster.Location = new System.Drawing.Point(160, 350);
            this.btnDetailSendToMaster.Name = "btnDetailSendToMaster";
            this.btnDetailSendToMaster.Size = new System.Drawing.Size(150, 40);
            this.btnDetailSendToMaster.TabIndex = 11;
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
            this.btnDetailFinish.Location = new System.Drawing.Point(320, 350);
            this.btnDetailFinish.Name = "btnDetailFinish";
            this.btnDetailFinish.Size = new System.Drawing.Size(130, 40);
            this.btnDetailFinish.TabIndex = 12;
            this.btnDetailFinish.Text = "✔ Завершить";
            this.btnDetailFinish.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Location = new System.Drawing.Point(0, 405);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteOrder.TabIndex = 13;
            this.btnDeleteOrder.Text = "🗑 Удалить заказ";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // btnBackFromDetails
            // 
            this.btnBackFromDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBackFromDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackFromDetails.FlatAppearance.BorderSize = 0;
            this.btnBackFromDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackFromDetails.ForeColor = System.Drawing.Color.White;
            this.btnBackFromDetails.Location = new System.Drawing.Point(160, 405);
            this.btnBackFromDetails.Name = "btnBackFromDetails";
            this.btnBackFromDetails.Size = new System.Drawing.Size(120, 40);
            this.btnBackFromDetails.TabIndex = 14;
            this.btnBackFromDetails.Text = "← Назад";
            this.btnBackFromDetails.UseVisualStyleBackColor = false;
            // 
            // ManagerMainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1240, 623);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(900, 600);
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
            this.panelOrderDetails.ResumeLayout(false);
            this.panelDetailCenter.ResumeLayout(false);
            this.panelDetailCenter.PerformLayout();
            this.panelMastersList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnLogout2;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnFilterByName;
        private System.Windows.Forms.Button btnFilterByPrice;
        private System.Windows.Forms.Button btnFilterByMaster;
        private System.Windows.Forms.Button btnFilterByStatus;
        private System.Windows.Forms.Button btnFilterByDate;
        private System.Windows.Forms.Button btnResetFilters;

        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Panel panelDetailCenter;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblDetailClient;
        private System.Windows.Forms.Label lblDetailDevice;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label lblDetailPrice;
        private System.Windows.Forms.Label lblDetailMaster;
        private System.Windows.Forms.Label lblCommentTitle;
        private System.Windows.Forms.TextBox txtDetailComment;
        private System.Windows.Forms.Button btnAssignMasterDetail;
        private System.Windows.Forms.Panel panelMastersList;
        private System.Windows.Forms.Label lblMastersTitle;
        private System.Windows.Forms.ListBox listMasters;
        private System.Windows.Forms.Button btnConfirmMaster;
        private System.Windows.Forms.Button btnCancelMaster;
        private System.Windows.Forms.Button btnDetailAccept;
        private System.Windows.Forms.Button btnDetailSendToMaster;
        private System.Windows.Forms.Button btnDetailFinish;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnBackFromDetails;
    }
}

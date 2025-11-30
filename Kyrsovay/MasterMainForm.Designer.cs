namespace Kyrsovay
{
    partial class MasterMainForm
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
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnFilterByName = new System.Windows.Forms.Button();
            this.btnFilterByPrice = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.panelDetailCenter = new System.Windows.Forms.Panel();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.lblDetailClient = new System.Windows.Forms.Label();
            this.lblDetailDevice = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.lblDetailPrice = new System.Windows.Forms.Label();
            this.lblCommentTitle = new System.Windows.Forms.Label();
            this.txtDetailComment = new System.Windows.Forms.TextBox();
            this.lblWorkCommentTitle = new System.Windows.Forms.Label();
            this.txtWorkComment = new System.Windows.Forms.TextBox();
            this.lblFinalPriceTitle = new System.Windows.Forms.Label();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.btnNeedParts = new System.Windows.Forms.Button();
            this.btnFinishRepair = new System.Windows.Forms.Button();
            this.btnBackFromDetails = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelFilter.SuspendLayout();
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
            this.lblWelcome.Size = new System.Drawing.Size(200, 21);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Панель мастера";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnLogout2);
            this.panelMenu.Controls.Add(this.btnMyOrders);
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
            this.btnMyOrders.Size = new System.Drawing.Size(200, 55);
            this.btnMyOrders.TabIndex = 1;
            this.btnMyOrders.Text = "🔧 Мои заявки";
            this.btnMyOrders.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.panelContent.Controls.Add(this.panelOrders);
            this.panelContent.Controls.Add(this.panelOrderDetails);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 550);
            this.panelContent.TabIndex = 2;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.gridOrders);
            this.panelOrders.Controls.Add(this.panelFilter);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(800, 550);
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
            this.gridOrders.Size = new System.Drawing.Size(800, 490);
            this.gridOrders.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.White;
            this.panelFilter.Controls.Add(this.btnFilterByName);
            this.panelFilter.Controls.Add(this.btnFilterByPrice);
            this.panelFilter.Controls.Add(this.btnResetFilters);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(10);
            this.panelFilter.Size = new System.Drawing.Size(800, 60);
            this.panelFilter.TabIndex = 1;
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
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFilters.FlatAppearance.BorderSize = 0;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetFilters.ForeColor = System.Drawing.Color.White;
            this.btnResetFilters.Location = new System.Drawing.Point(355, 15);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(120, 32);
            this.btnResetFilters.TabIndex = 2;
            this.btnResetFilters.Text = "✕ Сбросить";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.BackColor = System.Drawing.Color.White;
            this.panelOrderDetails.Controls.Add(this.panelDetailCenter);
            this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Padding = new System.Windows.Forms.Padding(40);
            this.panelOrderDetails.Size = new System.Drawing.Size(800, 550);
            this.panelOrderDetails.TabIndex = 1;
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
            this.panelDetailCenter.Controls.Add(this.lblWorkCommentTitle);
            this.panelDetailCenter.Controls.Add(this.txtWorkComment);
            this.panelDetailCenter.Controls.Add(this.lblFinalPriceTitle);
            this.panelDetailCenter.Controls.Add(this.txtFinalPrice);
            this.panelDetailCenter.Controls.Add(this.btnStartWork);
            this.panelDetailCenter.Controls.Add(this.btnNeedParts);
            this.panelDetailCenter.Controls.Add(this.btnFinishRepair);
            this.panelDetailCenter.Controls.Add(this.btnBackFromDetails);
            this.panelDetailCenter.Location = new System.Drawing.Point(40, 20);
            this.panelDetailCenter.Name = "panelDetailCenter";
            this.panelDetailCenter.Size = new System.Drawing.Size(700, 510);
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
            this.lblDetailTitle.Text = "🔧 Детали заявки";
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
            this.lblDetailDevice.Location = new System.Drawing.Point(0, 75);
            this.lblDetailDevice.Name = "lblDetailDevice";
            this.lblDetailDevice.Size = new System.Drawing.Size(87, 19);
            this.lblDetailDevice.TabIndex = 2;
            this.lblDetailDevice.Text = "Устройство:";
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.AutoSize = true;
            this.lblDetailStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailStatus.Location = new System.Drawing.Point(0, 100);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(54, 19);
            this.lblDetailStatus.TabIndex = 3;
            this.lblDetailStatus.Text = "Статус:";
            // 
            // lblDetailPrice
            // 
            this.lblDetailPrice.AutoSize = true;
            this.lblDetailPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailPrice.Location = new System.Drawing.Point(0, 125);
            this.lblDetailPrice.Name = "lblDetailPrice";
            this.lblDetailPrice.Size = new System.Drawing.Size(83, 19);
            this.lblDetailPrice.TabIndex = 4;
            this.lblDetailPrice.Text = "Стоимость:";
            // 
            // lblCommentTitle
            // 
            this.lblCommentTitle.AutoSize = true;
            this.lblCommentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCommentTitle.Location = new System.Drawing.Point(0, 160);
            this.lblCommentTitle.Name = "lblCommentTitle";
            this.lblCommentTitle.Size = new System.Drawing.Size(167, 19);
            this.lblCommentTitle.TabIndex = 5;
            this.lblCommentTitle.Text = "Описание от клиента:";
            // 
            // txtDetailComment
            // 
            this.txtDetailComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDetailComment.Location = new System.Drawing.Point(0, 185);
            this.txtDetailComment.Multiline = true;
            this.txtDetailComment.Name = "txtDetailComment";
            this.txtDetailComment.ReadOnly = true;
            this.txtDetailComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetailComment.Size = new System.Drawing.Size(500, 60);
            this.txtDetailComment.TabIndex = 6;
            // 
            // lblWorkCommentTitle
            // 
            this.lblWorkCommentTitle.AutoSize = true;
            this.lblWorkCommentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWorkCommentTitle.Location = new System.Drawing.Point(0, 260);
            this.lblWorkCommentTitle.Name = "lblWorkCommentTitle";
            this.lblWorkCommentTitle.Size = new System.Drawing.Size(180, 19);
            this.lblWorkCommentTitle.TabIndex = 7;
            this.lblWorkCommentTitle.Text = "Комментарий по работе:";
            // 
            // txtWorkComment
            // 
            this.txtWorkComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtWorkComment.Location = new System.Drawing.Point(0, 285);
            this.txtWorkComment.Multiline = true;
            this.txtWorkComment.Name = "txtWorkComment";
            this.txtWorkComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWorkComment.Size = new System.Drawing.Size(500, 70);
            this.txtWorkComment.TabIndex = 8;
            // 
            // lblFinalPriceTitle
            // 
            this.lblFinalPriceTitle.AutoSize = true;
            this.lblFinalPriceTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFinalPriceTitle.Location = new System.Drawing.Point(0, 370);
            this.lblFinalPriceTitle.Name = "lblFinalPriceTitle";
            this.lblFinalPriceTitle.Size = new System.Drawing.Size(171, 19);
            this.lblFinalPriceTitle.TabIndex = 9;
            this.lblFinalPriceTitle.Text = "Итоговая стоимость (₸):";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtFinalPrice.Location = new System.Drawing.Point(0, 395);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Size = new System.Drawing.Size(200, 27);
            this.txtFinalPrice.TabIndex = 10;
            // 
            // btnStartWork
            // 
            this.btnStartWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnStartWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartWork.FlatAppearance.BorderSize = 0;
            this.btnStartWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartWork.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartWork.ForeColor = System.Drawing.Color.White;
            this.btnStartWork.Location = new System.Drawing.Point(0, 445);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(160, 40);
            this.btnStartWork.TabIndex = 11;
            this.btnStartWork.Text = "▶ Начать работу";
            this.btnStartWork.UseVisualStyleBackColor = false;
            // 
            // btnNeedParts
            // 
            this.btnNeedParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnNeedParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNeedParts.FlatAppearance.BorderSize = 0;
            this.btnNeedParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeedParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNeedParts.ForeColor = System.Drawing.Color.White;
            this.btnNeedParts.Location = new System.Drawing.Point(170, 445);
            this.btnNeedParts.Name = "btnNeedParts";
            this.btnNeedParts.Size = new System.Drawing.Size(180, 40);
            this.btnNeedParts.TabIndex = 12;
            this.btnNeedParts.Text = "⏸ Ожидание запчастей";
            this.btnNeedParts.UseVisualStyleBackColor = false;
            // 
            // btnFinishRepair
            // 
            this.btnFinishRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFinishRepair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinishRepair.FlatAppearance.BorderSize = 0;
            this.btnFinishRepair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishRepair.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFinishRepair.ForeColor = System.Drawing.Color.White;
            this.btnFinishRepair.Location = new System.Drawing.Point(360, 445);
            this.btnFinishRepair.Name = "btnFinishRepair";
            this.btnFinishRepair.Size = new System.Drawing.Size(160, 40);
            this.btnFinishRepair.TabIndex = 13;
            this.btnFinishRepair.Text = "✔ Завершить ремонт";
            this.btnFinishRepair.UseVisualStyleBackColor = false;
            // 
            // btnBackFromDetails
            // 
            this.btnBackFromDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBackFromDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackFromDetails.FlatAppearance.BorderSize = 0;
            this.btnBackFromDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFromDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBackFromDetails.ForeColor = System.Drawing.Color.White;
            this.btnBackFromDetails.Location = new System.Drawing.Point(530, 445);
            this.btnBackFromDetails.Name = "btnBackFromDetails";
            this.btnBackFromDetails.Size = new System.Drawing.Size(120, 40);
            this.btnBackFromDetails.TabIndex = 14;
            this.btnBackFromDetails.Text = "← Назад";
            this.btnBackFromDetails.UseVisualStyleBackColor = false;
            // 
            // MasterMainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MasterMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервисный центр — Панель мастера";
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
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnLogout2;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnFilterByName;
        private System.Windows.Forms.Button btnFilterByPrice;
        private System.Windows.Forms.Button btnResetFilters;

        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Panel panelDetailCenter;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label lblDetailClient;
        private System.Windows.Forms.Label lblDetailDevice;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label lblDetailPrice;
        private System.Windows.Forms.Label lblCommentTitle;
        private System.Windows.Forms.TextBox txtDetailComment;
        private System.Windows.Forms.Label lblWorkCommentTitle;
        private System.Windows.Forms.TextBox txtWorkComment;
        private System.Windows.Forms.Label lblFinalPriceTitle;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Button btnStartWork;
        private System.Windows.Forms.Button btnNeedParts;
        private System.Windows.Forms.Button btnFinishRepair;
        private System.Windows.Forms.Button btnBackFromDetails;
    }
}

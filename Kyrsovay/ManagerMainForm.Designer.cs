namespace Kyrsovay
{
    partial class ManagerMainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Верхняя панель
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;

        // Левое меню
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnAssignMaster;
        private System.Windows.Forms.Button btnLogout2;

        // Контентная часть
        private System.Windows.Forms.Panel panelContent;

        // Панель 1 — ВСЕ ЗАЯВКИ
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelOrdersCenter;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Button btnOpenOrder;

        // Панель 2 — НАЗНАЧЕНИЕ МАСТЕРА
        private System.Windows.Forms.Panel panelAssignMaster;
        private System.Windows.Forms.Panel panelAssignCenter;
        private System.Windows.Forms.Label lblOrderInfo;
        private System.Windows.Forms.ComboBox cmbMasters;
        private System.Windows.Forms.Button btnAssignMasterConfirm;

        // Панель 3 — ДЕТАЛИ ЗАКАЗА
        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Panel panelDetailCenter;
        private System.Windows.Forms.Label lblDetailClient;
        private System.Windows.Forms.Label lblDetailDevice;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.TextBox txtDetailComment;
        private System.Windows.Forms.Button btnDetailAccept;
        private System.Windows.Forms.Button btnDetailSendToMaster;
        private System.Windows.Forms.Button btnDetailFinish;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAssignMaster = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panelOrdersCenter = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.btnOpenOrder = new System.Windows.Forms.Button();
            this.panelAssignMaster = new System.Windows.Forms.Panel();
            this.panelAssignCenter = new System.Windows.Forms.Panel();
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.cmbMasters = new System.Windows.Forms.ComboBox();
            this.btnAssignMasterConfirm = new System.Windows.Forms.Button();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.panelDetailCenter = new System.Windows.Forms.Panel();
            this.lblDetailClient = new System.Windows.Forms.Label();
            this.lblDetailDevice = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.txtDetailComment = new System.Windows.Forms.TextBox();
            this.btnDetailAccept = new System.Windows.Forms.Button();
            this.btnDetailSendToMaster = new System.Windows.Forms.Button();
            this.btnDetailFinish = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.panelOrdersCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelAssignMaster.SuspendLayout();
            this.panelAssignCenter.SuspendLayout();
            this.panelOrderDetails.SuspendLayout();
            this.panelDetailCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
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
            this.lblWelcome.Size = new System.Drawing.Size(62, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Приёмщик";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnAssignMaster);
            this.panelMenu.Controls.Add(this.btnPending);
            this.panelMenu.Controls.Add(this.btnAllOrders);
            this.panelMenu.Controls.Add(this.btnLogout2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 550);
            this.panelMenu.TabIndex = 1;
            // 
            // btnAssignMaster
            // 
            this.btnAssignMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAssignMaster.FlatAppearance.BorderSize = 0;
            this.btnAssignMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignMaster.ForeColor = System.Drawing.Color.White;
            this.btnAssignMaster.Location = new System.Drawing.Point(0, 120);
            this.btnAssignMaster.Name = "btnAssignMaster";
            this.btnAssignMaster.Size = new System.Drawing.Size(180, 60);
            this.btnAssignMaster.TabIndex = 0;
            this.btnAssignMaster.Text = "Назначить мастера";
            // 
            // btnPending
            // 
            this.btnPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPending.FlatAppearance.BorderSize = 0;
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.ForeColor = System.Drawing.Color.White;
            this.btnPending.Location = new System.Drawing.Point(0, 60);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(180, 60);
            this.btnPending.TabIndex = 1;
            this.btnPending.Text = "Новые заявки";
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllOrders.FlatAppearance.BorderSize = 0;
            this.btnAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOrders.ForeColor = System.Drawing.Color.White;
            this.btnAllOrders.Location = new System.Drawing.Point(0, 0);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(180, 60);
            this.btnAllOrders.TabIndex = 2;
            this.btnAllOrders.Text = "Все заявки";
            // 
            // btnLogout2
            // 
            this.btnLogout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout2.FlatAppearance.BorderSize = 0;
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.ForeColor = System.Drawing.Color.White;
            this.btnLogout2.Location = new System.Drawing.Point(0, 490);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(180, 60);
            this.btnLogout2.TabIndex = 3;
            this.btnLogout2.Text = "Выход";
            this.btnLogout2.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelOrders);
            this.panelContent.Controls.Add(this.panelAssignMaster);
            this.panelContent.Controls.Add(this.panelOrderDetails);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(180, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(620, 550);
            this.panelContent.TabIndex = 0;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.panelOrdersCenter);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(620, 550);
            this.panelOrders.TabIndex = 0;
            // 
            // panelOrdersCenter
            // 
            this.panelOrdersCenter.Controls.Add(this.gridOrders);
            this.panelOrdersCenter.Controls.Add(this.btnOpenOrder);
            this.panelOrdersCenter.Location = new System.Drawing.Point(0, 0);
            this.panelOrdersCenter.Name = "panelOrdersCenter";
            this.panelOrdersCenter.Size = new System.Drawing.Size(500, 400);
            this.panelOrdersCenter.TabIndex = 0;
            // 
            // gridOrders
            // 
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridOrders.Location = new System.Drawing.Point(0, 0);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(500, 300);
            this.gridOrders.TabIndex = 0;
            // 
            // btnOpenOrder
            // 
            this.btnOpenOrder.Location = new System.Drawing.Point(150, 320);
            this.btnOpenOrder.Name = "btnOpenOrder";
            this.btnOpenOrder.Size = new System.Drawing.Size(200, 40);
            this.btnOpenOrder.TabIndex = 1;
            this.btnOpenOrder.Text = "Открыть";
            // 
            // panelAssignMaster
            // 
            this.panelAssignMaster.Controls.Add(this.panelAssignCenter);
            this.panelAssignMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignMaster.Location = new System.Drawing.Point(0, 0);
            this.panelAssignMaster.Name = "panelAssignMaster";
            this.panelAssignMaster.Size = new System.Drawing.Size(620, 550);
            this.panelAssignMaster.TabIndex = 1;
            this.panelAssignMaster.Visible = false;
            // 
            // panelAssignCenter
            // 
            this.panelAssignCenter.Controls.Add(this.lblOrderInfo);
            this.panelAssignCenter.Controls.Add(this.cmbMasters);
            this.panelAssignCenter.Controls.Add(this.btnAssignMasterConfirm);
            this.panelAssignCenter.Location = new System.Drawing.Point(0, 0);
            this.panelAssignCenter.Name = "panelAssignCenter";
            this.panelAssignCenter.Size = new System.Drawing.Size(400, 250);
            this.panelAssignCenter.TabIndex = 0;
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.Location = new System.Drawing.Point(20, 20);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(100, 23);
            this.lblOrderInfo.TabIndex = 0;
            this.lblOrderInfo.Text = "Выберите заявку";
            // 
            // cmbMasters
            // 
            this.cmbMasters.Location = new System.Drawing.Point(20, 60);
            this.cmbMasters.Name = "cmbMasters";
            this.cmbMasters.Size = new System.Drawing.Size(300, 21);
            this.cmbMasters.TabIndex = 1;
            // 
            // btnAssignMasterConfirm
            // 
            this.btnAssignMasterConfirm.Location = new System.Drawing.Point(20, 120);
            this.btnAssignMasterConfirm.Name = "btnAssignMasterConfirm";
            this.btnAssignMasterConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnAssignMasterConfirm.TabIndex = 2;
            this.btnAssignMasterConfirm.Text = "Назначить";
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.Controls.Add(this.panelDetailCenter);
            this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Size = new System.Drawing.Size(620, 550);
            this.panelOrderDetails.TabIndex = 2;
            this.panelOrderDetails.Visible = false;
            // 
            // panelDetailCenter
            // 
            this.panelDetailCenter.Controls.Add(this.lblDetailClient);
            this.panelDetailCenter.Controls.Add(this.lblDetailDevice);
            this.panelDetailCenter.Controls.Add(this.lblDetailStatus);
            this.panelDetailCenter.Controls.Add(this.txtDetailComment);
            this.panelDetailCenter.Controls.Add(this.btnDetailAccept);
            this.panelDetailCenter.Controls.Add(this.btnDetailSendToMaster);
            this.panelDetailCenter.Controls.Add(this.btnDetailFinish);
            this.panelDetailCenter.Location = new System.Drawing.Point(0, 0);
            this.panelDetailCenter.Name = "panelDetailCenter";
            this.panelDetailCenter.Size = new System.Drawing.Size(450, 450);
            this.panelDetailCenter.TabIndex = 0;
            // 
            // lblDetailClient
            // 
            this.lblDetailClient.Location = new System.Drawing.Point(20, 20);
            this.lblDetailClient.Name = "lblDetailClient";
            this.lblDetailClient.Size = new System.Drawing.Size(100, 23);
            this.lblDetailClient.TabIndex = 0;
            this.lblDetailClient.Text = "Клиент:";
            // 
            // lblDetailDevice
            // 
            this.lblDetailDevice.Location = new System.Drawing.Point(20, 50);
            this.lblDetailDevice.Name = "lblDetailDevice";
            this.lblDetailDevice.Size = new System.Drawing.Size(100, 23);
            this.lblDetailDevice.TabIndex = 1;
            this.lblDetailDevice.Text = "Устройство:";
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.Location = new System.Drawing.Point(20, 80);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(100, 23);
            this.lblDetailStatus.TabIndex = 2;
            this.lblDetailStatus.Text = "Статус:";
            // 
            // txtDetailComment
            // 
            this.txtDetailComment.Location = new System.Drawing.Point(20, 120);
            this.txtDetailComment.Multiline = true;
            this.txtDetailComment.Name = "txtDetailComment";
            this.txtDetailComment.Size = new System.Drawing.Size(350, 100);
            this.txtDetailComment.TabIndex = 3;
            // 
            // btnDetailAccept
            // 
            this.btnDetailAccept.Location = new System.Drawing.Point(20, 230);
            this.btnDetailAccept.Name = "btnDetailAccept";
            this.btnDetailAccept.Size = new System.Drawing.Size(150, 40);
            this.btnDetailAccept.TabIndex = 4;
            this.btnDetailAccept.Text = "Принять";
            // 
            // btnDetailSendToMaster
            // 
            this.btnDetailSendToMaster.Location = new System.Drawing.Point(20, 280);
            this.btnDetailSendToMaster.Name = "btnDetailSendToMaster";
            this.btnDetailSendToMaster.Size = new System.Drawing.Size(150, 40);
            this.btnDetailSendToMaster.TabIndex = 5;
            this.btnDetailSendToMaster.Text = "К мастеру";
            // 
            // btnDetailFinish
            // 
            this.btnDetailFinish.Location = new System.Drawing.Point(20, 330);
            this.btnDetailFinish.Name = "btnDetailFinish";
            this.btnDetailFinish.Size = new System.Drawing.Size(150, 40);
            this.btnDetailFinish.TabIndex = 6;
            this.btnDetailFinish.Text = "Завершить";
            // 
            // ManagerMainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "ManagerMainForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            this.panelOrdersCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.panelAssignMaster.ResumeLayout(false);
            this.panelAssignCenter.ResumeLayout(false);
            this.panelOrderDetails.ResumeLayout(false);
            this.panelDetailCenter.ResumeLayout(false);
            this.panelDetailCenter.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}

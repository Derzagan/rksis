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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panelOrdersCenter = new System.Windows.Forms.Panel();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.btnOpenOrder = new System.Windows.Forms.Button();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.panelDetailCenter = new System.Windows.Forms.Panel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblDeviceInfo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtWorkComment = new System.Windows.Forms.TextBox();
            this.lblRepairPrice = new System.Windows.Forms.Label();
            this.txtRepairPrice = new System.Windows.Forms.TextBox();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.btnNeedParts = new System.Windows.Forms.Button();
            this.btnFinishRepair = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelOrders.SuspendLayout();
            this.panelOrdersCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.panelOrderDetails.SuspendLayout();
            this.panelDetailCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1409, 50);
            this.panelHeader.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(45, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Мастер";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(680, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Назад";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnInProgress);
            this.panelMenu.Controls.Add(this.btnMyOrders);
            this.panelMenu.Controls.Add(this.btnLogout2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 799);
            this.panelMenu.TabIndex = 1;
            // 
            // btnInProgress
            // 
            this.btnInProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInProgress.FlatAppearance.BorderSize = 0;
            this.btnInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInProgress.ForeColor = System.Drawing.Color.White;
            this.btnInProgress.Location = new System.Drawing.Point(0, 0);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(75, 60);
            this.btnInProgress.TabIndex = 0;
            this.btnInProgress.Text = "В работе";
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.ForeColor = System.Drawing.Color.White;
            this.btnMyOrders.Location = new System.Drawing.Point(0, 0);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(75, 60);
            this.btnMyOrders.TabIndex = 1;
            this.btnMyOrders.Text = "Мои заявки";
            // 
            // btnLogout2
            // 
            this.btnLogout2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout2.FlatAppearance.BorderSize = 0;
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.ForeColor = System.Drawing.Color.White;
            this.btnLogout2.Location = new System.Drawing.Point(0, 0);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(75, 60);
            this.btnLogout2.TabIndex = 2;
            this.btnLogout2.Text = "Выход";
            this.btnLogout2.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.gridOrders);
            this.panelContent.Controls.Add(this.panelOrders);
            this.panelContent.Controls.Add(this.panelOrderDetails);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(180, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1229, 799);
            this.panelContent.TabIndex = 0;
            // 
            // panelOrders
            // 
            this.panelOrders.Controls.Add(this.panelOrdersCenter);
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 0);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(200, 100);
            this.panelOrders.TabIndex = 0;
            this.panelOrders.Visible = false;
            // 
            // panelOrdersCenter
            // 
            this.panelOrdersCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelOrdersCenter.Controls.Add(this.btnOpenOrder);
            this.panelOrdersCenter.Location = new System.Drawing.Point(0, 0);
            this.panelOrdersCenter.Name = "panelOrdersCenter";
            this.panelOrdersCenter.Size = new System.Drawing.Size(700, 450);
            this.panelOrdersCenter.TabIndex = 0;
            // 
            // gridOrders
            // 
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrders.Location = new System.Drawing.Point(0, 0);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(1226, 132);
            this.gridOrders.TabIndex = 0;
            // 
            // btnOpenOrder
            // 
            this.btnOpenOrder.Location = new System.Drawing.Point(250, 390);
            this.btnOpenOrder.Name = "btnOpenOrder";
            this.btnOpenOrder.Size = new System.Drawing.Size(200, 40);
            this.btnOpenOrder.TabIndex = 1;
            this.btnOpenOrder.Text = "Открыть";
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.Controls.Add(this.panelDetailCenter);
            this.panelOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Size = new System.Drawing.Size(200, 100);
            this.panelOrderDetails.TabIndex = 1;
            this.panelOrderDetails.Visible = false;
            // 
            // panelDetailCenter
            // 
            this.panelDetailCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDetailCenter.Controls.Add(this.lblClientName);
            this.panelDetailCenter.Controls.Add(this.lblDeviceInfo);
            this.panelDetailCenter.Controls.Add(this.lblStatus);
            this.panelDetailCenter.Controls.Add(this.txtWorkComment);
            this.panelDetailCenter.Controls.Add(this.lblRepairPrice);
            this.panelDetailCenter.Controls.Add(this.txtRepairPrice);
            this.panelDetailCenter.Controls.Add(this.btnStartWork);
            this.panelDetailCenter.Controls.Add(this.btnNeedParts);
            this.panelDetailCenter.Controls.Add(this.btnFinishRepair);
            this.panelDetailCenter.Location = new System.Drawing.Point(0, 0);
            this.panelDetailCenter.Name = "panelDetailCenter";
            this.panelDetailCenter.Size = new System.Drawing.Size(500, 450);
            this.panelDetailCenter.TabIndex = 0;
            // 
            // lblClientName
            // 
            this.lblClientName.Location = new System.Drawing.Point(20, 20);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(100, 23);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Клиент:";
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.Location = new System.Drawing.Point(20, 50);
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(100, 23);
            this.lblDeviceInfo.TabIndex = 1;
            this.lblDeviceInfo.Text = "Устройство:";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(20, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Статус:";
            // 
            // txtWorkComment
            // 
            this.txtWorkComment.Location = new System.Drawing.Point(20, 120);
            this.txtWorkComment.Multiline = true;
            this.txtWorkComment.Name = "txtWorkComment";
            this.txtWorkComment.Size = new System.Drawing.Size(400, 100);
            this.txtWorkComment.TabIndex = 3;
            // 
            // lblRepairPrice
            // 
            this.lblRepairPrice.Location = new System.Drawing.Point(20, 240);
            this.lblRepairPrice.Name = "lblRepairPrice";
            this.lblRepairPrice.Size = new System.Drawing.Size(100, 23);
            this.lblRepairPrice.TabIndex = 4;
            this.lblRepairPrice.Text = "Цена:";
            // 
            // txtRepairPrice
            // 
            this.txtRepairPrice.Location = new System.Drawing.Point(70, 237);
            this.txtRepairPrice.Name = "txtRepairPrice";
            this.txtRepairPrice.Size = new System.Drawing.Size(120, 20);
            this.txtRepairPrice.TabIndex = 5;
            // 
            // btnStartWork
            // 
            this.btnStartWork.Location = new System.Drawing.Point(20, 280);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(200, 23);
            this.btnStartWork.TabIndex = 6;
            this.btnStartWork.Text = "Начать ремонт";
            // 
            // btnNeedParts
            // 
            this.btnNeedParts.Location = new System.Drawing.Point(20, 320);
            this.btnNeedParts.Name = "btnNeedParts";
            this.btnNeedParts.Size = new System.Drawing.Size(200, 23);
            this.btnNeedParts.TabIndex = 7;
            this.btnNeedParts.Text = "Ожидает запчастей";
            // 
            // btnFinishRepair
            // 
            this.btnFinishRepair.Location = new System.Drawing.Point(20, 360);
            this.btnFinishRepair.Name = "btnFinishRepair";
            this.btnFinishRepair.Size = new System.Drawing.Size(200, 23);
            this.btnFinishRepair.TabIndex = 8;
            this.btnFinishRepair.Text = "Завершить";
            // 
            // MasterMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1409, 849);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "MasterMainForm";
            this.Text = "Мастер";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelOrders.ResumeLayout(false);
            this.panelOrdersCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.panelOrderDetails.ResumeLayout(false);
            this.panelDetailCenter.ResumeLayout(false);
            this.panelDetailCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.Button btnLogout2;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelOrdersCenter;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Button btnOpenOrder;

        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Panel panelDetailCenter;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblDeviceInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtWorkComment;
        private System.Windows.Forms.Label lblRepairPrice;
        private System.Windows.Forms.TextBox txtRepairPrice;
        private System.Windows.Forms.Button btnStartWork;
        private System.Windows.Forms.Button btnNeedParts;
        private System.Windows.Forms.Button btnFinishRepair;
    }
}

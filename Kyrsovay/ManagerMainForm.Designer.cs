namespace Kyrsovay
{
    partial class ManagerMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка ресурсов
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код конструктора Windows Form Designer

        private void InitializeComponent()
        {
            this.metroGridOrders = new MetroFramework.Controls.MetroGrid();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridOrders
            // 
            this.metroGridOrders.AllowUserToAddRows = false;
            this.metroGridOrders.AllowUserToDeleteRows = false;
            this.metroGridOrders.AllowUserToResizeRows = false;
            this.metroGridOrders.BackgroundColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.metroGridOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridOrders.EnableHeadersVisualStyles = false;
            this.metroGridOrders.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.metroGridOrders.GridColor = System.Drawing.Color.FromArgb(17, 17, 17);
            this.metroGridOrders.Location = new System.Drawing.Point(23, 80);
            this.metroGridOrders.Name = "metroGridOrders";
            this.metroGridOrders.ReadOnly = true;
            this.metroGridOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.metroGridOrders.RowHeadersWidth = 51;
            this.metroGridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridOrders.Size = new System.Drawing.Size(940, 430);
            this.metroGridOrders.TabIndex = 0;
            this.metroGridOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top |
                                              System.Windows.Forms.AnchorStyles.Bottom)
                                              | System.Windows.Forms.AnchorStyles.Left)
                                              | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(820, 525);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom
                                              | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // ManagerMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.metroGridOrders);
            this.Name = "ManagerMainForm";
            this.Text = "Журнал заказов (приёмщик)";
            this.Load += new System.EventHandler(this.ManagerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridOrders;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}

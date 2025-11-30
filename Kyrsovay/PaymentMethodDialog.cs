using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class PaymentMethodDialog : Form
    {
        private ComboBox cmbPaymentMethod;
        private Label lblAmount;
        private Label lblAmountValue;
        private Button btnOK;
        private Button btnCancel;

        public string PaymentMethod { get; private set; }
        private decimal _amount;

        public PaymentMethodDialog(decimal amount)
        {
            _amount = amount;
            InitializeDialog();
        }

        private void InitializeDialog()
        {
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Оплата заказа";

            int y = 20;
            int labelX = 20;
            int controlX = 150;
            int controlWidth = 200;
            int rowHeight = 40;

            // Сумма
            lblAmount = new Label 
            { 
                Text = "Сумма к оплате:", 
                Left = labelX, 
                Top = y, 
                Width = 120,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            lblAmountValue = new Label 
            { 
                Text = $"{_amount:N0} ₸", 
                Left = controlX, 
                Top = y, 
                Width = controlWidth,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 167, 69)
            };
            this.Controls.Add(lblAmount);
            this.Controls.Add(lblAmountValue);
            y += rowHeight + 10;

            // Способ оплаты
            Label lblMethod = new Label 
            { 
                Text = "Способ оплаты:", 
                Left = labelX, 
                Top = y, 
                Width = 120 
            };
            cmbPaymentMethod = new ComboBox 
            { 
                Left = controlX, 
                Top = y, 
                Width = controlWidth, 
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10F)
            };
            cmbPaymentMethod.Items.AddRange(new string[] 
            { 
                "Наличные", 
                "Банковская карта", 
                "Электронный кошелёк",
                "Банковский перевод"
            });
            cmbPaymentMethod.SelectedIndex = 0;
            this.Controls.Add(lblMethod);
            this.Controls.Add(cmbPaymentMethod);
            y += rowHeight + 20;

            // Кнопки
            btnOK = new Button 
            { 
                Text = "✓ Оплатить", 
                Left = 150, 
                Top = y, 
                Width = 100, 
                Height = 35,
                DialogResult = DialogResult.None,
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnOK.Click += BtnOK_Click;
            this.Controls.Add(btnOK);

            btnCancel = new Button 
            { 
                Text = "✕ Отмена", 
                Left = 260, 
                Top = y, 
                Width = 100, 
                Height = 35,
                DialogResult = DialogResult.Cancel,
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            this.Controls.Add(btnCancel);

            this.CancelButton = btnCancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Выберите способ оплаты!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PaymentMethod = cmbPaymentMethod.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}


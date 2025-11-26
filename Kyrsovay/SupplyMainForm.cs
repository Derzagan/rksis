using System;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class SupplyMainForm : Form
    {
        private int _employeeId;

        public SupplyMainForm()
        {
            InitializeComponent();
        }

        public SupplyMainForm(int employeeId) : this()
        {
            _employeeId = employeeId;
        }

        private void SupplyMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

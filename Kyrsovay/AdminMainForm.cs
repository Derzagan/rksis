using System;
using System.Windows.Forms;

namespace Kyrsovay
{
    public partial class AdminMainForm : Form
    {
        private int _employeeId;

        public AdminMainForm()
        {
            InitializeComponent();
        }

        public AdminMainForm(int employeeId) : this()
        {
            _employeeId = employeeId;
            // сюда потом можно добавить отображение ФИО, прав и т.д.
        }
    }
}

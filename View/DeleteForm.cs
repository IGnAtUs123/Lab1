using System;
using System.Windows.Forms;
using Logic;

namespace View
{
    public partial class DeleteForm : Form
    {
        private readonly BusinessLogic _logic;

        public DeleteForm(BusinessLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studId.Text))
            {
                MessageBox.Show("Введите номер студенческого билета!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _logic.DeleteStudent(studId.Text);
            Close();
        }
    }
}

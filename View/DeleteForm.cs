using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    using Logic;
    public partial class DeleteForm : Form
    {
        public Action<string> StudentDeleted;
        private Logic logic = new Logic();
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void txtSpec_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(label43.Text))
            {
                MessageBox.Show("Вы должны заполнить все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StudentDeleted?.Invoke(studId.Text);
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

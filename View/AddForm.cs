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
    public partial class AddForm : Form
    {

        public Action<Logic> StudentCreated;
        private Logic logic = new Logic();
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtGroup.Text) || string.IsNullOrEmpty(txtSpec.Text) || string.IsNullOrEmpty(labe4.Text))
            {
                MessageBox.Show("Вы должны заполнить все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                logic.AddStudent(txtName.Text, txtSpec.Text, txtGroup.Text, studId.Text);
                StudentCreated?.Invoke(logic);
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void group_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}

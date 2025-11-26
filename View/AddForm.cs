using System;
using System.Windows.Forms;
using AppLogic = Logic.Logic; 

namespace View
{
    public partial class AddForm : Form
    {
        private readonly AppLogic logic;

        public AddForm(AppLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSpec.Text) ||
                string.IsNullOrWhiteSpace(txtGroup.Text) ||
                string.IsNullOrWhiteSpace(studId.Text))
            {
                MessageBox.Show("Вы должны заполнить все поля!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            logic.AddStudent(txtName.Text, txtSpec.Text, txtGroup.Text, studId.Text);

            Close();
        }
    }
}

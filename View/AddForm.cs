using System;
using System.Windows.Forms;
using AppLogic = Logic.Logic; // псевдоним для класса Logic

namespace View
{
    public partial class AddForm : Form
    {
        private readonly AppLogic logic;

        // Конструктор принимает общий экземпляр Logic
        public AddForm(AppLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        // Обработчик кнопки "Добавить"
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

            // Добавляем студента через общий экземпляр Logic
            logic.AddStudent(txtName.Text, txtSpec.Text, txtGroup.Text, studId.Text);

            // Закрываем форму после добавления
            Close();
        }
    }
}

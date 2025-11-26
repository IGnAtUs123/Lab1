using Logic;
using Microsoft.VisualBasic.Logging;

namespace View
{
    public partial class Main : Form
    {
        private readonly Logic.Logic _logic;

        public Main(Logic.Logic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            var form = new AddForm(_logic);
            form.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var form = new DeleteForm(_logic);
            form.Show();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            foreach (var student in _logic.ShowTheListOfStudents())
            {
                var item = new ListViewItem(student.Name);
                item.SubItems.Add(student.Speciality);
                item.SubItems.Add(student.Group);
                item.SubItems.Add(student.Id);
                listView.Items.Add(item);
            }
        }


        private void histogramButton_Click(object sender, EventArgs e)
        {
            var histogram = new Histogram(_logic);
            histogram.Show();
        }
    }
}

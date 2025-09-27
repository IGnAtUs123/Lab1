

namespace View
{
    using Logic;
    using System.Text.Json;
    using static System.Reflection.Metadata.BlobBuilder;

    public partial class Главная : Form
    {
        Logic lg = new Logic();
        //private void SaveBooksToFile()
        //{
        //    string json = JsonSerializer.Serialize(lg, new JsonSerializerOptions { WriteIndented = true });
        //    File.WriteAllText("students.json", json);
        //}
        //private void LoadBooksFromFile()
        //{
        //    if (File.Exists("students.json"))
        //    {
        //        string json = File.ReadAllText("students.json");
        //        lg = JsonSerializer.Deserialize<List<>>(json);
        //    }
        //}
        public Главная()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.StudentCreated += OnStudentCreated;
            form.Show();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            DeleteForm form = new DeleteForm();
            form.StudentDeleted += OnStudentDeleted;
            form.Show();
        }
        public void OnStudentCreated(Logic logic)
        {
            if (logic.ShowTheListOfStudents().Any())
            {
                lg.AddStudent(logic.ShowTheListOfStudents()[0].Name, logic.ShowTheListOfStudents()[0].Speciality, logic.ShowTheListOfStudents()[0].Group, logic.ShowTheListOfStudents()[0].Id);
            }
        }
        public void OnStudentDeleted(string id)
        {
            lg.DeleteStudent(id);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            foreach (var student in lg.ShowTheListOfStudents())
            {
                ListViewItem item = new ListViewItem(student.Name);
                item.SubItems.Add(student.Speciality);
                item.SubItems.Add(student.Group);
                item.SubItems.Add(student.Id);

                listView.Items.Add(item);
            }

        }

        private void histogramButton_Click(object sender, EventArgs e)
        {
            //listView.Items.Clear();
            //foreach (var student in lg.ShowTheHistogram())
            //{
            //    ListViewItem item = new ListViewItem(student.Name);
            //    item.SubItems.Add(student.Speciality);
            //    item.SubItems.Add(student.Group);

            //    listView.Items.Add(item);
            //}
            Histogram histogram = new Histogram(lg);
            histogram.Show();
        }
    }
}

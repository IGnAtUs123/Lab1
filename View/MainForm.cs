using System;
using System.Windows.Forms;
using System.Linq;
using Domain;

namespace View
{
    public partial class MainForm : Form, IView
    {
        public event EventHandler AddRequested;
        public event EventHandler DeleteRequested;

        public string InputName => txtName.Text;
        public string InputSpeciality => txtSpec.Text;
        public string InputGroup => txtGroup.Text;
        public string InputId => studId.Text;

        public MainForm()
        {
            InitializeComponent();

            addButton.Click += (s, e) => AddRequested?.Invoke(this, EventArgs.Empty);
            removeButton.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        public void ShowStudents(IEnumerable<Student> students)
        {
            listView.Items.Clear();
            foreach (var s in students)
            {
                var item = new ListViewItem(s.Name);
                item.SubItems.Add(s.Speciality);
                item.SubItems.Add(s.Group);
                item.SubItems.Add(s.Id);
                listView.Items.Add(item);
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ClearInputs()
        {
            txtName.Clear();
            txtSpec.Clear();
            txtGroup.Clear();
            studId.Clear();
        }

        public void Run() => Application.Run(this);
    }
}

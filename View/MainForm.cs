using System;
using System.Windows.Forms;
using System.Linq;

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

        public void ShowStudents(IEnumerable<object[]> students)
        {
            listView.Items.Clear();
            foreach (var s in students)
            {
                var item = new ListViewItem(s[0]?.ToString() ?? "");
                item.SubItems.Add(s[1]?.ToString() ?? "");
                item.SubItems.Add(s[2]?.ToString() ?? "");
                item.SubItems.Add(s[3]?.ToString() ?? "");
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

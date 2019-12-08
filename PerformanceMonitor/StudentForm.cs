using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceMonitor
{
    public partial class StudentForm : Form
    {
        Student student;
        public StudentForm(Student student)
        {
            InitializeComponent();
            this.student = student;

            FillList();
            SetParams();

            listView.ColumnWidthChanging += ListView_ColumnWidthChanging;
            this.SizeChanged += StudentForm_SizeChanged;
        }
        private void StudentForm_SizeChanged(object sender, EventArgs e)
        {
            SetParams();
        }
        private void SetParams()
        {
            listView.Columns[0].Width = Width / 2;
            listView.Columns[1].Width = Width / 4;
            listView.Columns[2].Width = Width / 4;
            listView.Location = new Point(0, linkLabelReturnToMain.Height);
            listView.Size = new Size(Width, Height);

            linkLabelСhangeLogin.Location = new Point(Width - linkLabelСhangeLogin.Width - 20, linkLabelСhangeLogin.Location.Y);
        }
        private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView.Columns[e.ColumnIndex].Width;
        }

        private void FillList()
        {
            List<Tuple<string, int, int>> info = student.gradeBook.GetFullInfo();
            List<ListViewItem> tabel = new List<ListViewItem>();
            foreach(Tuple< string, int, int> element in info)
            {
                ListViewItem row = new ListViewItem(element.Item1, 0);
                row.SubItems.Add(element.Item2.ToString());
                row.SubItems.Add(element.Item3.ToString());
                tabel.Add(row);
            }
            listView.Items.AddRange(tabel.ToArray());
        }

        private void linkLabelReturnToMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActiveForm.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }

        private void linkLabelСhangeLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form form = new ChangeLoginDataForm(student, this);
            form.ShowDialog();
        }
    }
}

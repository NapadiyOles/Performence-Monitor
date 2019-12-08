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
    public partial class TeacherForm : Form
    {
        private Teacher teacher;
        public TeacherForm(Teacher teacher)
        {
            InitializeComponent();

            this.teacher = teacher;

            groupBoxVisit.Width = radioButtonVisitTrue.Width + radioButtonVisitTrue.Width;
            radioButtonVisitTrue.Checked = true;
            labelOldResults.Text = "";
            SetPositions();

            this.SizeChanged += TeacherForm_SizeChanged;
            maskedTextBoxNumber.MouseDown += MaskedTextBoxPassword_MouseDown;
            maskedTextBoxNumber.TextChanged += MaskedTextBoxNumber_TextChanged;
        }


        private void TeacherForm_SizeChanged(object sender, EventArgs e)
        {
            SetPositions();
        }

        private void SetPositions()
        {
            labelNumber.Location = new Point((Width - labelNumber.Width) / 2, labelNumber.Location.Y);
            maskedTextBoxNumber.Location = new Point((Width - maskedTextBoxNumber.Width) / 2, maskedTextBoxNumber.Location.Y);
            labelOldResults.Location = new Point((Width - labelOldResults.Width) / 2, labelOldResults.Location.Y);
            labelMark.Location = new Point((Width - labelMark.Width) / 2, labelMark.Location.Y);
            numericUpDownMark.Location = new Point((Width - numericUpDownMark.Width) / 2, numericUpDownMark.Location.Y);
            labelVisit.Location = new Point((Width - labelVisit.Width) / 2, labelVisit.Location.Y);
            groupBoxVisit.Location = new Point((Width - groupBoxVisit.Width) / 2, groupBoxVisit.Location.Y);
            buttonSubmit.Location = new Point((Width - buttonSubmit.Width) / 2, buttonSubmit.Location.Y);

            linkLabelСhangeLogin.Location = new Point(Width - linkLabelСhangeLogin.Width - 20, linkLabelСhangeLogin.Location.Y);
        }

        private void MaskedTextBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            maskedTextBox.SelectionStart = maskedTextBox.Text.Length;
            maskedTextBox.SelectionLength = 0;
            toolTipNumber.Hide(maskedTextBoxNumber);
        }
        private void MaskedTextBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxNumber.MaskCompleted)
            {
                maskedTextBoxNumber.Text = maskedTextBoxNumber.Text.ToLower();

                Tuple<string, string> info;
                if ((info = GradeBook.GetSubjectInfo(teacher.Subject, maskedTextBoxNumber.Text)) != null && maskedTextBoxNumber.MaskCompleted)
                    labelOldResults.Text = $"Поточні бали: {info.Item1}. Кількість відвідувань: {info.Item2}.";
                else
                    labelOldResults.Text = "";
            }
            else
                labelOldResults.Text = "";
            labelOldResults.Location = new Point((Width - labelOldResults.Width) / 2, labelOldResults.Location.Y);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!maskedTextBoxNumber.MaskCompleted)
            {
                toolTipNumber.ToolTipTitle = "Некоректний ввід!";
                toolTipNumber.Show("Номер повинен складати рівно 2 буквенних і 4 цифрових символів.", maskedTextBoxNumber, 0, -20, 5000);
            }
            else if (!Admin.numberAlreadyExist(maskedTextBoxNumber.Text))
            {
                toolTipNumber.ToolTipTitle = "Такого студента не знайдено!";
                toolTipNumber.Show("Перевірте коректність введеної інформації.", maskedTextBoxNumber, 0, -20, 5000);
            }
            else
            {
                bool Visited = true;
                if (radioButtonVisitFalse.Checked)
                    Visited = false;
                teacher.SetMarks(maskedTextBoxNumber.Text, (int)numericUpDownMark.Value, Visited);
                MessageBox.Show("Результати виставлені.");
            }
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
            Form form = new ChangeLoginDataForm(teacher, this);
            form.ShowDialog();
        }
    }
}

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
    public partial class ChangeLoginDataForm : Form
    {
        private User user;
        private Form UserForm;
        public ChangeLoginDataForm(User user, Form UserForm)
        {
            InitializeComponent();

            this.user = user;
            this.UserForm = UserForm;

            maskedTextBoxLogin.MaskInputRejected += MaskedTextBoxLogin_MaskInputRejected;
            maskedTextBoxLogin.MouseDown += maskedTextBox_MouseDown;
            maskedTextBoxPassoword.MaskInputRejected += MaskedTextBoxPassoword_MaskInputRejected;
            maskedTextBoxPassoword.MouseDown += maskedTextBox_MouseDown;
            Load += ChangeLoginDataForm_Load;
            Resize += ChangeLoginDataForm_Resize;
            button1.Click += Button1_Click;
        }

        private void ChangeLoginDataForm_Load(object sender, EventArgs e)
        {
            SetPositions();

            switch (user.Role)
            {
                case "admin":
                    Admin admin = (Admin)user;
                    maskedTextBoxLogin.Text = admin.Name;
                    break;
                case "teacher":
                    Teacher teacher = (Teacher)user;
                    maskedTextBoxLogin.Text = teacher.Name;
                    break;
                case "student":
                    Student student = (Student)user;
                    maskedTextBoxLogin.Text = student.Name;
                    break;
            }
        }
        private void ChangeLoginDataForm_Resize(object sender, EventArgs e)
        {
            SetPositions();
        }
        private void SetPositions()
        {
            int defaultHeight = 80, interval = 40;
            label1.Location = new Point((Width - label1.Width) / 2, defaultHeight);
            defaultHeight += label1.Height + interval / 2;
            maskedTextBoxLogin.Location = new Point((Width - maskedTextBoxLogin.Width) / 2, defaultHeight);
            defaultHeight += maskedTextBoxLogin.Height + interval;
            label2.Location = new Point((Width - label2.Width) / 2, defaultHeight);
            defaultHeight += label2.Height + interval / 2;
            maskedTextBoxPassoword.Location = new Point((Width - maskedTextBoxPassoword.Width) / 2, defaultHeight);
            defaultHeight += maskedTextBoxPassoword.Height + interval * 2;
            button1.Location = new Point((Width - button1.Width) / 2, defaultHeight);
        }
        private void MaskedTextBoxLogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var maskedTextBox = (MaskedTextBox)sender;
            if (maskedTextBox.MaskFull)
            {
                toolTip1.ToolTipTitle = "Надто багато символів!";
                toolTip1.Show("Ви більше не можете вводити дані. Видаліть частину щоб ввести ще.", maskedTextBox, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBox.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Кінець поля вводу!";
                toolTip1.Show("Ви не можете ввести додаткові символи в кінець поля.", maskedTextBox, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Некоректний ввід!";
                toolTip1.Show("Ви можете вводити лише буквенні символи.", maskedTextBox, 0, -20, 5000);
            }
        }
        private void MaskedTextBoxPassoword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            var maskedTextBox = (MaskedTextBox)sender;
            if (!(maskedTextBox.MaskFull || e.Position == maskedTextBox.Mask.Length))
            {
                toolTip2.ToolTipTitle = "Некоректний ввід!";
                toolTip2.Show("Ви можете вводити лише буквенні символи і цифри.", maskedTextBox, 0, -20, 5000);
            }
        }
        private void maskedTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            maskedTextBox.SelectionStart = maskedTextBox.Text.Length;
            maskedTextBox.SelectionLength = 0;
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxLogin.Text.Length < 5)
            {
                toolTip1.ToolTipTitle = "Не достатньо символів!";
                toolTip1.Show("Введіть більше даних для обробки логіну.", maskedTextBoxLogin, 0, -20, 5000);
            }
            else if (!maskedTextBoxPassoword.MaskFull)
            {
                toolTip2.ToolTipTitle = "Не достатньо символів!";
                toolTip2.Show("Введіть більше даних для обробки пароля.", maskedTextBoxPassoword, 0, -20, 5000);
            }
            else
            {
                Hide();

                switch (user.Role)
                {
                    case "admin":
                        Admin admin = (Admin)user;
                        Admin.ChangeUser(admin.Name, maskedTextBoxLogin.Text, maskedTextBoxPassoword.Text, "admin", "-");
                        break;
                    case "teacher":
                        Teacher teacher = (Teacher)user;
                        Admin.ChangeUser(teacher.Name, maskedTextBoxLogin.Text, maskedTextBoxPassoword.Text, "teacher", teacher.Subject);
                        break;
                    case "student":
                        Student student = (Student)user;
                        Admin.ChangeUser(student.Name, maskedTextBoxLogin.Text, maskedTextBoxPassoword.Text, "student", student.Number);
                        break;
                }

                UserForm.Show();
                Close();
            }
        }
    }
}

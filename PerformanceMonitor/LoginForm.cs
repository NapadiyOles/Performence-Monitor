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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.Load += LoginForm_Load;
            this.SizeChanged += LoginForm_SizeChanged;

            maskedTextBoxLogin.MaskInputRejected += maskedTextBoxLogin_MaskInputRejected;
            maskedTextBoxLogin.KeyDown += maskedTextBox_KeyDown;
            maskedTextBoxLogin.MouseDown += maskedTextBox_MouseDown;

            maskedTextBoxPassword.MaskInputRejected += maskedTextBoxPassword_MaskInputRejected;
            maskedTextBoxPassword.KeyDown += maskedTextBox_KeyDown;
            maskedTextBoxPassword.MouseDown += maskedTextBox_MouseDown;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            maskedTextBoxPassword.PasswordChar = '*';
            setPositions();
        }
        private void LoginForm_SizeChanged(object sender, EventArgs e)
        {
            setPositions();
        }
        private void setPositions()
        {

            int defaultHeight = 80, interval = 40;
            label1.Location = new Point((Width - label1.Width) / 2, defaultHeight);
            defaultHeight += label1.Height + interval / 2;
            maskedTextBoxLogin.Location = new Point((Width - maskedTextBoxLogin.Width) / 2, defaultHeight);
            defaultHeight += maskedTextBoxLogin.Height + interval;
            label2.Location = new Point((Width - label2.Width) / 2, defaultHeight);
            defaultHeight += label2.Height + interval / 2;
            maskedTextBoxPassword.Location = new Point((Width - maskedTextBoxPassword.Width) / 2, defaultHeight);
            defaultHeight += maskedTextBoxPassword.Height + interval * 2;
            button1.Location = new Point((Width - button1.Width) / 2, defaultHeight);
        }
        void maskedTextBoxLogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBoxLogin.MaskFull)
            {
                toolTip1.ToolTipTitle = "Надто багато символів!";
                toolTip1.Show("Ви більше не можете вводити дані. Видаліть частину щоб ввести ще.", maskedTextBoxLogin, 0, -20, 5000);
            }
            else if (e.Position == maskedTextBoxLogin.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Кінець поля вводу!";
                toolTip1.Show("Ви не можете ввести додаткові символи в кінець поля.", maskedTextBoxLogin, 0, -20, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Некоректний ввід!";
                toolTip1.Show("Ви можете вводити лише буквенні символи.", maskedTextBoxLogin, 0, -20, 5000);
            }
        }
        void maskedTextBoxPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(!(maskedTextBoxPassword.MaskFull || e.Position == maskedTextBoxPassword.Mask.Length))
            {
                toolTip2.ToolTipTitle = "Некоректний ввід!";
                toolTip2.Show("Ви можете вводити лише буквенні символи і цифри.", maskedTextBoxPassword, 0, -20, 5000);
            }
        }
        void maskedTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            maskedTextBox.SelectionStart = maskedTextBox.Text.Length;
            maskedTextBox.SelectionLength = 0;
            toolTip1.Hide((MaskedTextBox)sender);
            toolTip2.Hide((MaskedTextBox)sender);
        }
        void maskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide((MaskedTextBox)sender);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Tuple<string, string, string> Info = null;
            if (!maskedTextBoxPassword.MaskFull)
            {
                toolTip2.ToolTipTitle = "Не достатньо символів!";
                toolTip2.Show("Введіть більше даних для обробки пароля.", maskedTextBoxPassword, 0, -20, 5000);
            }
            else if(maskedTextBoxLogin.Text.Length < 5)
            {
                toolTip2.ToolTipTitle = "Не достатньо символів!";
                toolTip2.Show("Введіть більше даних для обробки логіну.", maskedTextBoxLogin, 0, -20, 5000);
            }
            else if ((Info = Admin.Check(maskedTextBoxLogin.Text)) != null)
            {
                if (Info.Item1 != maskedTextBoxPassword.Text)
                {
                    toolTip2.ToolTipTitle = "Некоректнй пароль!";
                    toolTip2.Show("Введіть інший пароль або увійдіть під іншим логіном.", maskedTextBoxPassword, 0, -20, 5000);
                }
                else if (Subject.FillSubjectList())
                {
                    //TODO: Закінчити виклики форм і зчитування додаткових полів для класу Student і Teacher
                    //TODO: Написати 3 форми для класів Admin, Student, Teacher
                    switch (Info.Item2)
                    {
                        case "admin":
                            ActiveForm.Hide();
                            Admin admin = new Admin(maskedTextBoxLogin.Text, maskedTextBoxPassword.Text);
                            AdminForm adminForm = new AdminForm(admin);
                            adminForm.ShowDialog();
                            Close();
                            break;
                        case "student":
                            ActiveForm.Hide();
                            Student student = new Student(maskedTextBoxLogin.Text, maskedTextBoxPassword.Text, Info.Item3);
                            StudentForm studentForm = new StudentForm(student);
                            studentForm.ShowDialog();
                            Close();
                            break;
                        case "teacher":
                            ActiveForm.Hide();
                            Teacher teacher = new Teacher(maskedTextBoxLogin.Text, maskedTextBoxPassword.Text, Info.Item3);
                            TeacherForm teacherForm = new TeacherForm(teacher);
                            teacherForm.ShowDialog();
                            Close();
                            break;
                    }
                    Close();
                }
                else if(Info.Item2 == "admin")
                {
                    ActiveForm.Hide();
                    Admin admin = new Admin(maskedTextBoxLogin.Text, maskedTextBoxPassword.Text);
                    AdminForm adminForm = new AdminForm(admin);
                    adminForm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Ви тимчасово не маєте доступу.");
                }
            }
            else { MessageBox.Show("Ви ще не зареєстровані!"); }
        }
        }
}

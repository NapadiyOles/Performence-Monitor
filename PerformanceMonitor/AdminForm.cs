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
    public partial class AdminForm : Form
    {
        private Admin admin;
        public AdminForm(Admin admin)
        {
            InitializeComponent();

            this.admin = admin;

            this.Load += AdminForm_Load;
            this.SizeChanged += AdminForm_SizeChanged;
            maskedTextBoxLogin.MouseDown += MaskedTextBoxPassword_MouseDown;
            maskedTextBoxPassword.MouseDown += MaskedTextBoxPassword_MouseDown;
            maskedTextBoxGradebookNumber.MouseDown += MaskedTextBoxPassword_MouseDown;
            textBoxSetubject.MouseDown += TextBoxSetubject_MouseDown;
            maskedTextBoxGradebookNumber.TextChanged += MaskedTextBoxGradebookNumber_TextChanged;
        }

        private void MaskedTextBoxGradebookNumber_TextChanged(object sender, EventArgs e)
        {
            var maskedTextBox = (MaskedTextBox)sender;
            if (maskedTextBox.MaskCompleted)
                maskedTextBox.Text = maskedTextBox.Text.ToLower();
        }

        private void TextBoxSetubject_MouseDown(object sender, MouseEventArgs e)
        {
            toolTipLogin.Hide(maskedTextBoxLogin);
            toolTipPassword.Hide(maskedTextBoxPassword);
            toolTipNumber.Hide(maskedTextBoxGradebookNumber);
            toolTipSubject.Hide(textBoxSetubject);
        }

        private void MaskedTextBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            maskedTextBox.SelectionStart = maskedTextBox.Text.Length;
            maskedTextBox.SelectionLength = 0;
            toolTipLogin.Hide(maskedTextBoxLogin);
            toolTipPassword.Hide(maskedTextBoxPassword);
            toolTipNumber.Hide(maskedTextBoxGradebookNumber);
            toolTipSubject.Hide(textBoxSetubject);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            radioButtonAddTeacher.Checked = true;

            labelSetSubject.Visible = true;
            textBoxSetubject.Visible = true;
            labelSetNumber.Visible = false;
            maskedTextBoxGradebookNumber.Visible = false;

            if (Subject.Subjects.Count == 0)
                radioButtonDeleteTeacher.Enabled = false;
            if (!Admin.usersAlreadyExists("student"))
                radioButtonDeleteStudent.Enabled = false;

            setPositions();
        }

        private void AdminForm_SizeChanged(object sender, EventArgs e)
        {
            setPositions();
        }

        private void setPositions()
        {
            int myHeight = Height / 13;
            labelTop.Location = new Point((Width - labelTop.Width) / 2, Height / 100);
            radioButtonAddTeacher.Location = new Point(Width / 10, myHeight);
            radioButtonDeleteTeacher.Location = new Point(Width / 10, myHeight + radioButtonAddTeacher.Height);
            radioButtonAddStudent.Location = new Point(Width - radioButtonDeleteStudent.Width - Width / 10, myHeight);
            radioButtonDeleteStudent.Location = new Point(Width - radioButtonDeleteStudent.Width - Width / 10, myHeight + radioButtonAddStudent.Height);
            groupBoxUser.Location = new Point((Width - groupBoxUser.Width) / 2, (Height - groupBoxUser.Height) / 2);

            labelLogin.Location = new Point((groupBoxUser.Width - labelLogin.Width) / 2, labelLogin.Location.Y);
            labelPassword.Location = new Point((groupBoxUser.Width - labelPassword.Width) / 2, labelPassword.Location.Y);
            maskedTextBoxPassword.Location = new Point((groupBoxUser.Width - maskedTextBoxPassword.Width) / 2, maskedTextBoxPassword.Location.Y);
            labelSetNumber.Location = new Point((groupBoxUser.Width - labelSetNumber.Width) / 2, (groupBoxUser.Height - labelSetNumber.Height)-50);
            labelSetSubject.Location = new Point((groupBoxUser.Width - labelSetSubject.Width) / 2, (groupBoxUser.Height - labelSetNumber.Height) - 50);
            maskedTextBoxGradebookNumber.Location = new Point((groupBoxUser.Width - maskedTextBoxGradebookNumber.Width) / 2, maskedTextBoxGradebookNumber.Location.Y);

            buttonSubmit.Location = new Point((Width - buttonSubmit.Width) / 2, (Height - buttonSubmit.Height*2));

            linkLabelСhangeLogin.Location = new Point(Width - linkLabelСhangeLogin.Width - 20, linkLabelСhangeLogin.Location.Y);
        }

        private void linkLabelReturnToMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ActiveForm.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();
        }


        private void radioButtonAddTeacher_CheckedChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = true;
            maskedTextBoxPassword.Visible = true;
            labelSetNumber.Visible = false;
            maskedTextBoxGradebookNumber.Visible = false;
            labelSetSubject.Visible = true;
            textBoxSetubject.Visible = true;
        }

        private void radioButtonDeleteTeacher_CheckedChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            maskedTextBoxPassword.Visible = false;
            labelSetNumber.Visible = false;
            maskedTextBoxGradebookNumber.Visible = false;
            labelSetSubject.Visible = true;
            textBoxSetubject.Visible = true;
        }

        private void radioButtonAddStudent_CheckedChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = true;
            maskedTextBoxPassword.Visible = true;
            labelSetNumber.Visible = true;
            maskedTextBoxGradebookNumber.Visible = true;
            labelSetSubject.Visible = false;
            textBoxSetubject.Visible = false;
        }

        private void radioButtonDeleteStudent_CheckedChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            maskedTextBoxPassword.Visible = false;
            labelSetNumber.Visible = true;
            maskedTextBoxGradebookNumber.Visible = true;
            labelSetSubject.Visible = false;
            textBoxSetubject.Visible = false;
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool EnableEditing = true;
            if (!maskedTextBoxLogin.MaskCompleted)
            {
                EnableEditing = false;
                toolTipLogin.ToolTipTitle = "Некоректний ввід!";
                toolTipLogin.Show("Логін повенен складати не менше п'яти буквенних символів.", maskedTextBoxLogin, 0, -20, 5000);
            }
            if (radioButtonAddTeacher.Checked)
            {
                if (!maskedTextBoxPassword.MaskCompleted)
                {
                    EnableEditing = false;
                    toolTipPassword.ToolTipTitle = "Некоректний ввід!";
                    toolTipPassword.Show("Пароль повинен складати рівно 10 буквенних або цифрових символів.", maskedTextBoxPassword, 0, -20, 5000);
                }
                if (!Check.String(textBoxSetubject.Text))
                {
                    EnableEditing = false;
                    toolTipSubject.ToolTipTitle = "Некоректний ввід!";
                    toolTipSubject.Show("Назва предмета повинна містити символи.", textBoxSetubject, 0, -20, 5000);
                }
                if (Subject.SubjectExist(textBoxSetubject.Text))
                {
                    EnableEditing = false;
                    MessageBox.Show("Викладача для цього предмету вже додано!");
                }
                if (EnableEditing)
                {
                    if (admin.AddNewUser(maskedTextBoxLogin.Text, maskedTextBoxPassword.Text, "teacher", textBoxSetubject.Text))
                    {
                        MessageBox.Show("Викладача успішно додано!");
                        maskedTextBoxLogin.Text = "";
                        maskedTextBoxPassword.Text = "";
                        textBoxSetubject.Text = "";
                    }
                    else
                        MessageBox.Show("Такий викладач вже існує!");
                }
            }
            else if (radioButtonDeleteTeacher.Checked)
            {
                if (!Check.String(textBoxSetubject.Text))
                {
                    EnableEditing = false;
                    toolTipSubject.ToolTipTitle = "Некоректний ввід!";
                    toolTipSubject.Show("Назва предмета повинна містити символи.", textBoxSetubject, 0, -20, 5000);
                }
                if (EnableEditing)
                {
                    if (admin.DeleteUser(maskedTextBoxLogin.Text, "teacher", textBoxSetubject.Text))
                    {
                        MessageBox.Show("Викладача успішно видалено!");
                        maskedTextBoxLogin.Text = "";
                        maskedTextBoxPassword.Text = "";
                        textBoxSetubject.Text = "";
                    }
                    else
                        MessageBox.Show("Викладача з такими параметрами не знайдено!");
                }
            }
            else if (radioButtonAddStudent.Checked)
            {
                if (!maskedTextBoxPassword.MaskCompleted)
                {
                    EnableEditing = false;
                    toolTipPassword.ToolTipTitle = "Некоректний ввід!";
                    toolTipPassword.Show("Пароль повинен складати рівно 10 буквенних або цифрових символів.", maskedTextBoxPassword, 0, -20, 5000);
                }
                if (!maskedTextBoxGradebookNumber.MaskCompleted)
                {
                    EnableEditing = false;
                    toolTipPassword.ToolTipTitle = "Некоректний ввід!";
                    toolTipPassword.Show("Номер повинен складати рівно 2 буквенних і 4 цифрових символів.", maskedTextBoxGradebookNumber, 0, -20, 5000);
                }
                if (Admin.numberAlreadyExist(maskedTextBoxGradebookNumber.Text))
                {
                    EnableEditing = false;
                    MessageBox.Show("Студента з таким номером вже додано!");
                }
                if (EnableEditing)
                {
                    if (admin.AddNewUser(maskedTextBoxLogin.Text, maskedTextBoxPassword.Text, "student", maskedTextBoxGradebookNumber.Text))
                    {
                        MessageBox.Show("Студента успішно додано!");
                        maskedTextBoxLogin.Text = "";
                        maskedTextBoxPassword.Text = "";
                        maskedTextBoxGradebookNumber.Text = "";
                    }
                    else
                        MessageBox.Show("Такий студент вже існує!");
                }

            }
            else if (radioButtonDeleteStudent.Checked)
            {
                if (!maskedTextBoxGradebookNumber.MaskCompleted)
                {
                    EnableEditing = false;
                    toolTipPassword.ToolTipTitle = "Некоректний ввід!";
                    toolTipPassword.Show("Номер повинен складати рівно 2 буквенних і 4 цифрових символів.", maskedTextBoxGradebookNumber, 0, -20, 5000);
                }
                if (EnableEditing)
                {
                    if (admin.DeleteUser(maskedTextBoxLogin.Text, "student", maskedTextBoxGradebookNumber.Text))
                    {
                        MessageBox.Show("Студента успішно видалено!");
                        maskedTextBoxLogin.Text = "";
                        maskedTextBoxGradebookNumber.Text = "";
                    }
                    else
                        MessageBox.Show("Студента з такими параметрами не знайдено!");
                }
            }


            if (Subject.Subjects.Count != 0)
                radioButtonDeleteTeacher.Enabled = true;
            else
                radioButtonDeleteTeacher.Enabled = false;

            if (Admin.usersAlreadyExists("student"))
                radioButtonDeleteStudent.Enabled = true;
            else
                radioButtonDeleteStudent.Enabled = false;

            radioButtonAddTeacher.Checked = true;
        }

        private void linkLabelСhangeLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form form = new ChangeLoginDataForm(admin, this);
            form.ShowDialog();
        }
    }
}

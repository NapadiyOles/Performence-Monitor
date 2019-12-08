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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            Load += WelcomeForm_Load;
            Resize += WelcomeForm_Resize;

            labelChengeInfo.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void WelcomeForm_Resize(object sender, EventArgs e)
        {
            SetCenter(labelTop, labelAccessInfo, labelLoginInfo, labelPasswordInfo, labelChengeInfo, buttonSubmit);
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            SetCenter(labelTop, labelAccessInfo, labelLoginInfo, labelPasswordInfo, labelChengeInfo, buttonSubmit);
        }

        void SetCenter(params Control[] objs)
        {
            foreach(Control obj in objs)
            {
                obj.Location = new Point((Width - obj.Width) / 2, obj.Location.Y);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Admin.WriteDefaultAdmin();
            Form form = new LoginForm();
            form.ShowDialog();
            Close();
        }
    }
}

namespace PerformanceMonitor
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maskedTextBoxGradebookNumber = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonAddStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonAddTeacher = new System.Windows.Forms.RadioButton();
            this.textBoxSetubject = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelSetSubject = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.labelSetNumber = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.maskedTextBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLogin = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonDeleteTeacher = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteStudent = new System.Windows.Forms.RadioButton();
            this.labelTop = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.linkLabelReturnToMain = new System.Windows.Forms.LinkLabel();
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNumber = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSubject = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelСhangeLogin = new System.Windows.Forms.LinkLabel();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxGradebookNumber
            // 
            this.maskedTextBoxGradebookNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.maskedTextBoxGradebookNumber.Location = new System.Drawing.Point(99, 246);
            this.maskedTextBoxGradebookNumber.Mask = "LL0000";
            this.maskedTextBoxGradebookNumber.Name = "maskedTextBoxGradebookNumber";
            this.maskedTextBoxGradebookNumber.Size = new System.Drawing.Size(200, 31);
            this.maskedTextBoxGradebookNumber.TabIndex = 4;
            this.maskedTextBoxGradebookNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonAddStudent
            // 
            this.radioButtonAddStudent.AutoSize = true;
            this.radioButtonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.radioButtonAddStudent.Location = new System.Drawing.Point(501, 64);
            this.radioButtonAddStudent.Name = "radioButtonAddStudent";
            this.radioButtonAddStudent.Size = new System.Drawing.Size(246, 35);
            this.radioButtonAddStudent.TabIndex = 5;
            this.radioButtonAddStudent.TabStop = true;
            this.radioButtonAddStudent.Text = "Додати студента";
            this.radioButtonAddStudent.UseVisualStyleBackColor = true;
            this.radioButtonAddStudent.CheckedChanged += new System.EventHandler(this.radioButtonAddStudent_CheckedChanged);
            // 
            // radioButtonAddTeacher
            // 
            this.radioButtonAddTeacher.AutoSize = true;
            this.radioButtonAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.radioButtonAddTeacher.Location = new System.Drawing.Point(12, 64);
            this.radioButtonAddTeacher.Name = "radioButtonAddTeacher";
            this.radioButtonAddTeacher.Size = new System.Drawing.Size(266, 35);
            this.radioButtonAddTeacher.TabIndex = 6;
            this.radioButtonAddTeacher.TabStop = true;
            this.radioButtonAddTeacher.Text = "Додати викладача";
            this.radioButtonAddTeacher.UseVisualStyleBackColor = true;
            this.radioButtonAddTeacher.CheckedChanged += new System.EventHandler(this.radioButtonAddTeacher_CheckedChanged);
            // 
            // textBoxSetubject
            // 
            this.textBoxSetubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxSetubject.Location = new System.Drawing.Point(6, 246);
            this.textBoxSetubject.Name = "textBoxSetubject";
            this.textBoxSetubject.Size = new System.Drawing.Size(388, 31);
            this.textBoxSetubject.TabIndex = 7;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelLogin.Location = new System.Drawing.Point(122, 10);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(148, 25);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Введіть логін:";
            // 
            // labelSetSubject
            // 
            this.labelSetSubject.AutoSize = true;
            this.labelSetSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelSetSubject.Location = new System.Drawing.Point(62, 218);
            this.labelSetSubject.Name = "labelSetSubject";
            this.labelSetSubject.Size = new System.Drawing.Size(265, 25);
            this.labelSetSubject.TabIndex = 9;
            this.labelSetSubject.Text = "Введіть назву предмета: ";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.labelSetSubject);
            this.groupBoxUser.Controls.Add(this.labelSetNumber);
            this.groupBoxUser.Controls.Add(this.textBoxSetubject);
            this.groupBoxUser.Controls.Add(this.labelPassword);
            this.groupBoxUser.Controls.Add(this.maskedTextBoxPassword);
            this.groupBoxUser.Controls.Add(this.maskedTextBoxLogin);
            this.groupBoxUser.Controls.Add(this.labelLogin);
            this.groupBoxUser.Controls.Add(this.maskedTextBoxGradebookNumber);
            this.groupBoxUser.Location = new System.Drawing.Point(391, 163);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(400, 280);
            this.groupBoxUser.TabIndex = 10;
            this.groupBoxUser.TabStop = false;
            // 
            // labelSetNumber
            // 
            this.labelSetNumber.AutoSize = true;
            this.labelSetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelSetNumber.Location = new System.Drawing.Point(30, 190);
            this.labelSetNumber.Name = "labelSetNumber";
            this.labelSetNumber.Size = new System.Drawing.Size(338, 25);
            this.labelSetNumber.TabIndex = 11;
            this.labelSetNumber.Text = "Введіть номер залікової книжки:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelPassword.Location = new System.Drawing.Point(111, 84);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(170, 25);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Введіть пароль:";
            // 
            // maskedTextBoxPassword
            // 
            this.maskedTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.maskedTextBoxPassword.Location = new System.Drawing.Point(99, 112);
            this.maskedTextBoxPassword.Mask = "AAAAAAAAAA";
            this.maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            this.maskedTextBoxPassword.Size = new System.Drawing.Size(200, 31);
            this.maskedTextBoxPassword.TabIndex = 11;
            this.maskedTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxLogin
            // 
            this.maskedTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.maskedTextBoxLogin.Location = new System.Drawing.Point(0, 38);
            this.maskedTextBoxLogin.Mask = "LLLLL???????????????";
            this.maskedTextBoxLogin.Name = "maskedTextBoxLogin";
            this.maskedTextBoxLogin.Size = new System.Drawing.Size(400, 31);
            this.maskedTextBoxLogin.TabIndex = 11;
            this.maskedTextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonDeleteTeacher
            // 
            this.radioButtonDeleteTeacher.AutoSize = true;
            this.radioButtonDeleteTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.radioButtonDeleteTeacher.Location = new System.Drawing.Point(12, 105);
            this.radioButtonDeleteTeacher.Name = "radioButtonDeleteTeacher";
            this.radioButtonDeleteTeacher.Size = new System.Drawing.Size(293, 35);
            this.radioButtonDeleteTeacher.TabIndex = 13;
            this.radioButtonDeleteTeacher.TabStop = true;
            this.radioButtonDeleteTeacher.Text = "Видалити викладача";
            this.radioButtonDeleteTeacher.UseVisualStyleBackColor = true;
            this.radioButtonDeleteTeacher.CheckedChanged += new System.EventHandler(this.radioButtonDeleteTeacher_CheckedChanged);
            // 
            // radioButtonDeleteStudent
            // 
            this.radioButtonDeleteStudent.AutoSize = true;
            this.radioButtonDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.radioButtonDeleteStudent.Location = new System.Drawing.Point(501, 105);
            this.radioButtonDeleteStudent.Name = "radioButtonDeleteStudent";
            this.radioButtonDeleteStudent.Size = new System.Drawing.Size(273, 35);
            this.radioButtonDeleteStudent.TabIndex = 14;
            this.radioButtonDeleteStudent.TabStop = true;
            this.radioButtonDeleteStudent.Text = "Видалити студента";
            this.radioButtonDeleteStudent.UseVisualStyleBackColor = true;
            this.radioButtonDeleteStudent.CheckedChanged += new System.EventHandler(this.radioButtonDeleteStudent_CheckedChanged);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelTop.Location = new System.Drawing.Point(318, 9);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(169, 31);
            this.labelTop.TabIndex = 15;
            this.labelTop.Text = "Оберіть дію:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonSubmit.Location = new System.Drawing.Point(12, 400);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(178, 43);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Підтвердити";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // linkLabelReturnToMain
            // 
            this.linkLabelReturnToMain.AutoSize = true;
            this.linkLabelReturnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabelReturnToMain.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelReturnToMain.Location = new System.Drawing.Point(9, 9);
            this.linkLabelReturnToMain.Name = "linkLabelReturnToMain";
            this.linkLabelReturnToMain.Size = new System.Drawing.Size(168, 17);
            this.linkLabelReturnToMain.TabIndex = 17;
            this.linkLabelReturnToMain.TabStop = true;
            this.linkLabelReturnToMain.Text = "Повернутись на головну";
            this.linkLabelReturnToMain.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabelReturnToMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReturnToMain_LinkClicked);
            // 
            // linkLabelСhangeLogin
            // 
            this.linkLabelСhangeLogin.AutoSize = true;
            this.linkLabelСhangeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabelСhangeLogin.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelСhangeLogin.Location = new System.Drawing.Point(623, 9);
            this.linkLabelСhangeLogin.Name = "linkLabelСhangeLogin";
            this.linkLabelСhangeLogin.Size = new System.Drawing.Size(176, 17);
            this.linkLabelСhangeLogin.TabIndex = 18;
            this.linkLabelСhangeLogin.TabStop = true;
            this.linkLabelСhangeLogin.Text = "Змінити персональні дані";
            this.linkLabelСhangeLogin.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabelСhangeLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelСhangeLogin_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.linkLabelСhangeLogin);
            this.Controls.Add(this.linkLabelReturnToMain);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.radioButtonDeleteStudent);
            this.Controls.Add(this.radioButtonDeleteTeacher);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.radioButtonAddTeacher);
            this.Controls.Add(this.radioButtonAddStudent);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGradebookNumber;
        private System.Windows.Forms.RadioButton radioButtonAddStudent;
        private System.Windows.Forms.RadioButton radioButtonAddTeacher;
        private System.Windows.Forms.TextBox textBoxSetubject;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelSetSubject;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelSetNumber;
        private System.Windows.Forms.RadioButton radioButtonDeleteTeacher;
        private System.Windows.Forms.RadioButton radioButtonDeleteStudent;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.LinkLabel linkLabelReturnToMain;
        private System.Windows.Forms.ToolTip toolTipLogin;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.ToolTip toolTipNumber;
        private System.Windows.Forms.ToolTip toolTipSubject;
        private System.Windows.Forms.LinkLabel linkLabelСhangeLogin;
    }
}
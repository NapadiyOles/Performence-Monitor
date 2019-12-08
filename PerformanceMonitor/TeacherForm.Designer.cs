namespace PerformanceMonitor
{
    partial class TeacherForm
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
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelOldResults = new System.Windows.Forms.Label();
            this.numericUpDownMark = new System.Windows.Forms.NumericUpDown();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelVisit = new System.Windows.Forms.Label();
            this.radioButtonVisitTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonVisitFalse = new System.Windows.Forms.RadioButton();
            this.groupBoxVisit = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.toolTipNumber = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabelReturnToMain = new System.Windows.Forms.LinkLabel();
            this.linkLabelСhangeLogin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).BeginInit();
            this.groupBoxVisit.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(12, 109);
            this.maskedTextBoxNumber.Mask = "LL0000";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(200, 31);
            this.maskedTextBoxNumber.TabIndex = 5;
            this.maskedTextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelNumber.Location = new System.Drawing.Point(12, 58);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(423, 31);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "Введіть номер залікової книжки:";
            // 
            // labelOldResults
            // 
            this.labelOldResults.AutoSize = true;
            this.labelOldResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelOldResults.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOldResults.Location = new System.Drawing.Point(12, 143);
            this.labelOldResults.Name = "labelOldResults";
            this.labelOldResults.Size = new System.Drawing.Size(277, 17);
            this.labelOldResults.TabIndex = 7;
            this.labelOldResults.Text = "Тут будуть поточні оцінки й відвідування";
            // 
            // numericUpDownMark
            // 
            this.numericUpDownMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numericUpDownMark.Location = new System.Drawing.Point(18, 207);
            this.numericUpDownMark.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMark.Name = "numericUpDownMark";
            this.numericUpDownMark.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownMark.TabIndex = 8;
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelMark.Location = new System.Drawing.Point(12, 179);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(174, 25);
            this.labelMark.TabIndex = 9;
            this.labelMark.Text = "Зароблені бали:";
            // 
            // labelVisit
            // 
            this.labelVisit.AutoSize = true;
            this.labelVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelVisit.Location = new System.Drawing.Point(7, 257);
            this.labelVisit.Name = "labelVisit";
            this.labelVisit.Size = new System.Drawing.Size(159, 25);
            this.labelVisit.TabIndex = 10;
            this.labelVisit.Text = "Відвідав пару?";
            // 
            // radioButtonVisitTrue
            // 
            this.radioButtonVisitTrue.AutoSize = true;
            this.radioButtonVisitTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.radioButtonVisitTrue.Location = new System.Drawing.Point(10, 19);
            this.radioButtonVisitTrue.Name = "radioButtonVisitTrue";
            this.radioButtonVisitTrue.Size = new System.Drawing.Size(66, 29);
            this.radioButtonVisitTrue.TabIndex = 11;
            this.radioButtonVisitTrue.TabStop = true;
            this.radioButtonVisitTrue.Text = "Так";
            this.radioButtonVisitTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonVisitFalse
            // 
            this.radioButtonVisitFalse.AutoSize = true;
            this.radioButtonVisitFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.radioButtonVisitFalse.Location = new System.Drawing.Point(82, 19);
            this.radioButtonVisitFalse.Name = "radioButtonVisitFalse";
            this.radioButtonVisitFalse.Size = new System.Drawing.Size(50, 29);
            this.radioButtonVisitFalse.TabIndex = 12;
            this.radioButtonVisitFalse.TabStop = true;
            this.radioButtonVisitFalse.Text = "Ні";
            this.radioButtonVisitFalse.UseVisualStyleBackColor = true;
            // 
            // groupBoxVisit
            // 
            this.groupBoxVisit.Controls.Add(this.radioButtonVisitFalse);
            this.groupBoxVisit.Controls.Add(this.radioButtonVisitTrue);
            this.groupBoxVisit.Location = new System.Drawing.Point(12, 285);
            this.groupBoxVisit.Name = "groupBoxVisit";
            this.groupBoxVisit.Size = new System.Drawing.Size(142, 63);
            this.groupBoxVisit.TabIndex = 13;
            this.groupBoxVisit.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.buttonSubmit.Location = new System.Drawing.Point(12, 367);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(154, 42);
            this.buttonSubmit.TabIndex = 14;
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
            this.linkLabelReturnToMain.TabIndex = 18;
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
            this.linkLabelСhangeLogin.Location = new System.Drawing.Point(612, 9);
            this.linkLabelСhangeLogin.Name = "linkLabelСhangeLogin";
            this.linkLabelСhangeLogin.Size = new System.Drawing.Size(176, 17);
            this.linkLabelСhangeLogin.TabIndex = 19;
            this.linkLabelСhangeLogin.TabStop = true;
            this.linkLabelСhangeLogin.Text = "Змінити персональні дані";
            this.linkLabelСhangeLogin.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabelСhangeLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelСhangeLogin_LinkClicked);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelСhangeLogin);
            this.Controls.Add(this.linkLabelReturnToMain);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBoxVisit);
            this.Controls.Add(this.labelVisit);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.numericUpDownMark);
            this.Controls.Add(this.labelOldResults);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).EndInit();
            this.groupBoxVisit.ResumeLayout(false);
            this.groupBoxVisit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelOldResults;
        private System.Windows.Forms.NumericUpDown numericUpDownMark;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelVisit;
        private System.Windows.Forms.RadioButton radioButtonVisitTrue;
        private System.Windows.Forms.RadioButton radioButtonVisitFalse;
        private System.Windows.Forms.GroupBox groupBoxVisit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ToolTip toolTipNumber;
        private System.Windows.Forms.LinkLabel linkLabelReturnToMain;
        private System.Windows.Forms.LinkLabel linkLabelСhangeLogin;
    }
}
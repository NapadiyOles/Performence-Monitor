namespace PerformanceMonitor
{
    partial class WelcomeForm
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
            this.labelTop = new System.Windows.Forms.Label();
            this.labelAccessInfo = new System.Windows.Forms.Label();
            this.labelLoginInfo = new System.Windows.Forms.Label();
            this.labelPasswordInfo = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelChengeInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.labelTop.Location = new System.Drawing.Point(12, 9);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(242, 63);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Вітаємо!";
            // 
            // labelAccessInfo
            // 
            this.labelAccessInfo.AutoSize = true;
            this.labelAccessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelAccessInfo.Location = new System.Drawing.Point(12, 85);
            this.labelAccessInfo.Name = "labelAccessInfo";
            this.labelAccessInfo.Size = new System.Drawing.Size(605, 31);
            this.labelAccessInfo.TabIndex = 1;
            this.labelAccessInfo.Text = "Для доступу до програми увійдйть під адміном";
            // 
            // labelLoginInfo
            // 
            this.labelLoginInfo.AutoSize = true;
            this.labelLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelLoginInfo.Location = new System.Drawing.Point(12, 132);
            this.labelLoginInfo.Name = "labelLoginInfo";
            this.labelLoginInfo.Size = new System.Drawing.Size(167, 31);
            this.labelLoginInfo.TabIndex = 2;
            this.labelLoginInfo.Text = "Логін: admin";
            // 
            // labelPasswordInfo
            // 
            this.labelPasswordInfo.AutoSize = true;
            this.labelPasswordInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelPasswordInfo.Location = new System.Drawing.Point(13, 167);
            this.labelPasswordInfo.Name = "labelPasswordInfo";
            this.labelPasswordInfo.Size = new System.Drawing.Size(269, 31);
            this.labelPasswordInfo.TabIndex = 3;
            this.labelPasswordInfo.Text = "Пароль: adminadmin";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonSubmit.Location = new System.Drawing.Point(12, 331);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(167, 48);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Зрозуміло!";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelChengeInfo
            // 
            this.labelChengeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelChengeInfo.Location = new System.Drawing.Point(12, 217);
            this.labelChengeInfo.Name = "labelChengeInfo";
            this.labelChengeInfo.Size = new System.Drawing.Size(700, 73);
            this.labelChengeInfo.TabIndex = 5;
            this.labelChengeInfo.Text = "Змінити параметри за замовчуванням можна у вкладці \"Змінити персональні дані\"";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChengeInfo);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPasswordInfo);
            this.Controls.Add(this.labelLoginInfo);
            this.Controls.Add(this.labelAccessInfo);
            this.Controls.Add(this.labelTop);
            this.DoubleBuffered = true;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelAccessInfo;
        private System.Windows.Forms.Label labelLoginInfo;
        private System.Windows.Forms.Label labelPasswordInfo;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelChengeInfo;
    }
}
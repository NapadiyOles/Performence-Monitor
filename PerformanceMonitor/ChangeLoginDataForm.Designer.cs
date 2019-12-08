namespace PerformanceMonitor
{
    partial class ChangeLoginDataForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPassoword = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLogin = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(142, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Змінити";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(139, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введіть новий пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(142, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введіть свій новий логін";
            // 
            // maskedTextBoxPassoword
            // 
            this.maskedTextBoxPassoword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.maskedTextBoxPassoword.Location = new System.Drawing.Point(142, 245);
            this.maskedTextBoxPassoword.Mask = "AAAAAAAAAA";
            this.maskedTextBoxPassoword.Name = "maskedTextBoxPassoword";
            this.maskedTextBoxPassoword.Size = new System.Drawing.Size(200, 31);
            this.maskedTextBoxPassoword.TabIndex = 6;
            this.maskedTextBoxPassoword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxLogin
            // 
            this.maskedTextBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.maskedTextBoxLogin.Location = new System.Drawing.Point(142, 128);
            this.maskedTextBoxLogin.Mask = "LLLLL???????????????";
            this.maskedTextBoxLogin.Name = "maskedTextBoxLogin";
            this.maskedTextBoxLogin.Size = new System.Drawing.Size(400, 31);
            this.maskedTextBoxLogin.TabIndex = 5;
            this.maskedTextBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeLoginDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxPassoword);
            this.Controls.Add(this.maskedTextBoxLogin);
            this.Name = "ChangeLoginDataForm";
            this.Text = "ChangeLoginDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassoword;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}
namespace PerformanceMonitor
{
    partial class StudentForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVisits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabelReturnToMain = new System.Windows.Forms.LinkLabel();
            this.linkLabelСhangeLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSubject,
            this.columnMarks,
            this.columnVisits});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(217, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(366, 450);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnSubject
            // 
            this.columnSubject.Tag = "";
            this.columnSubject.Text = "Предмет";
            this.columnSubject.Width = 195;
            // 
            // columnMarks
            // 
            this.columnMarks.Text = "К-сть балів";
            this.columnMarks.Width = 68;
            // 
            // columnVisits
            // 
            this.columnVisits.Text = "К-сть відвідувань";
            this.columnVisits.Width = 99;
            // 
            // linkLabelReturnToMain
            // 
            this.linkLabelReturnToMain.AutoSize = true;
            this.linkLabelReturnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.linkLabelReturnToMain.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelReturnToMain.Location = new System.Drawing.Point(12, 0);
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
            this.linkLabelСhangeLogin.Location = new System.Drawing.Point(612, 0);
            this.linkLabelСhangeLogin.Name = "linkLabelСhangeLogin";
            this.linkLabelСhangeLogin.Size = new System.Drawing.Size(176, 17);
            this.linkLabelСhangeLogin.TabIndex = 20;
            this.linkLabelСhangeLogin.TabStop = true;
            this.linkLabelСhangeLogin.Text = "Змінити персональні дані";
            this.linkLabelСhangeLogin.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLabelСhangeLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelСhangeLogin_LinkClicked);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelСhangeLogin);
            this.Controls.Add(this.linkLabelReturnToMain);
            this.Controls.Add(this.listView);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnSubject;
        private System.Windows.Forms.ColumnHeader columnMarks;
        private System.Windows.Forms.ColumnHeader columnVisits;
        private System.Windows.Forms.LinkLabel linkLabelReturnToMain;
        private System.Windows.Forms.LinkLabel linkLabelСhangeLogin;
    }
}
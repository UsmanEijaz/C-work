namespace WindowsFormsApplication5
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schoolManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labAssistantInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schoolManagementToolStripMenuItem
            // 
            this.schoolManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountantToolStripMenuItem,
            this.securityInfoToolStripMenuItem,
            this.studentInfoToolStripMenuItem,
            this.teacherInfoToolStripMenuItem,
            this.labAssistantInfoToolStripMenuItem});
            this.schoolManagementToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolManagementToolStripMenuItem.Name = "schoolManagementToolStripMenuItem";
            this.schoolManagementToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.schoolManagementToolStripMenuItem.Text = "School Management";
            // 
            // accountantToolStripMenuItem
            // 
            this.accountantToolStripMenuItem.Name = "accountantToolStripMenuItem";
            this.accountantToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.accountantToolStripMenuItem.Text = "Accountant";
            this.accountantToolStripMenuItem.Click += new System.EventHandler(this.accountantToolStripMenuItem_Click);
            // 
            // securityInfoToolStripMenuItem
            // 
            this.securityInfoToolStripMenuItem.Name = "securityInfoToolStripMenuItem";
            this.securityInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.securityInfoToolStripMenuItem.Text = "Security Info";
            this.securityInfoToolStripMenuItem.Click += new System.EventHandler(this.securityInfoToolStripMenuItem_Click);
            // 
            // studentInfoToolStripMenuItem
            // 
            this.studentInfoToolStripMenuItem.Name = "studentInfoToolStripMenuItem";
            this.studentInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.studentInfoToolStripMenuItem.Text = "Student Info";
            this.studentInfoToolStripMenuItem.Click += new System.EventHandler(this.studentInfoToolStripMenuItem_Click);
            // 
            // teacherInfoToolStripMenuItem
            // 
            this.teacherInfoToolStripMenuItem.Name = "teacherInfoToolStripMenuItem";
            this.teacherInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.teacherInfoToolStripMenuItem.Text = "Teacher Info";
            this.teacherInfoToolStripMenuItem.Click += new System.EventHandler(this.teacherInfoToolStripMenuItem_Click);
            // 
            // labAssistantInfoToolStripMenuItem
            // 
            this.labAssistantInfoToolStripMenuItem.Name = "labAssistantInfoToolStripMenuItem";
            this.labAssistantInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.labAssistantInfoToolStripMenuItem.Text = "Lab Assistant Info";
            this.labAssistantInfoToolStripMenuItem.Click += new System.EventHandler(this.labAssistantInfoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 107);
            this.panel1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schoolManagementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem accountantToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem securityInfoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem studentInfoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem teacherInfoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem labAssistantInfoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}
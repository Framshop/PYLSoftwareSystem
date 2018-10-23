namespace PYLsystems
{
    partial class EmpManage
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
            this.settings = new System.Windows.Forms.Button();
            this.payrollButton = new System.Windows.Forms.Button();
            this.attendButton = new System.Windows.Forms.Button();
            this.empListButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(651, 701);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(83, 75);
            this.settings.TabIndex = 7;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // payrollButton
            // 
            this.payrollButton.Location = new System.Drawing.Point(221, 541);
            this.payrollButton.Name = "payrollButton";
            this.payrollButton.Size = new System.Drawing.Size(368, 81);
            this.payrollButton.TabIndex = 6;
            this.payrollButton.Text = "Payroll";
            this.payrollButton.UseVisualStyleBackColor = true;
            // 
            // attendButton
            // 
            this.attendButton.Location = new System.Drawing.Point(221, 335);
            this.attendButton.Name = "attendButton";
            this.attendButton.Size = new System.Drawing.Size(368, 81);
            this.attendButton.TabIndex = 5;
            this.attendButton.Text = "Attendance";
            this.attendButton.UseVisualStyleBackColor = true;
            // 
            // empListButton
            // 
            this.empListButton.Location = new System.Drawing.Point(221, 136);
            this.empListButton.Name = "empListButton";
            this.empListButton.Size = new System.Drawing.Size(368, 81);
            this.empListButton.TabIndex = 4;
            this.empListButton.Text = "Employees List";
            this.empListButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(45, 27);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 75);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.settings);
            this.content.Location = new System.Drawing.Point(20, 18);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(759, 809);
            this.content.TabIndex = 9;
            // 
            // EmpManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 844);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.payrollButton);
            this.Controls.Add(this.attendButton);
            this.Controls.Add(this.empListButton);
            this.Controls.Add(this.content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PYL Green Software System > Employee Management";
            this.content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button payrollButton;
        private System.Windows.Forms.Button attendButton;
        private System.Windows.Forms.Button empListButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel content;
    }
}
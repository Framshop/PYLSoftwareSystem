namespace PYLsystems
{
    partial class MainForm
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
            this.empManButtton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.inventButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empManButtton
            // 
            this.empManButtton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empManButtton.Location = new System.Drawing.Point(221, 136);
            this.empManButtton.Name = "empManButtton";
            this.empManButtton.Size = new System.Drawing.Size(368, 81);
            this.empManButtton.TabIndex = 0;
            this.empManButtton.Text = "Employee Management";
            this.empManButtton.UseVisualStyleBackColor = true;
            // 
            // salesButton
            // 
            this.salesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesButton.Location = new System.Drawing.Point(221, 335);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(368, 81);
            this.salesButton.TabIndex = 1;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            // 
            // inventButton
            // 
            this.inventButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventButton.Location = new System.Drawing.Point(221, 541);
            this.inventButton.Name = "inventButton";
            this.inventButton.Size = new System.Drawing.Size(368, 81);
            this.inventButton.TabIndex = 2;
            this.inventButton.Text = "Inventory";
            this.inventButton.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(677, 720);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(83, 75);
            this.settings.TabIndex = 3;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 844);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.inventButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.empManButtton);
            this.Name = "MainForm";
            this.Text = "PYL Green Software System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button empManButtton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button inventButton;
        private System.Windows.Forms.Button settings;
    }
}


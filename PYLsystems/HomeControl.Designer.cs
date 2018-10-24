namespace PYLsystems
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settings = new System.Windows.Forms.Button();
            this.empManButtton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.inventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(671, 711);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(83, 75);
            this.settings.TabIndex = 11;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // empManButtton
            // 
            this.empManButtton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empManButtton.Location = new System.Drawing.Point(215, 124);
            this.empManButtton.Name = "empManButtton";
            this.empManButtton.Size = new System.Drawing.Size(368, 81);
            this.empManButtton.TabIndex = 8;
            this.empManButtton.Text = "Employee Management";
            this.empManButtton.UseVisualStyleBackColor = true;
            this.empManButtton.Click += new System.EventHandler(this.empManButtton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesButton.Location = new System.Drawing.Point(215, 323);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(368, 81);
            this.salesButton.TabIndex = 9;
            this.salesButton.Text = "Sales";
            this.salesButton.UseVisualStyleBackColor = true;
            // 
            // inventButton
            // 
            this.inventButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventButton.Location = new System.Drawing.Point(215, 529);
            this.inventButton.Name = "inventButton";
            this.inventButton.Size = new System.Drawing.Size(368, 81);
            this.inventButton.TabIndex = 10;
            this.inventButton.Text = "Inventory";
            this.inventButton.UseVisualStyleBackColor = true;
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settings);
            this.Controls.Add(this.empManButtton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.inventButton);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(798, 844);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button empManButtton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button inventButton;
    }
}

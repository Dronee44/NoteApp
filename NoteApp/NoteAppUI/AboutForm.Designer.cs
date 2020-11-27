namespace NoteAppUI
{
    partial class AboutForm
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
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.GitHubLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameLabel.Location = new System.Drawing.Point(63, 28);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(160, 38);
            this.ProjectNameLabel.TabIndex = 0;
            this.ProjectNameLabel.Text = "NoteApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(67, 67);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(55, 17);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(67, 174);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(184, 17);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author: Asmolovskiy Andrey";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(67, 263);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(129, 17);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email for feedback:";
            // 
            // EmailLinkedLabel
            // 
            this.EmailLinkedLabel.AutoSize = true;
            this.EmailLinkedLabel.Location = new System.Drawing.Point(203, 263);
            this.EmailLinkedLabel.Name = "EmailLinkedLabel";
            this.EmailLinkedLabel.Size = new System.Drawing.Size(148, 17);
            this.EmailLinkedLabel.TabIndex = 4;
            this.EmailLinkedLabel.TabStop = true;
            this.EmailLinkedLabel.Text = "Dronee44@gmail.com";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(67, 280);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(60, 17);
            this.GitHubLabel.TabIndex = 5;
            this.GitHubLabel.Text = "Git Hub:";
            // 
            // GitHubLinkedLabel
            // 
            this.GitHubLinkedLabel.AutoSize = true;
            this.GitHubLinkedLabel.Location = new System.Drawing.Point(133, 280);
            this.GitHubLinkedLabel.Name = "GitHubLinkedLabel";
            this.GitHubLinkedLabel.Size = new System.Drawing.Size(130, 17);
            this.GitHubLinkedLabel.TabIndex = 6;
            this.GitHubLinkedLabel.TabStop = true;
            this.GitHubLinkedLabel.Text = "Dronee44/NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 376);
            this.Controls.Add(this.GitHubLinkedLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.EmailLinkedLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.MaximumSize = new System.Drawing.Size(471, 423);
            this.MinimumSize = new System.Drawing.Size(471, 423);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.LinkLabel EmailLinkedLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkedLabel;
    }
}
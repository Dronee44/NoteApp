namespace NoteAppUI
{
    partial class EditNote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NoteText = new System.Windows.Forms.TextBox();
            this.ModifyTimeLable = new System.Windows.Forms.Label();
            this.ModifyingDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CreatingDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CreateTimeLable = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLable = new System.Windows.Forms.Label();
            this.HeadingTextBox = new System.Windows.Forms.TextBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.NoteText);
            this.panel1.Controls.Add(this.ModifyTimeLable);
            this.panel1.Controls.Add(this.ModifyingDateTimePicker2);
            this.panel1.Controls.Add(this.CreatingDateTimePicker1);
            this.panel1.Controls.Add(this.CreateTimeLable);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Controls.Add(this.CategoryLable);
            this.panel1.Controls.Add(this.HeadingTextBox);
            this.panel1.Controls.Add(this.HeadingLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(617, 400);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(698, 400);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NoteText
            // 
            this.NoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteText.Location = new System.Drawing.Point(6, 89);
            this.NoteText.Multiline = true;
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(767, 305);
            this.NoteText.TabIndex = 8;
            // 
            // ModifyTimeLable
            // 
            this.ModifyTimeLable.AutoSize = true;
            this.ModifyTimeLable.Location = new System.Drawing.Point(246, 66);
            this.ModifyTimeLable.Name = "ModifyTimeLable";
            this.ModifyTimeLable.Size = new System.Drawing.Size(65, 17);
            this.ModifyTimeLable.TabIndex = 7;
            this.ModifyTimeLable.Text = "Modified:";
            // 
            // ModifyingDateTimePicker2
            // 
            this.ModifyingDateTimePicker2.Location = new System.Drawing.Point(317, 61);
            this.ModifyingDateTimePicker2.Name = "ModifyingDateTimePicker2";
            this.ModifyingDateTimePicker2.Size = new System.Drawing.Size(166, 22);
            this.ModifyingDateTimePicker2.TabIndex = 6;
            // 
            // CreatingDateTimePicker1
            // 
            this.CreatingDateTimePicker1.Location = new System.Drawing.Point(74, 61);
            this.CreatingDateTimePicker1.Name = "CreatingDateTimePicker1";
            this.CreatingDateTimePicker1.Size = new System.Drawing.Size(166, 22);
            this.CreatingDateTimePicker1.TabIndex = 5;
            // 
            // CreateTimeLable
            // 
            this.CreateTimeLable.AutoSize = true;
            this.CreateTimeLable.Location = new System.Drawing.Point(3, 66);
            this.CreateTimeLable.Name = "CreateTimeLable";
            this.CreateTimeLable.Size = new System.Drawing.Size(62, 17);
            this.CreateTimeLable.TabIndex = 4;
            this.CreateTimeLable.Text = "Created:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(74, 31);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.CategoryComboBox.TabIndex = 3;
            // 
            // CategoryLable
            // 
            this.CategoryLable.AutoSize = true;
            this.CategoryLable.Location = new System.Drawing.Point(3, 34);
            this.CategoryLable.Name = "CategoryLable";
            this.CategoryLable.Size = new System.Drawing.Size(69, 17);
            this.CategoryLable.TabIndex = 2;
            this.CategoryLable.Text = "Category:";
            // 
            // HeadingTextBox
            // 
            this.HeadingTextBox.Location = new System.Drawing.Point(74, 3);
            this.HeadingTextBox.Name = "HeadingTextBox";
            this.HeadingTextBox.Size = new System.Drawing.Size(464, 22);
            this.HeadingTextBox.TabIndex = 1;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Location = new System.Drawing.Point(3, 6);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(39, 17);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Title:";
            // 
            // EditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EditNote";
            this.Text = "EditNote";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox NoteText;
        private System.Windows.Forms.Label ModifyTimeLable;
        private System.Windows.Forms.DateTimePicker ModifyingDateTimePicker2;
        private System.Windows.Forms.DateTimePicker CreatingDateTimePicker1;
        private System.Windows.Forms.Label CreateTimeLable;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLable;
        private System.Windows.Forms.TextBox HeadingTextBox;
        private System.Windows.Forms.Label HeadingLabel;
    }
}
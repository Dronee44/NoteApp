namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NotesList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedTimeLabel = new System.Windows.Forms.Label();
            this.CreatingTimeLabel = new System.Windows.Forms.Label();
            this.CreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectedCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Category:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(856, 528);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 3;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(113, 3);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.CategoryComboBox.TabIndex = 3;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CreateButton);
            this.panel1.Controls.Add(this.NotesList);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.ChangeButton);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 492);
            this.panel1.TabIndex = 2;
            // 
            // NotesList
            // 
            this.NotesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesList.FormattingEnabled = true;
            this.NotesList.ItemHeight = 16;
            this.NotesList.Location = new System.Drawing.Point(3, 3);
            this.NotesList.Name = "NotesList";
            this.NotesList.Size = new System.Drawing.Size(272, 404);
            this.NotesList.TabIndex = 0;
            this.NotesList.SelectedIndexChanged += new System.EventHandler(this.NotesList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.HeadingLabel);
            this.panel2.Controls.Add(this.NoteTextBox);
            this.panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.panel2.Controls.Add(this.ModifiedTimeLabel);
            this.panel2.Controls.Add(this.CreatingTimeLabel);
            this.panel2.Controls.Add(this.CreationDateTimePicker);
            this.panel2.Controls.Add(this.SelectedCategoryLabel);
            this.panel2.Controls.Add(this.CategoryLabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 519);
            this.panel2.TabIndex = 0;
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadingLabel.Location = new System.Drawing.Point(244, 0);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(0, 36);
            this.HeadingLabel.TabIndex = 7;
            this.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NoteTextBox.Location = new System.Drawing.Point(6, 103);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(553, 413);
            this.NoteTextBox.TabIndex = 6;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(344, 75);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(165, 22);
            this.ModifiedDateTimePicker.TabIndex = 5;
            this.ModifiedDateTimePicker.Value = new System.DateTime(2020, 11, 22, 0, 0, 0, 0);
            // 
            // ModifiedTimeLabel
            // 
            this.ModifiedTimeLabel.AutoSize = true;
            this.ModifiedTimeLabel.Location = new System.Drawing.Point(273, 75);
            this.ModifiedTimeLabel.Name = "ModifiedTimeLabel";
            this.ModifiedTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.ModifiedTimeLabel.TabIndex = 4;
            this.ModifiedTimeLabel.Text = "Modified:";
            // 
            // CreatingTimeLabel
            // 
            this.CreatingTimeLabel.AutoSize = true;
            this.CreatingTimeLabel.Location = new System.Drawing.Point(30, 75);
            this.CreatingTimeLabel.Name = "CreatingTimeLabel";
            this.CreatingTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.CreatingTimeLabel.TabIndex = 3;
            this.CreatingTimeLabel.Text = "Creating:";
            // 
            // CreationDateTimePicker
            // 
            this.CreationDateTimePicker.Location = new System.Drawing.Point(101, 75);
            this.CreationDateTimePicker.Name = "CreationDateTimePicker";
            this.CreationDateTimePicker.Size = new System.Drawing.Size(166, 22);
            this.CreationDateTimePicker.TabIndex = 2;
            this.CreationDateTimePicker.Value = new System.DateTime(2020, 11, 22, 18, 40, 21, 0);
            // 
            // SelectedCategoryLabel
            // 
            this.SelectedCategoryLabel.AutoSize = true;
            this.SelectedCategoryLabel.Location = new System.Drawing.Point(105, 45);
            this.SelectedCategoryLabel.Name = "SelectedCategoryLabel";
            this.SelectedCategoryLabel.Size = new System.Drawing.Size(0, 17);
            this.SelectedCategoryLabel.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(30, 45);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateButton.BackgroundImage = global::NoteAppUI.Properties.Resources.Create1;
            this.CreateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreateButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CreateButton.Location = new System.Drawing.Point(3, 451);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(49, 35);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.BackgroundImage = global::NoteAppUI.Properties.Resources.Delete;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.Location = new System.Drawing.Point(110, 451);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(46, 35);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeButton.BackgroundImage = global::NoteAppUI.Properties.Resources.Change1;
            this.ChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeButton.Location = new System.Drawing.Point(58, 451);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(46, 35);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox NotesList;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SelectedCategoryLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CreatingTimeLabel;
        private System.Windows.Forms.DateTimePicker CreationDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Label ModifiedTimeLabel;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Label HeadingLabel;
    }
}


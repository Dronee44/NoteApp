using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class EditNote : Form
    {
        public Note _note;
        public EditNote(Note note)
        {

            InitializeComponent();
            _note = note;
            CategoryComboBox.Items.Add(NoteCategory.Work);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.Peoples);
            CategoryComboBox.Items.Add(NoteCategory.Documents);
            CategoryComboBox.Items.Add(NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteCategory.Other);
            CreatingDateTimePicker1.Enabled = false; // при запуске нельзя редактировать дату и время
            ModifyingDateTimePicker2.Enabled = false;
            HeadingTextBox.Text = note.Name;
            CategoryComboBox.SelectedItem = note.Category;
            NoteText.Text = note.Text;
            CreatingDateTimePicker1.Value = note.CreatingTime;
            ModifyingDateTimePicker2.Value = note.LastChangeTime == null ?DateTime.Now:note.LastChangeTime;

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _note.Name = HeadingTextBox.Text;
            if(Regex.IsMatch(_note.Name, @"[^\w\040\.@-]"))//проверка на спец символы
            {
                HeadingTextBox.ForeColor = Color.Red;
                return;
            }
            else
            HeadingTextBox.ForeColor = Color.Black;
            _note.Text = NoteText.Text;
            _note.Category = (NoteCategory)CategoryComboBox.SelectedItem;
            _note.LastChangeTime = ModifyingDateTimePicker2.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}

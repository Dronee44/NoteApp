using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        Note note2 = new Note("Zametka 1", NoteCategory.Work, "Nu i tekst");
        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.Add(NoteCategory.Documents);
            CategoryComboBox.Items.Add(NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.Peoples);
            CategoryComboBox.Items.Add(NoteCategory.Work);
            CategoryComboBox.Items.Add(NoteCategory.Other);

            

            NotesList.Items.Add(note2.Name);
            
        }

        private void NotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HeadingLabel.Text = note2.Name;
            NoteTextBox.Text = note2.Text;
            SelectedCategoryLabel.Text = Convert.ToString(note2.Category);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

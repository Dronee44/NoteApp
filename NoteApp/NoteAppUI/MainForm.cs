using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        Project AllNotes = new Project();   //список свех заметок
        List<Note> sortNotes = new List<Note>();
        List<Note> datasortNotes = new List<Note>();

        public MainForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.Add(NoteCategory.Work);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.Peoples);
            CategoryComboBox.Items.Add(NoteCategory.Documents);
            CategoryComboBox.Items.Add(NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteCategory.Other);
            CategoryComboBox.SelectedItem = CategoryComboBox.Items[0];
            NoteTextBox.ReadOnly = true;//отключаем редактирования текста заметки на главной форме
            CreationDateTimePicker.Enabled = false;// отключаем редактирование даты на главной форме
            ModifiedDateTimePicker.Enabled = false;
            AllNotes = ProjectManager.LoadFromFile("NoteApp.json");
            if (AllNotes != null)
            {
                NotesList.Items.Add(AllNotes.NoteList);
                CategoryComboBox.SelectedIndex = 0;//начальная категория с 0 индексом (ALL)
                CreationDateTimePicker.Enabled = false; // при запуске нельзя редактировать дату и время
                ModifiedDateTimePicker.Enabled = false;
                NoteTextBox.ReadOnly = true;//только для чтения
                if (AllNotes.NoteList.Count != 0 && AllNotes._currentNote.Count != 0)//если есть текущая заметка, то выводим ее, а если нет, то последнюю созданную
                {
                    HeadingLabel.Text = AllNotes._currentNote[0].Name;// вывод всех данных на форму
                    SelectedCategoryLabel.Text = Convert.ToString((NoteCategory)AllNotes._currentNote[0].Category);
                    NoteTextBox.Text = AllNotes._currentNote[0].Text;
                    ModifiedDateTimePicker.Value = AllNotes._currentNote[0].LastChangeTime;
                    CreationDateTimePicker.Value = AllNotes._currentNote[0].CreatingTime;
                    FillListbox();
                }
                else
                    LastNote();
            }
            else
            {
                AllNotes = new Project();
                EmptyNote();
            }



        }

        private void NotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesList.SelectedIndex == -1)
            {
                return;
            }
            if (sortNotes.Count == 0)
            {
                EmptyNote();
            }
            else
            {
                if(AllNotes._currentNote.Count!=0)
                AllNotes._currentNote.RemoveAt(0);
                AllNotes._currentNote.Add((Note)NotesList.SelectedItem);
                HeadingLabel.Text = sortNotes[NotesList.SelectedIndex].Name;// вывод всех данных на форму
                SelectedCategoryLabel.Text = Convert.ToString((NoteCategory)sortNotes[NotesList.SelectedIndex].Category);
                NoteTextBox.Text = sortNotes[NotesList.SelectedIndex].Text;
                ModifiedDateTimePicker.Value = sortNotes[NotesList.SelectedIndex].LastChangeTime;
                CreationDateTimePicker.Value = sortNotes[NotesList.SelectedIndex].CreatingTime;
                CorrectNameLenght();
                ProjectManager.SaveToFile(AllNotes);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListbox();
            if (NotesList.Items.Count != 0)
                NotesList.SelectedIndex = 0;
            else
                EmptyNote();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Note newNote = new Note() { LastChangeTime = DateTime.Now };
            EditNote noteForm = new EditNote(newNote);
            var result = noteForm.ShowDialog();
            var realIndex = NotesList.SelectedIndex;
            if (result == DialogResult.OK)
            {


                AllNotes.NoteList.Add(newNote);
                NotesList.Items.Add(newNote.Name);
                FillListbox();
                ProjectManager.SaveToFile(AllNotes);
                if (AllNotes.NoteList.Count != 0)//если есть заметка, то выводим ее
                {
                    LastNote();
                }


            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (NotesList.SelectedIndex == -1)
            { return; }
            var note = AllNotes.NoteList[NotesList.SelectedIndex];
            var realIndex = NotesList.SelectedIndex;
            EditNote noteForm = new EditNote(note);
            var result = noteForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                note = noteForm._note;
                AllNotes.NoteList.RemoveAt(realIndex);
                AllNotes.NoteList.Add(note);
                FillListbox();
                NotesList.SelectedIndex = realIndex;
                if (AllNotes.NoteList.Count != 0)//если есть заметка, то выводим ее
                {
                    LastNote();

                }
                ProjectManager.SaveToFile(AllNotes);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NotesList.SelectedIndex == -1)
            { return; }
            DialogResult result = MessageBox.Show("Do you realy want to delete " + ((Note)NotesList.SelectedItem).Name + " ?", "Удаление заметки",
                            MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                AllNotes.NoteList.Remove((Note)NotesList.SelectedItem);
                FillListbox();
                if (AllNotes.NoteList.Count == 0)
                    EmptyNote();
                if (AllNotes.NoteList.Count != 0)
                {
                    LastNote();
                }

                ProjectManager.SaveToFile(AllNotes);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateButton_Click(sender, e);
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeButton_Click(sender, e);
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }
        private void EmptyNote()// выводим стандартные надписи(при пустой форме)
        {
            HeadingLabel.Text = "Название";
            SelectedCategoryLabel.Text = "Категория";
            NoteTextBox.Text = "Текст";
            ModifiedDateTimePicker.Value = DateTime.Now;
            CreationDateTimePicker.Value = DateTime.Now;
        }
        private void LastNote()// выводим данные последней заметки
        {
            HeadingLabel.Text = AllNotes.NoteList.Last().Name;
            SelectedCategoryLabel.Text = Convert.ToString((NoteCategory)AllNotes.NoteList.Last().Category);
            NoteTextBox.Text = AllNotes.NoteList.Last().Text;
            ModifiedDateTimePicker.Value = AllNotes.NoteList.Last().LastChangeTime;
            CreationDateTimePicker.Value = AllNotes.NoteList.Last().CreatingTime;
        }
        private void CorrectNameLenght()//2 уровень проверки правильности ввода
        {
            for (int i = 0; i < AllNotes.NoteList.Count; i++)
            {
                if (AllNotes.NoteList[i].Name.Length > 50)
                {
                    HeadingLabel.ForeColor = Color.Red;
                }
                else
                    HeadingLabel.ForeColor = Color.Black;
            }
        }
        private void FillListbox()
        {
            //проверка на null(если заметок еще нет)
            if (AllNotes != null)
            {
                NotesList.Items.Clear();
                sortNotes = AllNotes.SortWithLastChangeTime();
                sortNotes = AllNotes.SortWithSelectionCategory(CategoryComboBox.SelectedIndex);
                for (int i = 0; i < sortNotes.Count; i++)
                {
                    NotesList.Items.Add(sortNotes[i]);
                }
            }
        }

        private void NotesList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
                DeleteButton_Click(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;


namespace NoteApp
{
    /// <summary>
    /// Класс заметок, содержащий список всех заметок.
    /// </summary>
    public class Project
    {

        public List<Note> NoteList = new List<Note>();
        public List<int> RealIndexes = new List<int>();

        // <summary>
        /// Индекс текущей заметки
        /// </summary>
        public List<Note> _currentNote = new List<Note>();

        public List<Note> SortWithSelectionCategory(int category)
        {
            var sortNotes = new List<Note>();

            //если выбрана категория All
            if (category == 0)
            {
                RealIndexes.Clear();

                for (int i = 0; i < NoteList.Count; i++)
                {
                    sortNotes.Add(NoteList[i]);
                    RealIndexes.Add(i);
                }
            }
            //если другая категория
            else
            {
                RealIndexes.Clear();

                for (int i = 0; i < NoteList.Count; i++)
                {
                    if ((int)NoteList[i].Category == category - 1)
                    {
                        sortNotes.Add(NoteList[i]);
                        RealIndexes.Add(i);
                    }
                }
            }
            return sortNotes;
        }
        public List<Note> SortWithLastChangeTime() // сортировка по дате пузырьком, не работает
        {
            var sortNotes = new List<Note>();
            RealIndexes.Clear();
            for (int i = 0; i < NoteList.Count; i++)
            {
                for (int j = i + 1; j < NoteList.Count; j++)
                {
                    if (NoteList[i].LastChangeTime < NoteList[j].LastChangeTime)
                    {
                        var t = NoteList[i];
                        NoteList[i] = NoteList[j];
                        NoteList[j] = t;
                    }
                }
                sortNotes.Add(NoteList[i]);

            }
            return sortNotes;
        }




    }
}
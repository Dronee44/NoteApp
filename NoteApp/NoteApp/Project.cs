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
        public BindingList<Note> NoteList = new BindingList<Note>();
        //public List<int> RealIndexes = new List<int>();
        //public int _currentNote = -1;

        //public BindingList<Note> SortWithSelectionCategory(int category)
        //{
        //    var sortNotes = new List<Note>();

        //    //если выбрана категория All
        //    if (category == 0)
        //    {
        //        RealIndexes.Clear();

        //        for (int i = 0; i < NoteList.Count; i++)
        //        {
        //            sortNotes.Add(NoteList[i]);
        //            RealIndexes.Add(i);
        //        }
        //    }
        //    //если другая категория
        //    else
        //    {
        //        RealIndexes.Clear();

        //        for (int i = 0; i < NoteList.Count; i++)
        //        {
        //            if ((int)NoteList[i].Category == category - 1)
        //            {
        //                sortNotes.Add(NoteList[i]);
        //                RealIndexes.Add(i);
        //            }
        //        }
        //    }
        //    return sortNotes;
        //}
    }

}


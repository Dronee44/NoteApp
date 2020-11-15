using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Индекс текущей заметки
        /// </summary>
        public int _currentNote = -1;
    }
    
}

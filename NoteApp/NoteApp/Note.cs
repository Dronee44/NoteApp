using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки, хранящий информацию о заголовке, категории, тексте и времени создания и изменении
    /// </summary>
    public class Note : ICloneable
    {
    
        private string _name;
        private NoteCategory _category;
        private string _text;
        private DateTime _creatingTime;
        private DateTime _lastChangeTime;

        /// <summary>
        /// Возвращает и задает название заметки
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (value.Length == 0)
                {
                    _name = "NoName";
                    return;
                }

                if (value.Length>50)
                {
                    throw new ArgumentException("Длинна названия не может превышать 50 символов");
                }

              }
        }
        /// <summary>
        ///  Возвращает и задает категорию заметки
        /// </summary>
        public NoteCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        /// <summary>
        /// Возвращает и задает текст заметки
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        /// <summary>
        /// Возвращает и задает время создания заметки
        /// </summary>

        public DateTime CreatingTime
        {
            get { return _creatingTime; }
            private set { _creatingTime = value; }
        }

        /// <summary>
        /// Возвращает и задает время последнего изменения заметки
        /// </summary>
        public DateTime LastChangeTime
        {
            get { return _lastChangeTime; }
            set { _lastChangeTime = value; }
        }

        /// <summary>
        /// Создание заметки
        /// </summary>
        public Note(string name, NoteCategory category, string text)
        {
            Name = name;
            Category = category;
            Text = text;
            CreatingTime = DateTime.Now;
        }

        public Note()
        {
        }

        public object Clone()
        {
            return new Note(this.Name, this.Category, this.Text)
            {
                LastChangeTime = this.LastChangeTime
            };
        }

    }
}

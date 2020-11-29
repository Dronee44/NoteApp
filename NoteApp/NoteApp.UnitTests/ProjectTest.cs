using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    class ProjectTest
    {
        private List<Note> _allNotes;
        [Test(Description = "Проверка, что создается элемент списка заметок ")]
        public void AllItemsAreNotNull()
        {

            _allNotes = new List<Note>();

            _allNotes.Add(new Note("Название", NoteCategory.Work, "Текст"));
            CollectionAssert.AllItemsAreNotNull(_allNotes, "Список заметок содержит незаполненые заметки");
        }
    }
}

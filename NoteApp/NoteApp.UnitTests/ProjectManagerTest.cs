using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;

namespace NoteApp.UnitTests
{
    class ProjectManagerTest
    {
        private Project _notesForSave;
        private Project _notesForLoad;
        private List<Note> _actualList;
        private static string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\NoteApp.Test.json";
        [SetUp]
        public void InitNote()
        {
            _notesForSave = new Project();
            _notesForLoad = new Project();
            _actualList = new List<Note>();
            _notesForSave.NoteList.Add(new Note("Заголовок1", NoteCategory.Work, "Текст1"));
            _notesForSave.NoteList.Add(new Note("Заголовок3", NoteCategory.Work, "Текст3"));
            _notesForSave.NoteList.Add(new Note("Заголовок2", NoteCategory.Work, "Текст2"));
            _notesForSave.NoteList.Add(new Note("Заголовок4", NoteCategory.Work, "Текст4"));
        }
        [Test(Description = "Тест сериализации")]
        public void TestSerialize_CorrectValue()
        {
            var expected = _notesForSave;
            var path = _path;
            var actualList = _actualList;

            ProjectManager.SaveToFile(expected, path);

            var actual = _notesForLoad;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(path))

            using (JsonReader reader = new JsonTextReader(sr))

                actual = (Project)serializer.Deserialize<Project>(reader);


            for (int i = 0; i < actual.NoteList.Count; i++)
            {
                actualList.Add(actual.NoteList[i]);
            }

            for (int i = 0; i < expected.NoteList.Count; i++)
            {
                Assert.AreEqual(expected.NoteList[i].Name, actualList[i].Name);
                Assert.AreEqual(expected.NoteList[i].Category, actualList[i].Category);
                Assert.AreEqual(expected.NoteList[i].Text, actualList[i].Text);
                Assert.AreEqual(expected.NoteList[i].LastChangeTime, actualList[i].LastChangeTime);
                Assert.AreEqual(expected.NoteList[i].CreatingTime, actualList[i].CreatingTime);
            }
        }
            [Test(Description = "Тест десериализации")]
        public void TestDeserialize_CorrectValue()
        {
            var expected = _notesForSave;
            var path = _path;
            var actualList = _actualList;

            var actual = ProjectManager.LoadFromFile(path);

            for (int i = 0; i < actual.NoteList.Count; i++)
            {
                actualList.Add(actual.NoteList[i]);
            }

            for (int i = 0; i < expected.NoteList.Count; i++)
            {
                Assert.AreEqual(expected.NoteList[i].Name, actualList[i].Name);
                Assert.AreEqual(expected.NoteList[i].Category, actualList[i].Category);
                Assert.AreEqual(expected.NoteList[i].Text, actualList[i].Text);
                Assert.AreEqual(expected.NoteList[i].LastChangeTime, actualList[i].LastChangeTime);
                Assert.AreEqual(expected.NoteList[i].CreatingTime, actualList[i].CreatingTime);
            }
        }
    }
}



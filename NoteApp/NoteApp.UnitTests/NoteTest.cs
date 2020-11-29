using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    // цикломатическая сложность 
    // Проект NoteApp(цикломатическая сложность=16)
    // Класс Note(цикломатическая сложность=13)
    //  свойство Name(цикломатическая сложность=4)
    //  свойство Category(цикломатическая сложность=2)
    //  свойство Text(цикломатическая сложность=2)
    //  свойство CreatingTime(цикломатическая сложность=1)
    //  свойство LastChangeTime(цикломатическая сложность=2)
    //  конструктор Note(цикломатическая сложность=1)
    //  метож Clone(цикломатическая сложность=1)
    // Класс NoteCategory()
    // Класс Project(цикломатическая сложность=1)
    // Класс ProjectManager(2)
    //  метод SaveToFile(цикломатическая сложность=1)
    //  метод LoadFromFile(цикломатическая сложность=1)

    [TestFixture]
    public class NoteTest
    {

        private Note _note;
        [SetUp]
        public void InitNote()
        {
            _note = new Note();
        }

        [Test(Description = "Тест геттера Name")]
        public void TestNameGet_CorrectValue()
        {
            var expected = "Заметка";
            _note.Name = expected;
            var actual = _note.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное название заметки");
        }
        [Test(Description = "Тест неправильного названия заметки больше 50 символов")]
        public void TestNameSet_Longer50Symbols()
        {
            var wrongName = "Заметка-Заметка-Заметка-Заметка-Заметка-Заметка-Заметка-Заметка-Заметка-Заметка-Заметка-Заметка";
            Assert.Throws<ArgumentException>(() => { _note.Name = wrongName; },
                "Должно возникать исключение, если названия заметки длиннее 50 символов");
        }
        [Test(Description = "Присваивание пустой строки в поле Name")]
        public void TestNameSet_EmptyStringValue()
        {
            var expected = "";
            _note.Name = expected;
            var actual = "NoName";
            Assert.AreNotEqual(expected, actual, "Геттер Name возвращает неправильное название заметки");
        }
        [Test(Description = "Присваивание нормального названия заметки в поле Name")]
        public void TestNameSet_CorrectValue()
        {
            var expected = "Нормальная заметка";
            _note.Name = expected;
            var actual = _note.Name;
            Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное название заметки");
        }
        [Test(Description = "Тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Documents;
            _note.Category = expected;
            var actual = _note.Category;
            Assert.AreEqual(expected, actual, "Геттер Category возвращает неправильную категорию заметки");
        }
        [Test(Description = "Тест сеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            var expected = NoteCategory.Documents;
            _note.Category = expected;
            var actual = NoteCategory.Documents;
            Assert.AreEqual(expected, actual, "Сеттер Category задает неправильную категорию заметки");
        }
        [Test(Description = "Тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var expected = "Проверочный текст";
            _note.Text = expected;
            var actual = _note.Text;
            Assert.AreEqual(expected, actual, "Геттер Text возвращает неправильный текст заметки");
        }
        [Test(Description = "Тест сеттера Text")]
        public void TestTextSet_CorrectValue()
        {
            var expected = "Проверочный текст";
            _note.Text = expected;
            var actual = "Проверочный текст";
            Assert.AreEqual(expected, actual, "Сеттер Text задает неправильный текст заметки");
        }
        [Test(Description = "Тест геттера CreatingTime")]
        public void TestCreatingTimeGet_CorrectValue()
        {
            var expected = _note.CreatingTime;
            var actual = DateTime.Now;
            Assert.AreEqual(expected, actual, "Геттер CreatingTime возвращает неправильную дату создания заметки");
        }
        [Test(Description = "Тест геттера LastChangeTime")]
        public void TestLastChangeTimeGet_CorrectValue()
        {
            var expected = DateTime.Now;
            _note.LastChangeTime = expected;
            var actual = _note.LastChangeTime;
            Assert.AreEqual(expected, actual, "Геттер LastChangeTime возвращает неправильную дату редактирования заметки");
        }
        [Test(Description = "Тест cеттера LastChangeTime")]
        public void TestLastChangeTimeSet_CorrectValue()
        {
            DateTime date = new DateTime(2008, 6, 1, 7, 47, 0);
            var expected = date;
            _note.LastChangeTime = expected;
            var actual = new DateTime(2008, 6, 1, 7, 47, 0); ;
            Assert.AreEqual(expected, actual, "Геттер LastChangeTime возвращает неправильную дату редактирования заметки");
        }
        [Test(Description = "Тест конструктора Note")]
        public void TestNoteСonstructor_CorrectValue()
        {

            var expected = new Note("Заметка", NoteCategory.Home, "Текст");
            var actual = new Note("Заметка", NoteCategory.Home, "Текст");
            Assert.AreEqual(expected.Name, actual.Name, "Ошибка в поле Name");
            Assert.AreEqual(expected.Category, actual.Category, "Ошибка в поле Category");
            Assert.AreEqual(expected.Text, actual.Text, "Ошибка в поле Text");
            Assert.AreEqual(expected.CreatingTime, actual.CreatingTime, "Ошибка в поле CreatingTime");
            Assert.AreEqual(expected.LastChangeTime, actual.LastChangeTime, "Ошибка в поле LastChangeTime");
        }
        [Test(Description = "Позитивный тест конструктора Note")]
        public void TestNoteClone_CorrectValue()
        {

            var expected = new Note("Заметка", NoteCategory.Home, "Текст");
            var actual = (Note)expected.Clone();
            Assert.AreEqual(expected.Name, actual.Name, "Ошибка в поле Name");
            Assert.AreEqual(expected.Category, actual.Category, "Ошибка в поле Category");
            Assert.AreEqual(expected.Text, actual.Text, "Ошибка в поле Text");
            Assert.AreEqual(expected.CreatingTime, actual.CreatingTime, "Ошибка в поле CreatingTime");
            Assert.AreEqual(expected.LastChangeTime, actual.LastChangeTime, "Ошибка в поле LastChangeTime");
        }


    }
}

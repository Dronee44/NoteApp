using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace NoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note = new Note();
            note.Name = "pupa";
            note.Text = "afiget";
            note.Category = NoteCategory.HealthAndSport;
            Note note2 = new Note();
            note2.Name = "lupa";
            note2.Text = "vaaaaaaaaaaau";
            note2.Category = NoteCategory.Work;

            Console.WriteLine(note.Name + " " + note.Text + " " + note.Category);
            Console.WriteLine(note2.Name + " " + note2.Text + " " + note2.Category);
            Project prj= new Project();
            Project prj2 = new Project();
            prj.NoteList.Add(note);
            ProjectManager.SaveToFile(prj);
            Console.WriteLine(prj);
            prj = null;
            prj = ProjectManager.LoadFromFile("NoteApp.txt");
            Console.WriteLine(prj);
            



        }
    }
}

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace NoteApp
{
    class Test
    {
        static void Main(string[] args)
        {
            Note note = new Note("",NoteCategory.Work,"Vse rabotaet");
            Note note2 = new Note("Zametka 2", NoteCategory.Peoples, "Opat vse rabotaet");

            Console.WriteLine(note.Name + " " + note.Text + " " + note.Category);
            Console.WriteLine(note2.Name + " " + note2.Text + " " + note2.Category);

            Project prj= new Project();
            Project prj2 = new Project();
            prj.NoteList.Add(note);
            prj.NoteList.Add(note2);
            ProjectManager.SaveToFile(prj);
            //prj = null;
            //prj = ProjectManager.LoadFromFile("NoteApp.txt");
            Note note3 = new Note("keka", NoteCategory.Finance, "Normas Zakladka");
            Console.WriteLine(note3.CreatingTime);
            Console.WriteLine(note.Name + note.Text);
             



        }
    }
}

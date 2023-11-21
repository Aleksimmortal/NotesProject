using NotesProjectBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NotesProject
{
    public static class CreateClass
    {
        private static INotesService _notesService = new NotesServiceClass();
        public static void CreateNote()
        {
            Console.WriteLine("Напишите название заметки:");
            string nameNote = Console.ReadLine();

            Console.WriteLine("Напишите текст заметки:");
            List<string> tekstList = new List<string>();
            tekstList.Add(Console.ReadLine());

            DateTime today = DateTime.Today;

            _notesService.Create(nameNote, tekstList, today);
        }
    }


}

using NotesProjectCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NotesProject
{
    public static class DeleteClassUI
    {
        public static void DeleteNote()
        {
            Console.WriteLine("Укажите дату когда сделали заметку(заметки):");
            DateTime dateFrom = DateTime.Parse(Console.ReadLine());
            List<Notes> list = ReturnNotesDate(dateFrom);
            Console.WriteLine("Заметки сделанные " + dateFrom + " удалены:");
            foreach (Notes note in list)
            {
                Console.WriteLine(note);
            }

        }

        public static List<Notes> ReturnNotesDate(DateTime dateFrom)
        {
            const string PATH = "D:\\NotesProject\\NotesDown.json";
            List<Notes> giveNotes = new List<Notes>();
            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    giveNotes = JsonSerializer.Deserialize<List<Notes>>(fs);
                }
            }
            return giveNotes.Where(n => n.DateToday == dateFrom).ToList();
        
        }

    }
}

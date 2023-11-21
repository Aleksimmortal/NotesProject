using NotesProjectBLL;
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
        private static INoteDeleteService _notesDeleteService = new NoteDeleteServiceClass();
        public static void DeleteNote()
        {
            Console.WriteLine("Укажите дату когда сделали заметку(заметки):");
            DateTime dateFrom = DateTime.Parse(Console.ReadLine());
            _notesDeleteService.DeleteNotes(dateFrom);
            Console.WriteLine("Заметки сделанные " + dateFrom + " удалены:");

        }

    }
}

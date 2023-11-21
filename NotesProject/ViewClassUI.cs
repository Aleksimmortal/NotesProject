using NotesProjectBLL;
using NotesProjectCore;
using NotesProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NotesProject
{
    public static class ViewClassUI
    {
        private static INoteOpenServ _notesServiceView = new OpenServClass();
        public static void ViewNote()
        {
            List<Notes> list = _notesServiceView.Open();
            Console.WriteLine("У вас созданы следующие заметки:");

            foreach (Notes note in list)
            {
                Console.WriteLine(note);
            }
        }
    }
}
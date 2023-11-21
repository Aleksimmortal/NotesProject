using NotesProjectCore;
using NotesProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProjectBLL
{
    public class NotesServiceClass: INotesService
    {
        private readonly INotesProjectDAL _notesDAL = new NotesDAL();
        public void Create (string nameNote, List<string> tekst, DateTime date)
        {
            var notes = new Notes(nameNote, tekst, date);
            _notesDAL.Create(notes);
        }
    }
}

using NotesProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProjectBLL
{
    public class NoteDeleteServiceClass: INoteDeleteService
    {
        private readonly INotesDeleteDAL _notesDeleteDAL = new NotesDeleteDAL();
        public void DeleteNotes(DateTime date)
        {
            _notesDeleteDAL.Delete(date);
        }
    }
}

using NotesProjectCore;
using NotesProjectDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProjectBLL
{
    public class OpenServClass : INoteOpenServ
    {
        private readonly IOpenDAL _notesOpenDAL = new OpenNotesDAL();
        public List<Notes> Open()
        {
            return _notesOpenDAL.Open(); 
        }
    }
}

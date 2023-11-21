using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesProjectCore;

namespace NotesProjectDAL
{
    public interface INotesProjectDAL
    {
        void Create(Notes note);
    }
}

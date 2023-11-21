using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProjectBLL
{
    public interface INoteDeleteService
    {
        void DeleteNotes(DateTime date);
    }
}

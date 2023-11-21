using NotesProjectCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProjectBLL
{
    public interface INoteOpenServ
    {
        List<Notes> Open();
    }
}

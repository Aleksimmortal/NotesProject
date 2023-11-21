using NotesProjectCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProjectDAL
{
    public interface IOpenDAL
    {
        List<Notes> Open();
    }
}

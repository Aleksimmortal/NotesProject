using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesProjectCore
{
    public class Notes
    {
        public string NotesName { get; set; }
        public List <string> Tekst { get; set; }
        public DateTime DateToday { get; set; }

        public Notes (string notesName, List<string> tekst, DateTime dateToday)
        {
            NotesName = notesName;
            Tekst = tekst;
            DateToday = dateToday;
        }
    }
}

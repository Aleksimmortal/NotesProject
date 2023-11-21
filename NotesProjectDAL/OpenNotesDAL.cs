using NotesProjectCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NotesProjectDAL
{
    public class OpenNotesDAL : IOpenDAL
    {
        private string BurnDisk = "D:\\NotesProject\\NotesDown.json";
        public List<Notes> Open()
        {
            var notification = new List<Notes>();
            if (File.Exists(BurnDisk))
            {
                using (FileStream fs = new FileStream(BurnDisk, FileMode.OpenOrCreate))
                {
                    notification = JsonSerializer.Deserialize<List<Notes>>(fs);
                }
            }
            return notification;
        }
    }
}

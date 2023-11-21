using NotesProjectCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NotesProjectDAL
{
    public class NotesDAL: INotesProjectDAL
    {
        private string BurnDisk = "D:\\NotesProject\\NotesDown.json";
        public void Create(Notes note)
        {
            var notification = new List<Notes>();
            if(File.Exists(BurnDisk))
            {
                using (FileStream fs = new FileStream(BurnDisk, FileMode.OpenOrCreate))
                {
                    notification = JsonSerializer.Deserialize<List<Notes>>(fs);
                }
            }
            notification.Add(note);
            Write(notification);
        }
        private void Write(List<Notes> note)
        {
            using (FileStream fs = new FileStream(BurnDisk, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Notes>>(fs, note);
            }
        }
    }
}

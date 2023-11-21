using NotesProjectCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NotesProjectDAL
{
    public class NotesDeleteDAL: INotesDeleteDAL
    {
        private string BurnDisk = "D:\\NotesProject\\NotesDown.json";
        public void Delete(DateTime date)
        {
            var notification = new List<Notes>();
            if (File.Exists(BurnDisk))
            {
                using (FileStream fs = new FileStream(BurnDisk, FileMode.OpenOrCreate))
                {
                    notification = JsonSerializer.Deserialize<List<Notes>>(fs);
                }
            }
            foreach (Notes note in notification)
            {
                Console.WriteLine(note);
            }
            int indexDate = Convert.ToInt32(notification.IndexOf(date));// Не знаю как извлечь индекс записи даты для удаления заметки?!
            notification.RemoveAt(indexDate);
        }
    }
}

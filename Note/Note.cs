using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Note
{
    class Note
    {
        public void EnregistrerNote(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter($"{path}", true))
            {
                sw.WriteLine(text);
            }
        }
    }
}

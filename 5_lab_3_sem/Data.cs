using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_lab_3_sem
{
    internal class Data
    {
        public string Text { get; set; }
        public string FileName { get; set; }
        System.Text.RegularExpressions.Match Match { get; set; }

        internal void ReadFromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                Text = sr.ReadToEnd().Replace("\r", "");
            }

        }
    }
}

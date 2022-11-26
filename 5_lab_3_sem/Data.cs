﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_lab_3_sem
{
    internal class Data
    {
        public string Text { get; set; }
        public string FileName { get; set; }
        public System.Text.RegularExpressions.Match Match { get; set; }

        internal void Find(string text)
        {
            if (this.Text != null)
            {
                this.Match = Regex.Match(this.Text, text); //text - regex
            }
        }

        internal void Next()
        {
            Match = Match?.NextMatch();
        }

        internal void ReadFromFile(string fileName)
        {
            FileName = fileName;
            if (fileName != "") 
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    Text = sr.ReadToEnd().Replace("\r", "");
                }
            }

        }
    }
}

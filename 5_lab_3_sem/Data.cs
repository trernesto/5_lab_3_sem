using System;
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

        internal void GetOfOrStatistics(out int ofc, out int orc)
        {
            ofc = 0; orc = 0;
            foreach (Match m in Regex.Matches(this.Text, @"\b(of|or)\b"))
            {
                if (m.ToString() == "of") {
                    ofc++;
                } else
                {
                    orc++;
                }
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

        public ISet<string> FindSentencesFirstWords()
        {
            ISet<string> words = new HashSet<string>();
            foreach (Match m in Regex.Matches(this.Text, @"([A-Z]\w+).*\?"))
            {
                words.Add(m.Groups[1].Value);
            }
            return words;
        }


    }
}

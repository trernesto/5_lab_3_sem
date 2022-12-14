using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            foreach (Match m in Regex.Matches(this.Text, 
                @"( ?[A-Z]\w+,?)\s(\b\w+ |\(\w+ |\w+\, |\w+\) |\w+\'\w+ |\w+\-\w+ )*\w+\?"))
            {
                words.Add(m.Groups[1].Value);
            }
            return words;
        }

        public ISet<string> FindSentences()
        {
            int max = 0;
            int averageCounter = 0;
            int average = 0;
            String maxSentence = "";
            ISet<string> toOutput = new HashSet<string>();
            ISet<string> sentences = new HashSet<string>();
            foreach (Match m in Regex.Matches(this.Text,
                @"( ?[A-Z]\w+,?)\s(\b\w+ |\(\w+ |\w+\, |\w+\) |\w+\'\w+ |\w+\-\w+ )*\w+[\?\.\!]"))
            {
                ++averageCounter;
                int numberOfWords = 0;
                foreach(Match word in Regex.Matches(m.ToString(), @"\w+"))
                {
                    ++numberOfWords;
                }
                if (numberOfWords > max)
                {
                    maxSentence = m.ToString();
                    max = numberOfWords;
                }
                average += numberOfWords;
                sentences.Add(m.ToString());
            }
            toOutput.Add((average / averageCounter).ToString());
            toOutput.Add(maxSentence);
            toOutput.Add(max.ToString());
            return toOutput;
        }

        public IDictionary<string, int> FirstLetterCounts()
        {
            SortedDictionary<string, int> counts = new SortedDictionary<string, int>();
            Regex r = new Regex(@"\s([A-z])");
            foreach (Match m in r.Matches(this.Text))
            {
                string b = m.Groups[1].Value.ToUpper();
                if (counts.ContainsKey(b))
                {
                    counts[b]++;
                }
                else
                {
                    counts[b] = 1;
                }
            }
            return counts;
        }



    }
}

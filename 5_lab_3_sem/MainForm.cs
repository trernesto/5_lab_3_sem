using _5_lab_3_sem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_lab_3_sem
{
    public partial class MainForm : Form
    {
        Data data = new Data();
        public MainForm()
        {
            InitializeComponent();
            data.ReadFromFile(Settings.Default.DefaultFileName);
            richTextBox1.Text = data.Text;

            listBox1.Items.Add(@"\s+\w+\s+");
            listBox1.Click += (s, e) =>
            {
                textBox1.Text = listBox1.Text;
                data.Find(textBox1.Text);
                ShowMatch();
            };
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1;
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            { data.ReadFromFile(dlg.FileName); }
            richTextBox1.Text = data.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Find(textBox1.Text);
            this.ShowMatch();
        }

        private void ShowMatch()
        {
            Match m = data.Match; // получить m из data
            if (m != null && m.Success)
            {
                richTextBox1.SelectionBackColor = Color.White; // сброс подсветки
                richTextBox1.SelectionStart = m.Index;
                // начало - место, на котором
                // в строке найдено регулярное выражение
                richTextBox1.SelectionLength = m.Value.Length;
                // длина найденного фрагмента
                richTextBox1.ScrollToCaret(); // прокрутка на выделенное место
                richTextBox1.SelectionBackColor = Color.Yellow; // подсветка

                richTextBox2.Text = $"Найдено[{m.Index}]: ##{m.Value}##\n";
            }
            for (int i = 0; i < m.Groups.Count; i++)
            {
                richTextBox2.Text += String.Format("Groups[{0}]={1}\n", i, m.Groups[i]);
            }
        }

        private void FindByEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                data.Find(textBox1.Text);
                this.ShowMatch();
                e.SuppressKeyPress = true; // дальше событие нажатие кнопки игнорируется
            }

        }

        private void NextMatch(object sender, EventArgs e)
        {
            data.Next();
            this.ShowMatch();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.DefaultFileName = data.FileName;
            Settings.Default.Save();
        }

        private void orOfClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ofc, orc;
            data.GetOfOrStatistics(out ofc, out orc);
            richTextBox2.Text = $" of: {ofc}, or: {orc}";
        }

        private void findFirstWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ISet<String> words = data.FindSentencesFirstWords();
            richTextBox2.Text = String.Join(", ", words);
        }

        private void первыеБуквыСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StatisticsForm(data.FirstLetterCounts()).Show();
        }

        private void колвоПредлИСреднееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ISet<String> words = data.FindSentences();
            richTextBox2.Text  = "Average: " + words.ElementAt(0) + '\n';
            richTextBox2.Text += "Max sentence: " + words.ElementAt(1) + '\n';
            richTextBox2.Text += "Words in max sentence: " + words.ElementAt(2);
        }
    }
}

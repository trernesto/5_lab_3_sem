namespace _5_lab_3_sem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orOfClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findFirstWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.первыеБуквыСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоПредложенийИСреднееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колвоПредлИСреднееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(628, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindByEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ещё";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NextMatch);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(184, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(607, 346);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(184, 402);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(607, 93);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 446);
            this.listBox1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orOfClickToolStripMenuItem,
            this.findFirstWordToolStripMenuItem,
            this.колвоПредлИСреднееToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // orOfClickToolStripMenuItem
            // 
            this.orOfClickToolStripMenuItem.Name = "orOfClickToolStripMenuItem";
            this.orOfClickToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.orOfClickToolStripMenuItem.Text = "OrOfClick";
            this.orOfClickToolStripMenuItem.Click += new System.EventHandler(this.orOfClickToolStripMenuItem_Click);
            // 
            // findFirstWordToolStripMenuItem
            // 
            this.findFirstWordToolStripMenuItem.Name = "findFirstWordToolStripMenuItem";
            this.findFirstWordToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.findFirstWordToolStripMenuItem.Text = "FindFirstWord";
            this.findFirstWordToolStripMenuItem.Click += new System.EventHandler(this.findFirstWordToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.первыеБуквыСловToolStripMenuItem,
            this.колвоПредложенийИСреднееToolStripMenuItem});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // первыеБуквыСловToolStripMenuItem
            // 
            this.первыеБуквыСловToolStripMenuItem.Name = "первыеБуквыСловToolStripMenuItem";
            this.первыеБуквыСловToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.первыеБуквыСловToolStripMenuItem.Text = "Первые буквы слов";
            this.первыеБуквыСловToolStripMenuItem.Click += new System.EventHandler(this.первыеБуквыСловToolStripMenuItem_Click);
            // 
            // колвоПредложенийИСреднееToolStripMenuItem
            // 
            this.колвоПредложенийИСреднееToolStripMenuItem.Name = "колвоПредложенийИСреднееToolStripMenuItem";
            this.колвоПредложенийИСреднееToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.колвоПредложенийИСреднееToolStripMenuItem.Text = "Кол-во предложений и среднее";
            // 
            // колвоПредлИСреднееToolStripMenuItem
            // 
            this.колвоПредлИСреднееToolStripMenuItem.Name = "колвоПредлИСреднееToolStripMenuItem";
            this.колвоПредлИСреднееToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.колвоПредлИСреднееToolStripMenuItem.Text = "Кол-во Предл и среднее";
            this.колвоПредлИСреднееToolStripMenuItem.Click += new System.EventHandler(this.колвоПредлИСреднееToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orOfClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findFirstWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem первыеБуквыСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоПредложенийИСреднееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колвоПредлИСреднееToolStripMenuItem;
    }
}
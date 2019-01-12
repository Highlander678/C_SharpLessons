namespace RtfРедактор
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВФорматеRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВФорматеWin1251ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВФорматеRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВФорматеRTFToolStripMenuItem,
            this.открытьВФорматеWin1251ToolStripMenuItem,
            this.сохранитьВФорматеRTFToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьВФорматеRTFToolStripMenuItem
            // 
            this.открытьВФорматеRTFToolStripMenuItem.Name = "открытьВФорматеRTFToolStripMenuItem";
            this.открытьВФорматеRTFToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.открытьВФорматеRTFToolStripMenuItem.Text = "Открыть в формате RTF";
            // 
            // открытьВФорматеWin1251ToolStripMenuItem
            // 
            this.открытьВФорматеWin1251ToolStripMenuItem.Name = "открытьВФорматеWin1251ToolStripMenuItem";
            this.открытьВФорматеWin1251ToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.открытьВФорматеWin1251ToolStripMenuItem.Text = "Открыть в формате Win1251";
            // 
            // сохранитьВФорматеRTFToolStripMenuItem
            // 
            this.сохранитьВФорматеRTFToolStripMenuItem.Name = "сохранитьВФорматеRTFToolStripMenuItem";
            this.сохранитьВФорматеRTFToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.сохранитьВФорматеRTFToolStripMenuItem.Text = "Сохранить в формате RTF";
            this.сохранитьВФорматеRTFToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВФорматеRTFToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(275, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 159);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 207);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВФорматеRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВФорматеWin1251ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВФорматеRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}


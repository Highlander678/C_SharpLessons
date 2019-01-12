namespace Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.полныйЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выклЗвукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вклЗвукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 31);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(469, 342);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.полныйЭкранToolStripMenuItem,
            this.паузаToolStripMenuItem,
            this.playToolStripMenuItem,
            this.выклЗвукToolStripMenuItem,
            this.вклЗвукToolStripMenuItem,
            this.свойстваToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // полныйЭкранToolStripMenuItem
            // 
            this.полныйЭкранToolStripMenuItem.Name = "полныйЭкранToolStripMenuItem";
            this.полныйЭкранToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.полныйЭкранToolStripMenuItem.Text = "Полный экран";
            this.полныйЭкранToolStripMenuItem.Click += new System.EventHandler(this.полныйЭкранToolStripMenuItem_Click);
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.паузаToolStripMenuItem.Text = "Пауза";
            this.паузаToolStripMenuItem.Click += new System.EventHandler(this.паузаToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // выклЗвукToolStripMenuItem
            // 
            this.выклЗвукToolStripMenuItem.Name = "выклЗвукToolStripMenuItem";
            this.выклЗвукToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.выклЗвукToolStripMenuItem.Text = "Выкл звук";
            this.выклЗвукToolStripMenuItem.Click += new System.EventHandler(this.выклЗвукToolStripMenuItem_Click);
            // 
            // вклЗвукToolStripMenuItem
            // 
            this.вклЗвукToolStripMenuItem.Name = "вклЗвукToolStripMenuItem";
            this.вклЗвукToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.вклЗвукToolStripMenuItem.Text = "Вкл звук";
            this.вклЗвукToolStripMenuItem.Click += new System.EventHandler(this.вклЗвукToolStripMenuItem_Click);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            this.свойстваToolStripMenuItem.Click += new System.EventHandler(this.свойстваToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 385);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem полныйЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выклЗвукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вклЗвукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
    }
}


using System;
using System.IO;
using System.Windows.Forms;

namespace SecondAssembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Безопасная операция.
            MessageBox.Show("Hello!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Опасная операция.
            FileStream stream = File.Create(@"D:\Virus.exe");
            stream.Close();

            MessageBox.Show("Файл успешно создан.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Процедура обработки события загрузки формы
            this.Text = "Приветствие";
            // или base.Text = "Приветствие"; 
            label1.Text = "Microsoft Visual C# 11";
            button1.Text = "Нажми меня";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Процедура обработки события щелчок на кнопке
            MessageBox.Show("Всем привет!");
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
            // Обработка события, когда указатель мыши "завис" над меткой:
            MessageBox.Show("Событие Hover!");
        }
    }
}

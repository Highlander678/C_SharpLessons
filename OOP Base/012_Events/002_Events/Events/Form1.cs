using System;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // EventArgs e - содержит вспомагательные данные о событии,
        // в данном случае, была ли нажата кнопка мышью (MouseEventArgs) или клавиатурой (EventArgs).
        // object sender - источник события

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата кнопка: " + sender.ToString(), "Чем нажали: " + e.ToString());
        }       
    }
}

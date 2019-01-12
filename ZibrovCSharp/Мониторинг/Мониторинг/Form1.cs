// Программа отображает координаты курсора мыши относительно экрана и
// элемента управления. Программа содержит форму, список элементов ListBox
// и два текстовых поля. Программа заполняет список ListBox данными о 
// местоположении и изменении положения курсора мыши. Кроме того, в
// текстовых полях отображаются координаты положения курсора мыши
// относительно экрана и элемента управления ListBox
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Мониторинг
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Мониторинг движения мыши";
        }
        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            // Процедура обработки события, когда указатель мыши входит
            // в видимую часть элемента управления ListBox:
            // ~ ~ ~ ~ ~ ~ ~ ~
            // Добавляем в список элементов новую запись
            listBox1.Items.Add("Курсор мыши вошел в область ListBox");
        }
        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            // Процедура обработки события, когда указатель мыши покидает
            // элемент управления ListBox:
            listBox1.Items.Add("Курсор мыши вышел из области ListBox");
        }
        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Процедура обработки события, происходящего при перемещении
            // указателя мыши на элементе управления ListBox:
            // ~ ~ ~ ~ ~ ~ ~ ~
            // Свойство объекта Control MousePosition возвращает точку,
            // соответствующую текущему положению мыши относительно
            // левого верхнего угла монитора
            textBox1.Text = String.Format("X = {0} или {1}",
                                           Control.MousePosition.X, e.X);
            textBox2.Text = String.Format("Y = {0} или {1}",
                                           Control.MousePosition.Y, e.Y);
        }
    }
}

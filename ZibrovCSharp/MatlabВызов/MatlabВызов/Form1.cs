// Программа вызывает простейшую функцию Matlab
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Для успешной работы программы нет необходимости добавлять ссылку на
// объектную библиотеку через Project | Reference. Однако на компьютере
// MATLAB должен быть установлен
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace MatlabВызов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Вызвать MATLAB";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Получить тип приложения MATLAB:
            var ТипМатЛаб = Type.GetTypeFromProgID("Matlab.Application");
            // Создать экземпляр объекта типа MATLAB:
            var МатЛаб = Activator.CreateInstance(ТипМатЛаб);
            // Подготавливаем команды для MATLAB:
            Object[] Команды = 
               { "x = 0:0.1:6.28; y = sin(x).*exp(-x); plot(x,y)" };
            // { "s = sin(0.5); c = cos(0.5); y = s*s+c*c; y" };
            // { "surf(peaks)" };
            // Вызываем MATLAB, подавая ему на вход подготовленные команды:
            var Результат =
                      ТипМатЛаб.InvokeMember("Execute", System.Reflection.
                      BindingFlags.InvokeMethod, null, МатЛаб, Команды);
            // MessageBox.Show(Результат.ToString());
        }
    }
}

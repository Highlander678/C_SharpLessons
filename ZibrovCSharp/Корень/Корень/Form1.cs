using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// Программа вводит через текстовое поле число, при щелчке на командной
// кнопке извлекает из него квадратный корень и выводит результат на метку
// label1. В случае ввода не числа сообщает пользователю об этом, выводя
// красным цветом предупреждение также на метку label1
namespace Корень
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Извлечь корень";
            label1.Text = String.Empty;
            // или label1.Text = null;
            base.Text = "Извлечение квадратного корня";
            textBox1.Clear(); // Очистка текстового поля
            textBox1.TabIndex = 0; // Установка фокуса в текстовом поле
        }
        private void button1_Click(object sender, EventArgs e)
        {
        Single X; // - из этого числа будем извлекать корень
        // Преобразование из строковой переменной в Single:
        bool Число_ли = Single.TryParse(
                    textBox1.Text,
                    System.Globalization.NumberStyles.Number,
                    System.Globalization.NumberFormatInfo.CurrentInfo,
                    out X);
        // Второй параметр - это разрешенный стиль числа (Integer, 
        // шестнадцатиричное число, экспоненциальный вид числа и прочее).
        // Третий параметр форматирует значения на основе текущего языка
        // и региональных параметров из Панели управления - Язык и
        // региональные стандарты число допустимого формата: метод
        // возвращает значение в переменную X
        if (Число_ли == false){
            // Если пользователь ввел не число:
            label1.Text = "Следует вводить числа";
            label1.ForeColor = Color.Red; // - цвет текста на метке
            return; // - выход из процедуры или Return
        }
        // Извлечение корня с преобразованием в тип Single:
        var Y = (Single)Math.Sqrt(X);
        // или var Y = Convert.ToSingle(Math.Sqrt(X));
        label1.ForeColor = Color.Black; // - черный цвет текста на метке
        label1.Text = String.Format("Корень из {0} равен {1:F5}", X, Y);
        }
    }
}

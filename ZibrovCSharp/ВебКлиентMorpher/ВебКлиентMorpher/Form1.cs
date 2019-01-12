// Клиентское Windows-приложение, потребляющее сервис веб-службы 
// "Морфер". На вход метода веб-службы PropisRUB подаем сумму
// в рублях цифрами, метод же возвращает сумму прописью
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ВебКлиентMorpher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите сумму в рублях цифрами";
            label2.Text = null;
            button1.Text = "Перевести";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Decimal Сумма;
            var Число_ли = Decimal.TryParse(textBox1.Text, out Сумма);
            if (Число_ли == false)
            {
                // Если пользователь ввел не число:
                label2.Text = "Следует вводить числа";
                label2.ForeColor = Color.Red; // - цвет текста на метке
                return; // - выход из процедуры
            }
            // Создаем клиентское приложение веб-службы:
            //           http://www.morpher.ru/WebServices/Morpher.asmx
            // Создаем экземпляр удаленного класса:
            var Методы = new ru.morpher.www.Morpher();
            var СуммаПрописью = Методы.PropisRUB(Сумма);
            label2.ForeColor = Color.Blue; // - цвет текста на метке
            label2.Text = СуммаПрописью;
        }
    }
}

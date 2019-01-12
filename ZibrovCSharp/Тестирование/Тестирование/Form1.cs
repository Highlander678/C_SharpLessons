// Программа тестирует студента по какому-либо предмету обучения
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace Тестирование
{
    public partial class Form1 : Form
    {
        // Внешние переменные:
        int СчетВопросов; // Счет вопросов
        int ПравилОтветов;  // Количество правильных ответов
        int НеПравилОтветов; // Количество не правильных ответов
        // Массив вопросов, на которые даны неправильные ответы:
        String[] НеПравилОтветы; // Размерность этого массива зададим позже
        int НомерПравОтвета;  // Номер правильного ответа
        int ВыбранОтвет;  // Номер ответа, выбранный студентом
        System.IO.StreamReader Читатель;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Следующий вопрос";
            button2.Text = "Выход";
            // Подписка на событие изменение состояния
            // переключателей RadioButton:
            radioButton1.CheckedChanged += new EventHandler(ИзмСостПерекл);
            radioButton2.CheckedChanged += new EventHandler(ИзмСостПерекл);
            radioButton3.CheckedChanged += new EventHandler(ИзмСостПерекл);
            НачалоТеста();
        }
        void НачалоТеста()
        {
            var Кодировка = System.Text.Encoding.GetEncoding(1251);
            try
            {
                // Создание экземпляра StreamReader для чтения из файла
                Читатель = new System.IO.StreamReader(
                System.IO.Directory.GetCurrentDirectory() +
                                               @"\test.txt", Кодировка);
                this.Text = Читатель.ReadLine(); // Название предмета
                // Обнуление всех счетчиков:
                СчетВопросов = 0; ПравилОтветов = 0; НеПравилОтветов = 0;
                // Задаем размер массива для НеПравилОтветы:
                НеПравилОтветы = new String[100];
            }
            catch (Exception Ситуация)
            {   // Отчет о всех ошибках:
                MessageBox.Show(Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ЧитатьСледВопрос();
        }
        void ЧитатьСледВопрос()
        {
            label1.Text = Читатель.ReadLine();
            // Считывание вариантов ответа:
            radioButton1.Text = Читатель.ReadLine();
            radioButton2.Text = Читатель.ReadLine();
            radioButton3.Text = Читатель.ReadLine();
            // Выясняем, какой ответ - правильный:
            НомерПравОтвета = int.Parse(Читатель.ReadLine());
            // Переводим все переключатели в состояние "выключено":
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            // Первую кнопку задаем не активной, пока студент не выберет
            // вариант ответа
            button1.Enabled = false;
            СчетВопросов = СчетВопросов + 1;
            // Проверка, конец ли файла:
            if (Читатель.EndOfStream == true) button1.Text = "Завершить";
        }
        void ИзмСостПерекл(Object sender, EventArgs e)
        {
            // Кнопка "Следующий вопрос" становится активной, и ей
            // передаем фокус:
            button1.Enabled = true; button1.Focus();
            RadioButton Переключатель = (RadioButton)sender;
            var tmp = Переключатель.Name;
            // Выясняем номер ответа, выбранный студентом:
            ВыбранОтвет = int.Parse(tmp.Substring(11));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке
            // "Следующий вопрос/Завершить/Начать тестирование снач"
            // Счет правильных ответов:
            if (ВыбранОтвет == НомерПравОтвета) ПравилОтветов =
                                                ПравилОтветов + 1;
            if (ВыбранОтвет != НомерПравОтвета)
            {
                // Счет неправильных ответов:
                НеПравилОтветов = НеПравилОтветов + 1;
                // Запоминаем вопросы с неправильными ответами:
                НеПравилОтветы[НеПравилОтветов] = label1.Text;
            }
            if (button1.Text == "Начать тестирование сначала")
            {
                button1.Text = "Следующий вопрос";
                // Переключатели становятся видимыми, доступными для выбора:
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                // Переход к началу файла:
                НачалоТеста(); return;
            }
            if (button1.Text == "Завершить")
            {
                // Закрываем текстовый файл:
                Читатель.Close();
                // Переключатели делаем невидимыми:
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                // Формируем оценку за тест:
                label1.Text = String.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Оценка в пятибальной системе: {2:F2}.", ПравилОтветов,
                    СчетВопросов, (ПравилОтветов * 5.0F) / СчетВопросов);
                // 5F - это максимальная оценка
                button1.Text = "Начать тестирование сначала";
                // Вывод вопросов, на которые "Вы дали неправильный ответ":
                var Str = "СПИСОК ВОПРОСОВ, НА КОТОРЫЕ ВЫ ДАЛИ " +
                          "НЕПРАВИЛЬНЫЙ ОТВЕТ:\n\n";
                for (int i = 1; i <= НеПравилОтветов; i++)
                    Str = Str + НеПравилОтветы[i] + "\n";

                // Если есть неправильные ответы, то вывести через
                // MessageBox список соответствующих вопросов:
                if (НеПравилОтветов != 0) MessageBox.Show(
                                          Str, "Тестирование завершено");
            } // Конец условия if (button1.Text == "Завершить")
            if (button1.Text == "Следующий вопрос") ЧитатьСледВопрос();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Щелчок на кнопке "Выход"
            this.Close();
        }
    }
}

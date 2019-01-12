// Программа для чтения/записи бинарных файлов с использованием потока данных
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ReadWriteBin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Успеваемость студента";
            label1.Text = "Номер п/п"; label2.Text = "Фамилия И.О.";
            label3.Text = "Средний балл";
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            button1.Text = "Читать"; button2.Text = "Сохранить";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ЧТЕНИЕ БИНАРНОГО ФАЙЛА
            // Если такого файла нет
            if (System.IO.File.Exists(@"D:\student.usp") == false) return;
            // Создание потока Читатель
            var Читатель = new System.IO.BinaryReader(
                               System.IO.File.OpenRead(@"D:\student.usp"));
            try
            {
                var Номер_пп = Читатель.ReadInt32();
                var ФИО = Читатель.ReadString();
                var СредБалл = Читатель.ReadSingle();
                textBox1.Text = Convert.ToString(Номер_пп);
                textBox2.Text = Convert.ToString(ФИО);
                textBox3.Text = Convert.ToString(СредБалл);
            }
            finally { Читатель.Close(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // ЗАПИСЬ БИНАРНОГО ФАЙЛА
            // Создаем поток Писатель для записи байтов в файл
            var Писатель = new System.IO.BinaryWriter(
                               System.IO.File.Open(@"D:\student.usp", 
                               System.IO.FileMode.Create));
            try
            {
                var Номер_пп = Convert.ToInt32(textBox1.Text);
                var ФИО = Convert.ToString(textBox2.Text);
                // Разрешаем в качестве разделителя целой и дробной
                // части как запятую, так и точку:
                textBox3.Text = textBox3.Text.Replace(".", ",");
                var СредБалл = Convert.ToSingle(textBox3.Text);
                Писатель.Write(Номер_пп);
                Писатель.Write(ФИО);
                Писатель.Write(СредБалл);
            }
            finally { Писатель.Close(); }
        }
    }
}

// Программа использует финансовую функцию Pmt() объектной библиотеки
// MS Excel для вычисления суммы периодического платежа на основе
// постоянства сумм платежей и постоянства процентной ставки
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Для подключения библиотеки объектов MS Excel в пункте меню Project
// выберем команду Add Reference. Затем в узле Assemblies выберем
// пункт Extensions, в появившемся списке отметим ссылку
// Microsoft.Office.Interop.Excel.
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ExcelПлт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Расчет ежемесячных платежей";
            label1.Text = "Год. ставка в %";
            label2.Text = "Срок в месяцах";
            label3.Text = "Размер кредита";
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            button1.Text = "Расчет";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var XL = new Microsoft.Office.Interop.
                                         Excel.Application();
                // Перменная с "пустым" значением:
                var t = Type.Missing;
                // Получаем размер месячного платежа:
                var pay = XL.WorksheetFunction.Pmt(
                             (Convert.ToDouble(textBox1.Text)) / 1200,
                              Convert.ToDouble(textBox2.Text),
                              Convert.ToDouble(textBox3.Text), t, t);
                // ИЛИ, если использовать функцию Pmt()
                // из Microsoft.VisualBasic:
                // var FV = 0.0;
                // var dt =
                //      Microsoft.VisualBasic.DueDate.EndOfPeriod;
                // var pay = Microsoft.VisualBasic.Financial.Pmt(
                //     (Convert.ToDouble(textBox1.Text)) / 1200,
                //      Convert.ToDouble(textBox2.Text),
                //      Convert.ToDouble(textBox3.Text), FV, dt);
                var Строка = String.Format(
                    "Каждый месяц следует платить {0:$#.##} долларов",
                                                         Math.Abs(pay));
                MessageBox.Show(Строка);
                XL.Quit();
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

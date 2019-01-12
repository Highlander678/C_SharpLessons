// Программа обращается к одной простой функции объектной библиотеки
// MS Excel для получения значения числа Пи = 3,14...
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Чтобы добавить ссылку на объектную библиотеку Excel, в пункте меню
// Project укажем команду Add Reference и в узле Assemblies выберем
// пункт Extensions, в появившемся списке отметим ссылку
// Microsoft.Office.Interop.Excel.
using System;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ExcelПи
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Создание экземпляра класса Excel.Application:
            var XL = new Microsoft.Office.Interop.
                                          Excel.Application();
            var PI = XL.WorksheetFunction.Pi();
            // Выводим значение ПИ в строку заголовка формы
            this.Text = "PI = " + PI.ToString();
            XL.Quit();
        }
    }
}

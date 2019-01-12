// В форме имеем две командные кнопки, и при нажатии указателем мыши
// любой из них получаем номер нажатой кнопки. При этом в программе
// предусмотрена только одна процедура обработки событий
using System;
using System.Drawing;
using System.Windows.Forms;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace ДваСобытияОднаПроц
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Щелкните на кнопке"; label1.Text = null;
            // Связываем события Click от обеих кнопок с одной
            // процедурой Кнопка_Click:
            button1.Click += new EventHandler(КЛИК);
            button2.Click += new EventHandler(КЛИК);
            // Подпиской на событие называют связывание названия события,
            // например, Click с названием процедуры обработки события, 
            // например, КЛИК посредством EventHandler
        }
        // Создаем обработчик события Click для кнопки:
        private void КЛИК(object sender, EventArgs e)
        {
            // Получить текст, отображаемый на кнопке можно таким образом:
            // label1.Text = Convert.ToString(sender);
            // получить текст, отображаемый на кнопке можно таким образом:
            // или 
            // label1.Text = ((Button)sender).Text;
            var Кнопка = (Button)sender;
            label1.Text = "Нажата кнопка " + Кнопка.Text; // или Кнопка.Name
        }
    }
}

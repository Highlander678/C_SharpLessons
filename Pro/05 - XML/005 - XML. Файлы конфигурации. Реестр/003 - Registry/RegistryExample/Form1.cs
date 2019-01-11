using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Инициализируем объект RegistryKey для работы с веткой реестра CurrentUser.
                RegistryKey regKey = Registry.CurrentUser;

                // CreateSubKey - создать по указаному пути ключ.
                regKey = regKey.CreateSubKey("Software\\CyberBionic\\Lessons");

                // Запись значений в реестр. SetValue( имя ключа, значение).
                regKey.SetValue("CurrText", textBox1.Text);

                MessageBox.Show("Запись создана");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey regKey = Registry.CurrentUser;
                regKey = regKey.OpenSubKey("Software\\CyberBionic\\Lessons");

                // GetValue(имя ключа для чтения, значение по умолчанию если ключ не найден)
                if (regKey != null)
                {
                    textBox2.Text = (string)regKey.GetValue("CurrText", "NoValue");

                    MessageBox.Show("чтение выполненно");
                }
                else
                {
                    MessageBox.Show("Ключа не существует");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

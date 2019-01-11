using System;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Configuration.Install;

namespace ServiceIU
{
    public partial class Form1 : Form
    {
        ServiceController controller;

        public Form1()
        {
            InitializeComponent();
        }

        // Выбор файла-службы
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SafeFileName;
            }
        }

        // Устанавка службы.
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Выберите файл с NT-службой.");
            }
            else
            {
                try
                {
                    ManagedInstallerClass.InstallHelper(new string[] { openFileDialog1.FileName });
                    MessageBox.Show("Сервис " + openFileDialog1.SafeFileName + " установлен!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        // Деинсталяция службы.
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Выберите файл с NT-службой.");
            }
            else
            {
                try
                {
                    ManagedInstallerClass.InstallHelper(new string[] { @"/u", openFileDialog1.FileName });
                    MessageBox.Show("Сервис " + openFileDialog1.SafeFileName + " деинсталирован!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        // Start службы.
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                controller = new ServiceController();
                controller.ServiceName = "[===== TEST SERVICE =====]";
                controller.Start();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        // Stop службы.
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                controller = new ServiceController();
                controller.ServiceName = "[===== TEST SERVICE =====]";
                controller.Stop();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}

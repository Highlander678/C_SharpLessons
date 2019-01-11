using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        // При помощи класса Assembly - можно динамически загружать сборки, 
        // обращаться к членам класса в процессе выполнения (ПОЗДНЕЕ СВЯЗЫВАНИЕ),
        // а так же получать информацию о самой сборке.
        Assembly assembly = null;

        public Form1()
        {
            InitializeComponent();
            FillListBox();
        }

        void FillListBox()
        {
            Array memberInfo = Enum.GetValues(typeof(MemberTypes));

            for (int i = 0; i < memberInfo.Length - 1; i++)
            {
                int index = checkedListBox1.Items.Add(memberInfo.GetValue(i));

            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Строка приема полного имени загружаемой сборки.
                string path = openFileDialog.FileName;

                try
                {
                    assembly = Assembly.LoadFile(path);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetView_Click(object sender, EventArgs e)
        {
            if (assembly == null)
            {
                textBox.Text = "Вы не выбрали файл!";
                return;
            }
            textBox.Text = "";
            // Вывод информации о всех типах в сборке.
            textBox.Text += "СПИСОК ВСЕХ ТИПОВ В СБОРКЕ:     " + assembly.FullName + Environment.NewLine + Environment.NewLine;

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                textBox.Text += "ТИП:  " + type + Environment.NewLine;
                object[] typeAttributes = type.GetCustomAttributes(false);
                // Отображаем полученные значения.
                if (typeAttributes.Length > 0 && checkBoxAtrType.Checked)
                {
                    textBox.Text += "AТРИБУТЫ ТИПА: ";
                    foreach (var attribute in typeAttributes)
                    {
                        textBox.Text += attribute + Environment.NewLine;
                    }
                }
                
                var members = type.GetMembers();
                if (members != null)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (checkedListBox1.GetItemChecked(i))
                        {
                            object element = Enum.Parse(typeof(MemberTypes), checkedListBox1.Items[i].ToString());
                            MemberTypes memberType = (MemberTypes)element;

                            foreach (var member in members)
                            {
                                if (member.MemberType == memberType)
                                {
                                    string methStr = member.MemberType.ToString().ToUpper() + " " + member.Name + "\n";

                                    textBox.Text += methStr + Environment.NewLine;

                                    object[] memberAttributes = member.GetCustomAttributes(false);
                                    if (memberAttributes.Length > 0 && checkBoxAtrMember.Checked)
                                    {
                                        textBox.Text += "AТРИБУТЫ ЧЛЕНА: ";
                                        foreach (var attribute in memberAttributes)
                                        {
                                            textBox.Text += attribute + Environment.NewLine;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                textBox.Text += Environment.NewLine;
            }
        }
    }
}

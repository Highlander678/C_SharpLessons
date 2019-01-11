using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetDrivers();
        }

        void GetDrivers()
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach (var item in driveInfo)
            {
                if (item.DriveType == DriveType.CDRom)
                {
                    continue;
                }
                checkedListBox1.Items.Add(string.Format(item.Name));
            }

        }

        string file;

        bool SearchFile(string directory, string fileName)
        {
            DirectoryInfo dir = new DirectoryInfo(directory);

            if (!dir.Exists)
            {
                return false;
            }

            FileInfo[] fileInfo = null;
            try
            {
                fileInfo = dir.GetFiles(fileName);
            }
            catch (Exception)
            {
                return false;
            }

            if (fileInfo.Length == 0)
            {
                DirectoryInfo[] dirInfo = dir.GetDirectories();

                if (dirInfo.Length == 0)
                {
                    return false;
                }

                foreach (var item in dirInfo)
                {
                    if (item.Attributes.Equals(FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory))
                    {
                        continue;
                    }

                    if (SearchFile(item.FullName, fileName))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                file = fileInfo[0].FullName;
                return true;
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                    if (SearchFile(checkedListBox1.Items[i].ToString(), textBoxFileName.Text))
                    {
                        textBox2.Text = "Файл " + file + " найден!";
                    }
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            StreamReader reader = File.OpenText(file);

            textBox2.Text = reader.ReadToEnd();

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream source = File.OpenRead(file);
                FileStream destination = File.Create(saveFileDialog1.FileName);

                // Создание компрессора.
                GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

                // Заполнение архива информацией из файла.
                int theByte = source.ReadByte();
                while (theByte != -1)
                {
                    compressor.WriteByte((byte)theByte);
                    theByte = source.ReadByte();
                }

                // Удаление компрессора.
                compressor.Close();
            }

        }
    }
}

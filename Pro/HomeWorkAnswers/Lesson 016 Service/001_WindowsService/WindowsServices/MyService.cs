using System.ServiceProcess;
using System.Diagnostics;
using System.Timers;
using System.Net;
using System.IO;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace WindowsServices
{
    public partial class MyService : ServiceBase
    {
        DriveInfo[] drives;
        static readonly string filePath = @"D:\deletedFiles.txt";

        public MyService()
        {
            InitializeComponent();

            // Получаем массив жестких дисков (для фильтра массива необходимо подключить пространство имен System.Linq)
            drives = DriveInfo.GetDrives().Where<DriveInfo>(drive => drive.DriveType == DriveType.Fixed).ToArray<DriveInfo>();
        }

        protected override void OnStart(string[] args)
        {
            foreach (var drive in drives)
            {
                // Создаем и настраиваем "вотчера"
                FileSystemWatcher watcher = new FileSystemWatcher(drive.RootDirectory.ToString());
                watcher.IncludeSubdirectories = true;
                watcher.Deleted += watcher_Deleted;
                watcher.Error += watcher_Error;
                watcher.EnableRaisingEvents = true;
            }
        }
        
        void watcher_Error(object sender, ErrorEventArgs e)
        {
            if (this.CanPauseAndContinue == true) { this.OnStart(new string[0]); }
        }

        //void watcher_Deleted(object sender, FileSystemEventArgs e)
        //{
        //    // Самый простой способ записать/прочитать текст в/из файла - воспользоваться классом File.
        //    // Данный вариант не подходит - нам необходимо разрешить доступ к файлу для чтения из другого потока.

        //    File.AppendAllText(filePath, e.FullPath + Environment.NewLine);
        //}

        //async void watcher_Deleted(object sender, FileSystemEventArgs e)
        //{
              // В данном варианте используется уже имеющийся функционал асинхронного выполнения работы, но 
              // мы все еще не можем настроить паралельный доступ к файлу.

        //    using (var streamWriter = new StreamWriter(filePath, true))
        //    {
        //        await streamWriter.WriteLineAsync(e.FullPath);
        //    }

        //}

        async void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            // С помощью параметра FileShare.Read разрешаем открытие файла для чтения из другого потока
            using (var stream = File.Open(filePath, FileMode.Append, FileAccess.Write, FileShare.Read))
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    await streamWriter.WriteLineAsync(e.FullPath);
                }
            }
        }
    }
}

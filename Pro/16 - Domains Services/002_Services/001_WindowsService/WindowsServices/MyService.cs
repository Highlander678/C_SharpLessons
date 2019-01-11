using System.ServiceProcess;
using System.IO;

namespace WindowsServices
{
    public partial class MyService : ServiceBase
    {
        FileInfo file;
        StreamWriter writer;
        FileSystemWatcher watcher;

        public MyService()
        {
            InitializeComponent();

            file = new FileInfo(@"D:\Log.txt");
            writer = file.CreateText();

            watcher = new FileSystemWatcher(@"D:\");
            watcher.Created += WatcherChanged;
            watcher.Deleted += WatcherChanged;
            watcher.Renamed += WatcherChanged;
            watcher.Changed += WatcherChanged;
        }

        void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            writer.WriteLine("Directory changed({0}): {1}", e.ChangeType, e.FullPath);
            writer.Flush();
        }

        protected override void OnStart(string[] args)
        {
            // Начать мониторинг.
            watcher.EnableRaisingEvents = true;
        }

        protected override void OnStop()
        {
            // Остановить мониторинг.
            watcher.EnableRaisingEvents = false;
        }

        protected override void OnContinue()
        {
        }

        protected override void OnPause()
        {
        }

        protected override void OnShutdown()
        {
        }
    }
}

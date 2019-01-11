using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceProcess;
using System.Configuration.Install;
using System.IO;

namespace DeletedFilesLogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceController controller;
        static readonly string filePath = @"D:\deletedFiles.txt";
        static readonly string servicePath = @"D:\WindowsServices.exe";
        static readonly string serviceName = "===== Deleted Files Logger =====";
        System.Windows.Forms.Timer timer;

        public MainWindow()
        {
            InitializeComponent();
            controller = new ServiceController { ServiceName = serviceName };
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                TextBox.Text = await ReadFileAsync();
                TextBox.ScrollToEnd();
            }
            catch (Exception ex)
            {
                timer.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<string> ReadFileAsync()
        {
            using (var stream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Write))
            {
                using (var streamReader = new StreamReader(stream))
                {
                    string str = await streamReader.ReadToEndAsync();
                    return str;
                }
            }
        }

        private async void Install_Click(object sender, RoutedEventArgs e)
        {
            Install.IsEnabled = false;
            await Task.Factory.StartNew(InstalService);
            Uninstall.IsEnabled = true;
            Start.IsEnabled = true;
        }

        private async void Uninstall_Click(object sender, RoutedEventArgs e)
        {
            Uninstall.IsEnabled = false;
            Start.IsEnabled = false;

            // В обработчике Install_Click использовался метод Task.Factory.StartNew.
            // В .NET Framework 4.5, была введен новый метод Task.Run.
            // http://blogs.msdn.com/b/pfxteam/archive/2011/10/24/10229468.aspx

            await Task.Run(() => UninstalService());
            Install.IsEnabled = true;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                controller.Start();
                MessageBox.Show("Service started");
                Start.IsEnabled = false;
                Stop.IsEnabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                controller.Stop();
                MessageBox.Show("Service stopped");
                Stop.IsEnabled = true;
                Start.IsEnabled = true;
                Uninstall.IsEnabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (timer.Enabled) timer.Stop();
            UninstalService();
        }

        private void InstalService()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new[] { servicePath });
                MessageBox.Show("Service installed");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void UninstalService()
        {
            if (!IsServiceInstalled(serviceName)) return;

            try
            {
                ManagedInstallerClass.InstallHelper(new[] { @"/u", servicePath });
                MessageBox.Show("Service uninstalled");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private bool IsServiceInstalled(string serviceName)
        {
            var controller = ServiceController.GetServices().FirstOrDefault<ServiceController>(s => s.ServiceName == serviceName);
            if (controller == null)
            {
                return false;
            }
            return true;
        }
    }
}

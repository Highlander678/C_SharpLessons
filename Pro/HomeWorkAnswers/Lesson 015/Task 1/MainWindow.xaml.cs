using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Forms.Timer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += timer_Tick;
        }

        async void timer_Tick(object sender, EventArgs e)
        {
            TextBox.Text += await GetDataAsync();
            TextBox.ScrollToEnd();
        }

        private Task<string> GetDataAsync()
        {
            return Task.Run(() => { return "data received" + Environment.NewLine; });
        }

        private async void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            ConnectButton.IsEnabled = false;
            TextBox.Text += await ConnectDBAsync();
            DisconnectButton.IsEnabled = true;
        }

        private async Task<string> ConnectDBAsync()
        {
            return await Task.Factory.StartNew(() => 
            { 
                Thread.Sleep(3000); 
                return "Connected" + Environment.NewLine; 
            });
        }

        private async void DisconnectButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            DisconnectButton.IsEnabled = false;
            TextBox.Text += await DisconnectDBAsync();
            ConnectButton.IsEnabled = true;
        }

        private async Task<string> DisconnectDBAsync()
        {
            // В методе ConnectDBAsync использовался метод Task.Factory.StartNew.
            // В .NET Framework 4.5, была введен новый метод Task.Run.
            // http://blogs.msdn.com/b/pfxteam/archive/2011/10/24/10229468.aspx

            return await Task.Run(() => 
            { 
                Thread.Sleep(3000); 
                return "Disconnected" + Environment.NewLine; 
            });
        }
    }
}

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

namespace Auto_Shutdown_Program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int current = 0;

        private void button_Click_60min(object sender, RoutedEventArgs e)
        {
            current = 60;
            currentLabel1.Content = current;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -a";
            process.StartInfo = startInfo;
            process.Start();

            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -t 3600 -f -s";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button_Click_Avbryt(object sender, RoutedEventArgs e)
        {
            //current = 0;
            currentLabel1.Content = "";
            currentLabel1.Content = current;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -a";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button_Click_90min(object sender, RoutedEventArgs e)
        {
            current = 90;
            currentLabel1.Content = current;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -a";
            process.StartInfo = startInfo;
            process.Start();

            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -t 5400 -f -s";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -a";
            process.StartInfo = startInfo;
            process.Start();

            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -t 0 -f -s";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            current += 10;
            currentLabel1.Content = current;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -a";
            process.StartInfo = startInfo;
            process.Start();           
            
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -t " + current * 60 + " -f -s";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            current = current <= 10 ? current = 10 : current -= 10;
            currentLabel1.Content = current;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -a";
            process.StartInfo = startInfo;
            process.Start();

            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -t " + current * 60 + " -f -s";
            process.StartInfo = startInfo;
            process.Start();

        }
    }
}
